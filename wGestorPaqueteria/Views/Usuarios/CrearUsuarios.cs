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

namespace wGestorPaqueteria.Views.Usuarios
{
    public partial class CrearUsuarios : Form
    {
        EmpleadoService _empleadoService;
        public CrearUsuarios()
        {
            InitializeComponent();
            _empleadoService = new EmpleadoService();
            CargarCombo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtContrasenna.Text)
                    || string.IsNullOrEmpty(cmbRol.Text))
                {
                    MessageBox.Show("Rellene todo los campos");
                }
                else
                {
                    var cliente = new Empleado
                    {
                        Nombre = txtNombre.Text,
                        Rol = cmbRol.Text,
                        Celular = txtTelefono.Text
                    };

                    _empleadoService.RegistrarEmpleado(cliente);
                    MessageBox.Show("Registro exitoso");
                    
                }
            }
            catch
            {
                MessageBox.Show("Error al insertar Usuario");
            }
        }

        private void CrearUsuarios_Load(object sender, EventArgs e)
        {
        }

        private void CargarCombo()
        {
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Despachador");
            cmbRol.Items.Add("Conductor");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaPaquetes().Show();
        }
    }
}
