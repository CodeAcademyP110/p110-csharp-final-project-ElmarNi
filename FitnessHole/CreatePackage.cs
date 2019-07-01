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
    public partial class CreatePackage : Form
    {
        private readonly FitnessHoleEntities _context;
        public CreatePackage()
        {
            InitializeComponent();
            _context = new FitnessHoleEntities();
        }

        private void CreatePackage_Load(object sender, EventArgs e)
        {
            dtgwPacks.ReadOnly = true;
            DtgvwUpdater();
            dtStartTime.Format = DateTimePickerFormat.Custom;
            dtStartTime.CustomFormat = "HH:mm"; // Only use hours and minutes
            dtStartTime.ShowUpDown = true;
            dtEndTime.Format = DateTimePickerFormat.Custom;
            dtEndTime.CustomFormat = "HH:mm"; // Only use hours and minutes
            dtEndTime.ShowUpDown = true;
            cmbServices.Items.AddRange(_context.Services.Where(serv => serv.Status == true).ToArray());
            if (cmbServices.Items.Count > 0)
            {
                cmbServices.SelectedIndex = 0;
            }
        }

        private void BtnAddservice_Click(object sender, EventArgs e)
        {
            if (cmbServices.Items.Count > 0)
            {
                Button btn = new Button();
                btn.Text = $"{((Service)cmbServices.SelectedItem).ServiceName}";
                btn.BackColor = Color.Orange;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Font = new Font("Century Gothic", 10.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = SystemColors.ControlLightLight;
                btn.Size = new Size(150, 45);
                btn.UseVisualStyleBackColor = false;
                btn.Click += (send, ev) =>
                {
                    pnlServices.Controls.Remove(btn);
                };
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
            else {
                MessageBox.Show("You have not any service. Please add service first", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private async void BtnCreate_Click(object sender, EventArgs e)
        {
            if (txtPackName.Text == string.Empty || txtPackName.Text.Length < 3)
            {
                MessageBox.Show("Please input a valid package name(it must contain more than 3 chars)", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_context.Packages.Any(pack => pack.Name == txtPackName.Text))
            {
                MessageBox.Show("Package is duplicate", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
            Package package = _context.Packages.Add(new Package
            {
                Name = txtPackName.Text,
                Price = numPrice.Value,
                StartTime = new TimeSpan(dtStartTime.Value.Hour, dtStartTime.Value.Minute, dtStartTime.Value.Second),
                EndTime = new TimeSpan(dtEndTime.Value.Hour, dtEndTime.Value.Minute, dtEndTime.Value.Second),
                isActiveAllDays = cbAllday.Checked,
                isActiveEvenDays = cbEvendays.Checked,
                isActiveOddDays = cbOdddays.Checked
            });
            foreach (var item in pnlServices.Controls)
            {
                _context.ServicesToPackages.Add(new ServicesToPackage
                {
                    PackagesId = package.Id,
                    ServicesId = _context.Services.First(serv => serv.ServiceName == ((Button)item).Text).Id
                });
            }
            await _context.SaveChangesAsync();
            MessageBox.Show("New package succsessfully added", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DtgvwUpdater();
            txtPackName.Text = "";
            numPrice.Value = 0;
            cbAllday.Checked = cbEvendays.Checked = cbOdddays.Checked = false;
            pnlServices.Controls.Clear();
        }
        //Day checkboxes
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
