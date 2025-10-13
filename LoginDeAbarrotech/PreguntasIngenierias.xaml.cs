using Reglas;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LoginDeAbarrotech
{
    /// <summary>
    /// Lógica de interacción para PreguntasIngenierias.xaml
    /// </summary>
    public partial class PreguntasIngenierias : Page
    {
        public PreguntasIngenierias(ServicioOrientacionVocacional servicio, Usuario usuario)
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
         "Pregunta 1: ¿Qué tipo de sistemas te interesa más diseñar o mejorar?",
         "Pregunta 2: ¿En qué ambiente prefieres trabajar?",
         "Pregunta 3: ¿Qué habilidad te sientes más cómodo desarrollando?",
         "Pregunta 4: ¿Qué tipo de problemas te gustaría resolver?",
         "Pregunta 5: ¿Con qué herramientas te gustaría trabajar?",
         "Pregunta 6: ¿Qué materia te parece más interesante?",
         "Pregunta 7: ¿Qué proyecto te motivaría más?"
         };

        private string[][] options = {
    new string[] { "Seleccione...", "a) Sistemas mecánicos y robots", "b) Sistemas de software y aplicaciones", "c) Estructuras y edificios", "d) Procesos industriales y de producción", "e) Procesos de producción de alimentos", "f) Procesos de extracción y tratamiento de minerales", "g) Desarrollo de nuevos materiales", "h) Sistemas de comunicación y redes", "i) Procesos biológicos y biotecnológicos" },
    new string[] { "Seleccione...", "a) Laboratorio de robótica o automatización", "b) Oficina con computadoras", "c) Obras de construcción", "d) Plantas industriales", "e) Plantas procesadoras de alimentos", "f) Minas o plantas metalúrgicas", "g) Laboratorio de materiales", "h) Centros de telecomunicaciones", "i) Laboratorio biotecnológico" },
    new string[] { "Seleccione...", "a) Programación de robots y sistemas automáticos", "b) Programación de software", "c) Diseño estructural y planos", "d) Optimización de procesos y gestión", "e) Control de calidad y procesos alimentarios", "f) Análisis de minerales y metales", "g) Análisis y síntesis de materiales", "h) Diseño de redes y comunicaciones", "i) Manipulación de organismos y bioprocesos" },
    new string[] { "Seleccione...", "a) Automatización de tareas repetitivas", "b) Creación de algoritmos eficientes", "c) Diseño de infraestructuras resistentes", "d) Mejora de la eficiencia en producción", "e) Conservación y procesamiento de alimentos", "f) Extracción y purificación de metales", "g) Desarrollo de materiales más ligeros o resistentes", "h) Mejora de la comunicación inalámbrica", "i) Desarrollo de productos biológicos" },
    new string[] { "Seleccione...", "a) Robots y sensores", "b) Lenguajes de programación", "c) Software de diseño CAD y equipos de construcción", "d) Software de simulación y gestión", "e) Equipos de procesamiento de alimentos", "f) Equipos de minería y metalurgia", "g) Microscopios y equipos de prueba de materiales", "h) Antenas y equipos de comunicación", "i) Reactores biológicos y equipos de laboratorio" },
    new string[] { "Seleccione...", "a) Electrónica y control", "b) Algoritmos y estructuras de datos", "c) Mecánica de materiales", "d) Investigación de operaciones", "e) Química de alimentos", "f) Mineralogía", "g) Ciencia de materiales", "h) Teoría de las comunicaciones", "i) Biología molecular" },
    new string[] { "Seleccione...", "a) Construir un robot autónomo", "b) Desarrollar una aplicación móvil", "c) Diseñar un puente o edificio", "d) Mejorar la logística de una empresa", "e) Crear un nuevo producto alimenticio", "f) Optimizar la extracción de un metal", "g) Crear un material biodegradable", "h) Diseñar una red de fibra óptica", "i) Desarrollar un biocombustible" }
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
            _usuario.diagnostico_carrera = resultados["Especialidad en Ingenierías"];
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
