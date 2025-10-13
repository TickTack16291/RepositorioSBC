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
    /// Lógica de interacción para PreguntasCNaturales.xaml
    /// </summary>
    public partial class PreguntasCNaturales : Page
    {
        public PreguntasCNaturales(ServicioOrientacionVocacional servicio, Usuario usuario)
        {
            InitializeComponent();
            InitializeQuestions();  
            _servicio = servicio;
            this._usuario = usuario;
        }
        private Usuario _usuario;
        private ServicioOrientacionVocacional _servicio;
        private List<ComboBox> answerComboBoxes = new List<ComboBox>();
        private const int totalQuestions = 7;

        public string[] respuestas = new string[7];

        // Preguntas y opciones de ejemplo
        private string[] questions = {
        "Pregunta 1: ¿Qué rama de las ciencias naturales te atrae más?",
        "Pregunta 2: ¿Qué tipo de investigación te gustaría realizar?",
        "Pregunta 3: ¿Qué habilidades consideras más afines a ti?",
        "Pregunta 4: ¿Qué entorno de trabajo prefieres?",
        "Pregunta 5: ¿Qué problema global te gustaría contribuir a resolver?",
        "Pregunta 6: ¿Qué materia de ciencias fue tu favorita en la preparatoria?",
        "Pregunta 7: ¿Qué tipo de tecnología te interesa más?"
        };


        private string[][] options = {
    new string[] { "Seleccione...", "a) Estudio de los seres vivos y sus procesos", "b) Estudio de las leyes del universo y aplicaciones tecnológicas", "c) Estudio de patrones, estructuras y relaciones abstractas", "d) Estudio de la composición y transformación de la materia" },
    new string[] { "Seleccione...", "a) Investigación de ecosistemas y biodiversidad", "b) Desarrollo de nuevas tecnologías y dispositivos", "c) Modelado matemático para resolver problemas complejos", "d) Síntesis y análisis de compuestos químicos" },
    new string[] { "Seleccione...", "a) Observación detallada y clasificación de organismos", "b) Resolución de problemas mediante principios físicos", "c) Pensamiento abstracto y lógico-matemático", "d) Experimentación metódica en laboratorio" },
    new string[] { "Seleccione...", "a) Campo y laboratorio biológico", "b) Laboratorio de física e instalaciones tecnológicas", "c) Entornos donde se aplique análisis de datos", "d) Laboratorio químico y plantas industriales" },
    new string[] { "Seleccione...", "a) Conservación de especies y ecosistemas", "b) Desarrollo de energías renovables", "c) Optimización de sistemas complejos (tráfico, finanzas)", "d) Creación de materiales sostenibles o medicamentos" },
    new string[] { "Seleccione...", "a) Biología", "b) Física", "c) Matemáticas", "d) Química" },
    new string[] { "Seleccione...", "a) Tecnologías para el estudio de organismos (microscopía, DNA)", "b) Tecnologías de punta (nanotecnología, robótica)", "c) Tecnologías computacionales y software", "d) Tecnologías de análisis y síntesis química" }
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
            ///
            var respuestasEspecificas = new Dictionary<int, string>();
            for (int i = 0; i < totalQuestions; i++)
            {
                int selectedIndex = answerComboBoxes[i].SelectedIndex;
                if (selectedIndex > 0)
                {
                    string respuesta = ((char)('a' + (selectedIndex - 1))).ToString();
                    respuestasEspecificas.Add(39 + i, respuesta); // 11-17 para ingenierías
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
            _usuario.diagnostico_carrera = resultados["Especialidad en Ciencias Naturales"];
            ConexionBD conexion = new ConexionBD();
            conexion.agregar_carrera(_usuario);
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
