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
    /// Lógica de interacción para PreguntasSalud.xaml
    /// </summary>
    public partial class PreguntasSalud : Page
    {
        public PreguntasSalud(ServicioOrientacionVocacional servicio, Usuario usuario)
        {
            InitializeComponent();
            InitializeQuestions();  
            _servicio = servicio;
            this._usuario = usuario;
        }
        private Usuario _usuario;
        private ServicioOrientacionVocacional _servicio;
        private List<ComboBox> answerComboBoxes = new List<ComboBox>();
        private const int totalQuestions = 6;

        public string[] respuestas = new string[6];

        // Preguntas y opciones de ejemplo
        private string[] questions = {
        "Pregunta 1: ¿Qué aspecto de la salud te interesa más?",
        "Pregunta 2: ¿Qué tipo de actividades te gustaría realizar en tu trabajo?",
        "Pregunta 3: ¿Con qué grupo de población prefieres trabajar?",
        "Pregunta 4: ¿Qué habilidades crees que son más importantes para ti?",
        "Pregunta 5: ¿Qué entorno de trabajo prefieres?",
        "Pregunta 6: ¿Qué te motiva a estudiar una carrera de salud?"
        };

        private string[][] options = {
    new string[] { "Seleccione...", "a) La salud bucal y dental", "b) El cuidado directo de pacientes en diversos entornos", "c) Los medicamentos y su efecto en el cuerpo", "d) El envejecimiento y el cuidado de adultos mayores", "e) El diagnóstico y tratamiento de enfermedades en general", "f) La alimentación y su impacto en la salud", "g) La salud mental y el comportamiento humano" },
    new string[] { "Seleccione...", "a) Realizar procedimientos dentales (limpiezas, extracciones, etc.)", "b) Administrar cuidados, tomar signos vitales, asistir en procedimientos", "c) Preparar y dispensar medicamentos, asesorar sobre su uso", "d) Diseñar programas de bienestar para adultos mayores", "e) Examinar pacientes, ordenar pruebas, prescribir tratamientos", "f) Evaluar dietas, planificar menús saludables, educar sobre nutrición", "g) Realizar terapias, evaluaciones psicológicas, investigar comportamientos" },
    new string[] { "Seleccione...", "a) Pacientes de todas las edades con problemas dentales", "b) Pacientes hospitalizados o en comunidad de todas las edades", "c) Público en general que necesita orientación sobre medicamentos", "d) Adultos mayores y sus familias", "e) Pacientes de todas las edades con diversas enfermedades", "f) Personas que buscan mejorar su salud a través de la dieta", "g) Personas con problemas emocionales, mentales o de comportamiento" },
    new string[] { "Seleccione...", "a) Habilidad manual para procedimientos detallados", "b) Empatía y capacidad para trabajar bajo presión", "c) Conocimiento profundo de química y biología", "d) Paciencia y comprensión para tratar con adultos mayores", "e) Capacidad de diagnóstico y toma de decisiones rápidas", "f) Conocimiento sobre alimentos y metabolismo", "g) Habilidad para escuchar y analizar problemas psicológicos" },
    new string[] { "Seleccione...", "a) Consultorio dental", "b) Hospital, clínica o comunidad", "c) Farmacia comunitaria u hospitalaria", "d) Residencias para adultos mayores, centros de día", "e) Hospital, consultorio privado, urgencias", "f) Consultorio, hospital, escuelas, empresas", "g) Consultorio psicológico, hospitales, escuelas" },
    new string[] { "Seleccione...", "a) Mejorar la salud bucal de las personas", "b) Proporcionar cuidado y confort a los pacientes", "c) Asegurar el uso seguro y efectivo de los medicamentos", "d) Mejorar la calidad de vida de los adultos mayores", "e) Curar enfermedades y salvar vidas", "f) Promover hábitos alimenticios saludables", "g) Ayudar a las personas a superar problemas mentales" }
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
                    respuestasEspecificas.Add(28 + i, respuesta); // 11-17 para ingenierías
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
