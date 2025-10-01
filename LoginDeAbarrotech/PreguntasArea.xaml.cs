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
    /// Lógica de interacción para PreguntasArea.xaml
    /// </summary>
    public partial class PreguntasArea : Window
    {
        public PreguntasArea()
        {
            InitializeComponent();
            InitializeQuestions();
        }
        private List<ComboBox> answerComboBoxes = new List<ComboBox>();
        private const int totalQuestions = 10;

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
           new string[] { "Seleccione...", "Matemáticas, Física, Química", "Biología, Química", "Historia, Filosofía, Literatura", "Sociología, Economía, Derecho", "Arte, Música, Teatro" },
           new string[] { "Seleccione...", "Resolver problemas, armar/desarmar cosas", "Leer, Escribir, Reflexionar", "Ayudar, aconsejar, enseñar", "Dibujar, pintar, crear musica", "Actividades al aire libre, cultivar, criar y cuidad animales", "Hacer experimentos, entender a la naturaleza" },
           new string[] { "Seleccione...", "Máquinas, sistemas, tecnología", "Personas y sus relaciones", "Ideas y conceptos", "Expresiones creativas", "Naturaleza, animales, plantas", "Sustancias, Materiales, Experimentos" },
           new string[] { "Seleccione...", "Innovar, resolver problemas técnicos, Conocer las relaciones materiales", "Impactar en la sociedad, leyes, políticas", "Comprender la cultura y el pensamiento", "Cuidar la salud y bienestar", "Expresar la creatividad", "Trabajar con la tierra y alimentos", "Entender el funcionamiento del mundo y de la naturaleza" },
           new string[] { "Seleccione...", "Me gusta construir, programar o diseñar soluciones técnicas", "Me interesa entender y ayudar a las personas en sociedad", "Quiero comprender la cultura, la historia y el pensamiento", "Me motiva mejorar la salud de las personas", "Necesito expresarme de forma artística", "Quiero trabajar con la naturaleza y el campo", "Me gusta entender el porqué de los fenómenos y eventos que suceden a nuestro alrededor" },
          new string[] { "Seleccione...", "Crear un invento, programa o empresa tecnológica", "Resolver problemas sociales, legales o económicos", "Escribir un libro o investigar sobre cultura", "Ser médico, enfermero o terapeuta", "Ser artista, músico o diseñador", "Ser agricultor, veterinario o ambientalista", "Ser físico o químico, contribuir en la creación de hipótesis de ciencia" },
          new string[] { "Seleccione...", "Técnicos o lógicos", "Sociales o políticos", "Filosóficos o culturales", "De salud o bienestar", "Creativos y artísticos", "Naturales y ambientales", "Científicos ye Innovadores" },
          new string[] { "Seleccione...", "Industria, computadoras", "Biblioteca, investigación documental", "Prácticas comunitarias", "Escenarios creativos (teatro, música, diseño)", "Campos de cultivo, naturaleza", "Laboratorios, taller, Escenarios de campo" },
          new string[] { "Seleccione...", "Diseñando soluciones técnicas o tecnológicas", "Investigando o resolviendo problemas sociales", "Enseñando, escribiendo o investigando ideas", "Tratando pacientes o investigando enfermedades", "Creando arte, diseño o música", "Cultivando, investigando plantas o cuidando animales", "Experimentando, Investigando, Crear nuevos componentes" },
          new string[] { "Seleccione...", "El que diseña o construye", "El que organiza, media y negocia", "El que reflexiona y propone ideas", "El que cuida la salud y bienestar", "El que inspira con creatividad", "El que conecta con la naturaleza", "El que conecta con el entendimiento del entorno" }
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
                answers.Add($"Pregunta {i + 1}: {answer}");
            }

            // Mostrar resultados
            string resultMessage = "¡Respuestas enviadas correctamente!\n\n" + string.Join("\n", answers);
            MessageBox.Show(resultMessage, "Resultados del Cuestionario",
                          MessageBoxButton.OK, MessageBoxImage.Information);

            // Aquí podrías agregar código para enviar las respuestas a una base de datos, servicio web, etc.
        }
    }
}
