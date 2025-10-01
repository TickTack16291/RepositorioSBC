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
    /// Lógica de interacción para RegistroProductos.xaml
    /// </summary>
    public partial class RegistroProductos : Window
    {
        public RegistroProductos()
        {
            InitializeComponent();
        }
        private void btn_Guardar_Click(object sender, RoutedEventArgs e)
        {
            // Verificamos que ningún campo esté vacío
            if (string.IsNullOrWhiteSpace(ct_Nombre.Text) ||
                string.IsNullOrWhiteSpace(ct_Marca.Text) ||
                string.IsNullOrWhiteSpace(ct_Categoria.Text) ||
                string.IsNullOrWhiteSpace(ct_Presentación.Text) ||
                string.IsNullOrWhiteSpace(ct_UnidadMedida.Text) ||
                string.IsNullOrWhiteSpace(ct_PrecioCompra.Text) ||
                string.IsNullOrWhiteSpace(ct_PrecioVenta.Text))
            {
                MessageBox.Show("No puedes dejar campos vacíos.");
                return;
            }

            // Validar que los precios sean números
            if (!float.TryParse(ct_PrecioVenta.Text, out float precioVenta))// Intenta convertir el texto a flotante, si funciona el valor se guarda en la variable
            {
                MessageBox.Show("El precio de venta debe ser un número válido.");
                return;
            }
            if (!float.TryParse(ct_PrecioCompra.Text, out float precioCompra))// Lo mismo que el de arriba
            {
                MessageBox.Show("El precio de compra debe ser un número válido.");
                return;
            }

            // Crear el objeto Producto con los datos del formulario
            Producto producto = new Producto(0,
                ct_Nombre.Text,
                ct_Marca.Text,
                ct_Presentación.Text,
                ct_UnidadMedida.Text,
                precioVenta,// La variable que se deberia haber guardado
                precioCompra,//x2
                1, // estado
                ct_Categoria.Text,
                0
            );

            ConexionBD conexion = new ConexionBD();

            if (conexion.AgregarProducto(producto))
            {
                MessageBox.Show("Producto guardado correctamente.");

                MenuOperaciones menuoperaciones = new MenuOperaciones();
                menuoperaciones.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al guardar el producto.");
            }
        }

        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MenuOperaciones menuOperaciones = new MenuOperaciones();
            menuOperaciones.Show();
        }
    }
}
