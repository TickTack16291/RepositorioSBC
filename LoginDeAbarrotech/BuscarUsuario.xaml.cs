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
    /// Lógica de interacción para BuscarUsuario.xaml
    /// </summary>
    public partial class BuscarUsuario : Window
    {
        public string UsuarioIngresado { get; private set; }
        public string ContrasenaIngresada { get; private set; }
        public Usuario auxiliar;
        public bool recibido;

        public BuscarUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            recibido = false;
            UsuarioIngresado = txtUsuario.Text.Trim();
            ContrasenaIngresada = txtContrasena.Password;
            ConexionBD conexion = new ConexionBD();
            (recibido, auxiliar) = conexion.obtener_datos_usuario(UsuarioIngresado, ContrasenaIngresada);
            if (!recibido)
            {
                MessageBox.Show("Usuario o contraseña incorrectos, intente de nuevo");

            }
            else
            {
                DialogResult = recibido;
                Close();

            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

       
        
    }
}
