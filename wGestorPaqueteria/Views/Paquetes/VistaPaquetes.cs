using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
        private ClienteService _clienteService;
        private Usuario usuario = SesionUsuario.Actual;

        public VistaPaquetes()
        {
            InitializeComponent();
            _paqueteService = new PaqueteService();
            _clienteService = new ClienteService();

            btnEliminar.Enabled = false; // Desactivado por defecto
            btnActualizar.Enabled = false; // Desactivado por defecto
            dgvPaquetes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaquetes.MultiSelect = false;
            dgvPaquetes.ClearSelection(); // Quita selección inicial
            pnlAsignaciones.Visible = false;
            pnlClientes.Visible = false;

            CargarProductos();
            MostrarInfoUsuario();
            CambiarVista();
        }

        private void CargarProductos()
        {
            try
            {
                if(!(usuario.Rol == "Conductor"))
                {
                    List<Paquete> paquetes = _paqueteService.ListarPaquetes();
                    List<Cliente> usuarios = _clienteService.ObtenerClientes();
                    dgvPaquetes.DataSource = paquetes;
                    dtgvClientes.DataSource = usuarios;
                    return;
                }
                PanelAsignacion();
                List<AsignacionPaquete> paquetesAsignados = _paqueteService.AsignacionesPaquetes(Convert.ToInt32(usuario.IdUsuario));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar paquetes: " + ex.Message);
            }
        }

        private void CambiarVista()
        {
            //MessageBox.Show(usuario.Rol.ToString());
            if (usuario.Rol == "Administrador")
            {

                btnEliminar.Visible = true;
                btnModuloClientes.Visible = true;
            }
            else if (usuario.Rol == "Despachador") // Por ejemplo: empleado
            {
                btnEliminar.Visible = false;
                btnModuloClientes.Visible = false;
            }
            else if (usuario.Rol == "Conductor")
            {
                btnEliminar.Visible = false;
                btnModuloClientes.Visible = false;
                btnModuloAsignaciones.Enabled = true;
                btnModuloSeguimiento.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAgregarPaquete().Show();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPaquetes.SelectedRows.Count > 0 && (usuario.Rol == "Administrador"))
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
            btnEliminar.Enabled =  (usuario.Rol == "Administrador") && dgvPaquetes.SelectedRows.Count > 0  ;
            btnActualizar.Enabled = dgvPaquetes.SelectedRows.Count > 0;
        }
        private void dtgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = dtgvClientes.SelectedRows.Count > 0 ;
            btnActualizar.Enabled = dtgvClientes.SelectedRows.Count > 0;
        }

        
        private void btnModuloClientes_Click(object sender, EventArgs e)
        {
            pnlClientes.Visible = (usuario.Rol == "Administrador");
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

        private void btnModuloPaquetes_Click(object sender, EventArgs e)
        {
            pnlClientes.Visible=false;
        }

        private void btnModuloAsignaciones_Click(object sender, EventArgs e)
        {
            PanelAsignacion();
        }

        private void btnModuloSeguimiento_Click(object sender, EventArgs e)
        {
            PanelSeguimiento();

        }

        private void PanelSeguimiento()
        {
            pnlAsignaciones.Visible = true;
            dtgvConductorAsignaciones.Visible = true;
            btnActualizarPaqueteConductor.Visible = true;
            pnlAsignaciones.BackColor = Color.OldLace;
            label1.Visible = false;
            pnlClientes.Visible = false;
            btnModuloPaquetes.Visible = false;
            btnEliminar.Visible = false;
            btnAgregar.Visible = false;
            btnModuloClientes.Visible = false;
        }

        private void PanelAsignacion()
        {
            pnlAsignaciones.Visible = true;
            label1.Visible = true;
            btnActualizarPaqueteConductor.Visible = false;
            dtgvConductorAsignaciones.Visible = false;
            pnlClientes.Visible = false;
            btnModuloPaquetes.Visible = false;
            btnEliminar.Visible = false;
            btnAgregar.Visible = false;
            btnModuloClientes.Visible = false;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VistaPaquetes_Load(object sender, EventArgs e)
        {

        }

        private void dtgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }
    }
}
