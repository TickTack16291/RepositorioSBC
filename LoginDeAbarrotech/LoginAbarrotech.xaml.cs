using System;
using System.Windows;

namespace LoginDeAbarrotech
{
    /// <summary>
    /// Lógica de interacción para LoginAbarrotech.xaml
    /// </summary>
    public partial class LoginAbarrotech : Window
    {
        public LoginAbarrotech()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Lbl_error.Visibility = Visibility.Hidden;

            string usuarioAux = txtUsuario.Text;
            string contrasenaAux = txtPassword.Password;

            if (usuarioAux == "" || contrasenaAux == "")// Campos vacios
            {
                Lbl_error.Content = "No puede haber campos vacios";
                Lbl_error.Visibility = Visibility.Visible;
                txtUsuario.Focus();
                var animacion = new System.Windows.Media.Animation.ThicknessAnimation();
                animacion.Duration = TimeSpan.FromMilliseconds(100);
                animacion.From = new Thickness(0);
                animacion.To = new Thickness(5);
                animacion.AutoReverse = true;
                animacion.RepeatBehavior = new System.Windows.Media.Animation.RepeatBehavior(2);
                Lbl_error.BeginAnimation(MarginProperty, animacion);
            }
            else
            {
                ConexionBD conexion = new ConexionBD();

                bool aux = conexion.validar_inicio_sesion(usuarioAux, contrasenaAux);
                if (aux)
                {
                    Usuario usuario = new Usuario();
                    usuario.usuario = usuarioAux;
                    usuario.contrasena = contrasenaAux;
                    // Aqui debe abrir un el menu de operciones
                    PreguntasArea ventanaPreguntas = new PreguntasArea(usuario);
                    this.Close();
                    ventanaPreguntas.Show();
                }
                else
                {
                    Lbl_error.Content = "Usuario o contraseña incorrectos";
                    Lbl_error.Visibility = Visibility.Visible;
                    txtUsuario.Focus();
                    var animacion = new System.Windows.Media.Animation.ThicknessAnimation();
                    animacion.Duration = TimeSpan.FromMilliseconds(100);
                    animacion.From = new Thickness(0);
                    animacion.To = new Thickness(5);
                    animacion.AutoReverse = true;
                    animacion.RepeatBehavior = new System.Windows.Media.Animation.RepeatBehavior(2);
                    Lbl_error.BeginAnimation(MarginProperty, animacion);
                }
            }
        }

        private void btn_Cerrar_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void btnRegistrarUsuario_Click(object sender, RoutedEventArgs e)
        {

            RegistroUsuarios registroUsuarios = new RegistroUsuarios();
            this.Hide();
            registroUsuarios.ShowDialog();
            if(registroUsuarios.DialogResult == true)
            {
                this.Show();
            }
        }
    }
}
