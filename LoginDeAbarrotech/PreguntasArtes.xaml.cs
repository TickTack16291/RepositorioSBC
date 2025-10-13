using Reglas;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LoginDeAbarrotech
{
    /// <summary>
    /// Lógica de interacción para PreguntasArtes.xaml
    /// </summary>
    public partial class PreguntasArtes : Page
    {
        public PreguntasArtes(ServicioOrientacionVocacional servicio, Usuario usuario)
        {
            InitializeComponent();
            InitializeQuestions();
            _servicio = servicio;
            this._usuario = usuario;
        }
        private Usuario _usuario;
        private ServicioOrientacionVocacional _servicio;
        private List<ComboBox> answerComboBoxes = new List<ComboBox>();
        private const int totalQuestions = 5;

        public string[] respuestas = new string[5];

        // Preguntas y opciones de ejemplo
        private string[] questions = {
        "Pregunta 1: ¿Qué forma de expresión artística prefieres?",
        "Pregunta 2: ¿En qué tipo de proyectos te gustaría trabajar?",
        "Pregunta 3: ¿Qué habilidades te describes?",
        "Pregunta 4: ¿Qué ambiente de trabajo te atrae más?",
        "Pregunta 5: ¿Qué tipo de audiencia prefieres?"
        };

        private string[][] options = {
    new string[] { "Seleccione...", "a) Pintura, escultura, fotografía", "b) Movimiento corporal y baile", "c) Diseño digital, ilustración, branding", "d) Sonido, instrumentos musicales, composición", "e) Actuación, dirección escénica, dramaturgia" },
    new string[] { "Seleccione...", "a) Crear obras de arte para exposiciones", "b) Coreografías y performances de danza", "c) Diseñar logotipos, posters, interfaces", "d) Componer música o tocar en una banda", "e) Montar obras de teatro o actuar" },
    new string[] { "Seleccione...", "a) Habilidad para dibujar, pintar o esculpir", "b) Habilidad para bailar y expresar con el cuerpo", "c) Habilidad para usar software de diseño y creatividad visual", "d) Habilidad para tocar instrumentos o cantar", "e) Habilidad para actuar o escribir guiones" },
    new string[] { "Seleccione...", "a) Estudio de arte o galería", "b) Estudio de danza o escenario", "c) Estudio de diseño o agencia", "d) Estudio de grabación o sala de conciertos", "e) Teatro o set de filmación" },
    new string[] { "Seleccione...", "a) Spectadores en una galería", "b) Audiencia en vivo en performances", "c) Clientes o usuarios de productos visuales", "d) Oyentes en conciertos o grabaciones", "e) Público en obras de teatro" }
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
                    respuestasEspecificas.Add(18 + i, respuesta); // 11-17 para ingenierías
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
            _usuario.diagnostico_carrera = resultados["Especialidad en Artes"];
            ConexionBD conexion = new ConexionBD();
            conexion.agregar_carrera(_usuario);
            ///resultados[$"Especialidad en {area}"] = especialidad;
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
