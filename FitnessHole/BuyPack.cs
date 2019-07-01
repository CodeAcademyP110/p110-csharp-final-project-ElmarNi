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
    public partial class BuyPack : Form
    {
        private Employee employee;
        private readonly FitnessHoleEntities _context;
        Package selectedPack;
        public BuyPack(Employee emp)
        {
            InitializeComponent();
            employee = emp;
            _context = new FitnessHoleEntities();
        }

        private void BuyPack_Load(object sender, EventArgs e)
        {
            cmbPackages.Items.AddRange(_context.Packages.Where(p => p.Status == true).ToArray());
            if (cmbPackages.Items.Count > 0)
            {
                cmbPackages.SelectedIndex = 0;
            }
            cmbCustomers.Items.AddRange(_context.Customers.ToArray());
        }

        private void CmbPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPack = _context.Packages.
                First(p => p.Id == ((Package)cmbPackages.SelectedItem).Id);
            pnlServices.Controls.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _context.Packages.
                Where(p => p.Id == ((Package)cmbPackages.SelectedItem).Id).Select(p => new {
                    p.Name,
                    p.Price,
                    p.StartTime,
                    p.EndTime,
                    AllDay = p.isActiveAllDays,
                    EvenDays = p.isActiveEvenDays,
                    OddDays = p.isActiveOddDays
                }).ToArray();
            numericUpDown1.Value = selectedPack.Price;
            foreach (var item in _context.ServicesToPackages.Where(sp => sp.PackagesId == ((Package)cmbPackages.SelectedItem).Id))
            {
                Button btn = new Button();
                CreateBtn($"{item.Service}", btn);
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
        }

        private void CmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCustomers.Enabled = false;
        }

        private async void BtnFinish_Click(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedIndex < 0)
            {
                MessageBox.Show("Please select customer", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _context.PackageOrders.Add(new PackageOrder {
                CustomerId = ((Customer)cmbCustomers.SelectedItem).Id,
                PackageId = selectedPack.Id,
                Price = numericUpDown1.Value,
                DateTime = DateTime.Now,
                EmployeeId = employee.Id
            });
            await _context.SaveChangesAsync();
            cmbCustomers.SelectedIndex = -1;
            cmbCustomers.Enabled = true;
            cmbPackages.SelectedIndex = 0;
        }
    }
}
