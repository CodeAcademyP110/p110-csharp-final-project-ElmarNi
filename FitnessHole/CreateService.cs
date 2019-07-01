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
    public partial class CreateService : Form
    {
        private readonly FitnessHoleEntities _context;
        public CreateService()
        {
            InitializeComponent();
            _context = new FitnessHoleEntities();
        }
        private void CreateService_Load(object sender, EventArgs e)
        {
            dtgwServices.ReadOnly = true;
            DtgvwUpdater();
        }

        private async void BtnCreateService_Click(object sender, EventArgs e)
        {
            string serviceName = txtServiceName.Text;
            int pricePerHour = (int)numPriceperhour.Value;
            int limitlessPrice = (int)numLimitlessprice.Value;
            if (serviceName == string.Empty || serviceName.Length < 3)
            {
                MessageBox.Show("Service name is not valid", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pricePerHour <= 0 || limitlessPrice <= 0)
            {
                MessageBox.Show("Price must be larger than 0", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_context.Services.Any(serv => serv.ServiceName == serviceName))
            {
                MessageBox.Show("Service is duplicate", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _context.Services.Add(new Service
            {
                ServiceName = serviceName,
                PricePerHours = pricePerHour,
                LimitlessPrice = limitlessPrice
            });
            MessageBox.Show("Service succsessfully created", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await _context.SaveChangesAsync();
            DtgvwUpdater();
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
