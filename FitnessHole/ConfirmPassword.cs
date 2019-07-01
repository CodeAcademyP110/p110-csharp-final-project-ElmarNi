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
    public partial class ConfirmPassword : Form
    {
        private Employee employee;
        private readonly FitnessHoleEntities _context;
        public ConfirmPassword(Employee emp)
        {
            InitializeComponent();
            employee = emp;
            _context = new FitnessHoleEntities();
        }

        private async void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (txtConfirmpass.Text == string.Empty || txtCurrentpass.Text == string.Empty || txtNewpass.Text == string.Empty)
            {
                MessageBox.Show("Please fill textboxes", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!CheckHash(employee.Password, txtCurrentpass.Text))
            {
                MessageBox.Show("Current password is not valid", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNewpass.Text.Length <= 5)
            {
                MessageBox.Show("Password must contain more than 5 characters", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtConfirmpass.Text != txtNewpass.Text)
            {
                MessageBox.Show("Passwords do not match", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Employee changedEmployee = _context.Employees.First(emp => emp.Id == employee.Id);
            changedEmployee.Password = GetHash(txtConfirmpass.Text);
            changedEmployee.isVerifiedPass = true;
            await _context.SaveChangesAsync();
            if (employee.RoleId == 1)
            {
                Admin admin = new Admin(employee);
                admin.ShowDialog();
                return;
            }
            if (employee.RoleId == 2)
            {
                Worker worker = new Worker(employee);
                worker.ShowDialog();
                return;
            }
            Close();
        }
    }
}
