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
    /// Lógica de interacción para PreguntasCVida.xaml
    /// </summary>
    public partial class PreguntasCVida : Page
    {
        public PreguntasCVida(ServicioOrientacionVocacional servicio, Usuario usuario)
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
        "Pregunta 1: ¿Qué área de las ciencias de la vida te interesa más?",
        "Pregunta 2: ¿Qué tipo de actividades te gustaría realizar en tu trabajo?",
        "Pregunta 3: ¿Con qué te sientes más cómodo trabajando?",
        "Pregunta 4: ¿Qué problema te gustaría resolver?",
        "Pregunta 5: ¿Qué entorno de trabajo prefieres?",
        "Pregunta 6: ¿Qué habilidad consideras más importante para ti?",
        "Pregunta 7: ¿Qué te motiva a estudiar esta área?"
        };


        private string[][] options = {
    new string[] { "Seleccione...", "a) La gestión y negocio de empresas agropecuarias", "b) La transformación industrial de productos agrícolas", "c) La producción sostenible de cultivos", "d) La conservación y manejo de bosques", "e) La salud y producción animal", "f) La composición y seguridad de los alimentos" },
    new string[] { "Seleccione...", "a) Planificar y administrar fincas o empresas agropecuarias", "b) Diseñar procesos para convertir materias primas en productos alimenticios", "c) Desarrollar técnicas de cultivo sostenibles", "d) Manejar y conservar recursos forestales", "e) Cuidar la salud de animales y mejorar su producción", "f) Analizar y mejorar la calidad de los alimentos" },
    new string[] { "Seleccione...", "a) Con números y planes de negocio", "b) Con maquinaria y procesos industriales", "c) Con plantas y suelos", "d) Con árboles y ecosistemas forestales", "e) Con animales", "f) Con reactivos y equipos de laboratorio" },
    new string[] { "Seleccione...", "a) Cómo hacer rentable una empresa agropecuaria", "b) Cómo procesar alimentos de manera eficiente", "c) Cómo producir alimentos sin dañar el ambiente", "d) Cómo proteger los bosques de la deforestación", "e) Cómo prevenir enfermedades en animales", "f) Cómo asegurar la inocuidad de los alimentos" },
    new string[] { "Seleccione...", "a) Oficina en el campo o empresa", "b) Planta procesadora de alimentos", "c) Campo agrícola", "d) Bosque o vivero", "e) Clínica veterinaria o granja", "f) Laboratorio de calidad alimentaria" },
    new string[] { "Seleccione...", "a) Habilidad para administrar y tomar decisiones financieras", "b) Habilidad para diseñar y optimizar procesos", "c) Habilidad para entender y manejar sistemas agrícolas", "d) Habilidad para conservar y manejar recursos naturales", "e) Habilidad para diagnosticar y tratar animales", "f) Habilidad para analizar composiciones químicas" },
    new string[] { "Seleccione...", "a) Crear empresas exitosas en el sector agropecuario", "b) Innovar en la producción de alimentos industrializados", "c) Contribuir a la seguridad alimentaria sostenible", "d) Proteger y manejar los recursos forestales", "e) Mejorar la salud y bienestar animal", "f) Garantizar la calidad y seguridad de lo que comemos" }
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
                    respuestasEspecificas.Add(46 + i, respuesta); // 11-17 para ingenierías
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
