using System;
using System.Collections.Generic;
using System.Windows.Forms;
using wGestorPaqueteria.Entities;
using wGestorPaqueteria.Services;

namespace wGestorPaqueteria.Views.Productos
{
    public partial class FormAgregarPaquete : Form
    {
        private ClienteService _clienteService;
        private PaqueteService _paqueteService;

        public FormAgregarPaquete()
        {
            InitializeComponent();
            _clienteService = new ClienteService();
            _paqueteService = new PaqueteService();
            CargarClientes();
            CargarDatosCmbEstado();
        }

        private void CargarClientes()
        {
            try
            {
                List<Cliente> clientes = _clienteService.ObtenerClientes();

                cmbRemitente.DataSource = new List<Cliente>(clientes);
                cmbRemitente.DisplayMember = "Nombre";
                cmbRemitente.ValueMember = "ClienteID";

                cmbDestinatario.DataSource = new List<Cliente>(clientes);
                cmbDestinatario.DisplayMember = "Nombre";
                cmbDestinatario.ValueMember = "ClienteID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var paquete = new Paquete
                {
                    NumeroSeguimiento = txtNumeroSeguimiento.Text,
                    Peso = decimal.Parse(txtPeso.Text),
                    Dimensiones = txtDimensiones.Text,
                    ValorDeclarado = decimal.Parse(txtValorDeclarado.Text),
                    Estado = cmbEstado.SelectedItem.ToString(),
                    RemitenteID = (int)cmbRemitente.SelectedValue,
                    DestinatarioID = (int)cmbDestinatario.SelectedValue
                };

                _paqueteService.RegistrarPaquete(paquete);
                MessageBox.Show("Paquete guardado correctamente.");
                this.Close();
                new VistaPaquetes().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el paquete: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new VistaPaquetes().Show();
        }

        private void CargarDatosCmbEstado()
        {
            cmbEstado.Items.Add("Recibido");
            cmbEstado.Items.Add("En tránsito");
            cmbEstado.Items.Add("Entregado");
            cmbEstado.SelectedIndex = 0;
        }
    }
}
