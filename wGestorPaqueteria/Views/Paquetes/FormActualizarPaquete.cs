using System;
using System.Collections.Generic;
using System.Windows.Forms;
using wGestorPaqueteria.Entities;
using wGestorPaqueteria.Services;

namespace wGestorPaqueteria.Views.Paquetes
{
    public partial class FormActualizarPaquete : Form
    {

        private Paquete paqueteSeleccionado;
        private PaqueteService _paqueteService;
        private ClienteService _clienteService;

        public FormActualizarPaquete(Paquete paquete)
        {
            InitializeComponent();

            paqueteSeleccionado = paquete; 

            _paqueteService = new PaqueteService();
            _clienteService = new ClienteService();

            CargarDatosCmbEstado();       
            CargarClientes();
            InicializarCampos();          
            DeshabilitarCampos();
        }

        private void CargarClientes()
        {
            try
            {
                List<Cliente> clientes = _clienteService.ObtenerClientes();

                cmbRemitente.DataSource = new List<Cliente>(clientes);
                cmbRemitente.DisplayMember = "Nombre";
                cmbRemitente.ValueMember = "ClienteID";

                // Establecer valor seleccionado
                cmbRemitente.SelectedValue = paqueteSeleccionado.RemitenteID;


                cmbDestinatario.DataSource = new List<Cliente>(clientes);
                cmbDestinatario.DisplayMember = "Nombre";
                cmbDestinatario.ValueMember = "ClienteID";

                // Establecer valor seleccionado
                cmbDestinatario.SelectedValue = paqueteSeleccionado.DestinatarioID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void InicializarCampos()
        {
            txtNumeroSeguimiento.Text = paqueteSeleccionado.NumeroSeguimiento;
            txtPeso.Text = paqueteSeleccionado.Peso.ToString();
            txtDimensiones.Text = paqueteSeleccionado.Dimensiones;
            txtValorDeclarado.Text = paqueteSeleccionado.ValorDeclarado.ToString();
            cmbEstado.SelectedItem = paqueteSeleccionado.Estado;
        }

        private void DeshabilitarCampos()
        {
            txtNumeroSeguimiento.Enabled = false;
            txtPeso.Enabled = false;
            txtDimensiones.Enabled = false;
            txtValorDeclarado.Enabled = false;
            cmbRemitente.Enabled = false;
            cmbDestinatario.Enabled = false;

            // cmbEstado queda habilitado
            cmbEstado.Enabled = true;
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            try
            {
                _paqueteService.CambiarEstado(paqueteSeleccionado.PaqueteID, cmbEstado.SelectedItem.ToString());
                MessageBox.Show("Paquete actualizado correctamente.");
                this.Close();
                new VistaPaquetes().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el paquete: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
            new VistaPaquetes().Show();
        }

        private void CargarDatosCmbEstado()
        {
            cmbEstado.Items.Add("Recibido");
            cmbEstado.Items.Add("En tránsito");
            cmbEstado.Items.Add("Entregado");
            
        }
    }
}
