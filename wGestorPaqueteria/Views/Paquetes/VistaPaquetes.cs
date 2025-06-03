using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using wGestorPaqueteria.Entities;
using wGestorPaqueteria.Services;
using wGestorPaqueteria.Utils;
using wGestorPaqueteria.Views.Paquetes;
using wGestorPaqueteria.Views.Productos;
using wGestorPaqueteria.Views.Reportes;
using wGestorPaqueteria.Views.Seguimiento;
using wGestorPaqueteria.Views.Usuarios;

namespace wGestorPaqueteria.Views
{
    public partial class VistaPaquetes : Form
    {
        private PaqueteService _paqueteService;
        private ClienteService _clienteService;
        private EmpleadoService _empleadoService;
        private Usuario usuario = SesionUsuario.Actual;

        public VistaPaquetes()
        {
            InitializeComponent();
            _paqueteService = new PaqueteService();
            _clienteService = new ClienteService();
            _empleadoService = new EmpleadoService();

            btnEliminar.Enabled = false; // Desactivado por defecto
            btnActualizar.Enabled = false; // Desactivado por defecto
            dgvPaquetes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaquetes.MultiSelect = false;
            dgvPaquetes.ClearSelection(); // Quita selección inicial
            pnlAsignaciones.Visible = false;
            pnlClientes.Visible = false;
            pnlEmpleados.Visible = false;

            CargarVistas();
            MostrarInfoUsuario();
        }

        private void CargarVistas()
        {
            try
            {
                //se busca el rol del usuario y se dan las vistas correspondientes
                string usuarioRol = usuario.Rol.ToString();
                switch (usuarioRol)
                {
                    case "Administrador":
                        ConfiguracionAdministrador();
                        MostrarPanelPaquetes();
                        break;
                    case "Despachador":
                        ConfiguracionDespachador();
                        MostrarPanelPaquetes();
                        break;
                    case "Conductor":
                        //Aqui no se llama a al panel de paquetes
                        //debido a que el conductor debe ver sus asignaciones
                        ConfiguracionConductor();
                        break;
                    default:
                        MessageBox.Show("Hubo un error al validar el usuario", "error", MessageBoxButtons.OKCancel);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar paquetes: " + ex.Message);
            }
        }

        private void MostrarInfoUsuario()
        {
            string nombre = SesionUsuario.Actual.NombreUsuario;
            string id = SesionUsuario.Actual.IdUsuario.ToString();
            lblUsuario.Text = $"Usuario: {nombre}";
            lblRol.Text = $"Id: {id}";
        }
        //Oculta todos lo paneles cada que abrimos otro panel
        private void OcultarTodosLosPaneles()
        {
            pnlClientes.Visible = false;
            pnlAsignaciones.Visible = false;
            pnlEmpleados.Visible = false;
            // Si existiera un pnlPaquetes o pnlSeguimiento aparte, ocultarlo aquí.
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = (usuario.Rol == "Administrador") && dgvPaquetes.SelectedRows.Count > 0;
            btnActualizar.Enabled = dgvPaquetes.SelectedRows.Count > 0;
        }
        private void dtgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = dtgvClientes.SelectedRows.Count > 0;
            btnActualizar.Enabled = dtgvClientes.SelectedRows.Count > 0;
        }


        private void btnModuloClientes_Click(object sender, EventArgs e)
        {
            //Solo es visible desde administrador, por lo que los datos se cargan desde este
            OcultarTodosLosPaneles();
            pnlClientes.Location = new Point(176, 56);
            pnlClientes.Size = new Size(715, 416);
            pnlClientes.Visible = (usuario.Rol == "Administrador");
        }
        private void btnModuloEmpleados_Click(object sender, EventArgs e)
        {
            //Lo mismo que en clientes
            OcultarTodosLosPaneles();
            //Esto es para colocar el panel en una forma correcta ya que uno se pierde 
            //con eso tan grande
            pnlEmpleados.Location = new Point(176, 56);
            pnlEmpleados.Size = new Size(715, 416);
            pnlEmpleados.Visible = (usuario.Rol == "Administrador");
        }

        private void btnModuloPaquetes_Click(object sender, EventArgs e)
        {

            MostrarPanelPaquetes();
        }
        private void btnModuloAsignaciones_Click(object sender, EventArgs e)
        {
            //Esto se hizo para menor confusión al momento de usar paneles
            this.Hide();
            new FormAsignarPedidos().Show();
        }

