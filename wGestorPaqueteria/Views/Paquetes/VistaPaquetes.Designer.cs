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
            this.dtgvClientes = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            this.pnlClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelHeader.Controls.Add(this.lblUsuario);
            this.panelHeader.Controls.Add(this.lblRol);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(180, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(620, 50);
            this.panelHeader.TabIndex = 0;
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
            this.panelMenu.Controls.Add(this.btnModuloPaquetes);
            this.panelMenu.Controls.Add(this.btnModuloClientes);
            this.panelMenu.Controls.Add(this.btnModuloEmpleados);
            this.panelMenu.Controls.Add(this.btnModuloSeguimiento);
            this.panelMenu.Controls.Add(this.btnModuloAsignaciones);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 470);
            this.panelMenu.TabIndex = 1;
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
            this.btnModuloEmpleados.BackColor = System.Drawing.Color.Gray;
            this.btnModuloEmpleados.Enabled = false;
            this.btnModuloEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModuloEmpleados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModuloEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnModuloEmpleados.Location = new System.Drawing.Point(10, 120);
            this.btnModuloEmpleados.Name = "btnModuloEmpleados";
            this.btnModuloEmpleados.Size = new System.Drawing.Size(160, 40);
            this.btnModuloEmpleados.TabIndex = 2;
            this.btnModuloEmpleados.Text = "Empleados";
            this.btnModuloEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnModuloSeguimiento
            // 
            this.btnModuloSeguimiento.BackColor = System.Drawing.Color.Gray;
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
            // 
            // btnModuloAsignaciones
            // 
            this.btnModuloAsignaciones.BackColor = System.Drawing.Color.Gray;
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
            this.btnActualizar.Location = new System.Drawing.Point(517, 400);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 40);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar Paquete";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pnlClientes
            // 
            this.pnlClientes.Controls.Add(this.dtgvClientes);
            this.pnlClientes.Location = new System.Drawing.Point(180, 50);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(620, 420);
            this.pnlClientes.TabIndex = 6;
            this.pnlClientes.Visible = false;
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
            this.dtgvClientes.Size = new System.Drawing.Size(570, 320);
            this.dtgvClientes.TabIndex = 6;
            this.dtgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvClientes_CellContentClick);
            this.dtgvClientes.SelectionChanged += new System.EventHandler(this.dtgvClientes_SelectionChanged);
            // 
            // VistaPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dgvPaquetes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
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
    }
}