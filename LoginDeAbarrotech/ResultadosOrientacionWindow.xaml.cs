using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LoginDeAbarrotech
{
    /// <summary>
    /// Lógica de interacción para ResultadosOrientacionWindow.xaml
    /// </summary>
    public partial class ResultadosOrientacionWindow : Window
    {
        public ResultadosOrientacionWindow(Dictionary<string, string> resultados)
        {
            InitializeComponent();
            MostrarResultados(resultados);
        }

        private void MostrarResultados(Dictionary<string, string> resultados)
        {
            foreach (var kvp in resultados)
            {
                var labelTitulo = new TextBlock
                {
                    Text = kvp.Key + ":",
                    FontWeight = FontWeights.Bold,
                    Foreground = new SolidColorBrush(Color.FromRgb(33, 150, 243)),
                    FontSize = 15,
                    Margin = new Thickness(0, 8, 0, 0)
                };

                var labelValor = new TextBlock
                {
                    Text = kvp.Value,
                    FontSize = 15,
                    Foreground = new SolidColorBrush(Color.FromRgb(66, 66, 66)),
                    Margin = new Thickness(0, 0, 0, 8)
                };

                ResultadosPanel.Children.Add(labelTitulo);
                ResultadosPanel.Children.Add(labelValor);
            }
        }

        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
