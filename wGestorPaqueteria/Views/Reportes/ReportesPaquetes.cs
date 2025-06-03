using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wGestorPaqueteria.Services;

namespace wGestorPaqueteria.Views.Reportes
{
    public partial class ReportesPaquetes : Form
    {
        PaqueteService _paqueteService;
        public ReportesPaquetes()
        {
            InitializeComponent();
            _paqueteService = new PaqueteService();
            GenerarReporte();
            
        }

        private void ReportesPaquetes_Load(object sender, EventArgs e)
        {

        }

        private void GenerarReporte()
        {
            var reporte = _paqueteService.GenerarReporteEnvios();
            dtgvReportes.DataSource = reporte;
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaPaquetes().Show();
        }
    }
}
