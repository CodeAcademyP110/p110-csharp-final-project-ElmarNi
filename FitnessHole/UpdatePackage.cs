using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessHole
{
    public partial class UpdatePackage : Form
    {
        private readonly FitnessHoleEntities _context;
        private Package selectedPack;
        public UpdatePackage()
        {
            InitializeComponent();
            _context = new FitnessHoleEntities();
        }

        private void UpdatePackage_Load(object sender, EventArgs e)
        {
            dtgwPacks.ReadOnly = true;
            DtgvwUpdater();
            dtStartTime.Format = DateTimePickerFormat.Custom;
            dtStartTime.CustomFormat = "HH:mm"; // Only use hours and minutes
            dtStartTime.ShowUpDown = true;
            dtEndTime.Format = DateTimePickerFormat.Custom;
            dtEndTime.CustomFormat = "HH:mm"; // Only use hours and minutes
            dtEndTime.ShowUpDown = true;
            cmbServices.Items.AddRange(_context.Services.ToArray());
            if (cmbServices.Items.Count > 0)
            {
                cmbServices.SelectedIndex = 0;
            }
        }

        private void DtgwPacks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbAllday.Checked = cbEvendays.Checked = cbOdddays.Checked = false;
            btnUpdate.Enabled = true;
            pnlServices.Controls.Clear();
            int selectedPackId = int.Parse(dtgwPacks.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
            selectedPack = _context.Packages.First(p => p.Id == selectedPackId);
            cbStatus.Checked = (bool)selectedPack.Status;
            if ((bool)selectedPack.isActiveAllDays)
            {
                cbAllday.Checked = true;
            }
            if ((bool)selectedPack.isActiveEvenDays)
            {
                cbEvendays.Checked = true;
            }
            if ((bool)selectedPack.isActiveOddDays)
            {
                cbOdddays.Checked = true;
            }
            txtPackName.Text = selectedPack.Name;
            numPrice.Value = selectedPack.Price;
            dtStartTime.Value = DateTime.Today.Add(selectedPack.StartTime);
            dtEndTime.Value = DateTime.Today.Add(selectedPack.EndTime);
            foreach (var item in _context.ServicesToPackages.Where(sp => sp.PackagesId == selectedPackId))
            {
                Button btn = new Button();
                CreateBtn($"{item.Service}", btn);
                pnlServices.Controls.Add(btn);
            }
        }
        private void CbAllday_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllday.Checked)
            {
                cbEvendays.Enabled = false;
                cbOdddays.Enabled = false;
                
            }
            else
            {
                cbEvendays.Enabled = true;
                cbOdddays.Enabled = true;
            }
        }

        private void CbEvendays_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEvendays.Checked)
            {
                cbAllday.Enabled = false;
                cbOdddays.Enabled = false;
                
            }
            else
            {
                cbAllday.Enabled = true;
                cbOdddays.Enabled = true;
            }
        }

        private void CbOdddays_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOdddays.Checked)
            {
                cbEvendays.Enabled = false;
                cbAllday.Enabled = false;
            }
            else
            {
                cbEvendays.Enabled = true;
                cbAllday.Enabled = true;
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPackName.Text == string.Empty || txtPackName.Text.Length < 3)
            {
                MessageBox.Show("Please input a valid package name(it must contain more than 3 chars)", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPackName.Text != selectedPack.Name)
            {
                if (_context.Packages.Any(p => p.Name == txtPackName.Text))
                {
                    MessageBox.Show("Package is duplicate", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (numPrice.Value <= 0)
            {
                MessageBox.Show("Please input a valid price", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbAllday.Checked == cbEvendays.Checked == cbOdddays.Checked == false)
            {
                MessageBox.Show("Please select which days package is active", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pnlServices.Controls.Count == 0)
            {
                MessageBox.Show("Please select services", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _context.ServicesToPackages.RemoveRange(_context.ServicesToPackages.Where(p => p.PackagesId == selectedPack.Id));
            selectedPack.Name = txtPackName.Text;
            selectedPack.Price = numPrice.Value;
            selectedPack.StartTime = new TimeSpan(dtStartTime.Value.Hour, dtStartTime.Value.Minute, dtStartTime.Value.Second);
            selectedPack.EndTime = new TimeSpan(dtEndTime.Value.Hour, dtEndTime.Value.Minute, dtEndTime.Value.Second);
            selectedPack.isActiveAllDays = cbAllday.Checked;
            selectedPack.isActiveEvenDays = cbEvendays.Checked;
            selectedPack.isActiveOddDays = cbOdddays.Checked;
            selectedPack.Status = cbStatus.Checked;
            foreach (var item in pnlServices.Controls)
            {
                _context.ServicesToPackages.Add(new ServicesToPackage
                {
                    PackagesId = selectedPack.Id,
                    ServicesId = _context.Services.First(serv => serv.ServiceName == ((Button)item).Text).Id
                });
            }
            await _context.SaveChangesAsync();
            MessageBox.Show("Package succsessfully updated", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DtgvwUpdater();
            txtPackName.Text = "";
            numPrice.Value = 0;
            cbAllday.Checked = cbEvendays.Checked = cbOdddays.Checked = false;
            pnlServices.Controls.Clear();
            btnUpdate.Enabled = false;
        }

        private void BtnAddservice_Click(object sender, EventArgs e)
        {
            if (selectedPack == null)
            {
                MessageBox.Show("Please select pack", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbServices.Items.Count > 0)
            {
                Button btn = new Button();
                CreateBtn($"{((Service)cmbServices.SelectedItem).ServiceName}", btn);
                foreach (var item in pnlServices.Controls)
                {
                    if (((Service)cmbServices.SelectedItem).ServiceName == ((Button)item).Text)
                    {
                        MessageBox.Show("This service already exsist", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                pnlServices.Controls.Add(btn);

            }
        }
        private void CreateBtn(string btnText, Button button)
        {
            button.Text = btnText;
            button.BackColor = Color.Orange;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Century Gothic", 10.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            button.ForeColor = SystemColors.ControlLightLight;
            button.Size = new Size(150, 45);
            button.UseVisualStyleBackColor = false;
            button.Click += (send, ev) =>
            {
                pnlServices.Controls.Remove(button);
            };
        }
        private void DtgvwUpdater()
        {
            dtgwPacks.DataSource = _context.Packages.Select(p => new {
                p.Id,
                p.Name,
                p.Price,
                p.StartTime,
                p.EndTime,
                AllDay = p.isActiveAllDays,
                EvenDays = p.isActiveEvenDays,
                OddDays = p.isActiveOddDays,
                p.Status
            }).ToArray();
        }
    }
}
