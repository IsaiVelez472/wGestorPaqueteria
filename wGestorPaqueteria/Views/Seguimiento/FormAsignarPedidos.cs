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

namespace wGestorPaqueteria.Views.Paquetes
{ 
    public partial class FormAsignarPedidos : Form
    {
        EmpleadoService _empleadoSevice;
        PaqueteService  _paqueteService;
        private string empleadoRol = "conductor";
        public FormAsignarPedidos()
        {
            InitializeComponent();
            _empleadoSevice = new EmpleadoService();
            _paqueteService = new PaqueteService();
            CargarConductores();
        }

        private void FormAsignarPedidos_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaPaquetes().Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string numeroTexto = txtNumeroSeguimiento.Text;
                string conductorTexto = cmbConductor.Text;

                if (string.IsNullOrWhiteSpace(numeroTexto) || string.IsNullOrWhiteSpace(conductorTexto) ||
                    !int.TryParse(numeroTexto, out int numeroSeguimiento))
                {
                    MessageBox.Show("Rellene todos los campos de forma correcta");
                    return;
                }

                if (!ValidarPaquete(numeroSeguimiento))
                {
                    MessageBox.Show("El paquete no existe");
                    return;
                }

                int conductorId = (int)cmbConductor.SelectedValue;
                string error;
                bool asignado = _paqueteService.AsignarPaqueteAConductor(numeroSeguimiento, conductorId, out error);

                if (asignado)
                {
                    var confirmacion = MessageBox.Show("¿Quieres volver al inicio?", "Confirmación", MessageBoxButtons.YesNo);
                    if (confirmacion == DialogResult.Yes)
                    {
                        this.Hide();
                        new VistaPaquetes().Show();
                    }
                }
                else
                {
                    if (error == "ya_asignado")
                        MessageBox.Show("Ya hay un conductor asignado a este paquete");
                    else
                        MessageBox.Show("Hubo un error al registrar la asignación");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al registrar la asignación");
            }
        }

        private void CargarConductores()
        {
            try
            {
                List<Empleado> empleados = _empleadoSevice.ListarEmpleados(empleadoRol);

                cmbConductor.DataSource = new List<Empleado>(empleados);
                cmbConductor.DisplayMember = "Nombre";
                cmbConductor.ValueMember = "EmpleadoID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private bool ValidarPaquete(int paqueteId)
        {
            List<Paquete> paquetes = _paqueteService.ListarPaquetes();

            bool paqueteExiste = paquetes.Any(p => p.PaqueteID == paqueteId);

            return paqueteExiste;
        }
    }
}
