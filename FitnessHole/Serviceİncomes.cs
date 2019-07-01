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
    public partial class Serviceİncomes : Form
    {
        private readonly FitnessHoleEntities _context;
        decimal income = 0;
        public Serviceİncomes()
        {
            InitializeComponent();
            _context = new FitnessHoleEntities();
        }

        private void Serviceİncomes_Load(object sender, EventArgs e)
        {
            CmbEmployeesUpdater();
            DtgwUpdate();
            dtgwServs.Columns[0].Visible = false;
            UpdateIncomeTxt();
            
        }
        private void UpdateIncomeTxt()
        {
            for (int i = 0; i < dtgwServs.Rows.Count; i++)
            {
                income += int.Parse(dtgwServs.Rows[i].Cells[4].Value.ToString());
            }
            txtIncome.Text = $"{income} AZN";
        }
        private void CmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            income = 0;
            dtgwServs.DataSource = dtgwServs.DataSource = _context.ServicesOrders.Where(serv => serv.EmployeeId == ((Employee)cmbEmployees.SelectedItem).Id).Select(serv => new
            {
                serv.Id,
                serv.Employee,
                serv.Customer,
                serv.Datetime,
                serv.Price
            }).ToArray();
            UpdateIncomeTxt();
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            income = 0;
            cmbEmployees.Items.Clear();
            CmbEmployeesUpdater();
            DtgwUpdate();
            UpdateIncomeTxt();
        }
        private void CmbEmployeesUpdater()
        {
            cmbEmployees.Items.AddRange(_context.Employees.Where(emp => emp.RoleId == 2).Where(emp => emp.Status == true).ToArray());
        }
        private void DtgwUpdate()
        {
            dtgwServs.DataSource = _context.ServicesOrders.Select(serv => new
            {
                serv.Id,
                serv.Employee,
                serv.Customer,
                serv.Datetime,
                serv.Price
            }).ToArray();
        }
    }
}
