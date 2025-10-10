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
        }

        private Usuario usuarioGenerico = new Usuario();
        

        private void btn_Guardar_Click(object sender, RoutedEventArgs e)
        {

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
            usuarioGenerico.apellido_materno= apellido_materno;
            usuarioGenerico.preparatoria_origen = preparatoria;

            ConexionBD conexion = new ConexionBD();
            bool aux = conexion.ingresar_usuarios(usuarioGenerico);
            if (aux)
            {
                MessageBox.Show("Usuario registrado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario");
            }


        }

        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Modificar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
