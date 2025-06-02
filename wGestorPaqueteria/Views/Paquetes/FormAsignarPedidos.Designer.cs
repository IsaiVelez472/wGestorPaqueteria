namespace wGestorPaqueteria.Views.Paquetes
{
    partial class FormAsignarPedidos
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbConductor = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroSeguimiento
            // 
            this.lblNumeroSeguimiento.AutoSize = true;
            this.lblNumeroSeguimiento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumeroSeguimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblNumeroSeguimiento.Location = new System.Drawing.Point(13, 66);
            this.lblNumeroSeguimiento.Name = "lblNumeroSeguimiento";
            this.lblNumeroSeguimiento.Size = new System.Drawing.Size(148, 19);
            this.lblNumeroSeguimiento.TabIndex = 16;
            this.lblNumeroSeguimiento.Text = "Número de Paquete:";
            // 
            // txtNumeroSeguimiento
            // 
            this.txtNumeroSeguimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroSeguimiento.Location = new System.Drawing.Point(196, 66);
            this.txtNumeroSeguimiento.Name = "txtNumeroSeguimiento";
            this.txtNumeroSeguimiento.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroSeguimiento.TabIndex = 17;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblEstado.Location = new System.Drawing.Point(14, 137);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(84, 19);
            this.lblEstado.TabIndex = 24;
            this.lblEstado.Text = "Conductor:";
            // 
            // cmbConductor
            // 
            this.cmbConductor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbConductor.Location = new System.Drawing.Point(197, 137);
            this.cmbConductor.Name = "cmbConductor";
            this.cmbConductor.Size = new System.Drawing.Size(200, 21);
            this.cmbConductor.TabIndex = 25;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(196, 236);
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
            this.btnCancelar.Location = new System.Drawing.Point(306, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 35);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormAsignarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.lblNumeroSeguimiento);
            this.Controls.Add(this.txtNumeroSeguimiento);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbConductor);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "FormAsignarPedidos";
            this.Text = "FormAsignarPedidos";
            this.Load += new System.EventHandler(this.FormAsignarPedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroSeguimiento;
        private System.Windows.Forms.TextBox txtNumeroSeguimiento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbConductor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}