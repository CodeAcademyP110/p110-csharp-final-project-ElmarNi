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
    public partial class Worker : Form
    {
        private Employee employee;
        private readonly FitnessHoleEntities _context;
        public Worker(Employee emp)
        {
            InitializeComponent();
            employee = emp;
            _context = new FitnessHoleEntities();
        }

        private void Worker_Load(object sender, EventArgs e)
        {
            lblMain.Text = $"Hello dear {employee.Firstname} {employee.Lastname}. Welcome !";
        }

        private void CreateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreateCustomer().Show();
        }

        private void BuyServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BuyService(employee).Show();
        }

        private void BuyPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BuyPack(employee).Show();
        }
    }
}
