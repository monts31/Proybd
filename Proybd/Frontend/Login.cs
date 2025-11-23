using Proybd.Backend;
using Proybd.Frontend;
using Proybd.pojo;

namespace Proybd
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            clsUsuarios usuario = new clsUsuarios();
            usuario.Usuario = txtUsuario.Text.Trim();
            usuario.Contraseña = txtPassword.Text.Trim();

            // Validaciones
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                clsConsultaUsuarios cons = new clsConsultaUsuarios();

                bool revisar = cons.IniciarSesion(usuario);

                if (revisar == true)
                {
                    MessageBox.Show("Usuario encontrado", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMenu menu = new frmMenu(usuario);
                    this.Hide();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos." + revisar, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar iniciar sesión:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
