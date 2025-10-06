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
    /// Lógica de interacción para PreguntasSociales.xaml
    /// </summary>
    public partial class PreguntasSociales : Page
    {
        public PreguntasSociales()
        {
            InitializeComponent();
            InitializeQuestions();
        }
        private List<ComboBox> answerComboBoxes = new List<ComboBox>();
        private const int totalQuestions = 5;

        public string[] respuestas = new string[5];

        // Preguntas y opciones de ejemplo
        private string[] questions = {
    "Pregunta 1: ¿Qué tipo de trabajo te atrae más?",
    "Pregunta 2: ¿Qué habilidad te consideras más fuerte?",
    "Pregunta 3: ¿Qué entorno laboral prefieres?",
    "Pregunta 4: ¿Qué te motiva a elegir una carrera?",
    "Pregunta 5: ¿Con qué tipo de problemas te gustaría lidiar?"
};

        private string[][] options = {
    new string[] { "Seleccione...", "a) Gestionar recursos y personas en organizaciones", "b) Analizar y asesorar en aspectos legales", "c) Enseñar y diseñar métodos educativos", "d) Investigar y comprender fenómenos sociales", "e) Desarrollar estrategias de mercado", "f) Manejar información financiera y contable", "g) Planificar el desarrollo de regiones", "h) Facilitar el comercio entre países", "i) Producir contenidos para medios", "j) Apoyar a grupos sociales en riesgo", "k) Crear experiencias gastronómicas", "l) Gestionar servicios turísticos", "m) Analizar la economía y políticas públicas" },
    new string[] { "Seleccione...", "a) Liderazgo y organización", "b) Argumentación y persuasión", "c) Paciencia y explicación", "d) Análisis crítico e investigación", "e) Creatividad para campañas", "f) Exactitud con números", "g) Visión de largo plazo", "h) Negociación intercultural", "i) Empatía y apoyo", "j) Habilidad culinaria", "k) Habilidad para servicio al cliente", "l) Análisis económico" },
    new string[] { "Seleccione...", "a) Oficina corporativa", "b) Despacho o juzgado", "c) Aula o centro educativo", "d) Instituto de investigación", "e) Agencia de publicidad", "f) Organización gubernamental", "g) Empresa internacional", "h) Medio de comunicación", "i) Comunidad o barrio", "j) Restaurante o cocina", "k) Hotel o destino turístico" },
    new string[] { "Seleccione...", "a) Crear riqueza y empleos", "b) Buscar justicia y equidad", "c) Formar a las nuevas generaciones", "d) Entender la sociedad", "e) Influir en las decisiones públicas", "f) Ayudar a las empresas a crecer", "g) Diseñar ciudades más habitables", "h) Facilitar el intercambio global", "i) Informar y entretener", "j) Promover la cultura alimentaria", "k) Promover el patrimonio cultural" },
    new string[] { "Seleccione...", "a) Problemas de gestión y eficiencia", "b) Problemas legales y disputas", "c) Problemas de aprendizaje", "d) Problemas sociales como desigualdad", "e) Problemas de marketing y competencia", "f) Problemas financieros", "g) Problemas de desarrollo urbano", "h) Problemas de logística internacional", "i) Problemas de comunicación", "j) Problemas de calidad alimentaria", "k) Problemas de sostenibilidad turística" }
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
            var resultado1 = MotorOrientacionVocacional.DeterminarAreaEnfasis(respuestas[0], respuestas[1], respuestas[2], respuestas[3], respuestas[4], respuestas[5], respuestas[6], respuestas[7], respuestas[8], respuestas[9]);
            MessageBox.Show(resultado1.AreaGanadora);

            // Mostrar resultados
            string resultMessage = "¡Respuestas enviadas correctamente!\n\n" + string.Join("\n", answers);
            MessageBox.Show(resultMessage, "Resultados del Cuestionario",
                          MessageBoxButton.OK, MessageBoxImage.Information);

            // Aquí podrías agregar código para enviar las respuestas a una base de datos, servicio web, etc.
        }
    }
}
