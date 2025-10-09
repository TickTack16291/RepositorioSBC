namespace Reglas
{
    using NRules;
    using NRules.Fluent;
    using System;
    using System.Linq;
    using System.Windows.Documents;
    using System.Collections.Generic;

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
        public string preguntaNo11 { get; set; } = "";
        public string preguntaNo12 { get; set; } = "";
        public string preguntaNo13 { get; set; } = "";
        public string preguntaNo14 { get; set; } = "";
        public string preguntaNo15 { get; set; } = "";
        public string preguntaNo16 { get; set; } = "";
        public string preguntaNo17 { get; set; } = "";
        public string preguntaNo18 { get; set; } = "";
        public string preguntaNo19 { get; set; } = "";
        public string preguntaNo20 { get; set; } = "";
        public string preguntaNo21 { get; set; } = "";
        public string preguntaNo22 { get; set; } = "";
        public string preguntaNo23 { get; set; } = "";
        public string preguntaNo24 { get; set; } = "";
        public string preguntaNo25 { get; set; } = "";
        public string preguntaNo26 { get; set; } = "";
        public string preguntaNo27 { get; set; } = "";
        public string preguntaNo28 { get; set; } = "";
        public string preguntaNo29 { get; set; } = "";
        public string preguntaNo30 { get; set; } = "";
        public string preguntaNo31 { get; set; } = "";
        public string preguntaNo32 { get; set; } = "";
        public string preguntaNo33 { get; set; } = "";
        public string preguntaNo34 { get; set; } = "";
        public string preguntaNo35 { get; set; } = "";
        public string preguntaNo36 { get; set; } = "";
        public string preguntaNo37 { get; set; } = "";
        public string preguntaNo38 { get; set; } = "";
        public string preguntaNo39 { get; set; } = "";
        public string preguntaNo40 { get; set; } = "";
        public string preguntaNo41 { get; set; } = "";
        public string preguntaNo42 { get; set; } = "";
        public string preguntaNo43 { get; set; } = "";
        public string preguntaNo44 { get; set; } = "";
        public string preguntaNo45 { get; set; } = "";
        public string preguntaNo46 { get; set; } = "";
        public string preguntaNo47 { get; set; } = "";
        public string preguntaNo48 { get; set; } = "";
        public string preguntaNo49 { get; set; } = "";
        public string preguntaNo50 { get; set; } = "";
        public string preguntaNo51 { get; set; } = "";
        public string preguntaNo52 { get; set; } = "";
    }

    public class PuntajeArea
    {
        // Áreas generales
        public int puntajeIngenieria { get; set; }
        public int puntajeCienciasSalud { get; set; }
        public int puntajeHumanidades { get; set; }
        public int puntajeCienciasSociales { get; set; }
        public int puntajeArtes { get; set; }
        public int puntajeCienciasNaturales { get; set; }
        public int puntajeCienciasDeLaVida { get; set; }

        // Ingenierías
        public int puntajeRobotica { get; set; }
        public int puntajeMecanica { get; set; }
        public int puntajeCienciasComputacionales { get; set; }
        public int puntajeIngenieriaSoftware { get; set; }
        public int puntajeIngenieriaCivil { get; set; }
        public int puntajeIngenieriaIndustrial { get; set; }
        public int puntajeIngenieriaAlimentos { get; set; }
        public int puntajeIngenieriaMineroMetalurgica { get; set; }
        public int puntajeIngenieriaMateriales { get; set; }
        public int puntajeIngenieriaTelecomunicaciones { get; set; }
        public int puntajeIngenieriaBiotecnologia { get; set; }

        // Artes
        public int puntajeArtesVisuales { get; set; }
        public int puntajeDanza { get; set; }
        public int puntajeDisenoGrafico { get; set; }
        public int puntajeMusica { get; set; }
        public int puntajeTeatro { get; set; }

        // Humanidades
        public int puntajeAntropologiaSocial { get; set; }
        public int puntajeArquitectura { get; set; }
        public int puntajeEnsenanzaLenguaInglesa { get; set; }
        public int puntajeHistoriaMexico { get; set; }
        public int puntajeInnovacionTecnologiaEducativa { get; set; }

        // Ciencias de la Salud
        public int puntajeCirujanoDentista { get; set; }
        public int puntajeEnfermeria { get; set; }
        public int puntajeFarmacia { get; set; }
        public int puntajeGerontologia { get; set; }
        public int puntajeMedicina { get; set; }
        public int puntajeNutricion { get; set; }
        public int puntajePsicologia { get; set; }

        // Ciencias Sociales
        public int puntajeAdministracion { get; set; }
        public int puntajeDerecho { get; set; }
        public int puntajeCienciasEducacion { get; set; }
        public int puntajeSociologia { get; set; }
        public int puntajeMercadotecnia { get; set; }
        public int puntajeContaduria { get; set; }
        public int puntajePlaneacionDesarrolloRegional { get; set; }
        public int puntajeComercioExterior { get; set; }
        public int puntajeComunicacion { get; set; }
        public int puntajeTrabajoSocial { get; set; }
        public int puntajeGastronomia { get; set; }
        public int puntajeTurismo { get; set; }
        public int puntajeEconomia { get; set; }
        public int puntajeCienciaPoliticaAdminPublica { get; set; }
        public int puntajeCreacionDesarrolloEmpresas { get; set; }
        public int puntajeIngenieriaEconomicaFinanciera { get; set; }

        // Ciencias Naturales
        public int puntajeBiologia { get; set; }
        public int puntajeFisicaTecnologiaAvanzada { get; set; }
        public int puntajeMatematicasAplicadas { get; set; }
        public int puntajeQuimica { get; set; }

        // Ciencias de la Vida
        public int puntajeGestionNegociosAgropecuarios { get; set; }
        public int puntajeIngenieriaAgroindustrial { get; set; }
        public int puntajeIngenieriaAgronomiaProduccionSustentable { get; set; }
        public int puntajeIngenieriaForestal { get; set; }
        public int puntajeMedicinaVeterinariaZootecnia { get; set; }
        public int puntajeQuimicaAlimentos { get; set; }

        // Métodos para sumar puntos
        public void sumarPuntosIngenieria(int puntos) => puntajeIngenieria += puntos;
        public void sumarPuntosCienciasSalud(int puntos) => puntajeCienciasSalud += puntos;
        public void sumarPuntosHumanidades(int puntos) => puntajeHumanidades += puntos;
        public void sumarPuntosCienciasSociales(int puntos) => puntajeCienciasSociales += puntos;
        public void sumarPuntosArtes(int puntos) => puntajeArtes += puntos;
        public void sumarPuntosCienciasNaturales(int puntos) => puntajeCienciasNaturales += puntos;
        public void sumarPuntosCienciasDeLaVida(int puntos) => puntajeCienciasDeLaVida += puntos;

        // Ingenierías
        public void sumarPuntosRobotica(int puntos) => puntajeRobotica += puntos;
        public void sumarPuntosMecanica(int puntos) => puntajeMecanica += puntos;
        public void sumarPuntosCienciasComputacionales(int puntos) => puntajeCienciasComputacionales += puntos;
        public void sumarPuntosIngenieriaSoftware(int puntos) => puntajeIngenieriaSoftware += puntos;
        public void sumarPuntosIngenieriaCivil(int puntos) => puntajeIngenieriaCivil += puntos;
        public void sumarPuntosIngenieriaIndustrial(int puntos) => puntajeIngenieriaIndustrial += puntos;
        public void sumarPuntosIngenieriaAlimentos(int puntos) => puntajeIngenieriaAlimentos += puntos;
        public void sumarPuntosIngenieriaMineroMetalurgica(int puntos) => puntajeIngenieriaMineroMetalurgica += puntos;
        public void sumarPuntosIngenieriaMateriales(int puntos) => puntajeIngenieriaMateriales += puntos;
        public void sumarPuntosIngenieriaTelecomunicaciones(int puntos) => puntajeIngenieriaTelecomunicaciones += puntos;
        public void sumarPuntosIngenieriaBiotecnologia(int puntos) => puntajeIngenieriaBiotecnologia += puntos;

        // Artes
        public void sumarPuntosArtesVisuales(int puntos) => puntajeArtesVisuales += puntos;
        public void sumarPuntosDanza(int puntos) => puntajeDanza += puntos;
        public void sumarPuntosDisenoGrafico(int puntos) => puntajeDisenoGrafico += puntos;
        public void sumarPuntosMusica(int puntos) => puntajeMusica += puntos;
        public void sumarPuntosTeatro(int puntos) => puntajeTeatro += puntos;

        // Humanidades
        public void sumarPuntosAntropologiaSocial(int puntos) => puntajeAntropologiaSocial += puntos;
        public void sumarPuntosArquitectura(int puntos) => puntajeArquitectura += puntos;
        public void sumarPuntosEnsenanzaLenguaInglesa(int puntos) => puntajeEnsenanzaLenguaInglesa += puntos;
        public void sumarPuntosHistoriaMexico(int puntos) => puntajeHistoriaMexico += puntos;
        public void sumarPuntosInnovacionTecnologiaEducativa(int puntos) => puntajeInnovacionTecnologiaEducativa += puntos;

        // Ciencias de la Salud
        public void sumarPuntosCirujanoDentista(int puntos) => puntajeCirujanoDentista += puntos;
        public void sumarPuntosEnfermeria(int puntos) => puntajeEnfermeria += puntos;
        public void sumarPuntosFarmacia(int puntos) => puntajeFarmacia += puntos;
        public void sumarPuntosGerontologia(int puntos) => puntajeGerontologia += puntos;
        public void sumarPuntosMedicina(int puntos) => puntajeMedicina += puntos;
        public void sumarPuntosNutricion(int puntos) => puntajeNutricion += puntos;
        public void sumarPuntosPsicologia(int puntos) => puntajePsicologia += puntos;

        // Ciencias Sociales
        public void sumarPuntosAdministracion(int puntos) => puntajeAdministracion += puntos;
        public void sumarPuntosDerecho(int puntos) => puntajeDerecho += puntos;
        public void sumarPuntosCienciasEducacion(int puntos) => puntajeCienciasEducacion += puntos;
        public void sumarPuntosSociologia(int puntos) => puntajeSociologia += puntos;
        public void sumarPuntosMercadotecnia(int puntos) => puntajeMercadotecnia += puntos;
        public void sumarPuntosContaduria(int puntos) => puntajeContaduria += puntos;
        public void sumarPuntosPlaneacionDesarrolloRegional(int puntos) => puntajePlaneacionDesarrolloRegional += puntos;
        public void sumarPuntosComercioExterior(int puntos) => puntajeComercioExterior += puntos;
        public void sumarPuntosComunicacion(int puntos) => puntajeComunicacion += puntos;
        public void sumarPuntosTrabajoSocial(int puntos) => puntajeTrabajoSocial += puntos;
        public void sumarPuntosGastronomia(int puntos) => puntajeGastronomia += puntos;
        public void sumarPuntosTurismo(int puntos) => puntajeTurismo += puntos;
        public void sumarPuntosEconomia(int puntos) => puntajeEconomia += puntos;
        public void sumarPuntosCienciaPoliticaAdminPublica(int puntos) => puntajeCienciaPoliticaAdminPublica += puntos;
        public void sumarPuntosCreacionDesarrolloEmpresas(int puntos) => puntajeCreacionDesarrolloEmpresas += puntos;
        public void sumarPuntosIngenieriaEconomicaFinanciera(int puntos) => puntajeIngenieriaEconomicaFinanciera += puntos;

        // Ciencias Naturales
        public void sumarPuntosBiologia(int puntos) => puntajeBiologia += puntos;
        public void sumarPuntosFisicaTecnologiaAvanzada(int puntos) => puntajeFisicaTecnologiaAvanzada += puntos;
        public void sumarPuntosMatematicasAplicadas(int puntos) => puntajeMatematicasAplicadas += puntos;
        public void sumarPuntosQuimica(int puntos) => puntajeQuimica += puntos;

        // Ciencias de la Vida
        public void sumarPuntosGestionNegociosAgropecuarios(int puntos) => puntajeGestionNegociosAgropecuarios += puntos;
        public void sumarPuntosIngenieriaAgroindustrial(int puntos) => puntajeIngenieriaAgroindustrial += puntos;
        public void sumarPuntosIngenieriaAgronomiaProduccionSustentable(int puntos) => puntajeIngenieriaAgronomiaProduccionSustentable += puntos;
        public void sumarPuntosIngenieriaForestal(int puntos) => puntajeIngenieriaForestal += puntos;
        public void sumarPuntosMedicinaVeterinariaZootecnia(int puntos) => puntajeMedicinaVeterinariaZootecnia += puntos;
        public void sumarPuntosQuimicaAlimentos(int puntos) => puntajeQuimicaAlimentos += puntos;

        public void ReiniciarPuntajes()
        {
            // Reiniciar todos los puntajes a 0
            var propiedades = this.GetType().GetProperties();
            foreach (var propiedad in propiedades)
            {
                if (propiedad.PropertyType == typeof(int))
                {
                    propiedad.SetValue(this, 0);
                }
            }
        }

        public string ObtenerAreaGanadora()
        {
            var puntajes = new[]
            {
                (Area: "Ingenierías", Puntaje: puntajeIngenieria),
                (Area: "Ciencias de la Salud", Puntaje: puntajeCienciasSalud),
                (Area: "Humanidades", Puntaje: puntajeHumanidades),
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

        public string ObtenerEspecialidadIngenieriaGanadora()
        {
            var especialidades = new[]
            {
                ("Robótica", puntajeRobotica),
                ("Mecánica", puntajeMecanica),
                ("Ciencias Computacionales", puntajeCienciasComputacionales),
                ("Ingeniería de Software", puntajeIngenieriaSoftware),
                ("Ingeniería Civil", puntajeIngenieriaCivil),
                ("Ingeniería Industrial", puntajeIngenieriaIndustrial),
                ("Ingeniería en Alimentos", puntajeIngenieriaAlimentos),
                ("Ingeniería Minero Metalúrgica", puntajeIngenieriaMineroMetalurgica),
                ("Ingeniería en Materiales", puntajeIngenieriaMateriales),
                ("Ingeniería en Telecomunicaciones", puntajeIngenieriaTelecomunicaciones),
                ("Ingeniería en Biotecnología", puntajeIngenieriaBiotecnologia)
            };

            return ObtenerEspecialidadGanadora(especialidades);
        }

        public string ObtenerEspecialidadArtesGanadora()
        {
            var especialidades = new[]
            {
                ("Artes Visuales", puntajeArtesVisuales),
                ("Danza", puntajeDanza),
                ("Diseño Gráfico", puntajeDisenoGrafico),
                ("Música", puntajeMusica),
                ("Teatro", puntajeTeatro)
            };

            return ObtenerEspecialidadGanadora(especialidades);
        }

        public string ObtenerEspecialidadHumanidadesGanadora()
        {
            var especialidades = new[]
            {
                ("Antropología Social", puntajeAntropologiaSocial),
                ("Arquitectura", puntajeArquitectura),
                ("Enseñanza de la Lengua Inglesa", puntajeEnsenanzaLenguaInglesa),
                ("Historia de México", puntajeHistoriaMexico),
                ("Innovación y Tecnología Educativa", puntajeInnovacionTecnologiaEducativa)
            };

            return ObtenerEspecialidadGanadora(especialidades);
        }

        public string ObtenerEspecialidadCienciasSaludGanadora()
        {
            var especialidades = new[]
            {
                ("Cirujano Dentista", puntajeCirujanoDentista),
                ("Enfermería", puntajeEnfermeria),
                ("Farmacia", puntajeFarmacia),
                ("Gerontología", puntajeGerontologia),
                ("Medicina", puntajeMedicina),
                ("Nutrición", puntajeNutricion),
                ("Psicología", puntajePsicologia)
            };

            return ObtenerEspecialidadGanadora(especialidades);
        }

        public string ObtenerEspecialidadCienciasSocialesGanadora()
        {
            var especialidades = new[]
            {
                ("Administración", puntajeAdministracion),
                ("Derecho", puntajeDerecho),
                ("Ciencias de la Educación", puntajeCienciasEducacion),
                ("Sociología", puntajeSociologia),
                ("Mercadotecnia", puntajeMercadotecnia),
                ("Contaduría", puntajeContaduria),
                ("Planeación y Desarrollo Regional", puntajePlaneacionDesarrolloRegional),
                ("Comercio Exterior", puntajeComercioExterior),
                ("Comunicación", puntajeComunicacion),
                ("Trabajo Social", puntajeTrabajoSocial),
                ("Gastronomía", puntajeGastronomia),
                ("Turismo", puntajeTurismo),
                ("Economía", puntajeEconomia),
                ("Ciencia Política y Administración Pública", puntajeCienciaPoliticaAdminPublica),
                ("Creación y Desarrollo de Empresas", puntajeCreacionDesarrolloEmpresas),
                ("Ingeniería Económica y Financiera", puntajeIngenieriaEconomicaFinanciera)
            };

            return ObtenerEspecialidadGanadora(especialidades);
        }

        public string ObtenerEspecialidadCienciasNaturalesGanadora()
        {
            var especialidades = new[]
            {
                ("Biología", puntajeBiologia),
                ("Física y Tecnología Avanzada", puntajeFisicaTecnologiaAvanzada),
                ("Matemáticas Aplicadas", puntajeMatematicasAplicadas),
                ("Química", puntajeQuimica)
            };

            return ObtenerEspecialidadGanadora(especialidades);
        }

        public string ObtenerEspecialidadCienciasVidaGanadora()
        {
            var especialidades = new[]
            {
                ("Gestión de Negocios Agropecuarios", puntajeGestionNegociosAgropecuarios),
                ("Ingeniería Agroindustrial", puntajeIngenieriaAgroindustrial),
                ("Ingeniería en Agronomía para la Producción Sustentable", puntajeIngenieriaAgronomiaProduccionSustentable),
                ("Ingeniería Forestal", puntajeIngenieriaForestal),
                ("Medicina Veterinaria y Zootecnia", puntajeMedicinaVeterinariaZootecnia),
                ("Química de Alimentos", puntajeQuimicaAlimentos)
            };

            return ObtenerEspecialidadGanadora(especialidades);
        }

        private string ObtenerEspecialidadGanadora((string Especialidad, int Puntaje)[] especialidades)
        {
            var maxPuntaje = especialidades.Max(e => e.Puntaje);
            var especialidadesGanadoras = especialidades.Where(e => e.Puntaje == maxPuntaje).ToList();

            if (especialidadesGanadoras.Count == 0 || maxPuntaje == 0)
                return "SinDeterminar";

            return especialidadesGanadoras.Count == 1
                ? especialidadesGanadoras[0].Especialidad
                : $"Empate entre: {string.Join(", ", especialidadesGanadoras.Select(e => e.Especialidad))}";
        }

        public List<string> ObtenerAreasGanadoras()
        {
            var puntajes = new[]
            {
            ("Ingenierías", puntajeIngenieria),
            ("Ciencias de la Salud", puntajeCienciasSalud),
            ("Humanidades", puntajeHumanidades),
            ("Ciencias Sociales", puntajeCienciasSociales),
            ("Artes", puntajeArtes),
            ("Ciencias Naturales", puntajeCienciasNaturales),
            ("Ciencias de la Vida", puntajeCienciasDeLaVida)
            };

            var maxPuntaje = puntajes.Max(p => p.Item2);
            if (maxPuntaje == 0)
                return new List<string> { "SinDeterminar" };
            var areasGanadoras = puntajes.Where(p => p.Item2 == maxPuntaje).Select(p => p.Item1).ToList();
            return areasGanadoras;
        }

        public List<string> ObtenerTopDosAreas()
        {
            var puntajes = new[]
            {
            ("Ingenierías", puntajeIngenieria),
            ("Ciencias de la Salud", puntajeCienciasSalud),
            ("Humanidades", puntajeHumanidades),
            ("Ciencias Sociales", puntajeCienciasSociales),
            ("Artes", puntajeArtes),
            ("Ciencias Naturales", puntajeCienciasNaturales),
            ("Ciencias de la Vida", puntajeCienciasDeLaVida)
        };

            return puntajes.OrderByDescending(p => p.Item2)
                          .Take(2)
                          .Select(p => p.Item1)
                          .ToList();
        }
    
}

    // REGLAS GENERALES (P1 a P10)

    /// <summary>
    /// Pregunta 1: ¿Qué asignaturas disfrutas más en la preparatoria?
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
        {
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
        {
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

    // REGLAS PARA ESPECIALIDADES DE INGERNIERIA (P11 a P17)

    /// <summary>
    /// Pregunta 11: ¿Qué tipo de sistemas te interesa más diseñar o mejorar?
    /// </summary>
    public class ReglaP11Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo11 == "a" || r.preguntaNo11 == "b" || r.preguntaNo11 == "c" ||
                    r.preguntaNo11 == "d" || r.preguntaNo11 == "e" || r.preguntaNo11 == "f" ||
                    r.preguntaNo11 == "g" || r.preguntaNo11 == "h" || r.preguntaNo11 == "i")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP11(respuestas.preguntaNo11, puntajes));
        }

        private static void ProcesarRespuestaP11(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a": // Sistemas mecánicos y robots
                    puntajes.sumarPuntosRobotica(2);
                    puntajes.sumarPuntosMecanica(1);
                    Console.WriteLine("P11: +2 Robótica, +1 Mecánica");
                    break;
                case "b": // Sistemas de software y aplicaciones
                    puntajes.sumarPuntosCienciasComputacionales(2);
                    puntajes.sumarPuntosIngenieriaSoftware(2);
                    Console.WriteLine("P11: +2 Ciencias Computacionales, +2 Ingeniería de Software");
                    break;
                case "c": // Estructuras y edificios
                    puntajes.sumarPuntosIngenieriaCivil(2);
                    Console.WriteLine("P11: +2 Ingeniería Civil");
                    break;
                case "d": // Procesos industriales y de producción
                    puntajes.sumarPuntosIngenieriaIndustrial(2);
                    Console.WriteLine("P11: +2 Ingeniería Industrial");
                    break;
                case "e": // Procesos de producción de alimentos
                    puntajes.sumarPuntosIngenieriaAlimentos(2);
                    Console.WriteLine("P11: +2 Ingeniería en Alimentos");
                    break;
                case "f": // Procesos de extracción y tratamiento de minerales
                    puntajes.sumarPuntosIngenieriaMineroMetalurgica(2);
                    Console.WriteLine("P11: +2 Ingeniería Minero Metalúrgica");
                    break;
                case "g": // Desarrollo de nuevos materiales
                    puntajes.sumarPuntosIngenieriaMateriales(2);
                    Console.WriteLine("P11: +2 Ingeniería en Materiales");
                    break;
                case "h": // Sistemas de comunicación y redes
                    puntajes.sumarPuntosIngenieriaTelecomunicaciones(2);
                    Console.WriteLine("P11: +2 Ingeniería en Telecomunicaciones");
                    break;
                case "i": // Procesos biológicos y biotecnológicos
                    puntajes.sumarPuntosIngenieriaBiotecnologia(2);
                    Console.WriteLine("P11: +2 Ingeniería en Biotecnología");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 12: ¿En que ambiente prefieres trabajar?
    /// </summary>
    public class ReglaP12Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo12 == "a" || r.preguntaNo12 == "b" || r.preguntaNo12 == "c" ||
                    r.preguntaNo12 == "d" || r.preguntaNo12 == "e" || r.preguntaNo12 == "f" ||
                    r.preguntaNo12 == "g" || r.preguntaNo12 == "h" || r.preguntaNo12 == "i")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP12(respuestas.preguntaNo12, puntajes));
        }

        private static void ProcesarRespuestaP12(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a": // Laboratorio de robótica o automatización
                    puntajes.sumarPuntosRobotica(2);
                    Console.WriteLine("P12: +2 Robótica");
                    break;
                case "b": // Oficina con computadoras
                    puntajes.sumarPuntosCienciasComputacionales(2);
                    puntajes.sumarPuntosIngenieriaSoftware(2);
                    Console.WriteLine("P12: +2 Ciencias Computacionales, +2 Ingeniería de Software");
                    break;
                case "c": // Obras de construcción
                    puntajes.sumarPuntosIngenieriaCivil(2);
                    Console.WriteLine("P12: +2 Ingeniería Civil");
                    break;
                case "d": // Plantas industriales
                    puntajes.sumarPuntosIngenieriaIndustrial(2);
                    Console.WriteLine("P12: +2 Ingeniería Industrial");
                    break;
                case "e": // Plantas procesadoras de alimentos
                    puntajes.sumarPuntosIngenieriaAlimentos(2);
                    Console.WriteLine("P12: +2 Ingeniería en Alimentos");
                    break;
                case "f": // Minas o plantas metalúrgicas
                    puntajes.sumarPuntosIngenieriaMineroMetalurgica(2);
                    Console.WriteLine("P12: +2 Ingeniería Minero Metalúrgica");
                    break;
                case "g": // Laboratorio de materiales
                    puntajes.sumarPuntosIngenieriaMateriales(2);
                    Console.WriteLine("P12: +2 Ingeniería en Materiales");
                    break;
                case "h": // Centros de telecomunicaciones
                    puntajes.sumarPuntosIngenieriaTelecomunicaciones(2);
                    Console.WriteLine("P12: +2 Ingeniería en Telecomunicaciones");
                    break;
                case "i": // Laboratorio biotecnológico
                    puntajes.sumarPuntosIngenieriaBiotecnologia(2);
                    Console.WriteLine("P12: +2 Ingeniería en Biotecnología");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 13: ¿Qué habilidad te sientes más cómodo desarrollando?
    /// </summary>
    public class ReglaP13Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo13 == "a" || r.preguntaNo13 == "b" || r.preguntaNo13 == "c" ||
                    r.preguntaNo13 == "d" || r.preguntaNo13 == "e" || r.preguntaNo13 == "f" ||
                    r.preguntaNo13 == "g" || r.preguntaNo13 == "h" || r.preguntaNo13 == "i")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP13(respuestas.preguntaNo13, puntajes));
        }

        private static void ProcesarRespuestaP13(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a": // Programación de robots y sistemas automáticos
                    puntajes.sumarPuntosRobotica(2);
                    Console.WriteLine("P13: +2 Robótica");
                    break;
                case "b": // Programación de software
                    puntajes.sumarPuntosCienciasComputacionales(2);
                    puntajes.sumarPuntosIngenieriaSoftware(2);
                    Console.WriteLine("P13: +2 Ciencias Computacionales, +2 Ingeniería de Software");
                    break;
                case "c": // Diseño estructural y planos
                    puntajes.sumarPuntosIngenieriaCivil(2);
                    Console.WriteLine("P13: +2 Ingeniería Civil");
                    break;
                case "d": // Optimización de procesos y gestión
                    puntajes.sumarPuntosIngenieriaIndustrial(2);
                    Console.WriteLine("P13: +2 Ingeniería Industrial");
                    break;
                case "e": // Control de calidad y procesos alimentarios
                    puntajes.sumarPuntosIngenieriaAlimentos(2);
                    Console.WriteLine("P13: +2 Ingeniería en Alimentos");
                    break;
                case "f": // Análisis de minerales y metales
                    puntajes.sumarPuntosIngenieriaMineroMetalurgica(2);
                    Console.WriteLine("P13: +2 Ingeniería Minero Metalúrgica");
                    break;
                case "g": // Análisis y síntesis de materiales
                    puntajes.sumarPuntosIngenieriaMateriales(2);
                    Console.WriteLine("P13: +2 Ingeniería en Materiales");
                    break;
                case "h": // Diseño de redes y comunicaciones
                    puntajes.sumarPuntosIngenieriaTelecomunicaciones(2);
                    Console.WriteLine("P13: +2 Ingeniería en Telecomunicaciones");
                    break;
                case "i": // Manipulación de organismos y bioprocesos
                    puntajes.sumarPuntosIngenieriaBiotecnologia(2);
                    Console.WriteLine("P13: +2 Ingeniería en Biotecnología");
                    break;
            }
        }
    }

    /// Pregunta 14: ¿Qué tipo de problemas te gustaría resolver?
    /// </summary>
    public class ReglaP14Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo14 == "a" || r.preguntaNo14 == "b" || r.preguntaNo14 == "c" ||
                    r.preguntaNo14 == "d" || r.preguntaNo14 == "e" || r.preguntaNo14 == "f" ||
                    r.preguntaNo14 == "g" || r.preguntaNo14 == "h" || r.preguntaNo14 == "i")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP14(respuestas.preguntaNo14, puntajes));
        }

        private static void ProcesarRespuestaP14(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a": // Automatización de tareas repetitivas
                    puntajes.sumarPuntosRobotica(2);
                    Console.WriteLine("P14: +2 Robótica");
                    break;
                case "b": // Creación de algoritmos eficientes
                    puntajes.sumarPuntosCienciasComputacionales(2);
                    puntajes.sumarPuntosIngenieriaSoftware(2);
                    Console.WriteLine("P14: +2 Ciencias Computacionales, +2 Ingeniería de Software");
                    break;
                case "c": // Diseño de infraestructuras resistentes
                    puntajes.sumarPuntosIngenieriaCivil(2);
                    Console.WriteLine("P14: +2 Ingeniería Civil");
                    break;
                case "d": // Mejora de la eficiencia en producción
                    puntajes.sumarPuntosIngenieriaIndustrial(2);
                    Console.WriteLine("P14: +2 Ingeniería Industrial");
                    break;
                case "e": // Conservación y procesamiento de alimentos
                    puntajes.sumarPuntosIngenieriaAlimentos(2);
                    Console.WriteLine("P14: +2 Ingeniería en Alimentos");
                    break;
                case "f": // Extracción y purificación de metales
                    puntajes.sumarPuntosIngenieriaMineroMetalurgica(2);
                    Console.WriteLine("P14: +2 Ingeniería Minero Metalúrgica");
                    break;
                case "g": // Desarrollo de materiales más ligeros o resistentes
                    puntajes.sumarPuntosIngenieriaMateriales(2);
                    Console.WriteLine("P14: +2 Ingeniería en Materiales");
                    break;
                case "h": // Mejora de la comunicación inalámbrica
                    puntajes.sumarPuntosIngenieriaTelecomunicaciones(2);
                    Console.WriteLine("P14: +2 Ingeniería en Telecomunicaciones");
                    break;
                case "i": // Desarrollo de productos biológicos
                    puntajes.sumarPuntosIngenieriaBiotecnologia(2);
                    Console.WriteLine("P14: +2 Ingeniería en Biotecnología");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 15: ¿Con qué herramientas te gustaría trabajar?
    /// </summary>
    public class ReglaP15Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo15 == "a" || r.preguntaNo15 == "b" || r.preguntaNo15 == "c" ||
                    r.preguntaNo15 == "d" || r.preguntaNo15 == "e" || r.preguntaNo15 == "f" ||
                    r.preguntaNo15 == "g" || r.preguntaNo15 == "h" || r.preguntaNo15 == "i")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP15(respuestas.preguntaNo15, puntajes));
        }

        private static void ProcesarRespuestaP15(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a": // Robots y sensores
                    puntajes.sumarPuntosRobotica(2);
                    Console.WriteLine("P15: +2 Robótica");
                    break;
                case "b": // Lenguajes de programación
                    puntajes.sumarPuntosCienciasComputacionales(2);
                    puntajes.sumarPuntosIngenieriaSoftware(2);
                    Console.WriteLine("P15: +2 Ciencias Computacionales, +2 Ingeniería de Software");
                    break;
                case "c": // Software de diseño CAD y equipos de construcción
                    puntajes.sumarPuntosIngenieriaCivil(2);
                    Console.WriteLine("P15: +2 Ingeniería Civil");
                    break;
                case "d": // Software de simulación y gestión
                    puntajes.sumarPuntosIngenieriaIndustrial(2);
                    Console.WriteLine("P15: +2 Ingeniería Industrial");
                    break;
                case "e": // Equipos de procesamiento de alimentos
                    puntajes.sumarPuntosIngenieriaAlimentos(2);
                    Console.WriteLine("P15: +2 Ingeniería en Alimentos");
                    break;
                case "f": // Equipos de minería y metalurgia
                    puntajes.sumarPuntosIngenieriaMineroMetalurgica(2);
                    Console.WriteLine("P15: +2 Ingeniería Minero Metalúrgica");
                    break;
                case "g": // Microscopios y equipos de prueba de materiales
                    puntajes.sumarPuntosIngenieriaMateriales(2);
                    Console.WriteLine("P15: +2 Ingeniería en Materiales");
                    break;
                case "h": // Antenas y equipos de comunicación
                    puntajes.sumarPuntosIngenieriaTelecomunicaciones(2);
                    Console.WriteLine("P15: +2 Ingeniería en Telecomunicaciones");
                    break;
                case "i": // Reactores biológicos y equipos de laboratorio
                    puntajes.sumarPuntosIngenieriaBiotecnologia(2);
                    Console.WriteLine("P15: +2 Ingeniería en Biotecnología");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 16: ¿Qué materia te parece más interesante?
    /// </summary>
    public class ReglaP16Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo16 == "a" || r.preguntaNo16 == "b" || r.preguntaNo16 == "c" ||
                    r.preguntaNo16 == "d" || r.preguntaNo16 == "e" || r.preguntaNo16 == "f" ||
                    r.preguntaNo16 == "g" || r.preguntaNo16 == "h" || r.preguntaNo16 == "i")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP16(respuestas.preguntaNo16, puntajes));
        }

        private static void ProcesarRespuestaP16(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a": // Electrónica y control
                    puntajes.sumarPuntosRobotica(2);
                    Console.WriteLine("P16: +2 Robótica");
                    break;
                case "b": // Algoritmos y estructuras de datos
                    puntajes.sumarPuntosCienciasComputacionales(2);
                    puntajes.sumarPuntosIngenieriaSoftware(2);
                    Console.WriteLine("P16: +2 Ciencias Computacionales, +2 Ingeniería de Software");
                    break;
                case "c": // Mecánica de materiales
                    puntajes.sumarPuntosIngenieriaCivil(2);
                    puntajes.sumarPuntosIngenieriaMateriales(1);
                    Console.WriteLine("P16: +2 Ingeniería Civil, +1 Ingeniería en Materiales");
                    break;
                case "d": // Investigación de operaciones
                    puntajes.sumarPuntosIngenieriaIndustrial(2);
                    Console.WriteLine("P16: +2 Ingeniería Industrial");
                    break;
                case "e": // Química de alimentos
                    puntajes.sumarPuntosIngenieriaAlimentos(2);
                    Console.WriteLine("P16: +2 Ingeniería en Alimentos");
                    break;
                case "f": // Mineralogía
                    puntajes.sumarPuntosIngenieriaMineroMetalurgica(2);
                    Console.WriteLine("P16: +2 Ingeniería Minero Metalúrgica");
                    break;
                case "g": // Ciencia de materiales
                    puntajes.sumarPuntosIngenieriaMateriales(2);
                    Console.WriteLine("P16: +2 Ingeniería en Materiales");
                    break;
                case "h": // Teoría de las comunicaciones
                    puntajes.sumarPuntosIngenieriaTelecomunicaciones(2);
                    Console.WriteLine("P16: +2 Ingeniería en Telecomunicaciones");
                    break;
                case "i": // Biología molecular
                    puntajes.sumarPuntosIngenieriaBiotecnologia(2);
                    Console.WriteLine("P16: +2 Ingeniería en Biotecnología");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 17: ¿Qué proyecto te motivaría más?
    /// </summary>
    public class ReglaP17Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo17 == "a" || r.preguntaNo17 == "b" || r.preguntaNo17 == "c" ||
                    r.preguntaNo17 == "d" || r.preguntaNo17 == "e" || r.preguntaNo17 == "f" ||
                    r.preguntaNo17 == "g" || r.preguntaNo17 == "h" || r.preguntaNo17 == "i")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP17(respuestas.preguntaNo17, puntajes));
        }

        private static void ProcesarRespuestaP17(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a": // Construir un robot autónomo
                    puntajes.sumarPuntosRobotica(2);
                    Console.WriteLine("P17: +2 Robótica");
                    break;
                case "b": // Desarrollar una aplicación móvil
                    puntajes.sumarPuntosCienciasComputacionales(2);
                    puntajes.sumarPuntosIngenieriaSoftware(2);
                    Console.WriteLine("P17: +2 Ciencias Computacionales, +2 Ingeniería de Software");
                    break;
                case "c": // Diseñar un puente o edificio
                    puntajes.sumarPuntosIngenieriaCivil(2);
                    Console.WriteLine("P17: +2 Ingeniería Civil");
                    break;
                case "d": // Mejorar la logística de una empresa
                    puntajes.sumarPuntosIngenieriaIndustrial(2);
                    Console.WriteLine("P17: +2 Ingeniería Industrial");
                    break;
                case "e": // Crear un nuevo producto alimenticio
                    puntajes.sumarPuntosIngenieriaAlimentos(2);
                    Console.WriteLine("P17: +2 Ingeniería en Alimentos");
                    break;
                case "f": // Optimizar la extracción de un metal
                    puntajes.sumarPuntosIngenieriaMineroMetalurgica(2);
                    Console.WriteLine("P17: +2 Ingeniería Minero Metalúrgica");
                    break;
                case "g": // Crear un material biodegradable
                    puntajes.sumarPuntosIngenieriaMateriales(2);
                    Console.WriteLine("P17: +2 Ingeniería en Materiales");
                    break;
                case "h": // Diseñar una red de fibra óptica
                    puntajes.sumarPuntosIngenieriaTelecomunicaciones(2);
                    Console.WriteLine("P17: +2 Ingeniería en Telecomunicaciones");
                    break;
                case "i": // Desarrollar un biocombustible
                    puntajes.sumarPuntosIngenieriaBiotecnologia(2);
                    Console.WriteLine("P17: +2 Ingeniería en Biotecnología");
                    break;
            }
        }
    }

    // REGLAS PARA ESPECIALIDADES DE ARTES (P18 a P22)

    /// <summary>
    /// Pregunta 18: ¿Qué forma de expresión artística prefieres?
    /// </summary>
    public class ReglaP18Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo18 == "a" || r.preguntaNo18 == "b" || r.preguntaNo18 == "c" ||
                    r.preguntaNo18 == "d" || r.preguntaNo18 == "e")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP18(respuestas.preguntaNo18, puntajes));
        }

        private static void ProcesarRespuestaP18(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosArtesVisuales(2);
                    Console.WriteLine("P18: +2 Artes Visuales");
                    break;
                case "b":
                    puntajes.sumarPuntosDanza(2);
                    Console.WriteLine("P18: +2 Danza");
                    break;
                case "c":
                    puntajes.sumarPuntosDisenoGrafico(2);
                    Console.WriteLine("P18: +2 Diseño Gráfico");
                    break;
                case "d":
                    puntajes.sumarPuntosMusica(2);
                    Console.WriteLine("P18: +2 Música");
                    break;
                case "e":
                    puntajes.sumarPuntosTeatro(2);
                    Console.WriteLine("P18: +2 Teatro");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 19: ¿En qué tipo de proyectos te gustaría trabajar?
    /// </summary>
    public class ReglaP19Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo19 == "a" || r.preguntaNo19 == "b" || r.preguntaNo19 == "c" ||
                    r.preguntaNo19 == "d" || r.preguntaNo19 == "e")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP19(respuestas.preguntaNo19, puntajes));
        }

        private static void ProcesarRespuestaP19(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosArtesVisuales(2);
                    Console.WriteLine("P19: +2 Artes Visuales");
                    break;
                case "b":
                    puntajes.sumarPuntosDanza(2);
                    Console.WriteLine("P19: +2 Danza");
                    break;
                case "c":
                    puntajes.sumarPuntosDisenoGrafico(2);
                    Console.WriteLine("P19: +2 Diseño Gráfico");
                    break;
                case "d":
                    puntajes.sumarPuntosMusica(2);
                    Console.WriteLine("P19: +2 Música");
                    break;
                case "e":
                    puntajes.sumarPuntosTeatro(2);
                    Console.WriteLine("P19: +2 Teatro");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 20: ¿Qué habilidades te describes?
    /// </summary>
    public class ReglaP20Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo20 == "a" || r.preguntaNo20 == "b" || r.preguntaNo20 == "c" ||
                    r.preguntaNo20 == "d" || r.preguntaNo20 == "e")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP20(respuestas.preguntaNo20, puntajes));
        }

        private static void ProcesarRespuestaP20(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosArtesVisuales(2);
                    Console.WriteLine("P20: +2 Artes Visuales");
                    break;
                case "b":
                    puntajes.sumarPuntosDanza(2);
                    Console.WriteLine("P20: +2 Danza");
                    break;
                case "c":
                    puntajes.sumarPuntosDisenoGrafico(2);
                    Console.WriteLine("P20: +2 Diseño Gráfico");
                    break;
                case "d":
                    puntajes.sumarPuntosMusica(2);
                    Console.WriteLine("P20: +2 Música");
                    break;
                case "e":
                    puntajes.sumarPuntosTeatro(2);
                    Console.WriteLine("P20: +2 Teatro");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 21: ¿Qué ambiente de trabajo te atrae más?
    /// </summary>
    public class ReglaP21Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo21 == "a" || r.preguntaNo21 == "b" || r.preguntaNo21 == "c" ||
                    r.preguntaNo21 == "d" || r.preguntaNo21 == "e")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP21(respuestas.preguntaNo21, puntajes));
        }

        private static void ProcesarRespuestaP21(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosArtesVisuales(2);
                    Console.WriteLine("P21: +2 Artes Visuales");
                    break;
                case "b":
                    puntajes.sumarPuntosDanza(2);
                    Console.WriteLine("P21: +2 Danza");
                    break;
                case "c":
                    puntajes.sumarPuntosDisenoGrafico(2);
                    Console.WriteLine("P21: +2 Diseño Gráfico");
                    break;
                case "d":
                    puntajes.sumarPuntosMusica(2);
                    Console.WriteLine("P21: +2 Música");
                    break;
                case "e":
                    puntajes.sumarPuntosTeatro(2);
                    Console.WriteLine("P21: +2 Teatro");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 22: ¿Qué tipo de audiencia prefieres?
    /// </summary>
    public class ReglaP22Consolidada : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo22 == "a" || r.preguntaNo22 == "b" || r.preguntaNo22 == "c" ||
                    r.preguntaNo22 == "d" || r.preguntaNo22 == "e")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP22(respuestas.preguntaNo22, puntajes));
        }

        private static void ProcesarRespuestaP22(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosArtesVisuales(2);
                    Console.WriteLine("P22: +2 Artes Visuales");
                    break;
                case "b":
                    puntajes.sumarPuntosDanza(2);
                    Console.WriteLine("P22: +2 Danza");
                    break;
                case "c":
                    puntajes.sumarPuntosDisenoGrafico(2);
                    Console.WriteLine("P22: +2 Diseño Gráfico");
                    break;
                case "d":
                    puntajes.sumarPuntosMusica(2);
                    Console.WriteLine("P22: +2 Música");
                    break;
                case "e":
                    puntajes.sumarPuntosTeatro(2);
                    Console.WriteLine("P22: +2 Teatro");
                    break;
            }
        }
    }

    // REGLAS PARA HUMANIDADES (P23-P27)
    public class ReglaP23Humanidades : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r => r.preguntaNo23 == "a" || r.preguntaNo23 == "b" ||
                    r.preguntaNo23 == "c" || r.preguntaNo23 == "d" || r.preguntaNo23 == "e")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP23(respuestas.preguntaNo23, puntajes));
        }

        private static void ProcesarRespuestaP23(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosAntropologiaSocial(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P23: +2 Antropología Social, +1 Humanidades");
                    break;
                case "b":
                    puntajes.sumarPuntosArquitectura(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P23: +2 Arquitectura, +1 Humanidades");
                    break;
                case "c":
                    puntajes.sumarPuntosEnsenanzaLenguaInglesa(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P23: +2 Enseñanza de la Lengua Inglesa, +1 Humanidades");
                    break;
                case "d":
                    puntajes.sumarPuntosHistoriaMexico(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P23: +2 Historia de México, +1 Humanidades");
                    break;
                case "e":
                    puntajes.sumarPuntosInnovacionTecnologiaEducativa(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P23: +2 Innovación y Tecnología Educativa, +1 Humanidades");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 24: ¿Qué tipo de trabajo te gustaría realizar? (Humanidades)
    /// </summary>
    public class ReglaP24Humanidades : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r => r.preguntaNo24 == "a" || r.preguntaNo24 == "b" ||
                    r.preguntaNo24 == "c" || r.preguntaNo24 == "d" || r.preguntaNo24 == "e")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP24(respuestas.preguntaNo24, puntajes));
        }

        private static void ProcesarRespuestaP24(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosAntropologiaSocial(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P24: +2 Antropología Social, +1 Humanidades");
                    break;
                case "b":
                    puntajes.sumarPuntosArquitectura(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P24: +2 Arquitectura, +1 Humanidades");
                    break;
                case "c":
                    puntajes.sumarPuntosEnsenanzaLenguaInglesa(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P24: +2 Enseñanza de la Lengua Inglesa, +1 Humanidades");
                    break;
                case "d":
                    puntajes.sumarPuntosHistoriaMexico(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P24: +2 Historia de México, +1 Humanidades");
                    break;
                case "e":
                    puntajes.sumarPuntosInnovacionTecnologiaEducativa(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P24: +2 Innovación y Tecnología Educativa, +1 Humanidades");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 25: ¿Qué habilidades posees o quieres desarrollar? (Humanidades)
    /// </summary>
    public class ReglaP25Humanidades : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r => r.preguntaNo25 == "a" || r.preguntaNo25 == "b" ||
                    r.preguntaNo25 == "c" || r.preguntaNo25 == "d" || r.preguntaNo25 == "e")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP25(respuestas.preguntaNo25, puntajes));
        }

        private static void ProcesarRespuestaP25(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosAntropologiaSocial(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P25: +2 Antropología Social, +1 Humanidades");
                    break;
                case "b":
                    puntajes.sumarPuntosArquitectura(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P25: +2 Arquitectura, +1 Humanidades");
                    break;
                case "c":
                    puntajes.sumarPuntosEnsenanzaLenguaInglesa(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P25: +2 Enseñanza de la Lengua Inglesa, +1 Humanidades");
                    break;
                case "d":
                    puntajes.sumarPuntosHistoriaMexico(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P25: +2 Historia de México, +1 Humanidades");
                    break;
                case "e":
                    puntajes.sumarPuntosInnovacionTecnologiaEducativa(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P25: +2 Innovación y Tecnología Educativa, +1 Humanidades");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 26: ¿En qué entorno te ves trabajando? (Humanidades)
    /// </summary>
    public class ReglaP26Humanidades : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r => r.preguntaNo26 == "a" || r.preguntaNo26 == "b" ||
                    r.preguntaNo26 == "c" || r.preguntaNo26 == "d" || r.preguntaNo26 == "e")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP26(respuestas.preguntaNo26, puntajes));
        }

        private static void ProcesarRespuestaP26(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosAntropologiaSocial(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P26: +2 Antropología Social, +1 Humanidades");
                    break;
                case "b":
                    puntajes.sumarPuntosArquitectura(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P26: +2 Arquitectura, +1 Humanidades");
                    break;
                case "c":
                    puntajes.sumarPuntosEnsenanzaLenguaInglesa(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P26: +2 Enseñanza de la Lengua Inglesa, +1 Humanidades");
                    break;
                case "d":
                    puntajes.sumarPuntosHistoriaMexico(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P26: +2 Historia de México, +1 Humanidades");
                    break;
                case "e":
                    puntajes.sumarPuntosInnovacionTecnologiaEducativa(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P26: +2 Innovación y Tecnología Educativa, +1 Humanidades");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 27: ¿Qué te motiva más? (Humanidades)
    /// </summary>
    public class ReglaP27Humanidades : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r => r.preguntaNo27 == "a" || r.preguntaNo27 == "b" ||
                    r.preguntaNo27 == "c" || r.preguntaNo27 == "d" || r.preguntaNo27 == "e")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP27(respuestas.preguntaNo27, puntajes));
        }

        private static void ProcesarRespuestaP27(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosAntropologiaSocial(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P27: +2 Antropología Social, +1 Humanidades");
                    break;
                case "b":
                    puntajes.sumarPuntosArquitectura(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P27: +2 Arquitectura, +1 Humanidades");
                    break;
                case "c":
                    puntajes.sumarPuntosEnsenanzaLenguaInglesa(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P27: +2 Enseñanza de la Lengua Inglesa, +1 Humanidades");
                    break;
                case "d":
                    puntajes.sumarPuntosHistoriaMexico(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P27: +2 Historia de México, +1 Humanidades");
                    break;
                case "e":
                    puntajes.sumarPuntosInnovacionTecnologiaEducativa(2);
                    puntajes.sumarPuntosHumanidades(1);
                    Console.WriteLine("P27: +2 Innovación y Tecnología Educativa, +1 Humanidades");
                    break;
            }
        }
    }

    /// REGLAS  PARA CIENCIAS DE LA SALUD(P28-P33)

    /// <summary>
    /// Pregunta 28: ¿Qué aspecto de la salud te interesa más?
    /// </summary>
    public class ReglaP28CienciasSalud : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r => r.preguntaNo28 == "a" || r.preguntaNo28 == "b" ||
                    r.preguntaNo28 == "c" || r.preguntaNo28 == "d" || r.preguntaNo28 == "e" ||
                    r.preguntaNo28 == "f" || r.preguntaNo28 == "g")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP28(respuestas.preguntaNo28, puntajes));
        }

        private static void ProcesarRespuestaP28(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosCirujanoDentista(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P28: +2 Cirujano Dentista, +1 Ciencias de la Salud");
                    break;
                case "b":
                    puntajes.sumarPuntosEnfermeria(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P28: +2 Enfermería, +1 Ciencias de la Salud");
                    break;
                case "c":
                    puntajes.sumarPuntosFarmacia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P28: +2 Farmacia, +1 Ciencias de la Salud");
                    break;
                case "d":
                    puntajes.sumarPuntosGerontologia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P28: +2 Gerontología, +1 Ciencias de la Salud");
                    break;
                case "e":
                    puntajes.sumarPuntosMedicina(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P28: +2 Medicina, +1 Ciencias de la Salud");
                    break;
                case "f":
                    puntajes.sumarPuntosNutricion(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P28: +2 Nutrición, +1 Ciencias de la Salud");
                    break;
                case "g":
                    puntajes.sumarPuntosPsicologia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P28: +2 Psicología, +1 Ciencias de la Salud");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 29: ¿Qué tipo de actividades te gustaría realizar en tu trabajo?
    /// </summary>
    public class ReglaP29CienciasSalud : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r => r.preguntaNo29 == "a" || r.preguntaNo29 == "b" ||
                    r.preguntaNo29 == "c" || r.preguntaNo29 == "d" || r.preguntaNo29 == "e" ||
                    r.preguntaNo29 == "f" || r.preguntaNo29 == "g")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP29(respuestas.preguntaNo29, puntajes));
        }

        private static void ProcesarRespuestaP29(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosCirujanoDentista(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P29: +2 Cirujano Dentista, +1 Ciencias de la Salud");
                    break;
                case "b":
                    puntajes.sumarPuntosEnfermeria(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P29: +2 Enfermería, +1 Ciencias de la Salud");
                    break;
                case "c":
                    puntajes.sumarPuntosFarmacia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P29: +2 Farmacia, +1 Ciencias de la Salud");
                    break;
                case "d":
                    puntajes.sumarPuntosGerontologia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P29: +2 Gerontología, +1 Ciencias de la Salud");
                    break;
                case "e":
                    puntajes.sumarPuntosMedicina(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P29: +2 Medicina, +1 Ciencias de la Salud");
                    break;
                case "f":
                    puntajes.sumarPuntosNutricion(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P29: +2 Nutrición, +1 Ciencias de la Salud");
                    break;
                case "g":
                    puntajes.sumarPuntosPsicologia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P29: +2 Psicología, +1 Ciencias de la Salud");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 30: ¿Con qué grupo de población prefieres trabajar?
    /// </summary>
    public class ReglaP30CienciasSalud : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r => r.preguntaNo30 == "a" || r.preguntaNo30 == "b" ||
                    r.preguntaNo30 == "c" || r.preguntaNo30 == "d" || r.preguntaNo30 == "e" ||
                    r.preguntaNo30 == "f" || r.preguntaNo30 == "g")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP30(respuestas.preguntaNo30, puntajes));
        }

        private static void ProcesarRespuestaP30(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosCirujanoDentista(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P30: +2 Cirujano Dentista, +1 Ciencias de la Salud");
                    break;
                case "b":
                    puntajes.sumarPuntosEnfermeria(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P30: +2 Enfermería, +1 Ciencias de la Salud");
                    break;
                case "c":
                    puntajes.sumarPuntosFarmacia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P30: +2 Farmacia, +1 Ciencias de la Salud");
                    break;
                case "d":
                    puntajes.sumarPuntosGerontologia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P30: +2 Gerontología, +1 Ciencias de la Salud");
                    break;
                case "e":
                    puntajes.sumarPuntosMedicina(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P30: +2 Medicina, +1 Ciencias de la Salud");
                    break;
                case "f":
                    puntajes.sumarPuntosNutricion(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P30: +2 Nutrición, +1 Ciencias de la Salud");
                    break;
                case "g":
                    puntajes.sumarPuntosPsicologia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P30: +2 Psicología, +1 Ciencias de la Salud");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 31: ¿Qué habilidades crees que son más importantes para ti?
    /// </summary>
    public class ReglaP31CienciasSalud : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r => r.preguntaNo31 == "a" || r.preguntaNo31 == "b" ||
                    r.preguntaNo31 == "c" || r.preguntaNo31 == "d" || r.preguntaNo31 == "e" ||
                    r.preguntaNo31 == "f" || r.preguntaNo31 == "g")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP31(respuestas.preguntaNo31, puntajes));
        }

        private static void ProcesarRespuestaP31(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosCirujanoDentista(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P31: +2 Cirujano Dentista, +1 Ciencias de la Salud");
                    break;
                case "b":
                    puntajes.sumarPuntosEnfermeria(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P31: +2 Enfermería, +1 Ciencias de la Salud");
                    break;
                case "c":
                    puntajes.sumarPuntosFarmacia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P31: +2 Farmacia, +1 Ciencias de la Salud");
                    break;
                case "d":
                    puntajes.sumarPuntosGerontologia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P31: +2 Gerontología, +1 Ciencias de la Salud");
                    break;
                case "e":
                    puntajes.sumarPuntosMedicina(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P31: +2 Medicina, +1 Ciencias de la Salud");
                    break;
                case "f":
                    puntajes.sumarPuntosNutricion(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P31: +2 Nutrición, +1 Ciencias de la Salud");
                    break;
                case "g":
                    puntajes.sumarPuntosPsicologia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P31: +2 Psicología, +1 Ciencias de la Salud");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 32: ¿Qué entorno de trabajo prefieres?
    /// </summary>
    public class ReglaP32CienciasSalud : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r => r.preguntaNo32 == "a" || r.preguntaNo32 == "b" ||
                    r.preguntaNo32 == "c" || r.preguntaNo32 == "d" || r.preguntaNo32 == "e" ||
                    r.preguntaNo32 == "f" || r.preguntaNo32 == "g")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP32(respuestas.preguntaNo32, puntajes));
        }

        private static void ProcesarRespuestaP32(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosCirujanoDentista(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P32: +2 Cirujano Dentista, +1 Ciencias de la Salud");
                    break;
                case "b":
                    puntajes.sumarPuntosEnfermeria(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P32: +2 Enfermería, +1 Ciencias de la Salud");
                    break;
                case "c":
                    puntajes.sumarPuntosFarmacia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P32: +2 Farmacia, +1 Ciencias de la Salud");
                    break;
                case "d":
                    puntajes.sumarPuntosGerontologia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P32: +2 Gerontología, +1 Ciencias de la Salud");
                    break;
                case "e":
                    puntajes.sumarPuntosMedicina(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P32: +2 Medicina, +1 Ciencias de la Salud");
                    break;
                case "f":
                    puntajes.sumarPuntosNutricion(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P32: +2 Nutrición, +1 Ciencias de la Salud");
                    break;
                case "g":
                    puntajes.sumarPuntosPsicologia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P32: +2 Psicología, +1 Ciencias de la Salud");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 33: ¿Qué te motiva a estudiar una carrera de salud?
    /// </summary>
    public class ReglaP33CienciasSalud : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r => r.preguntaNo33 == "a" || r.preguntaNo33 == "b" ||
                    r.preguntaNo33 == "c" || r.preguntaNo33 == "d" || r.preguntaNo33 == "e" ||
                    r.preguntaNo33 == "f" || r.preguntaNo33 == "g")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP33(respuestas.preguntaNo33, puntajes));
        }

        private static void ProcesarRespuestaP33(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosCirujanoDentista(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P33: +2 Cirujano Dentista, +1 Ciencias de la Salud");
                    break;
                case "b":
                    puntajes.sumarPuntosEnfermeria(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P33: +2 Enfermería, +1 Ciencias de la Salud");
                    break;
                case "c":
                    puntajes.sumarPuntosFarmacia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P33: +2 Farmacia, +1 Ciencias de la Salud");
                    break;
                case "d":
                    puntajes.sumarPuntosGerontologia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P33: +2 Gerontología, +1 Ciencias de la Salud");
                    break;
                case "e":
                    puntajes.sumarPuntosMedicina(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P33: +2 Medicina, +1 Ciencias de la Salud");
                    break;
                case "f":
                    puntajes.sumarPuntosNutricion(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P33: +2 Nutrición, +1 Ciencias de la Salud");
                    break;
                case "g":
                    puntajes.sumarPuntosPsicologia(2);
                    puntajes.sumarPuntosCienciasSalud(1);
                    Console.WriteLine("P33: +2 Psicología, +1 Ciencias de la Salud");
                    break;
            }
        }
    }

    // REGLAS PARA CIENCIAS SOCIALES (P34-P38)

    /// <summary>
    /// Pregunta 34: ¿Qué tipo de trabajo te atrae más? (Ciencias Sociales)
    /// </summary>
    public class ReglaP34CienciasSociales : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo34 == "a" || r.preguntaNo34 == "b" || r.preguntaNo34 == "c" ||
                    r.preguntaNo34 == "d" || r.preguntaNo34 == "e" || r.preguntaNo34 == "f" ||
                    r.preguntaNo34 == "g" || r.preguntaNo34 == "h" || r.preguntaNo34 == "i" ||
                    r.preguntaNo34 == "j" || r.preguntaNo34 == "k" || r.preguntaNo34 == "l" || r.preguntaNo34 == "m")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP34(respuestas.preguntaNo34, puntajes));
        }

        private static void ProcesarRespuestaP34(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosAdministracion(2);
                    puntajes.sumarPuntosCreacionDesarrolloEmpresas(1);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P34: +2 Administración, +1 Creación y Desarrollo de Empresas, +1 Ciencias Sociales");
                    break;
                case "b":
                    puntajes.sumarPuntosDerecho(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P34: +2 Derecho, +1 Ciencias Sociales");
                    break;
                case "c":
                    puntajes.sumarPuntosCienciasEducacion(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P34: +2 Ciencias de la Educación, +1 Ciencias Sociales");
                    break;
                case "d":
                    puntajes.sumarPuntosSociologia(2);
                    puntajes.sumarPuntosCienciaPoliticaAdminPublica(1);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P34: +2 Sociología, +1 Ciencia Política, +1 Ciencias Sociales");
                    break;
                case "e":
                    puntajes.sumarPuntosMercadotecnia(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P34: +2 Mercadotecnia, +1 Ciencias Sociales");
                    break;
                case "f":
                    puntajes.sumarPuntosContaduria(2);
                    puntajes.sumarPuntosIngenieriaEconomicaFinanciera(1);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P34: +2 Contaduría, +1 Ingeniería Económica, +1 Ciencias Sociales");
                    break;
                case "g":
                    puntajes.sumarPuntosPlaneacionDesarrolloRegional(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P34: +2 Planeación y Desarrollo Regional, +1 Ciencias Sociales");
                    break;
                case "h":
                    puntajes.sumarPuntosComercioExterior(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P34: +2 Comercio Exterior, +1 Ciencias Sociales");
                    break;
                case "i":
                    puntajes.sumarPuntosComunicacion(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P34: +2 Comunicación, +1 Ciencias Sociales");
                    break;
                case "j":
                    puntajes.sumarPuntosTrabajoSocial(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P34: +2 Trabajo Social, +1 Ciencias Sociales");
                    break;
                case "k":
                    puntajes.sumarPuntosGastronomia(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P34: +2 Gastronomía, +1 Ciencias Sociales");
                    break;
                case "l":
                    puntajes.sumarPuntosTurismo(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P34: +2 Turismo, +1 Ciencias Sociales");
                    break;
                case "m":
                    puntajes.sumarPuntosEconomia(2);
                    puntajes.sumarPuntosCienciaPoliticaAdminPublica(1);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P34: +2 Economía, +1 Ciencia Política, +1 Ciencias Sociales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 35: ¿Qué habilidad te consideras más fuerte? (Ciencias Sociales)
    /// </summary>
    public class ReglaP35CienciasSociales : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo35 == "a" || r.preguntaNo35 == "b" || r.preguntaNo35 == "c" ||
                    r.preguntaNo35 == "d" || r.preguntaNo35 == "e" || r.preguntaNo35 == "f" ||
                    r.preguntaNo35 == "g" || r.preguntaNo35 == "h" || r.preguntaNo35 == "i" ||
                    r.preguntaNo35 == "j" || r.preguntaNo35 == "k" || r.preguntaNo35 == "l")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP35(respuestas.preguntaNo35, puntajes));
        }

        private static void ProcesarRespuestaP35(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosAdministracion(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P35: +2 Administración, +1 Ciencias Sociales");
                    break;
                case "b":
                    puntajes.sumarPuntosDerecho(2);
                    puntajes.sumarPuntosComunicacion(1);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P35: +2 Derecho, +1 Comunicación, +1 Ciencias Sociales");
                    break;
                case "c":
                    puntajes.sumarPuntosCienciasEducacion(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P35: +2 Ciencias de la Educación, +1 Ciencias Sociales");
                    break;
                case "d":
                    puntajes.sumarPuntosSociologia(2);
                    puntajes.sumarPuntosCienciaPoliticaAdminPublica(1);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P35: +2 Sociología, +1 Ciencia Política, +1 Ciencias Sociales");
                    break;
                case "e":
                    puntajes.sumarPuntosMercadotecnia(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P35: +2 Mercadotecnia, +1 Ciencias Sociales");
                    break;
                case "f":
                    puntajes.sumarPuntosContaduria(2);
                    puntajes.sumarPuntosEconomia(1);
                    puntajes.sumarPuntosIngenieriaEconomicaFinanciera(1);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P35: +2 Contaduría, +1 Economía, +1 Ingeniería Económica, +1 Ciencias Sociales");
                    break;
                case "g":
                    puntajes.sumarPuntosPlaneacionDesarrolloRegional(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P35: +2 Planeación y Desarrollo Regional, +1 Ciencias Sociales");
                    break;
                case "h":
                    puntajes.sumarPuntosComercioExterior(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P35: +2 Comercio Exterior, +1 Ciencias Sociales");
                    break;
                case "i":
                    puntajes.sumarPuntosTrabajoSocial(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P35: +2 Trabajo Social, +1 Ciencias Sociales");
                    break;
                case "j":
                    puntajes.sumarPuntosGastronomia(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P35: +2 Gastronomía, +1 Ciencias Sociales");
                    break;
                case "k":
                    puntajes.sumarPuntosTurismo(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P35: +2 Turismo, +1 Ciencias Sociales");
                    break;
                case "l":
                    puntajes.sumarPuntosEconomia(2);
                    puntajes.sumarPuntosIngenieriaEconomicaFinanciera(1);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P35: +2 Economía, +1 Ingeniería Económica, +1 Ciencias Sociales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 36: ¿Qué entorno laboral prefieres? (Ciencias Sociales)
    /// </summary>
    public class ReglaP36CienciasSociales : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo36 == "a" || r.preguntaNo36 == "b" || r.preguntaNo36 == "c" ||
                    r.preguntaNo36 == "d" || r.preguntaNo36 == "e" || r.preguntaNo36 == "f" ||
                    r.preguntaNo36 == "g" || r.preguntaNo36 == "h" || r.preguntaNo36 == "i" ||
                    r.preguntaNo36 == "j" || r.preguntaNo36 == "k")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP36(respuestas.preguntaNo36, puntajes));
        }

        private static void ProcesarRespuestaP36(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosAdministracion(1);
                    puntajes.sumarPuntosContaduria(1);
                    puntajes.sumarPuntosMercadotecnia(1);
                    puntajes.sumarPuntosEconomia(1);
                    puntajes.sumarPuntosIngenieriaEconomicaFinanciera(1);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P36: +1 Administración, Contaduría, Mercadotecnia, Economía, Ingeniería Económica, +1 Ciencias Sociales");
                    break;
                case "b":
                    puntajes.sumarPuntosDerecho(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P36: +2 Derecho, +1 Ciencias Sociales");
                    break;
                case "c":
                    puntajes.sumarPuntosCienciasEducacion(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P36: +2 Ciencias de la Educación, +1 Ciencias Sociales");
                    break;
                case "d":
                    puntajes.sumarPuntosSociologia(1);
                    puntajes.sumarPuntosCienciaPoliticaAdminPublica(1);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P36: +1 Sociología, +1 Ciencia Política, +1 Ciencias Sociales");
                    break;
                case "e":
                    puntajes.sumarPuntosMercadotecnia(1);
                    puntajes.sumarPuntosComunicacion(1);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P36: +1 Mercadotecnia, +1 Comunicación, +1 Ciencias Sociales");
                    break;
                case "f":
                    puntajes.sumarPuntosCienciaPoliticaAdminPublica(1);
                    puntajes.sumarPuntosPlaneacionDesarrolloRegional(1);
                    puntajes.sumarPuntosTrabajoSocial(1);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P36: +1 Ciencia Política, Planeación, Trabajo Social, +1 Ciencias Sociales");
                    break;
                case "g":
                    puntajes.sumarPuntosComercioExterior(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P36: +2 Comercio Exterior, +1 Ciencias Sociales");
                    break;
                case "h":
                    puntajes.sumarPuntosComunicacion(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P36: +2 Comunicación, +1 Ciencias Sociales");
                    break;
                case "i":
                    puntajes.sumarPuntosTrabajoSocial(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P36: +2 Trabajo Social, +1 Ciencias Sociales");
                    break;
                case "j":
                    puntajes.sumarPuntosGastronomia(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P36: +2 Gastronomía, +1 Ciencias Sociales");
                    break;
                case "k":
                    puntajes.sumarPuntosTurismo(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P36: +2 Turismo, +1 Ciencias Sociales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 37: ¿Qué te motiva a elegir una carrera? (Ciencias Sociales)
    /// </summary>
    public class ReglaP37CienciasSociales : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo37 == "a" || r.preguntaNo37 == "b" || r.preguntaNo37 == "c" ||
                    r.preguntaNo37 == "d" || r.preguntaNo37 == "e" || r.preguntaNo37 == "f" ||
                    r.preguntaNo37 == "g" || r.preguntaNo37 == "h" || r.preguntaNo37 == "i" ||
                    r.preguntaNo37 == "j" || r.preguntaNo37 == "k")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP37(respuestas.preguntaNo37, puntajes));
        }

        private static void ProcesarRespuestaP37(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosAdministracion(2);
                    puntajes.sumarPuntosEconomia(2);
                    puntajes.sumarPuntosCreacionDesarrolloEmpresas(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P37: +2 Administración, Economía, Creación de Empresas, +1 Ciencias Sociales");
                    break;
                case "b":
                    puntajes.sumarPuntosDerecho(2);
                    puntajes.sumarPuntosTrabajoSocial(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P37: +2 Derecho, Trabajo Social, +1 Ciencias Sociales");
                    break;
                case "c":
                    puntajes.sumarPuntosCienciasEducacion(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P37: +2 Ciencias de la Educación, +1 Ciencias Sociales");
                    break;
                case "d":
                    puntajes.sumarPuntosSociologia(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P37: +2 Sociología, +1 Ciencias Sociales");
                    break;
                case "e":
                    puntajes.sumarPuntosCienciaPoliticaAdminPublica(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P37: +2 Ciencia Política, +1 Ciencias Sociales");
                    break;
                case "f":
                    puntajes.sumarPuntosMercadotecnia(2);
                    puntajes.sumarPuntosContaduria(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P37: +2 Mercadotecnia, Contaduría, +1 Ciencias Sociales");
                    break;
                case "g":
                    puntajes.sumarPuntosPlaneacionDesarrolloRegional(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P37: +2 Planeación y Desarrollo Regional, +1 Ciencias Sociales");
                    break;
                case "h":
                    puntajes.sumarPuntosComercioExterior(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P37: +2 Comercio Exterior, +1 Ciencias Sociales");
                    break;
                case "i":
                    puntajes.sumarPuntosComunicacion(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P37: +2 Comunicación, +1 Ciencias Sociales");
                    break;
                case "j":
                    puntajes.sumarPuntosGastronomia(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P37: +2 Gastronomía, +1 Ciencias Sociales");
                    break;
                case "k":
                    puntajes.sumarPuntosTurismo(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P37: +2 Turismo, +1 Ciencias Sociales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 38: ¿Con qué tipo de problemas te gustaría lidiar? (Ciencias Sociales)
    /// </summary>
    public class ReglaP38CienciasSociales : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo38 == "a" || r.preguntaNo38 == "b" || r.preguntaNo38 == "c" ||
                    r.preguntaNo38 == "d" || r.preguntaNo38 == "e" || r.preguntaNo38 == "f" ||
                    r.preguntaNo38 == "g" || r.preguntaNo38 == "h" || r.preguntaNo38 == "i" ||
                    r.preguntaNo38 == "j" || r.preguntaNo38 == "k")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP38(respuestas.preguntaNo38, puntajes));
        }

        private static void ProcesarRespuestaP38(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosAdministracion(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P38: +2 Administración, +1 Ciencias Sociales");
                    break;
                case "b":
                    puntajes.sumarPuntosDerecho(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P38: +2 Derecho, +1 Ciencias Sociales");
                    break;
                case "c":
                    puntajes.sumarPuntosCienciasEducacion(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P38: +2 Ciencias de la Educación, +1 Ciencias Sociales");
                    break;
                case "d":
                    puntajes.sumarPuntosSociologia(2);
                    puntajes.sumarPuntosTrabajoSocial(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P38: +2 Sociología, Trabajo Social, +1 Ciencias Sociales");
                    break;
                case "e":
                    puntajes.sumarPuntosMercadotecnia(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P38: +2 Mercadotecnia, +1 Ciencias Sociales");
                    break;
                case "f":
                    puntajes.sumarPuntosContaduria(2);
                    puntajes.sumarPuntosEconomia(2);
                    puntajes.sumarPuntosIngenieriaEconomicaFinanciera(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P38: +2 Contaduría, Economía, Ingeniería Económica, +1 Ciencias Sociales");
                    break;
                case "g":
                    puntajes.sumarPuntosPlaneacionDesarrolloRegional(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P38: +2 Planeación y Desarrollo Regional, +1 Ciencias Sociales");
                    break;
                case "h":
                    puntajes.sumarPuntosComercioExterior(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P38: +2 Comercio Exterior, +1 Ciencias Sociales");
                    break;
                case "i":
                    puntajes.sumarPuntosComunicacion(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P38: +2 Comunicación, +1 Ciencias Sociales");
                    break;
                case "j":
                    puntajes.sumarPuntosGastronomia(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P38: +2 Gastronomía, +1 Ciencias Sociales");
                    break;
                case "k":
                    puntajes.sumarPuntosTurismo(2);
                    puntajes.sumarPuntosCienciasSociales(1);
                    Console.WriteLine("P38: +2 Turismo, +1 Ciencias Sociales");
                    break;
            }
        }
    }

    // REGLAS PARA CIENCIAS NATURALES (P39-P45)

    /// <summary>
    /// Pregunta 39: ¿Qué rama de las ciencias naturales te atrae más?
    /// </summary>
    public class ReglaP39CienciasNaturales : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo39 == "a" || r.preguntaNo39 == "b" || r.preguntaNo39 == "c" || r.preguntaNo39 == "d")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP39(respuestas.preguntaNo39, puntajes));
        }

        private static void ProcesarRespuestaP39(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosBiologia(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P39: +2 Biología, +1 Ciencias Naturales");
                    break;
                case "b":
                    puntajes.sumarPuntosFisicaTecnologiaAvanzada(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P39: +2 Física y Tecnología Avanzada, +1 Ciencias Naturales");
                    break;
                case "c":
                    puntajes.sumarPuntosMatematicasAplicadas(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P39: +2 Matemáticas Aplicadas, +1 Ciencias Naturales");
                    break;
                case "d":
                    puntajes.sumarPuntosQuimica(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P39: +2 Química, +1 Ciencias Naturales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 40: ¿Qué tipo de investigación te gustaría realizar?
    /// </summary>
    public class ReglaP40CienciasNaturales : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo40 == "a" || r.preguntaNo40 == "b" || r.preguntaNo40 == "c" || r.preguntaNo40 == "d")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP40(respuestas.preguntaNo40, puntajes));
        }

        private static void ProcesarRespuestaP40(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosBiologia(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P40: +2 Biología, +1 Ciencias Naturales");
                    break;
                case "b":
                    puntajes.sumarPuntosFisicaTecnologiaAvanzada(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P40: +2 Física y Tecnología Avanzada, +1 Ciencias Naturales");
                    break;
                case "c":
                    puntajes.sumarPuntosMatematicasAplicadas(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P40: +2 Matemáticas Aplicadas, +1 Ciencias Naturales");
                    break;
                case "d":
                    puntajes.sumarPuntosQuimica(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P40: +2 Química, +1 Ciencias Naturales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 41: ¿Qué habilidades consideras más afines a ti?
    /// </summary>
    public class ReglaP41CienciasNaturales : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo41 == "a" || r.preguntaNo41 == "b" || r.preguntaNo41 == "c" || r.preguntaNo41 == "d")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP41(respuestas.preguntaNo41, puntajes));
        }

        private static void ProcesarRespuestaP41(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosBiologia(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P41: +2 Biología, +1 Ciencias Naturales");
                    break;
                case "b":
                    puntajes.sumarPuntosFisicaTecnologiaAvanzada(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P41: +2 Física y Tecnología Avanzada, +1 Ciencias Naturales");
                    break;
                case "c":
                    puntajes.sumarPuntosMatematicasAplicadas(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P41: +2 Matemáticas Aplicadas, +1 Ciencias Naturales");
                    break;
                case "d":
                    puntajes.sumarPuntosQuimica(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P41: +2 Química, +1 Ciencias Naturales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 42: ¿Qué entorno de trabajo prefieres?
    /// </summary>
    public class ReglaP42CienciasNaturales : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo42 == "a" || r.preguntaNo42 == "b" || r.preguntaNo42 == "c" || r.preguntaNo42 == "d")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP42(respuestas.preguntaNo42, puntajes));
        }

        private static void ProcesarRespuestaP42(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosBiologia(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P42: +2 Biología, +1 Ciencias Naturales");
                    break;
                case "b":
                    puntajes.sumarPuntosFisicaTecnologiaAvanzada(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P42: +2 Física y Tecnología Avanzada, +1 Ciencias Naturales");
                    break;
                case "c":
                    puntajes.sumarPuntosMatematicasAplicadas(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P42: +2 Matemáticas Aplicadas, +1 Ciencias Naturales");
                    break;
                case "d":
                    puntajes.sumarPuntosQuimica(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P42: +2 Química, +1 Ciencias Naturales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 43: ¿Qué problema global te gustaría contribuir a resolver?
    /// </summary>
    public class ReglaP43CienciasNaturales : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo43 == "a" || r.preguntaNo43 == "b" || r.preguntaNo43 == "c" || r.preguntaNo43 == "d")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP43(respuestas.preguntaNo43, puntajes));
        }

        private static void ProcesarRespuestaP43(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosBiologia(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P43: +2 Biología, +1 Ciencias Naturales");
                    break;
                case "b":
                    puntajes.sumarPuntosFisicaTecnologiaAvanzada(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P43: +2 Física y Tecnología Avanzada, +1 Ciencias Naturales");
                    break;
                case "c":
                    puntajes.sumarPuntosMatematicasAplicadas(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P43: +2 Matemáticas Aplicadas, +1 Ciencias Naturales");
                    break;
                case "d":
                    puntajes.sumarPuntosQuimica(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P43: +2 Química, +1 Ciencias Naturales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 44: ¿Qué materia de ciencias fue tu favorita en la preparatoria?
    /// </summary>
    public class ReglaP44CienciasNaturales : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo44 == "a" || r.preguntaNo44 == "b" || r.preguntaNo44 == "c" || r.preguntaNo44 == "d")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP44(respuestas.preguntaNo44, puntajes));
        }

        private static void ProcesarRespuestaP44(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosBiologia(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P44: +2 Biología, +1 Ciencias Naturales");
                    break;
                case "b":
                    puntajes.sumarPuntosFisicaTecnologiaAvanzada(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P44: +2 Física y Tecnología Avanzada, +1 Ciencias Naturales");
                    break;
                case "c":
                    puntajes.sumarPuntosMatematicasAplicadas(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P44: +2 Matemáticas Aplicadas, +1 Ciencias Naturales");
                    break;
                case "d":
                    puntajes.sumarPuntosQuimica(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P44: +2 Química, +1 Ciencias Naturales");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 45: ¿Qué tipo de tecnología te interesa más?
    /// </summary>
    public class ReglaP45CienciasNaturales : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo45 == "a" || r.preguntaNo45 == "b" || r.preguntaNo45 == "c" || r.preguntaNo45 == "d")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP45(respuestas.preguntaNo45, puntajes));
        }

        private static void ProcesarRespuestaP45(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosBiologia(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P45: +2 Biología, +1 Ciencias Naturales");
                    break;
                case "b":
                    puntajes.sumarPuntosFisicaTecnologiaAvanzada(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P45: +2 Física y Tecnología Avanzada, +1 Ciencias Naturales");
                    break;
                case "c":
                    puntajes.sumarPuntosMatematicasAplicadas(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P45: +2 Matemáticas Aplicadas, +1 Ciencias Naturales");
                    break;
                case "d":
                    puntajes.sumarPuntosQuimica(2);
                    puntajes.sumarPuntosCienciasNaturales(1);
                    Console.WriteLine("P45: +2 Química, +1 Ciencias Naturales");
                    break;
            }
        }
    }

    // REGLAS PARA CIENCIAS DE LA VIDA (P46-P52)

    /// <summary>
    /// Pregunta 46: ¿Qué área de las ciencias de la vida te interesa más?
    /// </summary>
    public class ReglaP46CienciasVida : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo46 == "a" || r.preguntaNo46 == "b" || r.preguntaNo46 == "c" ||
                    r.preguntaNo46 == "d" || r.preguntaNo46 == "e" || r.preguntaNo46 == "f")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP46(respuestas.preguntaNo46, puntajes));
        }

        private static void ProcesarRespuestaP46(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosGestionNegociosAgropecuarios(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P46: +2 Gestión de Negocios Agropecuarios, +1 Ciencias de la Vida");
                    break;
                case "b":
                    puntajes.sumarPuntosIngenieriaAgroindustrial(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P46: +2 Ingeniería Agroindustrial, +1 Ciencias de la Vida");
                    break;
                case "c":
                    puntajes.sumarPuntosIngenieriaAgronomiaProduccionSustentable(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P46: +2 Ingeniería en Agronomía, +1 Ciencias de la Vida");
                    break;
                case "d":
                    puntajes.sumarPuntosIngenieriaForestal(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P46: +2 Ingeniería Forestal, +1 Ciencias de la Vida");
                    break;
                case "e":
                    puntajes.sumarPuntosMedicinaVeterinariaZootecnia(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P46: +2 Medicina Veterinaria y Zootecnia, +1 Ciencias de la Vida");
                    break;
                case "f":
                    puntajes.sumarPuntosQuimicaAlimentos(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P46: +2 Química de Alimentos, +1 Ciencias de la Vida");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 47: ¿Qué tipo de actividades te gustaría realizar en tu trabajo?
    /// </summary>
    public class ReglaP47CienciasVida : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo47 == "a" || r.preguntaNo47 == "b" || r.preguntaNo47 == "c" ||
                    r.preguntaNo47 == "d" || r.preguntaNo47 == "e" || r.preguntaNo47 == "f")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP47(respuestas.preguntaNo47, puntajes));
        }

        private static void ProcesarRespuestaP47(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosGestionNegociosAgropecuarios(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P47: +2 Gestión de Negocios Agropecuarios, +1 Ciencias de la Vida");
                    break;
                case "b":
                    puntajes.sumarPuntosIngenieriaAgroindustrial(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P47: +2 Ingeniería Agroindustrial, +1 Ciencias de la Vida");
                    break;
                case "c":
                    puntajes.sumarPuntosIngenieriaAgronomiaProduccionSustentable(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P47: +2 Ingeniería en Agronomía, +1 Ciencias de la Vida");
                    break;
                case "d":
                    puntajes.sumarPuntosIngenieriaForestal(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P47: +2 Ingeniería Forestal, +1 Ciencias de la Vida");
                    break;
                case "e":
                    puntajes.sumarPuntosMedicinaVeterinariaZootecnia(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P47: +2 Medicina Veterinaria y Zootecnia, +1 Ciencias de la Vida");
                    break;
                case "f":
                    puntajes.sumarPuntosQuimicaAlimentos(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P47: +2 Química de Alimentos, +1 Ciencias de la Vida");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 48: ¿Con qué te sientes más cómodo trabajando?
    /// </summary>
    public class ReglaP48CienciasVida : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo48 == "a" || r.preguntaNo48 == "b" || r.preguntaNo48 == "c" ||
                    r.preguntaNo48 == "d" || r.preguntaNo48 == "e" || r.preguntaNo48 == "f")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP48(respuestas.preguntaNo48, puntajes));
        }

        private static void ProcesarRespuestaP48(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosGestionNegociosAgropecuarios(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P48: +2 Gestión de Negocios Agropecuarios, +1 Ciencias de la Vida");
                    break;
                case "b":
                    puntajes.sumarPuntosIngenieriaAgroindustrial(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P48: +2 Ingeniería Agroindustrial, +1 Ciencias de la Vida");
                    break;
                case "c":
                    puntajes.sumarPuntosIngenieriaAgronomiaProduccionSustentable(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P48: +2 Ingeniería en Agronomía, +1 Ciencias de la Vida");
                    break;
                case "d":
                    puntajes.sumarPuntosIngenieriaForestal(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P48: +2 Ingeniería Forestal, +1 Ciencias de la Vida");
                    break;
                case "e":
                    puntajes.sumarPuntosMedicinaVeterinariaZootecnia(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P48: +2 Medicina Veterinaria y Zootecnia, +1 Ciencias de la Vida");
                    break;
                case "f":
                    puntajes.sumarPuntosQuimicaAlimentos(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P48: +2 Química de Alimentos, +1 Ciencias de la Vida");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 49: ¿Qué problema te gustaría resolver?
    /// </summary>
    public class ReglaP49CienciasVida : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo49 == "a" || r.preguntaNo49 == "b" || r.preguntaNo49 == "c" ||
                    r.preguntaNo49 == "d" || r.preguntaNo49 == "e" || r.preguntaNo49 == "f")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP49(respuestas.preguntaNo49, puntajes));
        }

        private static void ProcesarRespuestaP49(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosGestionNegociosAgropecuarios(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P49: +2 Gestión de Negocios Agropecuarios, +1 Ciencias de la Vida");
                    break;
                case "b":
                    puntajes.sumarPuntosIngenieriaAgroindustrial(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P49: +2 Ingeniería Agroindustrial, +1 Ciencias de la Vida");
                    break;
                case "c":
                    puntajes.sumarPuntosIngenieriaAgronomiaProduccionSustentable(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P49: +2 Ingeniería en Agronomía, +1 Ciencias de la Vida");
                    break;
                case "d":
                    puntajes.sumarPuntosIngenieriaForestal(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P49: +2 Ingeniería Forestal, +1 Ciencias de la Vida");
                    break;
                case "e":
                    puntajes.sumarPuntosMedicinaVeterinariaZootecnia(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P49: +2 Medicina Veterinaria y Zootecnia, +1 Ciencias de la Vida");
                    break;
                case "f":
                    puntajes.sumarPuntosQuimicaAlimentos(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P49: +2 Química de Alimentos, +1 Ciencias de la Vida");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 50: ¿Qué entorno de trabajo prefieres?
    /// </summary>
    public class ReglaP50CienciasVida : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo50 == "a" || r.preguntaNo50 == "b" || r.preguntaNo50 == "c" ||
                    r.preguntaNo50 == "d" || r.preguntaNo50 == "e" || r.preguntaNo50 == "f")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP50(respuestas.preguntaNo50, puntajes));
        }

        private static void ProcesarRespuestaP50(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosGestionNegociosAgropecuarios(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P50: +2 Gestión de Negocios Agropecuarios, +1 Ciencias de la Vida");
                    break;
                case "b":
                    puntajes.sumarPuntosIngenieriaAgroindustrial(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P50: +2 Ingeniería Agroindustrial, +1 Ciencias de la Vida");
                    break;
                case "c":
                    puntajes.sumarPuntosIngenieriaAgronomiaProduccionSustentable(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P50: +2 Ingeniería en Agronomía, +1 Ciencias de la Vida");
                    break;
                case "d":
                    puntajes.sumarPuntosIngenieriaForestal(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P50: +2 Ingeniería Forestal, +1 Ciencias de la Vida");
                    break;
                case "e":
                    puntajes.sumarPuntosMedicinaVeterinariaZootecnia(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P50: +2 Medicina Veterinaria y Zootecnia, +1 Ciencias de la Vida");
                    break;
                case "f":
                    puntajes.sumarPuntosQuimicaAlimentos(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P50: +2 Química de Alimentos, +1 Ciencias de la Vida");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 51: ¿Qué habilidad consideras más importante para ti?
    /// </summary>
    public class ReglaP51CienciasVida : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo51 == "a" || r.preguntaNo51 == "b" || r.preguntaNo51 == "c" ||
                    r.preguntaNo51 == "d" || r.preguntaNo51 == "e" || r.preguntaNo51 == "f")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP51(respuestas.preguntaNo51, puntajes));
        }

        private static void ProcesarRespuestaP51(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosGestionNegociosAgropecuarios(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P51: +2 Gestión de Negocios Agropecuarios, +1 Ciencias de la Vida");
                    break;
                case "b":
                    puntajes.sumarPuntosIngenieriaAgroindustrial(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P51: +2 Ingeniería Agroindustrial, +1 Ciencias de la Vida");
                    break;
                case "c":
                    puntajes.sumarPuntosIngenieriaAgronomiaProduccionSustentable(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P51: +2 Ingeniería en Agronomía, +1 Ciencias de la Vida");
                    break;
                case "d":
                    puntajes.sumarPuntosIngenieriaForestal(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P51: +2 Ingeniería Forestal, +1 Ciencias de la Vida");
                    break;
                case "e":
                    puntajes.sumarPuntosMedicinaVeterinariaZootecnia(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P51: +2 Medicina Veterinaria y Zootecnia, +1 Ciencias de la Vida");
                    break;
                case "f":
                    puntajes.sumarPuntosQuimicaAlimentos(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P51: +2 Química de Alimentos, +1 Ciencias de la Vida");
                    break;
            }
        }
    }

    /// <summary>
    /// Pregunta 52: ¿Qué te motiva a estudiar esta área?
    /// </summary>
    public class ReglaP52CienciasVida : NRules.Fluent.Dsl.Rule
    {
        public override void Define()
        {
            RespuestaUsuario respuestas = null;
            PuntajeArea puntajes = null;

            When()
                .Match<RespuestaUsuario>(() => respuestas, r =>
                    r.preguntaNo52 == "a" || r.preguntaNo52 == "b" || r.preguntaNo52 == "c" ||
                    r.preguntaNo52 == "d" || r.preguntaNo52 == "e" || r.preguntaNo52 == "f")
                .Match<PuntajeArea>(() => puntajes);

            Then()
                .Do(ctx => ProcesarRespuestaP52(respuestas.preguntaNo52, puntajes));
        }

        private static void ProcesarRespuestaP52(string respuesta, PuntajeArea puntajes)
        {
            switch (respuesta)
            {
                case "a":
                    puntajes.sumarPuntosGestionNegociosAgropecuarios(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P52: +2 Gestión de Negocios Agropecuarios, +1 Ciencias de la Vida");
                    break;
                case "b":
                    puntajes.sumarPuntosIngenieriaAgroindustrial(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P52: +2 Ingeniería Agroindustrial, +1 Ciencias de la Vida");
                    break;
                case "c":
                    puntajes.sumarPuntosIngenieriaAgronomiaProduccionSustentable(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P52: +2 Ingeniería en Agronomía, +1 Ciencias de la Vida");
                    break;
                case "d":
                    puntajes.sumarPuntosIngenieriaForestal(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P52: +2 Ingeniería Forestal, +1 Ciencias de la Vida");
                    break;
                case "e":
                    puntajes.sumarPuntosMedicinaVeterinariaZootecnia(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P52: +2 Medicina Veterinaria y Zootecnia, +1 Ciencias de la Vida");
                    break;
                case "f":
                    puntajes.sumarPuntosQuimicaAlimentos(2);
                    puntajes.sumarPuntosCienciasDeLaVida(1);
                    Console.WriteLine("P52: +2 Química de Alimentos, +1 Ciencias de la Vida");
                    break;
            }
        }
    }

    public class MotorOrientacionVocacional
    {
        public static (List<string> AreaGanadora, PuntajeArea Puntajes) DeterminarAreaEnfasis(
            string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10)
        {
            // Crear el repositorio de reglas
            var repository = new RuleRepository();
            repository.Load(x => x.From(typeof(ReglaP1Consolidada).Assembly));

            // Compilar las reglas de SBC
            var factory = repository.Compile();

            // Crear una sesión de reglas solo para las primeras 10 preguntas
            var session = factory.CreateSession();

            // Crear los hechos (facts) hechos asociados al area de enfasis
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
                //Sí lees esto...Ti amo AA <3 
            };

            var puntajes = new PuntajeArea();
            puntajes.ReiniciarPuntajes();

            // Insertar los hechos en la sesión
            session.Insert(respuestas);
            session.Insert(puntajes);

            // Ejecutar las reglas
            session.Fire();

            var areasGanadoras = puntajes.ObtenerAreasGanadoras();
            return (areasGanadoras, puntajes);
        }

        public static PuntajeArea ProcesarTodasLasReglas (RespuestaUsuario respuestasCompletas)
        {
            var repository = new RuleRepository();
            repository.Load(x => x.From(typeof(ReglaP1Consolidada).Assembly));

            var factory = repository.Compile();
            var session = factory.CreateSession();
            var puntajes = new PuntajeArea();
            puntajes.ReiniciarPuntajes();
            session.Insert(respuestasCompletas);
            session.Insert(puntajes);
            session.Fire();

            return puntajes;

        }
    }



    }

    //internal class BaseConocimiento
    //{
    //    static void prueba(string[] args)
    //    {
    //        //Console.WriteLine("SISTEMA DE ORIENTACIÓN VOCACIONAL - 52 PREGUNTAS\n");

    //        //// EJEMPLO 1: Ingeniería de Software
    //        //Console.WriteLine("=== EJEMPLO 1: Perfil Ingenieria de Software");
    //        //var resultado1 = MotorOrientacionVocacional.DeterminarAreaEnfasis(
    //        //    "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    //        //    "b", "b", "b", "b", "b", "b", "b", "c", "c", "c", "c", "c");
    //        //MostrarResultado(resultado1);

    //        //// EJEMPLO 2: Medicina
    //        //Console.WriteLine("\n=== EJEMPLO 2: Perfil Medicina");
    //        //var resultado2 = MotorOrientacionVocacional.DeterminarAreaEnfasis(
    //        //    "c", "c", "b", "d", "d", "d", "d", "a", "d", "d",
    //        //    "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    //        //    p28: "e", p29: "e", p30: "e", p31: "e", p32: "e", p33: "e");
    //        //MostrarResultado(resultado2);

    //        //// EJEMPLO 3: Derecho
    //        //Console.WriteLine("\n=== EJEMPLO 3: Perfil Derecho");
    //        //var resultado3 = MotorOrientacionVocacional.DeterminarAreaEnfasis(
    //        //    "e", "b", "c", "b", "b", "b", "b", "c", "b", "b",
    //        //    "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    //        //    p34: "b", p35: "b", p36: "b", p37: "b", p38: "b");
    //        //MostrarResultado(resultado3);

    //        //// EJEMPLO 4: Biología
    //        //Console.WriteLine("\n=== EJEMPLO 4: Perfil Biología");
    //        //var resultado4 = MotorOrientacionVocacional.DeterminarAreaEnfasis(
    //        //    "b", "f", "f", "g", "g", "g", "g", "f", "g", "g",
    //        //    "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    //        //    p39: "a", p40: "a", p41: "a", p42: "a", p43: "a", p44: "a", p45: "a");
    //        //MostrarResultado(resultado4);

    //        //// EJEMPLO 5: Medicina Veterinaria
    //        //Console.WriteLine("\n=== EJEMPLO 5: Perfil Medicina Veterinaria");
    //        //var resultado5 = MotorOrientacionVocacional.DeterminarAreaEnfasis(
    //        //    "c", "e", "e", "f", "f", "f", "f", "e", "f", "f",
    //        //    "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    //        //    p46: "e", p47: "e", p48: "e", p49: "e", p50: "e", p51: "e", p52: "e");
    //        //MostrarResultado(resultado5);
    //    //}

    //    //static void MostrarResultado((string AreaGanadora, PuntajeArea Puntajes) resultado)
    //    //{
    //    //    Console.WriteLine($"\nPUNTAJES FINALES:");
    //    //    Console.WriteLine($"Ingenierías: {resultado.Puntajes.puntajeIngenieria}");
    //    //    Console.WriteLine($"Ciencias de la Salud: {resultado.Puntajes.puntajeCienciasSalud}");
    //    //    Console.WriteLine($"Humanidades: {resultado.Puntajes.puntajeHumanidades}");
    //    //    Console.WriteLine($"Ciencias Sociales: {resultado.Puntajes.puntajeCienciasSociales}");
    //    //    Console.WriteLine($"Artes: {resultado.Puntajes.puntajeArtes}");
    //    //    Console.WriteLine($"Ciencias Naturales: {resultado.Puntajes.puntajeCienciasNaturales}");
    //    //    Console.WriteLine($"Ciencias de la Vida: {resultado.Puntajes.puntajeCienciasDeLaVida}");

    //    //    Console.WriteLine($"\nÁREA DE ÉNFASIS RECOMENDADA: {resultado.AreaGanadora}");

    //    //    // Mostrar especialidad según el área ganadora
    //    //    switch (resultado.AreaGanadora)
    //    //    {
    //    //        case "Ingenierías":
    //    //            var espIng = resultado.Puntajes.ObtenerEspecialidadIngenieriaGanadora();
    //    //            if (espIng != "SinDeterminar")
    //    //                Console.WriteLine($"ESPECIALIDAD: {espIng}");
    //    //            break;
    //    //        case "Artes":
    //    //            var espArt = resultado.Puntajes.ObtenerEspecialidadArtesGanadora();
    //    //            if (espArt != "SinDeterminar")
    //    //                Console.WriteLine($"ESPECIALIDAD: {espArt}");
    //    //            break;
    //    //        case "Humanidades":
    //    //            var espHum = resultado.Puntajes.ObtenerEspecialidadHumanidadesGanadora();
    //    //            if (espHum != "SinDeterminar")
    //    //                Console.WriteLine($"ESPECIALIDAD: {espHum}");
    //    //            break;
    //    //        case "Ciencias de la Salud":
    //    //            var espSalud = resultado.Puntajes.ObtenerEspecialidadCienciasSaludGanadora();
    //    //            if (espSalud != "SinDeterminar")
    //    //                Console.WriteLine($"ESPECIALIDAD: {espSalud}");
    //    //            break;
    //    //        case "Ciencias Sociales":
    //    //            var espSoc = resultado.Puntajes.ObtenerEspecialidadCienciasSocialesGanadora();
    //    //            if (espSoc != "SinDeterminar")
    //    //                Console.WriteLine($"ESPECIALIDAD: {espSoc}");
    //    //            break;
    //    //        case "Ciencias Naturales":
    //    //            var espNat = resultado.Puntajes.ObtenerEspecialidadCienciasNaturalesGanadora();
    //    //            if (espNat != "SinDeterminar")
    //    //                Console.WriteLine($"ESPECIALIDAD: {espNat}");
    //    //            break;
    //    //        case "Ciencias de la Vida":
    //    //            var espVida = resultado.Puntajes.ObtenerEspecialidadCienciasVidaGanadora();
    //    //            if (espVida != "SinDeterminar")
    //    //                Console.WriteLine($"ESPECIALIDAD: {espVida}");
    //    //            break;
    //    //    }
    //    //}
    //}

