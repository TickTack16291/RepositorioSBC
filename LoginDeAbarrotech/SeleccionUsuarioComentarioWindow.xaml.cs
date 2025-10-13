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
    /// Lógica de interacción para SeleccionUsuarioComentarioWindow.xaml
    /// </summary>
    public partial class SeleccionUsuarioComentarioWindow : Window
    {
        private List<Usuario> usuarios;
        private Usuario usuarioSeleccionado;

        public SeleccionUsuarioComentarioWindow(List<Usuario> listaUsuarios)
        {
            InitializeComponent();
            usuarios = listaUsuarios.Select(u => new Usuario
            {
                id_usuario = u.id_usuario,
                nombre = u.nombre,
                apellido_paterno = u.apellido_paterno,
                apellido_materno = u.apellido_materno,
                preparatoria_origen = u.preparatoria_origen,
                diagnostico_area = u.diagnostico_area,
                diagnostico_carrera = u.diagnostico_carrera,
                comentarios = u.comentarios,
                usuario = u.usuario,
                contrasena = u.contrasena
            }).ToList();

            var usuariosVisual = usuarios.Select(u => new
            {
                u.id_usuario,
                u.nombre,
                u.apellido_paterno,
                u.apellido_materno,
                u.preparatoria_origen,
                u.diagnostico_area,
                u.diagnostico_carrera,
                comentarioAsignado = string.IsNullOrWhiteSpace(u.comentarios) ? "No" : "Sí"
            }).ToList();

            dgUsuarios.ItemsSource = usuariosVisual;
        }

        private void dgUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = dgUsuarios.SelectedItem;
            if (selectedItem == null)
            {
                LimpiarCampos();
                usuarioSeleccionado = null;
                return;
            }

            var idProp = selectedItem.GetType().GetProperty("id_usuario");
            int idUsuario = (int)idProp.GetValue(selectedItem);
            usuarioSeleccionado = usuarios.FirstOrDefault(u => u.id_usuario == idUsuario);

            if (usuarioSeleccionado != null)
            {
                txtNombre.Text = usuarioSeleccionado.nombre;
                txtApellidoPaterno.Text = usuarioSeleccionado.apellido_paterno;
                txtApellidoMaterno.Text = usuarioSeleccionado.apellido_materno;
                txtPreparatoriaOrigen.Text = usuarioSeleccionado.preparatoria_origen;
                txtComentario.Text = usuarioSeleccionado.comentarios ?? "";
                Lbl_error.Visibility = Visibility.Collapsed;
            }
        }

        private void btnGuardarComentario_Click(object sender, RoutedEventArgs e)
        {
            if (usuarioSeleccionado == null)
            {
                Lbl_error.Content = "Selecciona un usuario de la tabla.";
                Lbl_error.Foreground = Brushes.Red;
                Lbl_error.Visibility = Visibility.Visible;
                return;
            }

            string nuevoComentario = txtComentario.Text.Trim();
            ConexionBD conexion = new ConexionBD();
            bool exito = conexion.agregar_comentario_usuario(usuarioSeleccionado.id_usuario, nuevoComentario);

            if (exito)
            {
                usuarioSeleccionado.comentarios = nuevoComentario;
                // Actualizar la tabla visual
                var usuariosVisual = usuarios.Select(u => new
                {
                    u.id_usuario,
                    u.nombre,
                    u.apellido_paterno,
                    u.apellido_materno,
                    u.preparatoria_origen,
                    u.diagnostico_area,
                    u.diagnostico_carrera,
                    comentarioAsignado = string.IsNullOrWhiteSpace(u.comentarios) ? "No" : "Sí"
                }).ToList();
                dgUsuarios.ItemsSource = usuariosVisual;

                Lbl_error.Content = "Comentario guardado correctamente en la base de datos.";
                Lbl_error.Foreground = Brushes.Green;
                Lbl_error.Visibility = Visibility.Visible;
            }
            else
            {
                Lbl_error.Content = "Error al guardar el comentario en la base de datos.";
                Lbl_error.Foreground = Brushes.Red;
                Lbl_error.Visibility = Visibility.Visible;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtPreparatoriaOrigen.Text = "";
            txtComentario.Text = "";
            Lbl_error.Visibility = Visibility.Collapsed;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
