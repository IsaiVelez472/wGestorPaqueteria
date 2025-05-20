using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using wGestorPaqueteria.Entities;
using wGestorPaqueteria.Services;
using wGestorPaqueteria.Utils;
using wGestorPaqueteria.Views.Paquetes;
using wGestorPaqueteria.Views.Productos;

namespace wGestorPaqueteria.Views
{
    public partial class VistaPaquetes : Form
    {
        private PaqueteService _paqueteService;

        public VistaPaquetes()
        {
            InitializeComponent();
            _paqueteService = new PaqueteService();

            btnEliminar.Enabled = false; // Desactivado por defecto
            btnActualizar.Enabled = false; // Desactivado por defecto
            dgvPaquetes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaquetes.MultiSelect = false;
            dgvPaquetes.ClearSelection(); // Quita selección inicial

            CargarProductos();
            MostrarInfoUsuario();
        }

        private void CargarProductos()
        {
            try
            {
                List<Paquete> paquetes = _paqueteService.ListarPaquetes();
                dgvPaquetes.DataSource = paquetes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar paquetes: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAgregarPaquete().Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPaquetes.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("¿Estás seguro de eliminar este paquete?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var fila = dgvPaquetes.SelectedRows[0];
                    int paqueteID = (int)fila.Cells["PaqueteID"].Value;

                    try
                    {
                        _paqueteService.EliminarPaquete(paqueteID);
                        MessageBox.Show("Paquete eliminado correctamente.");
                        CargarProductos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar paquete: " + ex.Message);
                    }
                }
            }
        }

        private void MostrarInfoUsuario()
        {
            string nombre = SesionUsuario.Actual.NombreUsuario;
            string id = SesionUsuario.Actual.IdUsuario.ToString();

            lblUsuario.Text = $"Usuario: {nombre}";
            lblRol.Text = $"Id: {id}";
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = dgvPaquetes.SelectedRows.Count > 0;
            btnActualizar.Enabled = dgvPaquetes.SelectedRows.Count > 0;
        }

        private void btnModuloPaquetes_Click(object sender, EventArgs e)
        {

        }

        private void btnModuloClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvPaquetes.SelectedRows.Count > 0)
            {
                var fila = dgvPaquetes.SelectedRows[0];
                var paquete = (Paquete)fila.DataBoundItem;

                FormActualizarPaquete formActualizar = new FormActualizarPaquete(paquete);
                formActualizar.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona un paquete para actualizar.");
            }
        }
    }
}
