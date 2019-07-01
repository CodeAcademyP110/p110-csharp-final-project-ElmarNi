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
    public partial class CreateWorker : Form
    {
        private readonly FitnessHoleEntities _context;
        public CreateWorker()
        {
            InitializeComponent();
            _context = new FitnessHoleEntities();
        }

        private void CreateWorker_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
            dtgwWorkers.ReadOnly = true;
            cmbRoles.Items.AddRange(_context.Roles.ToArray());
            cmbRoles.SelectedIndex = 0;
        }
        private async void Button1_Click(object sender, EventArgs e)
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
            if (_context.Employees.Any(emp => emp.Username == txtUsername.Text))
            {
                MessageBox.Show("Username is duplicate", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text.Length <= 5)
            {
                MessageBox.Show("Password must contain more than 5 characters", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _context.Employees.Add(new Employee
            {
                Firstname = txtFname.Text,
                Lastname = txtLname.Text,
                Username = txtUsername.Text,
                Password = GetHash(txtPassword.Text),
                RoleId = ((Role)cmbRoles.SelectedItem).Id,
                isVerifiedPass = false 
            });
            MessageBox.Show("New employee succsessfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await _context.SaveChangesAsync();
            txtUsername.Text = txtPassword.Text = txtLname.Text = txtFname.Text = "";
            UpdateDataGridView();
            cmbRoles.SelectedIndex = 0;
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
        }
    }
}
