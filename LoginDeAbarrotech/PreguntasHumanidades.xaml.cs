using Reglas;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginDeAbarrotech
{
    /// <summary>
    /// Lógica de interacción para PreguntasHumanidades.xaml
    /// </summary>
    public partial class PreguntasHumanidades : Page
    {
        public PreguntasHumanidades(ServicioOrientacionVocacional servicio)
        {
            InitializeComponent();
            InitializeQuestions();
            _servicio = servicio;
        }
        private ServicioOrientacionVocacional _servicio;

        private List<ComboBox> answerComboBoxes = new List<ComboBox>();
        private const int totalQuestions = 5;

        public string[] respuestas = new string[5];

        // Preguntas y opciones de ejemplo
        private string[] questions = {
        "Pregunta 1: ¿Qué área de estudio te interesa más?",
        "Pregunta 2: ¿Qué tipo de trabajo te gustaría realizar?",
        "Pregunta 3: ¿Qué habilidades posees o quieres desarrollar?",
        "Pregunta 4: ¿En qué entorno te ves trabajando?",
        "Pregunta 5: ¿Qué te motiva más?"
        };

        private string[][] options = {
    new string[] { "Seleccione...", "a) Culturas y sociedades humanas", "b) Diseño de espacios y edificios", "c) Enseñanza de idiomas", "d) Eventos pasados y su impacto", "e) Tecnología aplicada a la educación" },
    new string[] { "Seleccione...", "a) Investigación de campo con comunidades", "b) Diseñar planos y proyectos arquitectónicos", "c) Enseñar inglés a estudiantes", "d) Investigar documentos históricos", "e) Desarrollar materiales educativos digitales" },
    new string[] { "Seleccione...", "a) Observación y análisis cultural", "b) Diseño creativo y técnico", "c) Habilidad para enseñar y comunicar en inglés", "d) Análisis crítico de fuentes históricas", "e) Habilidad en tecnología y pedagogía" },
    new string[] { "Seleccione...", "a) Comunidades rurales o urbanas", "b) Oficina de arquitectura o obra", "c) Aula de clases o instituto de idiomas", "d) Archivos históricos o museos", "e) Instituciones educativas con tecnología" },
    new string[] { "Seleccione...", "a) Entender la diversidad cultural", "b) Crear espacios funcionales y bellos", "c) Ayudar a otros a aprender un idioma", "d) Preservar y explicar el pasado", "e) Innovar en métodos educativos" }
    };

        private void InitializeQuestions()
        {
            for (int i = 0; i < totalQuestions; i++)
            {
                // Crear borde para cada pregunta
                Border questionBorder = new Border
                {
                    BorderBrush = new SolidColorBrush(Color.FromRgb(189, 195, 199)),
                    BorderThickness = new Thickness(1),
                    Background = new SolidColorBrush(Color.FromRgb(69, 213, 167)),
                    CornerRadius = new CornerRadius(4),
                    Margin = new Thickness(0, 6, 0, 6),
                    Padding = new Thickness(15)
                };

                // Panel principal para cada pregunta
                StackPanel questionPanel = new StackPanel();

                // Texto de la pregunta
                TextBlock questionText = new TextBlock
                {
                    Text = questions[i],
                    FontSize = 13,
                    FontWeight = FontWeights.SemiBold,
                    TextWrapping = TextWrapping.Wrap,
                    Margin = new Thickness(0, 0, 0, 10),
                    Foreground = new SolidColorBrush(Color.FromRgb(44, 62, 80))
                };

                // ComboBox para las opciones
                ComboBox comboBox = new ComboBox
                {
                    FontSize = 12,
                    Width = 300,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Height = 30,
                    Background = Brushes.White
                };

                // Agregar opciones al ComboBox
                foreach (string option in options[i])
                {
                    comboBox.Items.Add(option);
                }

                // Seleccionar primera opción por defecto
                if (comboBox.Items.Count > 0)
                    comboBox.SelectedIndex = 0;

                answerComboBoxes.Add(comboBox);

                // Agregar controles al panel
                questionPanel.Children.Add(questionText);
                questionPanel.Children.Add(comboBox);

                // Agregar panel al borde
                questionBorder.Child = questionPanel;

                // Agregar borde al panel principal
                QuestionsPanel.Children.Add(questionBorder);
            }
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            // Validar que todas las preguntas estén respondidas
            bool allAnswered = true;
            List<string> unansweredQuestions = new List<string>();

            for (int i = 0; i < answerComboBoxes.Count; i++)
            {
                if (answerComboBoxes[i].SelectedIndex == 0) // "Seleccione..." es el primer item
                {
                    allAnswered = false;
                    unansweredQuestions.Add($"Pregunta {i + 1}");
                }
            }

            if (!allAnswered)
            {
                MessageBox.Show($"Por favor responde las siguientes preguntas:\n{string.Join(", ", unansweredQuestions)}",
                              "Preguntas pendientes", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Recopilar respuestas
            List<string> answers = new List<string>();
            for (int i = 0; i < answerComboBoxes.Count; i++)
            {
                string answer = answerComboBoxes[i].SelectedItem?.ToString() ?? "Sin respuesta";
                answers.Add(answer);
            }

            for (int i = 0; i < totalQuestions; i++)///Desde la pregunta 1 hasta diez pero con indice 0
            {
                int selectedIndex = answerComboBoxes[i].SelectedIndex;///obtener el indice seleccionado
                // Si seleccionó una opción válida (no "Seleccione...")
                if (selectedIndex > 0)///Si va arriba de 0
                {
                    // Convertir el índice a letra: 1 -> 'a', 2 -> 'b', etc.
                    respuestas[i] = ((char)('a' + (selectedIndex - 1))).ToString(); // a + 0 se queda en a, a+1 se vuelve b y asi sucesivamente con casteo de char, ya se valido que no sea 0
                }
            }
            ///Correr Motod del conocimiento
            var respuestasEspecificas = new Dictionary<int, string>();
            for (int i = 0; i < totalQuestions; i++)
            {
                int selectedIndex = answerComboBoxes[i].SelectedIndex;
                if (selectedIndex > 0)
                {
                    string respuesta = ((char)('a' + (selectedIndex - 1))).ToString();
                    respuestasEspecificas.Add(11 + i, respuesta); // 11-17 para ingenierías
                }
            }

            // Procesar respuestas específicas
            _servicio.ProcesarRespuestasEspecificas(respuestasEspecificas);

            // Obtener resultados finales
            var resultados = _servicio.ObtenerResultadosFinales();

            // Mostrar resultados
            string mensajeResultados = "¡Test completado!\n\n";
            foreach (var resultado in resultados)
            {
                mensajeResultados += $"{resultado.Key}: {resultado.Value}\n";
            }

            MessageBox.Show(mensajeResultados, "Resultados de Orientación Vocacional");

            // Aquí puedes navegar a una página de resultados finales
            // o cerrar la aplicación, según lo necesites
            //var resultado1 = MotorOrientacionVocacional.DeterminarAreaEnfasis(respuestas[0], respuestas[1], respuestas[2], respuestas[3], respuestas[4], respuestas[5], respuestas[6], respuestas[7], respuestas[8], respuestas[9]);
            //MessageBox.Show(resultado1.AreaGanadora);

            //// Mostrar resultados
            //string resultMessage = "¡Respuestas enviadas correctamente!\n\n" + string.Join("\n", answers);
            //MessageBox.Show(resultMessage, "Resultados del Cuestionario",
            //              MessageBoxButton.OK, MessageBoxImage.Information);

            // Aquí podrías agregar código para enviar las respuestas a una base de datos, servicio web, etc.
        }
    }
}
