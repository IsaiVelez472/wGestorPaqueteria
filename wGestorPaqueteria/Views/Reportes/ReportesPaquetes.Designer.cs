namespace wGestorPaqueteria.Views.Reportes
{
    partial class ReportesPaquetes
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
            this.dtgvReportes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvReportes
            // 
            this.dtgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReportes.Location = new System.Drawing.Point(52, 85);
            this.dtgvReportes.Name = "dtgvReportes";
            this.dtgvReportes.Size = new System.Drawing.Size(627, 303);
            this.dtgvReportes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(62, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reportes de envíos";
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.BackColor = System.Drawing.Color.PaleGreen;
            this.btnVolverInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnVolverInicio.Location = new System.Drawing.Point(653, 394);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(115, 34);
            this.btnVolverInicio.TabIndex = 2;
            this.btnVolverInicio.Text = "Volver";
            this.btnVolverInicio.UseVisualStyleBackColor = false;
            this.btnVolverInicio.Click += new System.EventHandler(this.btnVolverInicio_Click);
            // 
            // ReportesPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvReportes);
            this.Name = "ReportesPaquetes";
            this.Text = "ReportesPaquetes";
            this.Load += new System.EventHandler(this.ReportesPaquetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvReportes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolverInicio;
    }
}