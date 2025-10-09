using Org.BouncyCastle.Tls;
using Reglas;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LoginDeAbarrotech
{
    /// <summary>
    /// Lógica de interacción para PreguntasArea.xaml
    /// </summary>
    public partial class PreguntasArea : Window
    {

       
       
        public PreguntasArea()
        {
            InitializeComponent();
            _servicio = new ServicioOrientacionVocacional();
            InitializeQuestions();
        }

        //private void NavegarAPreguntasIngenierias()
        //{
        //    try
        //    {
        //        // 1. Crea la nueva página
        //      PreguntasSalud preguntas = new PreguntasSalud();
        //        this.Content = preguntas; // ← Asigna la página, no solo su Content

        //        //Limpia recursos anteriores
        //        GC.Collect();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al cambiar página: {ex.Message}");
        //    }
        //}


        private ServicioOrientacionVocacional _servicio;
        private List<ComboBox> answerComboBoxes = new List<ComboBox>();
        private const int totalQuestions = 10;

        public string[] respuestas = new string[10];

        // Preguntas y opciones de ejemplo
        private string[] questions = {
            "Pregunta 1: ¿Qué asignaturas disfrutas más en la preparatoria?",
            "Pregunta 2: ¿Qué tipo de actividades disfrutas más en tu tiempo libre?",
            "Pregunta 3: ¿Prefieres trabajar con…?",
            "Pregunta 4 ¿Qué valoras más en un trabajo?",
            "Pregunta 5 ¿Cuál de estas frases resuena más contigo?",
            "Pregunta 6 Si pudieras elegir un proyecto de vida, sería…",
            "Pregunta 7 ¿Qué tipo de problemas disfrutas resolver más?",
            "Pregunta 8 ¿Qué ambiente de aprendizaje prefieres?",
            "Pregunta 9 ¿En qué te visualizas trabajando en el futuro?",
            "Pregunta 10 Si tuvieras que elegir un rol en un equipo de trabajo, serías…"
        };

        private string[][] options = {
       new string[] { "Seleccione...", "a) Matemáticas, Física, Química", "b) Biología, Química", "c) Historia, Filosofía, Literatura", "d) Sociología, Economía, Derecho", "e) Arte, Música, Teatro" },
       new string[] { "Seleccione...", "a) Resolver problemas, armar/desarmar cosas", "b) Leer, Escribir, Reflexionar", "c) Ayudar, aconsejar, enseñar", "d) Dibujar, pintar, crear musica", "e) Actividades al aire libre, cultivar, criar y cuidad animales", "f) Hacer experimentos, entender a la naturaleza" },
       new string[] { "Seleccione...", "a) Máquinas, sistemas, tecnología", "b) Personas y sus relaciones", "c) Ideas y conceptos", "d) Expresiones creativas", "e) Naturaleza, animales, plantas", "f) Sustancias, Materiales, Experimentos" },
       new string[] { "Seleccione...", "a) Innovar, resolver problemas técnicos, Conocer las relaciones materiales", "b) Impactar en la sociedad, leyes, políticas", "c) Comprender la cultura y el pensamiento", "d) Cuidar la salud y bienestar", "e) Expresar la creatividad", "f) Trabajar con la tierra y alimentos", "g) Entender el funcionamiento del mundo y de la naturaleza" },
       new string[] { "Seleccione...", "a) Me gusta construir, programar o diseñar soluciones técnicas", "b) Me interesa entender y ayudar a las personas en sociedad", "c) Quiero comprender la cultura, la historia y el pensamiento", "d) Me motiva mejorar la salud de las personas", "e) Necesito expresarme de forma artística", "f) Quiero trabajar con la naturaleza y el campo", "g) Me gusta entender el porqué de los fenómenos y eventos que suceden a nuestro alrededor" },
      new string[] { "Seleccione...", "a) Crear un invento, programa o empresa tecnológica", "b) Resolver problemas sociales, legales o económicos", "c) Escribir un libro o investigar sobre cultura", "d) Ser médico, enfermero o terapeuta", "e) Ser artista, músico o diseñador", "f) Ser agricultor, veterinario o ambientalista", "g) Ser físico o químico, contribuir en la creación de hipótesis de ciencia" },
      new string[] { "Seleccione...", "a) Técnicos o lógicos", "b) Sociales o políticos", "c) Filosóficos o culturales", "d) De salud o bienestar", "e) Creativos y artísticos", "f) Naturales y ambientales", "g) Científicos ye Innovadores" },
      new string[] { "Seleccione...", "a) Industria, computadoras", "b) Biblioteca, investigación documental", "c) Prácticas comunitarias", "d) Escenarios creativos (teatro, música, diseño)", "e) Campos de cultivo, naturaleza", "f) Laboratorios, taller, Escenarios de campo" },
      new string[] { "Seleccione...", "a) Diseñando soluciones técnicas o tecnológicas", "b) Investigando o resolviendo problemas sociales", "c) Enseñando, escribiendo o investigando ideas", "d) Tratando pacientes o investigando enfermedades", "e) Creando arte, diseño o música", "f) Cultivando, investigando plantas o cuidando animales", "g) Experimentando, Investigando, Crear nuevos componentes" },
      new string[] { "Seleccione...", "a) El que diseña o construye", "b) El que organiza, media y negocia", "c) El que reflexiona y propone ideas", "d) El que cuida la salud y bienestar", "e) El que inspira con creatividad", "f) El que conecta con la naturaleza", "g) El que conecta con el entendimiento del entorno" }
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
                    Background = new SolidColorBrush(Color.FromRgb(248, 249, 250)),
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
             var resultado = _servicio.ProcesarPrimeraFase(respuestas[0], respuestas[1], respuestas[2], respuestas[3], respuestas[4], respuestas[5], respuestas[6], respuestas[7], respuestas[8], respuestas[9]);

            if (resultado.EsEmpate)
            {
                //Mostrar La seleccion de las areas, decision personal
                var areasLimitadas = _servicio.LimitarEmpateADosAreas(resultado.Areas);
                MostrarVentanasSeleccionArea(areasLimitadas);
            }
            else
            {
                //Navegar al area ganadora
                NavegarAPreguntasEspecificas(resultado.Areas[0]);
            }

            //    var resultado1 = MotorOrientacionVocacional.DeterminarAreaEnfasis(respuestas[0], respuestas[1], respuestas[2], respuestas[3], respuestas[4], respuestas[5], respuestas[6], respuestas[7], respuestas[8], respuestas[9]);
            //MessageBox.Show(resultado1.AreaGanadora);

            //// Mostrar resultados
            //string resultMessage = "¡Respuestas enviadas correctamente!\n\n" + string.Join("\n", answers);
            //MessageBox.Show(resultMessage, "Resultados del Cuestionario",
            //              MessageBoxButton.OK, MessageBoxImage.Information);

            //NavegarAPreguntasIngenierias();
        }

        private void MostrarVentanasSeleccionArea(List<string> areas)
        {
            var seleccionWindow  = new SeleccionAreaWindow(areas);
            seleccionWindow.AreaSeleccionada += (Sender, areaSeleccionada) =>
            {
                NavegarAPreguntasEspecificas(areaSeleccionada);
            };
            seleccionWindow.ShowDialog();
        }

        private void NavegarAPreguntasEspecificas(string area)
        {
            try
            {
                // Determinar qué página cargar según el área
                Page paginaEspecifica = area switch
                {
                    "Ingenierías" => new PreguntasIngenierias(_servicio),
                    "Ciencias de la Salud" => new PreguntasSalud(_servicio),
                    "Artes" => new PreguntasArtes(_servicio),
                    "Humanidades" => new PreguntasHumanidades(_servicio),
                    "Ciencias Sociales" => new PreguntasSociales(_servicio),
                    "Ciencias Naturales" => new PreguntasCNaturales(_servicio),
                    "Ciencias de la Vida" => new PreguntasCVida(_servicio),
                    _ => new PreguntasIngenierias(_servicio) // Default
                };

                // Crear una nueva ventana para las preguntas específicas
                var ventanaPreguntas = new Window
                {
                    Content = paginaEspecifica,
                    Title = $"Preguntas de {area}",
                    Width = 800,
                    Height = 600,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner
                };

                ventanaPreguntas.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al navegar: {ex.Message}");
            }
        }
    }
}
