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
    public partial class Admin : Form
    {
        private readonly Employee employee;
        private readonly FitnessHoleEntities _context;
        public Admin(Employee emp)
        {
            InitializeComponent();
            employee = emp;
            _context = new FitnessHoleEntities();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            lblMain.Text = $"Hello dear {employee.Lastname} {employee.Firstname}. Welcome !";
        }
        private void CreateNewWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreateWorker().Show();
        }
        private void UpdateWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdateWorker(employee).Show();
        }

        private void CreateNewServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreateService().Show();
        }

        private void UpdateServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdateService().Show();
        }

        private void CreateNewPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreatePackage().Show();
        }

        private void UpdatePackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdatePackage().Show();
        }

        private void AllIncomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal price = 0;
            foreach (var item in _context.PackageOrders)
            {
                price += (decimal)item.Price;
            }
            MessageBox.Show($"All incomes: {price}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FromPackagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PackIncomes().Show();
        }

        private void FromServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Serviceİncomes().Show();
        }

        private void OutcomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Outcomes().Show();
        }

        private void NetIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal income = 0;
            foreach (var item in _context.PackageOrders)
            {
                income += (decimal)item.Price;
            }
            decimal outcome = 0;
            foreach (var item in _context.OutComes)
            {
                outcome += (decimal)item.Price;
            }
            MessageBox.Show($"Net incomes {income - outcome}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
