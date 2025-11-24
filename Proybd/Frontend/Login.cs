using Proybd.Backend;
using Proybd.Frontend;
using Proybd.pojo;

namespace Proybd
{
    public partial class Login : Form
    {
        public static string Usuario ="";
        public static int idg = 0;
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
            Usuario = txtUsuario.Text.Trim();
            idg = usuario.Id_Usuario;

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
                    frmInicio inicio = new frmInicio();
                    ClsSesion.UsuarioActual = usuario;
                    ClsSesion.id = usuario.Id_Usuario;
                    this.Hide();
                    inicio.ShowDialog();
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
