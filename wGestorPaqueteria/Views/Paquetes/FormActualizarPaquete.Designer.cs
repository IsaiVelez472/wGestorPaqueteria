namespace wGestorPaqueteria.Views.Paquetes
{
    partial class FormActualizarPaquete
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
            this.lblNumeroSeguimiento = new System.Windows.Forms.Label();
            this.txtNumeroSeguimiento = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblDimensiones = new System.Windows.Forms.Label();
            this.txtDimensiones = new System.Windows.Forms.TextBox();
            this.lblValorDeclarado = new System.Windows.Forms.Label();
            this.txtValorDeclarado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblRemitente = new System.Windows.Forms.Label();
            this.cmbRemitente = new System.Windows.Forms.ComboBox();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.cmbDestinatario = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroSeguimiento
            // 
            this.lblNumeroSeguimiento.AutoSize = true;
            this.lblNumeroSeguimiento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumeroSeguimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblNumeroSeguimiento.Location = new System.Drawing.Point(34, 51);
            this.lblNumeroSeguimiento.Name = "lblNumeroSeguimiento";
            this.lblNumeroSeguimiento.Size = new System.Drawing.Size(177, 19);
            this.lblNumeroSeguimiento.TabIndex = 16;
            this.lblNumeroSeguimiento.Text = "Número de Seguimiento:";
            // 
            // txtNumeroSeguimiento
            // 
            this.txtNumeroSeguimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroSeguimiento.Location = new System.Drawing.Point(217, 51);
            this.txtNumeroSeguimiento.Name = "txtNumeroSeguimiento";
            this.txtNumeroSeguimiento.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroSeguimiento.TabIndex = 17;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblPeso.Location = new System.Drawing.Point(34, 91);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(76, 19);
            this.lblPeso.TabIndex = 18;
            this.lblPeso.Text = "Peso (kg):";
            // 
            // txtPeso
            // 
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeso.Location = new System.Drawing.Point(217, 91);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(200, 20);
            this.txtPeso.TabIndex = 19;
            // 
            // lblDimensiones
            // 
            this.lblDimensiones.AutoSize = true;
            this.lblDimensiones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDimensiones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblDimensiones.Location = new System.Drawing.Point(34, 131);
            this.lblDimensiones.Name = "lblDimensiones";
            this.lblDimensiones.Size = new System.Drawing.Size(97, 19);
            this.lblDimensiones.TabIndex = 20;
            this.lblDimensiones.Text = "Dimensiones:";
            // 
            // txtDimensiones
            // 
            this.txtDimensiones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDimensiones.Location = new System.Drawing.Point(217, 131);
            this.txtDimensiones.Name = "txtDimensiones";
            this.txtDimensiones.Size = new System.Drawing.Size(200, 20);
            this.txtDimensiones.TabIndex = 21;
            // 
            // lblValorDeclarado
            // 
            this.lblValorDeclarado.AutoSize = true;
            this.lblValorDeclarado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblValorDeclarado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblValorDeclarado.Location = new System.Drawing.Point(34, 171);
            this.lblValorDeclarado.Name = "lblValorDeclarado";
            this.lblValorDeclarado.Size = new System.Drawing.Size(143, 19);
            this.lblValorDeclarado.TabIndex = 22;
            this.lblValorDeclarado.Text = "Valor Declarado ($):";
            // 
            // txtValorDeclarado
            // 
            this.txtValorDeclarado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorDeclarado.Location = new System.Drawing.Point(217, 171);
            this.txtValorDeclarado.Name = "txtValorDeclarado";
            this.txtValorDeclarado.Size = new System.Drawing.Size(200, 20);
            this.txtValorDeclarado.TabIndex = 23;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblEstado.Location = new System.Drawing.Point(34, 211);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(57, 19);
            this.lblEstado.TabIndex = 24;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstado.Location = new System.Drawing.Point(217, 211);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 21);
            this.cmbEstado.TabIndex = 25;
            // 
            // lblRemitente
            // 
            this.lblRemitente.AutoSize = true;
            this.lblRemitente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemitente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblRemitente.Location = new System.Drawing.Point(34, 251);
            this.lblRemitente.Name = "lblRemitente";
            this.lblRemitente.Size = new System.Drawing.Size(81, 19);
            this.lblRemitente.TabIndex = 26;
            this.lblRemitente.Text = "Remitente:";
            // 
            // cmbRemitente
            // 
            this.cmbRemitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRemitente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRemitente.Location = new System.Drawing.Point(217, 251);
            this.cmbRemitente.Name = "cmbRemitente";
            this.cmbRemitente.Size = new System.Drawing.Size(200, 21);
            this.cmbRemitente.TabIndex = 27;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDestinatario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblDestinatario.Location = new System.Drawing.Point(34, 291);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(94, 19);
            this.lblDestinatario.TabIndex = 28;
            this.lblDestinatario.Text = "Destinatario:";
            // 
            // cmbDestinatario
            // 
            this.cmbDestinatario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinatario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDestinatario.Location = new System.Drawing.Point(217, 291);
            this.cmbDestinatario.Name = "cmbDestinatario";
            this.cmbDestinatario.Size = new System.Drawing.Size(200, 21);
            this.cmbDestinatario.TabIndex = 29;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(217, 334);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 35);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(327, 334);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 35);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormActualizarPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(451, 420);
            this.Controls.Add(this.lblNumeroSeguimiento);
            this.Controls.Add(this.txtNumeroSeguimiento);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblDimensiones);
            this.Controls.Add(this.txtDimensiones);
            this.Controls.Add(this.lblValorDeclarado);
            this.Controls.Add(this.txtValorDeclarado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblRemitente);
            this.Controls.Add(this.cmbRemitente);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.cmbDestinatario);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "FormActualizarPaquete";
            this.Text = "Actualizar Paquete";
            this.Load += new System.EventHandler(this.FormActualizarPaquete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroSeguimiento;
        private System.Windows.Forms.TextBox txtNumeroSeguimiento;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblDimensiones;
        private System.Windows.Forms.TextBox txtDimensiones;
        private System.Windows.Forms.Label lblValorDeclarado;
        private System.Windows.Forms.TextBox txtValorDeclarado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblRemitente;
        private System.Windows.Forms.ComboBox cmbRemitente;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.ComboBox cmbDestinatario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}