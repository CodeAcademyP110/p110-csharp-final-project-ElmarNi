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
    public partial class CreateCustomer : Form
    {
        private readonly FitnessHoleEntities _context;
        public CreateCustomer()
        {
            InitializeComponent();
            _context = new FitnessHoleEntities();
        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {
            dtgwCustomers.DataSource = _context.Customers.Select(c => new { c.Firstname, c.Lastname, c.CardNo }).ToArray();
        }

        private async void BtnCreate_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == string.Empty)
            {
                MessageBox.Show("Please input a firstname / lastname", "Erorr !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtFname.Text.Length < 3)
            {
                MessageBox.Show("Firstname is too short", "Erorr !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Random random = new Random();
            int cardNo = random.Next(100, 1000);
            while (_context.Customers.Any(c => c.CardNo == cardNo))
            {
                cardNo = random.Next(100, 1000);
            }
            _context.Customers.Add(new Customer
            {
                Firstname = txtFname.Text,
                Lastname = txtLname.Text,
                CardNo = cardNo
            });
            await _context.SaveChangesAsync();
            MessageBox.Show("New customer succsessfully created", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFname.Text = txtLname.Text = "";
            dtgwCustomers.DataSource = _context.Customers.Select(c => new { c.Firstname, c.Lastname, c.CardNo }).ToArray();
        }
    }
}
