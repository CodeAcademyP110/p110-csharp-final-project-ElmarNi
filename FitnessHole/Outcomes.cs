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
    public partial class Outcomes : Form
    {
        private readonly FitnessHoleEntities _context;
        public Outcomes()
        {
            InitializeComponent();
            _context = new FitnessHoleEntities();
        }

        private void Outcomes_Load(object sender, EventArgs e)
        {
            dtgwOutcomes.DataSource = _context.OutComes.ToArray();
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtIncome.Text == string.Empty || txtDesc.Text == string.Empty)
            {
                MessageBox.Show("Please fill all textboxes", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numericUpDown1.Value < 0)
            {
                MessageBox.Show("Please input a valid price", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _context.OutComes.Add(new OutCome
            {
                WhatFor = txtIncome.Text,
                Description = txtDesc.Text,
                Price = int.Parse(numericUpDown1.Value.ToString())
            });
            await _context.SaveChangesAsync();
            MessageBox.Show("Outcome succsessfully added", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDesc.Text = txtIncome.Text = "";
            numericUpDown1.Value = 0;
            dtgwOutcomes.DataSource = _context.OutComes.ToArray();
        }
    }
}
