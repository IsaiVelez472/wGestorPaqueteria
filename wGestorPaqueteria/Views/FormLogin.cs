using System;
using System.Windows.Forms;
using wGestorPaqueteria.Services;
using wGestorPaqueteria.Utils;
using wGestorPaqueteria.Views;

namespace wGestorPaqueteria
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string usuarioValue = txtUsuario.Text.Trim();
            string claveValue = txtClave.Text.Trim();

            if (usuarioValue == "" || claveValue == "")
            {
                MessageBox.Show("Por favor ingrese usuario y clave.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var auth = new AuthService();
                var usuario = auth.Login(usuarioValue, claveValue);

                if (usuario != null)
                {
                    SesionUsuario.Actual = usuario;
                    this.Hide();
                    new VistaPaquetes().Show();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
