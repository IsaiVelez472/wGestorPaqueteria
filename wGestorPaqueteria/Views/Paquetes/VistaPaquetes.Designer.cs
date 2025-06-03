namespace wGestorPaqueteria.Views
{
    partial class VistaPaquetes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModuloPaquetes = new System.Windows.Forms.Button();
            this.btnModuloClientes = new System.Windows.Forms.Button();
            this.btnModuloEmpleados = new System.Windows.Forms.Button();
            this.btnModuloSeguimiento = new System.Windows.Forms.Button();
            this.btnModuloAsignaciones = new System.Windows.Forms.Button();
            this.dgvPaquetes = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.dtgvClientes = new System.Windows.Forms.DataGridView();
            this.pnlAsignaciones = new System.Windows.Forms.Panel();
            this.dtgvConductorAsignaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizarPaqueteConductor = new System.Windows.Forms.Button();
            this.pnlEmpleados = new System.Windows.Forms.Panel();
            this.dtgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            this.pnlClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).BeginInit();
            this.pnlAsignaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConductorAsignaciones)).BeginInit();
            this.pnlEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelHeader.Controls.Add(this.lblUsuario);
            this.panelHeader.Controls.Add(this.lblRol);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(174, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(743, 50);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUsuario.Location = new System.Drawing.Point(15, 15);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(152, 21);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario: [Nombre]";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblRol.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRol.Location = new System.Drawing.Point(200, 17);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(64, 19);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol: [Rol]";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnModuloPaquetes);
            this.panelMenu.Controls.Add(this.btnModuloClientes);
            this.panelMenu.Controls.Add(this.btnModuloEmpleados);
            this.panelMenu.Controls.Add(this.btnModuloSeguimiento);
            this.panelMenu.Controls.Add(this.btnModuloAsignaciones);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(174, 470);
            this.panelMenu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModuloPaquetes
            // 
            this.btnModuloPaquetes.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnModuloPaquetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModuloPaquetes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModuloPaquetes.ForeColor = System.Drawing.Color.White;
            this.btnModuloPaquetes.Location = new System.Drawing.Point(10, 20);
            this.btnModuloPaquetes.Name = "btnModuloPaquetes";
            this.btnModuloPaquetes.Size = new System.Drawing.Size(160, 40);
            this.btnModuloPaquetes.TabIndex = 0;
            this.btnModuloPaquetes.Text = "Paquetes";
            this.btnModuloPaquetes.UseVisualStyleBackColor = false;
            this.btnModuloPaquetes.Click += new System.EventHandler(this.btnModuloPaquetes_Click);
            // 
            // btnModuloClientes
            // 
            this.btnModuloClientes.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModuloClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModuloClientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModuloClientes.ForeColor = System.Drawing.Color.White;
            this.btnModuloClientes.Location = new System.Drawing.Point(10, 70);
            this.btnModuloClientes.Name = "btnModuloClientes";
            this.btnModuloClientes.Size = new System.Drawing.Size(160, 40);
            this.btnModuloClientes.TabIndex = 1;
            this.btnModuloClientes.Text = "Clientes";
            this.btnModuloClientes.UseVisualStyleBackColor = false;
            this.btnModuloClientes.Click += new System.EventHandler(this.btnModuloClientes_Click);
            // 
            // btnModuloEmpleados
            // 
            this.btnModuloEmpleados.BackColor = System.Drawing.Color.IndianRed;
            this.btnModuloEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModuloEmpleados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModuloEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnModuloEmpleados.Location = new System.Drawing.Point(10, 120);
            this.btnModuloEmpleados.Name = "btnModuloEmpleados";
            this.btnModuloEmpleados.Size = new System.Drawing.Size(160, 40);
            this.btnModuloEmpleados.TabIndex = 2;
            this.btnModuloEmpleados.Text = "Empleados";
            this.btnModuloEmpleados.UseVisualStyleBackColor = false;
            this.btnModuloEmpleados.Click += new System.EventHandler(this.btnModuloEmpleados_Click);
            // 
            // btnModuloSeguimiento
            // 
            this.btnModuloSeguimiento.BackColor = System.Drawing.Color.Coral;
            this.btnModuloSeguimiento.Enabled = false;
            this.btnModuloSeguimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModuloSeguimiento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModuloSeguimiento.ForeColor = System.Drawing.Color.White;
            this.btnModuloSeguimiento.Location = new System.Drawing.Point(10, 170);
            this.btnModuloSeguimiento.Name = "btnModuloSeguimiento";
            this.btnModuloSeguimiento.Size = new System.Drawing.Size(160, 40);
            this.btnModuloSeguimiento.TabIndex = 3;
            this.btnModuloSeguimiento.Text = "Seguimiento";
            this.btnModuloSeguimiento.UseVisualStyleBackColor = false;
            this.btnModuloSeguimiento.Click += new System.EventHandler(this.btnModuloSeguimiento_Click);
            // 
            // btnModuloAsignaciones
            // 
            this.btnModuloAsignaciones.BackColor = System.Drawing.Color.Chocolate;
            this.btnModuloAsignaciones.Enabled = false;
            this.btnModuloAsignaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModuloAsignaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModuloAsignaciones.ForeColor = System.Drawing.Color.White;
            this.btnModuloAsignaciones.Location = new System.Drawing.Point(10, 220);
            this.btnModuloAsignaciones.Name = "btnModuloAsignaciones";
            this.btnModuloAsignaciones.Size = new System.Drawing.Size(160, 40);
            this.btnModuloAsignaciones.TabIndex = 4;
            this.btnModuloAsignaciones.Text = "Asignaciones";
            this.btnModuloAsignaciones.UseVisualStyleBackColor = false;
            this.btnModuloAsignaciones.Click += new System.EventHandler(this.btnModuloAsignaciones_Click);
            // 
            // dgvPaquetes
            // 
            this.dgvPaquetes.AllowUserToAddRows = false;
            this.dgvPaquetes.AllowUserToDeleteRows = false;
            this.dgvPaquetes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaquetes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPaquetes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaquetes.Location = new System.Drawing.Point(200, 60);
            this.dgvPaquetes.MultiSelect = false;
            this.dgvPaquetes.Name = "dgvPaquetes";
            this.dgvPaquetes.ReadOnly = true;
            this.dgvPaquetes.RowHeadersVisible = false;
            this.dgvPaquetes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaquetes.Size = new System.Drawing.Size(570, 320);
            this.dgvPaquetes.TabIndex = 2;
            this.dgvPaquetes.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(200, 400);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 40);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar Paquete";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(360, 400);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 40);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar Paquete";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(516, 400);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 40);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar Paquete";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pnlClientes
            // 
            this.pnlClientes.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlClientes.Controls.Add(this.button5);
            this.pnlClientes.Controls.Add(this.btnAgregarCliente);
            this.pnlClientes.Controls.Add(this.dtgvClientes);
            this.pnlClientes.Location = new System.Drawing.Point(180, 281);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(444, 184);
            this.pnlClientes.TabIndex = 6;
            this.pnlClientes.Visible = false;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregarCliente.Location = new System.Drawing.Point(522, 308);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(114, 41);
            this.btnAgregarCliente.TabIndex = 7;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // dtgvClientes
            // 
            this.dtgvClientes.AllowUserToAddRows = false;
            this.dtgvClientes.AllowUserToDeleteRows = false;
            this.dtgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvClientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClientes.Location = new System.Drawing.Point(25, 20);
            this.dtgvClientes.MultiSelect = false;
            this.dtgvClientes.Name = "dtgvClientes";
            this.dtgvClientes.ReadOnly = true;
            this.dtgvClientes.RowHeadersVisible = false;
            this.dtgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvClientes.Size = new System.Drawing.Size(611, 266);
            this.dtgvClientes.TabIndex = 6;
            this.dtgvClientes.SelectionChanged += new System.EventHandler(this.dtgvClientes_SelectionChanged);
            // 
            // pnlAsignaciones
            // 
            this.pnlAsignaciones.BackColor = System.Drawing.Color.Coral;
            this.pnlAsignaciones.Controls.Add(this.button2);
            this.pnlAsignaciones.Controls.Add(this.dtgvConductorAsignaciones);
            this.pnlAsignaciones.Controls.Add(this.label1);
            this.pnlAsignaciones.Controls.Add(this.btnActualizarPaqueteConductor);
            this.pnlAsignaciones.Location = new System.Drawing.Point(217, 39);
            this.pnlAsignaciones.Name = "pnlAsignaciones";
            this.pnlAsignaciones.Size = new System.Drawing.Size(688, 419);
            this.pnlAsignaciones.TabIndex = 8;
            this.pnlAsignaciones.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAsignaciones_Paint);
            // 
            // dtgvConductorAsignaciones
            // 
            this.dtgvConductorAsignaciones.AllowUserToAddRows = false;
            this.dtgvConductorAsignaciones.AllowUserToDeleteRows = false;
            this.dtgvConductorAsignaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvConductorAsignaciones.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvConductorAsignaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvConductorAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvConductorAsignaciones.Location = new System.Drawing.Point(13, 11);
            this.dtgvConductorAsignaciones.MultiSelect = false;
            this.dtgvConductorAsignaciones.Name = "dtgvConductorAsignaciones";
            this.dtgvConductorAsignaciones.ReadOnly = true;
            this.dtgvConductorAsignaciones.RowHeadersVisible = false;
            this.dtgvConductorAsignaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvConductorAsignaciones.Size = new System.Drawing.Size(570, 320);
            this.dtgvConductorAsignaciones.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label1.Location = new System.Drawing.Point(141, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 47);
            this.label1.TabIndex = 10;
            this.label1.Text = "En construcción";
            // 
            // btnActualizarPaqueteConductor
            // 
            this.btnActualizarPaqueteConductor.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnActualizarPaqueteConductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPaqueteConductor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizarPaqueteConductor.ForeColor = System.Drawing.Color.White;
            this.btnActualizarPaqueteConductor.Location = new System.Drawing.Point(253, 342);
            this.btnActualizarPaqueteConductor.Name = "btnActualizarPaqueteConductor";
            this.btnActualizarPaqueteConductor.Size = new System.Drawing.Size(150, 40);
            this.btnActualizarPaqueteConductor.TabIndex = 9;
            this.btnActualizarPaqueteConductor.Text = "Actualizar Paquete";
            this.btnActualizarPaqueteConductor.UseVisualStyleBackColor = false;
            this.btnActualizarPaqueteConductor.Click += new System.EventHandler(this.btnActualizarPaqueteConductor_Click);
            // 
            // pnlEmpleados
            // 
            this.pnlEmpleados.BackColor = System.Drawing.Color.IndianRed;
            this.pnlEmpleados.Controls.Add(this.button4);
            this.pnlEmpleados.Controls.Add(this.button3);
            this.pnlEmpleados.Controls.Add(this.dtgvEmpleados);
            this.pnlEmpleados.Location = new System.Drawing.Point(176, 380);
            this.pnlEmpleados.Name = "pnlEmpleados";
            this.pnlEmpleados.Size = new System.Drawing.Size(318, 85);
            this.pnlEmpleados.TabIndex = 9;
            // 
            // dtgvEmpleados
            // 
            this.dtgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmpleados.Location = new System.Drawing.Point(29, 27);
            this.dtgvEmpleados.Name = "dtgvEmpleados";
            this.dtgvEmpleados.Size = new System.Drawing.Size(637, 269);
            this.dtgvEmpleados.TabIndex = 0;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.BackColor = System.Drawing.Color.Purple;
            this.btnCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelarPedido.ForeColor = System.Drawing.Color.White;
            this.btnCancelarPedido.Location = new System.Drawing.Point(672, 400);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(150, 40);
            this.btnCancelarPedido.TabIndex = 10;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = false;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(518, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Reportes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(526, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 41);
            this.button3.TabIndex = 8;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(376, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 41);
            this.button4.TabIndex = 9;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(372, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 41);
            this.button5.TabIndex = 10;
            this.button5.Text = "Eliminar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // VistaPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(917, 470);
            this.Controls.Add(this.pnlEmpleados);
            this.Controls.Add(this.pnlAsignaciones);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dgvPaquetes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelarPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VistaPaquetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Paquetes";
            this.Load += new System.EventHandler(this.VistaPaquetes_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).EndInit();
            this.pnlClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).EndInit();
            this.pnlAsignaciones.ResumeLayout(false);
            this.pnlAsignaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConductorAsignaciones)).EndInit();
            this.pnlEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaquetes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnModuloPaquetes;
        private System.Windows.Forms.Button btnModuloClientes;
        private System.Windows.Forms.Button btnModuloEmpleados;
        private System.Windows.Forms.Button btnModuloSeguimiento;
        private System.Windows.Forms.Button btnModuloAsignaciones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.DataGridView dtgvClientes;
        private System.Windows.Forms.Panel pnlAsignaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizarPaqueteConductor;
        private System.Windows.Forms.DataGridView dtgvConductorAsignaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlEmpleados;
        private System.Windows.Forms.DataGridView dtgvEmpleados;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}