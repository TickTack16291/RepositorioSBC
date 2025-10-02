namespace Reglas
{
    using NRules;
    using NRules.Fluent;
    using System;
    using System.Linq;

    public class Preguntas
    {
        public string preguntaNo1 { get; set; } = "¿Qué asignaturas disfrutas más en la preparatoria?";
        public string preguntaNo2 { get; set; } = "¿Qué tipo de actividades disfrutas más en tu tiempo libre?";
        public string preguntaNo3 { get; set; } = "¿Prefieres trabajar con…?";
        public string preguntaNo4 { get; set; } = "¿Qué valoras más en un trabajo?";
        public string preguntaNo5 { get; set; } = "¿Cuál de estas frases resuena más contigo?";
        public string preguntaNo6 { get; set; } = "Si pudieras elegir un proyecto de vida, sería…";
        public string preguntaNo7 { get; set; } = "¿Qué tipo de problemas disfrutas resolver más?";
        public string preguntaNo8 { get; set; } = "¿Qué ambiente de aprendizaje prefieres?";
        public string preguntaNo9 { get; set; } = "¿En qué te visualizas trabajando en el futuro?";
        public string preguntaNo10 { get; set; } = "Si tuvieras que elegir un rol en un equipo de trabajo, serías…";
    }

    public class RespuestaUsuario
    {
        public string respuestaNo1 { get; set; } = "";
        public string respuestaNo2 { get; set; } = "";
        public string respuestaNo3 { get; set; } = "";
        public string respuestaNo4 { get; set; } = "";
        public string respuestaNo5 { get; set; } = "";
        public string respuestaNo6 { get; set; } = "";
        public string respuestaNo7 { get; set; } = "";
        public string respuestaNo8 { get; set; } = "";
        public string respuestaNo9 { get; set; } = "";
        public string respuestaNo10 { get; set; } = "";

    }

    public class PuntajeArea
    {
        public int puntajeIngenieria { get; set; }
        public int puntajeCienciasSalud { get; set; }
        public int puntajeHumanidades { get; set; }
        public int puntajeCienciasSociales { get; set; }
        public int puntajeArtes { get; set; }
        public int puntajeCienciasNaturales { get; set; }
        public int puntajeCienciasDeLaVida { get; set; }

        public void sumarPuntosIngenieria(int puntos)
        {
            puntajeIngenieria += puntos;
        }
        public void sumarPuntosCienciasSalud(int puntos)
        {
            puntajeCienciasSalud += puntos;
        }
        public void sumarPuntosHumanidades(int puntos)
        {
            puntajeHumanidades += puntos;
        }
        public void sumarPuntosCienciasSociales(int puntos)
        {
            puntajeCienciasSociales += puntos;
        }
        public void sumarPuntosArtes(int puntos)
        {
            puntajeArtes += puntos;
        }
        public void sumarPuntosCienciasNaturales(int puntos)
        {
            puntajeCienciasNaturales += puntos;
        }
        public void sumarPuntosCienciasDeLaVida(int puntos)
        {
            puntajeCienciasDeLaVida += puntos;
        }

        public void ReiniciarPuntajes()
        {
            puntajeIngenieria = 0;
            puntajeCienciasSalud = 0;
            puntajeHumanidades = 0;
            puntajeCienciasSociales = 0;
            puntajeArtes = 0;
            puntajeCienciasNaturales = 0;
            puntajeCienciasDeLaVida = 0;
        }

        public string ObtenerAreaGanadora()
        {
            var puntajes = new[]
            {
                (Area: "Ingenierías", Puntaje: puntajeIngenieria),
                (Area: "Ciencias de la Salud", Puntaje: puntajeCienciasSalud),
                (Area: "Humanidades", Puntaje:  puntajeHumanidades),
                (Area: "Ciencias Sociales", Puntaje: puntajeCienciasSociales),
                (Area: "Artes", Puntaje: puntajeArtes),
                (Area: "Ciencias Naturales", Puntaje: puntajeCienciasNaturales),
                (Area: "Ciencias de la Vida", Puntaje: puntajeCienciasDeLaVida)
            };

            var maxPuntaje = puntajes.Max(p => p.Puntaje);
            var areasGanadoras = puntajes.Where(p => p.Puntaje == maxPuntaje).ToList();

            if (areasGanadoras.Count == 0 || maxPuntaje == 0)
                return "SinDeterminar";

            return areasGanadoras.Count == 1
                ? areasGanadoras[0].Area
                : $"Empate entre: {string.Join(", ", areasGanadoras.Select(a => a.Area))}";
        }

    }

    

    /// <summary>
    /// Pregunta 1: ¿Qué asignaturas disfrutas más en la preparatoria?
    /// a) Matemáticas, Física, Química → Ingenierías / Ciencias Naturales
    /// b) Biología, Química → Ciencias de la Salud / Agricultura
    /// c) Historia, Filosofía, Literatura → Humanidades
    /// d) Sociología, Economía, Derecho → Ciencias Sociales
    /// e) Arte, Música, Teatro → Artes
    /// </summary>
    public class ReglaP1Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
           
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.respuestaNo1 == "a" || r.respuestaNo1 == "b" || r.respuestaNo1 == "c" ||
                    r.respuestaNo1 == "d" || r.respuestaNo1 == "e" || r.respuestaNo1 == "f")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP1(respuestas.respuestaNo1, puntajes));
        }

        private static void ProcesarRespuestaP1(string respuesta, PuntajeArea puntajes)
        {
            ///SE TIENE QUE QUITAR, a fin de cuentas solo importa la respuesta
            Preguntas preguntas = new Preguntas();
            Console.WriteLine(preguntas.preguntaNo1);
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosIngenieria(4);
                    Console.WriteLine("P1: +4 Ingenierías");
                    break;
                case "b":
                    puntajes.sumarPuntosCienciasNaturales(2);
                    Console.WriteLine("P1: +2 Ciencias Naturales");
                    break;
                case "c":
                    puntajes.sumarPuntosCienciasNaturales(1);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P1: +1 Ciencias Naturales, Ciencias de la vida, Ciencias de la salud");
                    break;
                case "d":
                    puntajes.sumarPuntosHumanidades(2);
                    Console.WriteLine("P1: +2 Humanidades");
                    break;
                case "e":
                    puntajes.sumarPuntosCienciasSociales(2);
                    Console.WriteLine("P1: +2 Ciencias Sociales");
                    break;
                case "f":
                    puntajes.sumarPuntosArtes(2);
                    Console.WriteLine("P1: +2 Artes");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 2: ¿Qué tipo de actividades disfrutas más en tu tiempo libre?
    /// a) Resolver problemas, armar/desarmar cosas → Ingenierías
    /// b) Leer, escribir, reflexionar → Humanidades
    /// c) Ayudar, enseñar, aconsejar → Ciencias Sociales / Salud
    /// d) Dibujar, pintar, crear música → Artes
    /// e) Actividades al aire libre, cultivar → Agricultura
    /// f) Hacer experimentos, entender la naturaleza – Ciencias naturales
    /// </summary>
    public class ReglaP2Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.respuestaNo2 == "a" || r.respuestaNo2 == "b" || r.respuestaNo2 == "c" ||
                    r.respuestaNo2 == "d" || r.respuestaNo2 == "e" || r.respuestaNo2 == "f")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP2(respuestas.respuestaNo2, puntajes));
        }

        private static void ProcesarRespuestaP2(string respuesta, PuntajeArea puntajes)
        { ///SE TIENE QUE QUITAR, a fin de cuentas solo importa la respuesta
            Preguntas preguntas = new Preguntas();
            Console.WriteLine(preguntas.preguntaNo2);
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosIngenieria(2);
                    Console.WriteLine("P2: +2 Ingeniería");
                    break;
                case "b":
                    puntajes.sumarPuntosHumanidades(2);
                    Console.WriteLine("P2: +2 Humanidades");
                    break;
                case "c":
                    puntajes.sumarPuntosCienciasSalud(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P2: +2 Ciencias de la Salud, +1 Humanidades");
                    break;
                case "d":
                    puntajes.sumarPuntosArtes(2);
                    Console.WriteLine("P2: +2 Artes");
                    break;
                case "e":
                    puntajes.sumarPuntosCienciasDeLaVida(2);
                    Console.WriteLine("P2: +2 Ciencias de la Vida");
                    break;
                case "f":
                    puntajes.sumarPuntosCienciasNaturales(2);
                    Console.WriteLine("P2: +2 Ciencias Naturales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 3: ¿Prefieres trabajar con…?
    /// a) Máquinas, sistemas, tecnología → Ingenierías / Computación
    /// b) Personas y sus relaciones → Ciencias Sociales / Salud
    /// c) Ideas y conceptos → Humanidades
    /// d) Expresiones creativas → Artes
    /// e) Naturaleza, animales, plantas → Agricultura
    /// f) Sustancias, Materiales, Experimentos -Ciencias naturales
    /// </summary>
    public class ReglaP3Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.respuestaNo3 == "a" || r.respuestaNo3 == "b" || r.respuestaNo3 == "c" ||
                    r.respuestaNo3 == "d" || r.respuestaNo3 == "e" || r.respuestaNo3 == "f")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP3(respuestas.respuestaNo3, puntajes));
        }

        private static void ProcesarRespuestaP3(string respuesta, PuntajeArea puntajes)
        {
            ///SE TIENE QUE QUITAR, a fin de cuentas solo importa la respuesta
            Preguntas preguntas = new Preguntas();
            Console.WriteLine(preguntas.preguntaNo3);
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosIngenieria(2);
                    Console.WriteLine("P3: +2 Ingeniería");
                    break;
                case "b":
                    puntajes.sumarPuntosHumanidades(1);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P3: +1 Humanidades, +1 Ciencias de la Salud");
                    break;
                case "c":
                    puntajes.sumarPuntosHumanidades(2);
                    Console.WriteLine("P3: +2 Humanidades");
                    break;
                case "d":
                    puntajes.sumarPuntosArtes(2);
                    Console.WriteLine("P3: +2 Artes");
                    break;
                case "e":
                    puntajes.sumarPuntosCienciasDeLaVida(2);
                    Console.WriteLine("P3: +2 Ciencias de la Vida");
                    break;
                case "f":
                    puntajes.sumarPuntosCienciasNaturales(2);
                    Console.WriteLine("P3: +2 Ciencias Naturales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 4: ¿Qué valoras más en un trabajo?
    /// a) Innovar, resolver problemas técnicos, Conocer las relaciones materiales → Ingenierías
    /// b) Impactar en la sociedad, leyes, políticas → Ciencias Sociales
    /// c) Comprender la cultura y el pensamiento → Humanidades
    /// d) Cuidar la salud y bienestar → Salud
    /// e) Expresar la creatividad → Artes
    /// f) Trabajar con la tierra y alimentos → Agricultura
    /// g) Entender el funcionamiento del mundo y de la naturaleza → Ciencias naturales
    /// </summary>
    public class ReglaP4Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.respuestaNo4 == "a" || r.respuestaNo4 == "b" || r.respuestaNo4 == "c" ||
                    r.respuestaNo4 == "d" || r.respuestaNo4 == "e" || r.respuestaNo4 == "f" || r.respuestaNo4 == "g")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP4(respuestas.respuestaNo4, puntajes));
        }

        private static void ProcesarRespuestaP4(string respuesta, PuntajeArea puntajes)
        { ///SE TIENE QUE QUITAR, a fin de cuentas solo importa la respuesta
            Preguntas preguntas = new Preguntas();
            Console.WriteLine(preguntas.preguntaNo4);
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosIngenieria(3);
                    Console.WriteLine("P4: +3 Ingenierías");
                    break;
                case "b":
                    puntajes.sumarPuntosCienciasSociales(3);
                    Console.WriteLine("P4: +3 Ciencias Sociales");
                    break;
                case "c":
                    puntajes.sumarPuntosHumanidades(3);
                    Console.WriteLine("P4: +3 Humanidades");
                    break;
                case "d":
                    puntajes.sumarPuntosCienciasSalud(3);
                    Console.WriteLine("P4: +3 Ciencias de la Salud");
                    break;
                case "e":
                    puntajes.sumarPuntosArtes(3);
                    Console.WriteLine("P4: +3 Artes");
                    break;
                case "f":
                    puntajes.sumarPuntosCienciasDeLaVida(3);
                    Console.WriteLine("P4: +3 Ciencias de la Vida");
                    break;
                case "g":
                    puntajes.sumarPuntosCienciasNaturales(3);
                    Console.WriteLine("P4: +3 Ciencias Naturales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 5: ¿Cuál de estas frases resuena más contigo?
    /// a) "Me gusta construir, programar o diseñar soluciones técnicas" → Ingenierías
    /// b) "Me interesa entender y ayudar a las personas en sociedad" → Ciencias Sociales
    /// c) "Quiero comprender la cultura, la historia y el pensamiento" → Humanidades
    /// d) "Me motiva mejorar la salud de las personas" → Salud
    /// e) "Necesito expresarme de forma artística" → Artes
    /// f) "Quiero trabajar con la naturaleza y el campo" → Agricultura
    /// g) "Me gusta entender el porqué de los fenómenos y eventos que suceden a nuestro alrededor" → Ciencias naturales
    /// </summary>
    public class ReglaP5Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.respuestaNo5 == "a" || r.respuestaNo5 == "b" || r.respuestaNo5 == "c" ||
                    r.respuestaNo5 == "d" || r.respuestaNo5 == "e" || r.respuestaNo5 == "f" || r.respuestaNo5 == "g")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP5(respuestas.respuestaNo5, puntajes));
        }

        private static void ProcesarRespuestaP5(string respuesta, PuntajeArea puntajes)
        {
            ///SE TIENE QUE QUITAR, a fin de cuentas solo importa la respuesta
            Preguntas preguntas = new Preguntas();
            Console.WriteLine(preguntas.preguntaNo5);
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosIngenieria(3);
                    Console.WriteLine("P5: +3 Ingenierías");
                    break;
                case "b":
                    puntajes.sumarPuntosCienciasSociales(3);
                    Console.WriteLine("P5: +3 Ciencias Sociales");
                    break;
                case "c":
                    puntajes.sumarPuntosHumanidades(3);
                    Console.WriteLine("P5: +3 Humanidades");
                    break;
                case "d":
                    puntajes.sumarPuntosCienciasSalud(3);
                    Console.WriteLine("P5: +3 Ciencias de la Salud");
                    break;
                case "e":
                    puntajes.sumarPuntosArtes(3);
                    Console.WriteLine("P5: +3 Artes");
                    break;
                case "f":
                    puntajes.sumarPuntosCienciasDeLaVida(3);
                    Console.WriteLine("P5: +3 Ciencias de la Vida");
                    break;
                case "g":
                    puntajes.sumarPuntosCienciasNaturales(3);
                    Console.WriteLine("P5: +3 Ciencias Naturales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 6: Si pudieras elegir un proyecto de vida, sería…
    /// a) Crear un invento, programa o empresa tecnológica → Ingenierías
    /// b) Resolver problemas sociales, legales o económicos → Ciencias Sociales
    /// c) Escribir un libro o investigar sobre cultura → Humanidades
    /// d) Ser médico, enfermero o terapeuta → Salud
    /// e) Ser artista, músico o diseñador → Artes
    /// f) Ser agricultor, veterinario o ambientalista → Agricultura
    /// g) Ser físico o químico, contribuir en la creación de hipótesis de ciencia → Ciencias naturales
    /// </summary>
    public class ReglaP6Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.respuestaNo6 == "a" || r.respuestaNo6 == "b" || r.respuestaNo6 == "c" ||
                    r.respuestaNo6 == "d" || r.respuestaNo6 == "e" || r.respuestaNo6 == "f" || r.respuestaNo6 == "g")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP6(respuestas.respuestaNo6, puntajes));
        }

        private static void ProcesarRespuestaP6(string respuesta, PuntajeArea puntajes)
        {
            ///SE TIENE QUE QUITAR, a fin de cuentas solo importa la respuesta
            Preguntas preguntas = new Preguntas();
            Console.WriteLine(preguntas.preguntaNo6);
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosIngenieria(3);
                    Console.WriteLine("P6: +3 Ingenierías");
                    break;
                case "b":
                    puntajes.sumarPuntosCienciasSociales(3);
                    Console.WriteLine("P6: +3 Ciencias Sociales");
                    break;
                case "c":
                    puntajes.sumarPuntosHumanidades(3);
                    Console.WriteLine("P6: +3 Humanidades");
                    break;
                case "d":
                    puntajes.sumarPuntosCienciasSalud(3);
                    Console.WriteLine("P6: +3 Ciencias de la Salud");
                    break;
                case "e":
                    puntajes.sumarPuntosArtes(3);
                    Console.WriteLine("P6: +3 Artes");
                    break;
                case "f":
                    puntajes.sumarPuntosCienciasDeLaVida(3);
                    Console.WriteLine("P6: +3 Ciencias de la Vida");
                    break;
                case "g":
                    puntajes.sumarPuntosCienciasNaturales(3);
                    Console.WriteLine("P6: +3 Ciencias Naturales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 7: ¿Qué tipo de problemas disfrutas resolver más?
    /// a) Técnicos o lógicos → Ingenierías
    /// b) Sociales o políticos → Ciencias Sociales
    /// c) Filosóficos o culturales → Humanidades
    /// d) De salud o bienestar → Salud
    /// e) Creativos y artísticos → Artes
    /// f) Naturales y ambientales → Agricultura
    /// g) Científicos e Innovadores → Ciencias naturales
    /// </summary>
    public class ReglaP7Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.respuestaNo7 == "a" || r.respuestaNo7 == "b" || r.respuestaNo7 == "c" ||
                    r.respuestaNo7 == "d" || r.respuestaNo7 == "e" || r.respuestaNo7 == "f" || r.respuestaNo7 == "g")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP7(respuestas.respuestaNo7, puntajes));
        }

        private static void ProcesarRespuestaP7(string respuesta, PuntajeArea puntajes)
        {
            ///SE TIENE QUE QUITAR, a fin de cuentas solo importa la respuesta
            Preguntas preguntas = new Preguntas();
            Console.WriteLine(preguntas.preguntaNo7);
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosIngenieria(3);
                    Console.WriteLine("P7: +3 Ingenierías");
                    break;
                case "b":
                    puntajes.sumarPuntosCienciasSociales(3);
                    Console.WriteLine("P7: +3 Ciencias Sociales");
                    break;
                case "c":
                    puntajes.sumarPuntosHumanidades(3);
                    Console.WriteLine("P7: +3 Humanidades");
                    break;
                case "d":
                    puntajes.sumarPuntosCienciasSalud(3);
                    Console.WriteLine("P7: +3 Ciencias de la Salud");
                    break;
                case "e":
                    puntajes.sumarPuntosArtes(3);
                    Console.WriteLine("P7: +3 Artes");
                    break;
                case "f":
                    puntajes.sumarPuntosCienciasDeLaVida(3);
                    Console.WriteLine("P7: +3 Ciencias de la Vida");
                    break;
                case "g":
                    puntajes.sumarPuntosCienciasNaturales(3);
                    Console.WriteLine("P7: +3 Ciencias Naturales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 8: ¿Qué ambiente de aprendizaje prefieres?
    /// a) Industria, computadoras → Ingenierías / Salud
    /// b) Biblioteca, investigación documental → Humanidades
    /// c) Prácticas comunitarias → Ciencias Sociales
    /// d) Escenarios creativos (teatro, música, diseño) → Artes
    /// e) Campos de cultivo, naturaleza → Agricultura
    /// f) Laboratorios, taller, Escenarios de campo → Ciencias naturales
    /// </summary>
    public class ReglaP8Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.respuestaNo8 == "a" || r.respuestaNo8 == "b" || r.respuestaNo8 == "c" ||
                    r.respuestaNo8 == "d" || r.respuestaNo8 == "e" || r.respuestaNo8 == "f")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP8(respuestas.respuestaNo8, puntajes));
        }

        private static void ProcesarRespuestaP8(string respuesta, PuntajeArea puntajes)
        {
            ///SE TIENE QUE QUITAR, a fin de cuentas solo importa la respuesta
            Preguntas preguntas = new Preguntas();
            Console.WriteLine(preguntas.preguntaNo8);
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosIngenieria(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P8: +2 Ingenierías, +1 Ciencias de la Salud");
                    break;
                case "b":
                    puntajes.sumarPuntosHumanidades(3);
                    Console.WriteLine("P8: +3 Humanidades");
                    break;
                case "c":
                    puntajes.sumarPuntosCienciasSociales(3);
                    Console.WriteLine("P8: +3 Ciencias Sociales");
                    break;
                case "d":
                    puntajes.sumarPuntosArtes(3);
                    Console.WriteLine("P8: +3 Artes");
                    break;
                case "e":
                    puntajes.sumarPuntosCienciasDeLaVida(3);
                    Console.WriteLine("P8: +3 Ciencias de la Vida");
                    break;
                case "f":
                    puntajes.sumarPuntosCienciasNaturales(3);
                    Console.WriteLine("P8: +3 Ciencias Naturales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 9: ¿En qué te visualizas trabajando en el futuro?
    /// a) Diseñando soluciones técnicas o tecnológicas → Ingenierías
    /// b) Investigando o resolviendo problemas sociales → Ciencias Sociales
    /// c) Enseñando, escribiendo o investigando ideas → Humanidades
    /// d) Tratando pacientes o investigando enfermedades → Salud
    /// e) Creando arte, diseño o música → Artes
    /// f) Cultivando, investigando plantas o cuidando animales → Agricultura
    /// g) Experimentando, Investigando, Crear nuevos componentes → Ciencias naturales
    /// </summary>
    public class ReglaP9Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.respuestaNo9 == "a" || r.respuestaNo9 == "b" || r.respuestaNo9 == "c" ||
                    r.respuestaNo9 == "d" || r.respuestaNo9 == "e" || r.respuestaNo9 == "f" || r.respuestaNo9 == "g")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP9(respuestas.respuestaNo9, puntajes));
        }

        private static void ProcesarRespuestaP9(string respuesta, PuntajeArea puntajes)
        {
            ///SE TIENE QUE QUITAR, a fin de cuentas solo importa la respuesta
            Preguntas preguntas = new Preguntas();
            Console.WriteLine(preguntas.preguntaNo9);
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosIngenieria(3);
                    Console.WriteLine("P9: +3 Ingenierías");
                    break;
                case "b":
                    puntajes.sumarPuntosCienciasSociales(3);
                    Console.WriteLine("P9: +3 Ciencias Sociales");
                    break;
                case "c":
                    puntajes.sumarPuntosHumanidades(3);
                    Console.WriteLine("P9: +3 Humanidades");
                    break;
                case "d":
                    puntajes.sumarPuntosCienciasSalud(3);
                    Console.WriteLine("P9: +3 Ciencias de la Salud");
                    break;
                case "e":
                    puntajes.sumarPuntosArtes(3);
                    Console.WriteLine("P9: +3 Artes");
                    break;
                case "f":
                    puntajes.sumarPuntosCienciasDeLaVida(3);
                    Console.WriteLine("P9: +3 Ciencias de la Vida");
                    break;
                case "g":
                    puntajes.sumarPuntosCienciasNaturales(3);
                    Console.WriteLine("P9: +3 Ciencias Naturales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 10: Si tuvieras que elegir un rol en un equipo de trabajo, serías…
    /// a) El que diseña o construye → Ingenierías
    /// b) El que organiza, media y negocia → Ciencias Sociales
    /// c) El que reflexiona y propone ideas → Humanidades
    /// d) El que cuida la salud y bienestar → Salud
    /// e) El que inspira con creatividad → Artes
    /// f) El que conecta con la naturaleza → Agricultura
    /// g) El que conecta con el entendimiento del entorno → Ciencias naturales
    /// </summary>
    public class ReglaP10Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.respuestaNo10 == "a" || r.respuestaNo10 == "b" || r.respuestaNo10 == "c" ||
                    r.respuestaNo10 == "d" || r.respuestaNo10 == "e" || r.respuestaNo10 == "f" || r.respuestaNo10 == "g")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP10(respuestas.respuestaNo10, puntajes));
        }

        private static void ProcesarRespuestaP10(string respuesta, PuntajeArea puntajes)
        {
            ///SE TIENE QUE QUITAR, a fin de cuentas solo importa la respuesta
            Preguntas preguntas = new Preguntas();
            Console.WriteLine(preguntas.preguntaNo10);
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosIngenieria(3);
                    Console.WriteLine("P10: +3 Ingenierías");
                    break;
                case "b":
                    puntajes.sumarPuntosCienciasSociales(3);
                    Console.WriteLine("P10: +3 Ciencias Sociales");
                    break;
                case "c":
                    puntajes.sumarPuntosHumanidades(3);
                    Console.WriteLine("P10: +3 Humanidades");
                    break;
                case "d":
                    puntajes.sumarPuntosCienciasSalud(3);
                    Console.WriteLine("P10: +3 Ciencias de la Salud");
                    break;
                case "e":
                    puntajes.sumarPuntosArtes(3);
                    Console.WriteLine("P10: +3 Artes");
                    break;
                case "f":
                    puntajes.sumarPuntosCienciasDeLaVida(3);
                    Console.WriteLine("P10: +3 Ciencias de la Vida");
                    break;
                case "g":
                    puntajes.sumarPuntosCienciasNaturales(3);
                    Console.WriteLine("P10: +3 Ciencias Naturales");
                    break;
            }
        }
    }

    /// <summary>
    /// //
    /// </summary>
    /// 


    // Motor de inferencia
    public class MotorOrientacionVocacional
    {
        public static (string AreaGanadora, PuntajeArea Puntajes) DeterminarAreaEnfasis(
            string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10)
        {
            // Crear el repositorio de reglas
            var repository = new RuleRepository();
            repository.Load(x => x.From(typeof(ReglaP1Consolidada).Assembly));

            // Compilar las reglas
            var factory = repository.Compile();

            // Crear una sesión de reglas
            var session = factory.CreateSession();

            // Crear los hechos (facts)
            var respuestas = new RespuestaUsuario
            {
                respuestaNo1 = p1,
                respuestaNo2 = p2,
                respuestaNo3 = p3,
                respuestaNo4 = p4,
                respuestaNo5 = p5,
                respuestaNo6 = p6,
                respuestaNo7 = p7,
                respuestaNo8 = p8,
                respuestaNo9 = p9,
                respuestaNo10 = p10,
            };

            var puntajes = new PuntajeArea();
            puntajes.ReiniciarPuntajes();

            // Insertar los hechos en la sesión
            session.Insert(respuestas);
            session.Insert(puntajes);

            // Ejecutar las reglas
            session.Fire();

            return (puntajes.ObtenerAreaGanadora(), puntajes);
        }
    }

    

    internal class Program
    {
        static void ejemplo(string[] args)
        {
            Console.WriteLine("SISTEMA DE ORIENTACIÓN VOCACIONAL\n");

            // Ejemplo 1: Perfil de Ingenierías
            Console.WriteLine("=== EJEMPLO 1: Perfil Ingenierías");
            var resultado1 = MotorOrientacionVocacional.DeterminarAreaEnfasis("a", "a","a","a","b","c","d","e","f","d");
            MostrarResultado(resultado1);

            // Ejemplo 2: Perfil de Artes
            Console.WriteLine("\n=== EJEMPLO 2: Perfil Artes");
            var resultado2 = MotorOrientacionVocacional.DeterminarAreaEnfasis("a", "b","c","d","d","d","d","e","f","d");
            MostrarResultado(resultado2);

            // Ejemplo 3: Perfil mixto
            Console.WriteLine("\n=== EJEMPLO 3: Perfil Mixto");
            var resultado3 = MotorOrientacionVocacional.DeterminarAreaEnfasis("e", "e", "a", "a", "b", "c", "d", "e", "f", "f");
            MostrarResultado(resultado3);
        }

        static void MostrarResultado((string AreaGanadora, PuntajeArea Puntajes) resultado)
        {
            Console.WriteLine($"\nPUNTAJES FINALES:");
            Console.WriteLine($"   Ingenierías: {resultado.Puntajes.puntajeIngenieria}");
            Console.WriteLine($"   Ciencias de la Salud: {resultado.Puntajes.puntajeCienciasSalud}");
            Console.WriteLine($"   Humanidades: {resultado.Puntajes.puntajeHumanidades}");
            Console.WriteLine($"   Ciencias Sociales: {resultado.Puntajes.puntajeCienciasSociales}");
            Console.WriteLine($"   Artes: {resultado.Puntajes.puntajeArtes}");
            Console.WriteLine($"   Agricultura: {resultado.Puntajes.puntajeCienciasNaturales}");
            Console.WriteLine($"   Ciencias Naturales: {resultado.Puntajes.puntajeCienciasDeLaVida}");

            Console.WriteLine($"\n ÁREA DE ÉNFASIS RECOMENDADA: {resultado.AreaGanadora}");
        }
    }

     
    }