        private void btnModuloSeguimiento_Click(object sender, EventArgs e)
        {
            //Se ocultan todos los paneles 
            OcultarTodosLosPaneles(); 
            //Se configura la posición del panel
            PanelSeguimiento();
            //Se carga en el datagrid
            List<AsignacionPaquete> paquetesAsignados = _paqueteService.ObtenerAsignaciones();
            dtgvConductorAsignaciones.DataSource = paquetesAsignados;
            btnModuloAsignaciones.Enabled = true;
            //aquí se crea un nuevo botón esto porque no pude reciclar el otro
            Button btnActualizarSeguimiento = new Button();
            btnActualizarSeguimiento.Text = "Actualizar Seguimiento";
            btnActualizarSeguimiento.Location = new Point(516, 400);
            btnActualizarSeguimiento.Click += btnActualizarPaqueteConductor_Click;
            //Aquí se añade a los controles, si no se hace no aparecer
            this.Controls.Add(btnActualizarSeguimiento);

        }
        private void MostrarPanelPaquetes()
        {
            OcultarTodosLosPaneles();
           
        }


        #region El problema de los paneles
        private void ConfiguracionAdministrador()
        {
            //Se cargan los datagrid de los administradores
            List<Paquete> paquetes = _paqueteService.ListarPaquetes();
            List<Cliente> usuarios = _clienteService.ObtenerClientes();
            List<Empleado> empleados = _empleadoService.ListarEmpleados();    
            dgvPaquetes.DataSource = paquetes;
            dtgvClientes.DataSource = usuarios;
            dtgvEmpleados.DataSource = empleados;
            //Aquí organizo la vista del panel de paquetes 
            btnEliminar.Visible = true;
            btnCancelarPedido.Visible=true;
            btnActualizar.Visible = true;
            //además de los modulos
            btnModuloPaquetes.Visible = true;
            btnModuloClientes.Visible = true;
            btnModuloEmpleados.Visible = true;
            btnModuloAsignaciones.Visible = true;
            btnModuloSeguimiento.Visible = true;
            btnModuloAsignaciones.Enabled = true;
            btnModuloSeguimiento.Enabled = true;
            // si no hay alguna vista active este codigo
            //pnlClientes.Visible = true;
            
        }

        private void ConfiguracionDespachador()
        {
            //Aquí cargamos los datos de que le pertenecen a el despachador
            List<Paquete> paquetes = _paqueteService.ListarPaquetes();
            List<Cliente> usuarios = _clienteService.ObtenerClientes();
            dgvPaquetes.DataSource = paquetes;
            dtgvClientes.DataSource = usuarios;
            btnEliminar.Visible = false;
            //Ponermos el boton de cancelar en una posición mas comoda
            btnCancelarPedido.Location = new Point(360, 400);
            //desactivamos modulos
            btnModuloClientes.Visible = false;
            btnModuloEmpleados.Visible = false;
            btnModuloSeguimiento.Visible = false;
            btnModuloAsignaciones.Visible = false;
        }

        //La mala para el conductor
        private void ConfiguracionConductor()
        {
            //Configuramos el panel de seguimiento
            PanelSeguimiento();
            pnlAsignaciones.Visible = true;
            //traemos los datos pero según el empleado
            //Es se hizo cambiando la consulta del servicio para que cuando fuera nula trajera todos
            //pero si había una condición trajera los correspondientes
            List<AsignacionPaquete> paquetesAsignados = _paqueteService.ObtenerAsignaciones(Convert.ToInt32(usuario.IdUsuario));
            dtgvConductorAsignaciones.DataSource = paquetesAsignados;
            btnModuloAsignaciones.Visible = false ;
            button2.Visible = false;
            //Nuevamente creamos el boton
            Button btnActualizarSeguimiento = new Button();
            btnActualizarSeguimiento.Text = "Actualizar Seguimiento";
            btnActualizarSeguimiento.Location = new Point(516, 400);
            //Reciclamos el evento del click
            btnActualizarSeguimiento.Click += btnActualizarPaqueteConductor_Click;
            btnEliminar.Visible = false;
            btnCancelarPedido.Visible = false;
            //Agregamos el boton
            this.Controls.Add(btnActualizarSeguimiento);
            //Y las configuraciones de los modulos y botones
            btnModuloPaquetes.Visible = false;
            btnModuloClientes.Visible = false;
            btnModuloEmpleados.Visible = false;
            //Lo desactivé para que simule que esta "seleccionado"
            btnModuloSeguimiento.Enabled = false;
            pnlClientes.Visible = false;
            btnModuloPaquetes.Visible = false;
            btnEliminar.Visible = false;
            btnAgregar.Visible = false;
            btnActualizar.Visible = false;
        }

