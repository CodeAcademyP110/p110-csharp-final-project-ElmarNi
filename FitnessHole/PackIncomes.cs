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
    public partial class PackIncomes : Form
    {
        private readonly FitnessHoleEntities _context;
        private decimal incomes = 0;
        public PackIncomes()
        {
            InitializeComponent();
            _context = new FitnessHoleEntities();
        }

        private void PackIncomes_Load(object sender, EventArgs e)
        {
            DtgwUpdater();
            dtgwPacks.Columns[0].Visible = false;
            UpdateIncomeTxt();
            cmbPacks.Items.AddRange(_context.Packages.Where(p => p.Status == true).ToArray());
            CmbEmployeesUpdater();
        }
        private void CmbPacks_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEmployees.Items.Clear();
            CmbEmployeesUpdater();
            incomes = 0;
            dtgwPacks.DataSource = _context.PackageOrders.Where(p => p.PackageId == ((Package)cmbPacks.SelectedItem).Id).Select(p => new
            {
                p.Id,
                p.Employee,
                p.Customer,
                p.DateTime,
                p.Package,
                p.Price
            }).ToArray();
            UpdateIncomeTxt();
        }
        private void UpdateIncomeTxt()
        {
            for (int i = 0; i < dtgwPacks.Rows.Count; i++)
            {
                incomes += int.Parse(dtgwPacks.Rows[i].Cells[5].Value.ToString());
            }
            txtIncome.Text = $"{incomes} AZN";
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            incomes = 0;
            cmbPacks.Items.Clear();
            cmbPacks.Items.AddRange(_context.Packages.Where(p => p.Status == true).ToArray());
            cmbEmployees.Items.Clear();
            CmbEmployeesUpdater();
            DtgwUpdater();
            UpdateIncomeTxt();
        }
        private void CmbEmployeesUpdater()
        {
            cmbEmployees.Items.AddRange(_context.Employees.Where(emp => emp.RoleId == 2).Where(emp => emp.Status == true).ToArray());
        }
        private void DtgwUpdater()
        {
            dtgwPacks.DataSource = _context.PackageOrders.Select(p => new
            {
                p.Id,
                p.Employee,
                p.Customer,
                p.DateTime,
                p.Package,
                p.Price
            }).ToArray();
        }

        private void CmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            incomes = 0;
            cmbPacks.Items.Clear();
            cmbPacks.Items.AddRange(_context.Packages.Where(p => p.Status == true).ToArray());
            dtgwPacks.DataSource = dtgwPacks.DataSource = _context.PackageOrders.Where(p => p.EmployeeId == ((Employee)cmbEmployees.SelectedItem).Id).Select(p => new
            {
                p.Id,
                p.Employee,
                p.Customer,
                p.DateTime,
                p.Package,
                p.Price
            }).ToArray();
            UpdateIncomeTxt();
        }
    }
}
