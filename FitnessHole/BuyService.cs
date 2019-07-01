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
    public partial class BuyService : Form
    {
        private Employee employee;
        decimal total = 0;
        private readonly FitnessHoleEntities _context;
        public BuyService(Employee emp)
        {
            InitializeComponent();
            employee = emp;
            _context = new FitnessHoleEntities();
        }

        private void BuyService_Load(object sender, EventArgs e)
        {
            cmbCustomers.Items.AddRange(_context.Customers.ToArray());
            cmbServices.Items.AddRange(_context.Services.Where(serv => serv.Status == true).ToArray());
            if (cmbServices.Items.Count > 0)
            {
                cmbServices.SelectedIndex = 0;
            }
            for (int i = 1; i < 13; i++)
            {
                cmbHours.Items.Add(i);
            }
            cmbHours.SelectedIndex = 0;
        }

        private void BtnAddserv_Click(object sender, EventArgs e)
        {
            if (cmbServices.Items.Count > 0)
            {
                decimal price = ((Service)cmbServices.SelectedItem).PricePerHours * decimal.Parse(cmbHours.SelectedItem.ToString());
                Button button = new Button();
                button.Text = $"{((Service)cmbServices.SelectedItem).ServiceName}";
                button.BackColor = Color.Orange;
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Century Gothic", 10.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = SystemColors.ControlLightLight;
                button.Size = new Size(150, 45);
                button.UseVisualStyleBackColor = false;
                button.Click += (send, ev) =>
                {
                    pnlServices.Controls.Remove(button);
                    total = total - price;
                    numericUpDown1.Value = total;
                };
                foreach (var item in pnlServices.Controls)
                {
                    if (((Service)cmbServices.SelectedItem).ServiceName == ((Button)item).Text)
                    {
                        MessageBox.Show("This service already exsist", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                pnlServices.Controls.Add(button);
                total = total + price;
                numericUpDown1.Value = total;
            }
            else
            {
                MessageBox.Show("You have not any service. Please add service first", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private async void BtnFinish_Click(object sender, EventArgs e)
        {
            if (pnlServices.Controls.Count <1)
            {
                MessageBox.Show("Please select service", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ServicesOrder order = _context.ServicesOrders.Add(new ServicesOrder
            {
                CustomerId = ((Customer)cmbCustomers.SelectedItem).Id,
                EmployeeId = employee.Id,
                Datetime = DateTime.Now,
                Price = int.Parse(numericUpDown1.Value.ToString())
            });
            foreach (var item in pnlServices.Controls)
            {
                Service service = _context.Services.First(serv => serv.ServiceName == ((Button)item).Text);
                _context.OrderDetailsServices.Add(new OrderDetailsService {
                    OrderId = order.Id,
                    ServiceId = service.Id
                });
            }
            await _context.SaveChangesAsync();
            MessageBox.Show("Purchased", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbServices.SelectedIndex = 0;
            cmbHours.SelectedIndex = 0;
            cmbCustomers.SelectedIndex = 0;
            numericUpDown1.Value = 0;
            pnlServices.Controls.Clear();
        }

        private void CmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCustomers.Enabled = false;
        }
    }
}
