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
    public partial class Form1 : Form
    {
        private readonly FitnessHoleEntities _context;
        public Form1()
        {
            InitializeComponent();
            _context = new FitnessHoleEntities();
        }
        
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!_context.Employees.Any(u => u.Username == txtUsername.Text))
            {
                MessageBox.Show("Username or password is not valid", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Employee employee = _context.Employees.First(u => u.Username == txtUsername.Text);
            if (!CheckHash(employee.Password, txtPassword.Text))
            {
                MessageBox.Show("Username or password is not valid", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (employee.isVerifiedPass == false)
            {
                new ConfirmPassword(employee).ShowDialog();
                return;
            }
            if (employee.RoleId == 1)
            {
                Admin admin = new Admin(employee);
                admin.ShowDialog();
                this.WindowState = FormWindowState.Minimized;
                txtUsername.Text = txtPassword.Text = "";
                return;
            }
            if (employee.RoleId == 2)
            {
                Worker worker = new Worker(employee);
                worker.ShowDialog();
                this.WindowState = FormWindowState.Minimized;
                txtUsername.Text = txtPassword.Text = "";
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
