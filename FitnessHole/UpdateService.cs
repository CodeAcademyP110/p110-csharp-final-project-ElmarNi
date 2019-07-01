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
    public partial class UpdateService : Form
    {
        private readonly FitnessHoleEntities _context;
        private Service selectedService;
        public UpdateService()
        {
            InitializeComponent();
            _context = new FitnessHoleEntities();
        }

        private void UpdateService_Load(object sender, EventArgs e)
        {
            dtgwServices.ReadOnly = true;
            DtgvwUpdater();
        }

        private void DtgwServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdateService.Enabled = true;
            int selectedServiceId = int.Parse(dtgwServices.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
            selectedService = _context.Services.First(serv => serv.Id == selectedServiceId);
            txtServiceName.Text = selectedService.ServiceName;
            numLimitlessprice.Value = selectedService.LimitlessPrice;
            numPriceperhour.Value = selectedService.PricePerHours;
            cbStatus.Checked = (bool)selectedService.Status;
        }

        private async void BtnUpdateService_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text == string.Empty || txtServiceName.Text.Length < 3)
            {
                MessageBox.Show("Service name is not valid", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtServiceName.Text != selectedService.ServiceName)
            {
                if (!_context.Services.Any(serv => serv.ServiceName == txtServiceName.Text))
                {
                    selectedService.ServiceName = txtServiceName.Text;
                }
                else
                {
                    MessageBox.Show("Servicename is duplicate", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (numLimitlessprice.Value < 0 || numPriceperhour.Value < 0)
            {
                MessageBox.Show("Price must be larger than 0", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selectedService.LimitlessPrice = numLimitlessprice.Value;
            selectedService.PricePerHours = numPriceperhour.Value;
            selectedService.Status = cbStatus.Checked;
            await _context.SaveChangesAsync();
            DtgvwUpdater();
            txtServiceName.Text = "";
            numPriceperhour.Value = numLimitlessprice.Value = 0;
            btnUpdateService.Enabled = false;
        }
        private void DtgvwUpdater()
        {
            dtgwServices.DataSource = _context.Services.Select(s => new
            {
                s.Id,
                s.ServiceName,
                s.PricePerHours,
                s.Status
            }).ToArray();
        }
    }
}
