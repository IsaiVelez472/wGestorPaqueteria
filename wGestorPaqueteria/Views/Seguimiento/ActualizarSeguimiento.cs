using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wGestorPaqueteria.Entities;
using wGestorPaqueteria.Services;

namespace wGestorPaqueteria.Views.Seguimiento
{
    public partial class ActualizarSeguimiento : Form
    {
        private Paquete paqueteSeleccionado;
        private PaqueteService _paqueteService;
        public ActualizarSeguimiento(Paquete paquete)
        {
            InitializeComponent();
            _paqueteService = new PaqueteService();
            paqueteSeleccionado = paquete;
            InicializarCampos();
            DesactivarCacmpos();
        }

        private void ActualizarSeguimiento_Load(object sender, EventArgs e)
        {

        }
        private void DesactivarCacmpos()
        {
            txtIdpaquete.Enabled = false;
            txtNumeroSeguimiento.Enabled = false;
        }

        private void InicializarCampos()
        {
            txtIdpaquete.Text = paqueteSeleccionado.PaqueteID.ToString();
            txtNumeroSeguimiento.Text = paqueteSeleccionado.NumeroSeguimiento.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int paquete = paqueteSeleccionado.PaqueteID;
                DateTime fechaevento = dtpFechaEvento.Value;
                string descripcion = txtDescripciones.Text;
                string ubicacion = txtUbicacion.Text;
             
                _paqueteService.RegistrarSeguimiento(paquete, fechaevento, descripcion,ubicacion);
                MessageBox.Show("Paquete actualizado correctamente.");
                this.Close();
                new VistaPaquetes().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el paquete: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new VistaPaquetes().Show();
            this.Hide();
        }
    }
}
