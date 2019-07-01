using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FitnessHole.Utilities.Hash;

namespace FitnessHole
{
    public partial class UpdateWorker : Form
    {
        private readonly Employee employee;
        private readonly FitnessHoleEntities _context;
        private Employee selectedEmp;
        public UpdateWorker( Employee emp)
        {
            InitializeComponent();
            employee = emp;
            _context = new FitnessHoleEntities();
        }

        private void UpdateWorker_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
            cmbRoles.Items.AddRange(_context.Roles.ToArray());
            cmbRoles.SelectedIndex = 0;
        }
        private void DtgwWorkers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            int selectedEmpId = int.Parse(dtgwWorkers.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
            selectedEmp = _context.Employees.First(emp => emp.Id == selectedEmpId);
            txtFname.Text = selectedEmp.Firstname;
            txtLname.Text = selectedEmp.Lastname;
            txtUsername.Text = selectedEmp.Username;
            cmbRoles.SelectedItem = selectedEmp.Role;
            cbStatus.Checked = selectedEmp.Status;
        }
        private void UpdateDataGridView()
        {
            dtgwWorkers.DataSource = null;
            dtgwWorkers.DataSource = _context.Employees.Select(emp => new
            {
                emp.Id,
                emp.Firstname,
                emp.Lastname,
                emp.Username,
                emp.Role,
                VerifiedPassword = emp.isVerifiedPass,
                emp.Status
            }).ToList();
            dtgwWorkers.ReadOnly = true;
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == string.Empty || txtLname.Text == string.Empty)
            {
                MessageBox.Show("Firstname or Lastname is empty! Please fill these", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtUsername.Text.Length <= 3)
            {
                MessageBox.Show("Username must contain more than 3 characters", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtUsername.Text != selectedEmp.Username)
            {
                if (!_context.Employees.Any(emp => emp.Username == txtUsername.Text))
                {
                    selectedEmp.Username = txtUsername.Text;
                }
                else
                {
                    MessageBox.Show("Username is duplicate", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (txtPassword.Text.Length >= 5)
            {
                selectedEmp.Password = GetHash(txtPassword.Text);
            }
            else
            {
                MessageBox.Show("Password is not changed.If you want change it input a valid password(longer than 5 chars)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            selectedEmp.Firstname = txtFname.Text;
            selectedEmp.Lastname = txtLname.Text;
            selectedEmp.RoleId = ((Role)cmbRoles.SelectedItem).Id;
            selectedEmp.Status = cbStatus.Checked;
            await _context.SaveChangesAsync();
            UpdateDataGridView();
            cmbRoles.SelectedIndex = 0;
            txtUsername.Text = txtPassword.Text = txtLname.Text = txtFname.Text = "";
            btnUpdate.Enabled = false;
        }
    }
}