        private void PanelSeguimiento()
        {
            OcultarTodosLosPaneles();
            //posicionamiento del panel
            pnlAsignaciones.Location = new Point(176, 56);
            pnlAsignaciones.Size = new Size(933, 509);
            dtgvConductorAsignaciones.Size = new Size(702, 320);
            
            pnlAsignaciones.Visible = true;
            dtgvConductorAsignaciones.Visible = true;
            label1.Visible = false;
        }

        
        #endregion

        #region CRUD

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAgregarPaquete().Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvPaquetes.SelectedRows.Count > 0)
            {

                var fila = dgvPaquetes.SelectedRows[0];
                var paquete = (Paquete)fila.DataBoundItem;

                if(usuario.Rol != "Administrador")
                {
                    ActualizarSeguimiento actualizarSeguimiento = new ActualizarSeguimiento(paquete);
                    this.Hide();
                    actualizarSeguimiento.Show();
                    return;
                }
                FormActualizarPaquete formActualizar = new FormActualizarPaquete(paquete);
                this.Hide();
                formActualizar.Show();
            }
            else
            {
                MessageBox.Show("Selecciona un paquete para actualizar.");
            }
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
                        CargarVistas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar paquete: " + ex.Message);
                    }
                }
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            //Hice un agregar cliente basandome en lo de agreagar producto, de eso tambien hay servicio
            //También hice uno para el empleado pero como no lo piden no lo seguí haciendo
            this.Hide();
            new FormAgregarCliente().Show();
        }

        private void btnActualizarPaqueteConductor_Click(object sender, EventArgs e)
        {
            if (dtgvConductorAsignaciones.SelectedRows.Count > 0)
            {
                //Aqui hubo problemas ya que el datagridview del conductor es de otra clase
                //Ya que tiene que tener información extra (lo hice por medio de una vista)
                //Seleccionamos la asignacion
                var fila = dtgvConductorAsignaciones.SelectedRows[0];
                //Lo tranformamos en el tipo 
                var paqueteAsignado = (AsignacionPaquete)fila.DataBoundItem;
                //Seleccionamos solamente el ID
                int paqueteID = paqueteAsignado.PaqueteID;
                //Como esto me devuelve una lista, se usa .Single que 
                //Devuelve el único elemento de la colección solo si realmente hay exactamente uno.
                Paquete paquete = _paqueteService.ListarPaquetes(paqueteID).Single();
                //Y lo enviamos al formulario de actualizar
                FormActualizarPaquete formActualizar = new FormActualizarPaquete(paquete);
                this.Hide();
                formActualizar.Show();

            }
            else
            {
                MessageBox.Show("Selecciona un paquete para actualizar.");
            }
        }

        private void btnCancelarPedido_Click_1(object sender, EventArgs e)
        {
            if (dgvPaquetes.SelectedRows.Count > 0)
            {
                var fila = dgvPaquetes.SelectedRows[0];
                var paquete = (Paquete)fila.DataBoundItem;
                //Aqui valido que el estado si sea recido y si está seguro de cancelarlo
                if (paquete.Estado != "Recibido" )
                {
                    MessageBox.Show("El paquete ya no puede ser cancelado");
                    return;
                }
                var result = MessageBox.Show("¿Estás seguro de Cancelar este paquete?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Y aquí cambiamos el estado
                    _paqueteService.CambiarEstado(paquete.PaqueteID, "Cancelado");
                    MessageBox.Show("Paquete a sido cancelado correctamente.");
                    CargarVistas();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un paquete para actualizar.");
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void VistaPaquetes_Load(object sender, EventArgs e)
        {

        }

        private void pnlAsignaciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReportesPaquetes().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CrearUsuarios().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dtgvEmpleados.SelectedRows.Count > 0 && (usuario.Rol == "Administrador"))
            {
                var result = MessageBox.Show("¿Estás seguro de eliminar este Empleado?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var fila = dtgvEmpleados.SelectedRows[0];
                    int empleadoID = (int)fila.Cells["EmpleadoID"].Value;

                    try
                    {
                        _empleadoService.EliminarEmpleado(empleadoID);
                        MessageBox.Show("Empleado eliminado correctamente.");
                        CargarVistas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar empleado: " + ex.Message);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dtgvClientes.SelectedRows.Count > 0 && (usuario.Rol == "Administrador"))
            {
                var result = MessageBox.Show("¿Estás seguro de eliminar este Cliente?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var fila = dtgvClientes.SelectedRows[0];
                    int clienteID = (int)fila.Cells["ClienteID"].Value;

                    try
                    {
                        _clienteService.EliminarCliente(clienteID);
                        MessageBox.Show("Cliente eliminado correctamente.");
                        CargarVistas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar cliente: " + ex.Message);
                    }
                }
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
