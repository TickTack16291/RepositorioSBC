using System.Windows;
using System.Text;

namespace LoginDeAbarrotech
{
    public partial class VisualizacionUsuariosWindow : Window
    {
        public VisualizacionUsuariosWindow(Usuario usuario)
        {
            InitializeComponent();
            
            // Asegurar que la ventana use codificación UTF-8
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            
            CargarInformacionUsuario(usuario);
        }

        private void CargarInformacionUsuario(Usuario usuario)
        {
            // Usar ?? con valores por defecto que soporten acentos
            lblUsuario.Text = usuario.usuario ?? "No disponible";
            lblNombre.Text = usuario.nombre ?? "No disponible";
            lblApellidoPaterno.Text = usuario.apellido_paterno ?? "No disponible";
            lblApellidoMaterno.Text = usuario.apellido_materno ?? "No disponible";
            lblPreparatoriaOrigen.Text = usuario.preparatoria_origen ?? "No disponible";
            lblDiagnosticoArea.Text = usuario.diagnostico_area ?? "Aún no realizado";
            lblDiagnosticoCarrera.Text = usuario.diagnostico_carrera ?? "Aún no realizado";
            lblComentarios.Text = string.IsNullOrWhiteSpace(usuario.comentarios) 
                ? "Sin comentarios del experto" 
                : usuario.comentarios;
            
            // Forzar la actualización de la interfaz
            this.UpdateLayout();
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}