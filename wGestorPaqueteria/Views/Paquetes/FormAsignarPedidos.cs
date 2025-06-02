using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wGestorPaqueteria.Views.Paquetes
{
    public partial class FormAsignarPedidos : Form
    {
        public FormAsignarPedidos()
        {
            InitializeComponent();
        }

        private void FormAsignarPedidos_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new VistaPaquetes().Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
