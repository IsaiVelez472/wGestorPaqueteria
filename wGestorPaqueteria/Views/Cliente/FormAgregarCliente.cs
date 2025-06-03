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
    public partial class FormAgregarCliente : Form
    {
        private ClienteService _clienteService;
        public FormAgregarCliente()
        {
            InitializeComponent();
            _clienteService = new ClienteService();
        }

        private void FormAgregarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new VistaPaquetes().Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    Direccion = txtDireccion.Text,
                };

                _clienteService.RegistrarCliente(cliente);
                MessageBox.Show("Cliente guardado correctamente.");
                this.Hide();
                new VistaPaquetes().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el Cliente: " + ex.Message);
            }
        }
    }
}
