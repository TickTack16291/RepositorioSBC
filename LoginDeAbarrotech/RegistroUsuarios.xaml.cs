using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LoginDeAbarrotech
{
    /// <summary>
    /// Lógica de interacción para RegistroUsuarios.xaml
    /// </summary>
    public partial class RegistroUsuarios : Window
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
            Lbl_error.Visibility = Visibility.Collapsed;
        }

        private Usuario usuarioGenerico = new Usuario();
        private int guardar = 0; //0 = guardar, 1 = modificar

        private void mostrar_error(string mensaje)
        {
            Lbl_error.Content = mensaje;
            Lbl_error.Visibility = Visibility.Visible;
            var animacion = new System.Windows.Media.Animation.ThicknessAnimation();
            animacion.Duration = TimeSpan.FromMilliseconds(100);
            animacion.From = new Thickness(0);
            animacion.To = new Thickness(5);
            animacion.AutoReverse = true;
            animacion.RepeatBehavior = new System.Windows.Media.Animation.RepeatBehavior(2);
            Lbl_error.BeginAnimation(MarginProperty, animacion);
        }
        private bool campos_vacios()
        {
            if (string.IsNullOrWhiteSpace(ct_Usuario.Text) ||
                string.IsNullOrWhiteSpace(ct_Contrasena.Password) ||
                string.IsNullOrWhiteSpace(ct_Nombre.Text) ||
                string.IsNullOrWhiteSpace(ct_ApellidoPaterno.Text) ||
                string.IsNullOrWhiteSpace(ct_ApellidoMaterno.Text) ||
                string.IsNullOrWhiteSpace(ct_PreparatoriaOrigen.Text))
            {
                return true;
            }
            return false;
        }
        private void btn_Guardar_Click(object sender, RoutedEventArgs e)
        {
            if (campos_vacios()) {
                mostrar_error("No puede haber campos vacios");
                return;
                
            }
            ConexionBD conexion = new ConexionBD();
            string usuario;
            string nombre;
            string contrasena;
            string apellido_paterno;
            string apellido_materno;
            string preparatoria;

            usuario = ct_Usuario.Text;
            nombre = ct_Nombre.Text;
            contrasena = ct_Contrasena.Password;
            apellido_paterno = ct_ApellidoPaterno.Text;
            apellido_materno = ct_ApellidoMaterno.Text;
            preparatoria = ct_PreparatoriaOrigen.Text;
           
                usuarioGenerico.usuario = usuario;
                usuarioGenerico.nombre = nombre;
                usuarioGenerico.contrasena = contrasena;
                usuarioGenerico.apellido_paterno = apellido_paterno;
                usuarioGenerico.apellido_materno = apellido_materno;
                usuarioGenerico.preparatoria_origen = preparatoria;
            if (guardar == 0)
            {
                bool repetido = conexion.validar_usuarios_repetidos(usuarioGenerico.usuario);
                if (repetido)
                {
                    mostrar_error("El usuario ya existe, intente con otro");
                    ct_Usuario.Clear();
                    ct_Usuario.Focus();
                    return;
                }
                else
                {
                    bool aux = conexion.ingresar_usuarios(usuarioGenerico);
                    if (aux)
                    {
                        MessageBox.Show("Usuario registrado con exito");
                        this.DialogResult = true;
                        this.Close();



                    }
                    else
                    {
                        mostrar_error("Error al registrar el usuario, intente de nuevo");
                    }


                }
            }
            else {

                var aux = conexion.modificar_usuarios(usuarioGenerico);
                if (aux)
                {
                    this.DialogResult = true; this.Close();
                }
                else
                { mostrar_error("Error al modificar el usuario, intente de nuevo");
                }
            
            }

        }

        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }

        private void btn_Modificar_Click(object sender, RoutedEventArgs e)
        {

            Usuario usuario_modificar;
            var buscarUsuarioWindow = new BuscarUsuario();
            buscarUsuarioWindow.ShowDialog();
            if (buscarUsuarioWindow.DialogResult == true)
            {
                usuario_modificar = buscarUsuarioWindow.auxiliar;
                ct_Usuario.Text = usuario_modificar.usuario;
                ct_Nombre.Text = usuario_modificar.nombre;
                ct_Contrasena.Password = usuario_modificar.contrasena;
                ct_ApellidoPaterno.Text = usuario_modificar.apellido_paterno;
                ct_ApellidoMaterno.Text = usuario_modificar.apellido_materno;
                ct_PreparatoriaOrigen.Text = usuario_modificar.preparatoria_origen;
                ct_Usuario.IsEnabled = false;
                btn_Modificar.IsEnabled = false;
                guardar = 1; //cambiar a modo modificar
            }
            else
            {
               mostrar_error("No se ha seleccionado ningun usuario");
                //modo guardar permanece

            }


        }

        private void ct_Usuario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ct_PreparatoriaOrigen_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult = true;
        }
    }
}
