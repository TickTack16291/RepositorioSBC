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
    public partial class SeleccionAreaWindow : Window
    {
        public event EventHandler<string> AreaSeleccionada;

        public SeleccionAreaWindow(List<string> areas)
        {
            InitializeComponent();
            ListaAreas.ItemsSource = areas;
            if (areas.Count > 0)
                ListaAreas.SelectedIndex = 0;
        }

        private void BtnContinuar_Click(object sender, RoutedEventArgs e)
        {
            if (ListaAreas.SelectedItem != null)
            {
                string areaSeleccionada = ListaAreas.SelectedItem.ToString();
                AreaSeleccionada?.Invoke(this, areaSeleccionada);
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor selecciona un área para continuar.");
            }
        }
    }
}