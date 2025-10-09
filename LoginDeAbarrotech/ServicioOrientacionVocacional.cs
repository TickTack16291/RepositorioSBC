using Reglas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDeAbarrotech
{

    public class ServicioOrientacionVocacional
    {
        private PuntajeArea _puntajesActuales;
        private List<string> _areasGanadoras;
        private RespuestaUsuario _respuestasAcumuladas;

        public ServicioOrientacionVocacional()
        {


            _respuestasAcumuladas = new RespuestaUsuario();
            _puntajesActuales = new PuntajeArea();
        }

        public (List<String> Areas, bool EsEmpate) ProcesarPrimeraFase(string p1, string p2, string p3, string p4, string p5,
        string p6, string p7, string p8, string p9, string p10)
        {
            ///Guardar las repuestas Iniciales
            _respuestasAcumuladas.respuestaNo1 = p1;
            _respuestasAcumuladas.respuestaNo2 = p2;
            _respuestasAcumuladas.respuestaNo3 = p3;
            _respuestasAcumuladas.respuestaNo4 = p4;
            _respuestasAcumuladas.respuestaNo5 = p5;
            _respuestasAcumuladas.respuestaNo6 = p6;
            _respuestasAcumuladas.respuestaNo7 = p7;
            _respuestasAcumuladas.respuestaNo8 = p8;
            _respuestasAcumuladas.respuestaNo9 = p9;
            _respuestasAcumuladas.respuestaNo10 = p10;

            var resultado = MotorOrientacionVocacional.DeterminarAreaEnfasis(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);

            _areasGanadoras = resultado.AreaGanadora;
            _puntajesActuales = resultado.Puntajes;
            return (resultado.AreaGanadora, resultado.AreaGanadora.Count > 1);

        }

        public List<int> ObtenerRangoPreguntasParaArea(string area)
        {
            var mapeoPreguntas = new Dictionary<string, List<int>>
            {
                ["Ingenierías"] = new List<int> { 11, 12, 13, 14, 15, 16, 17 },
                ["Artes"] = new List<int> { 18, 19, 20, 21, 22 },
                ["Humanidades"] = new List<int> { 23, 24, 25, 26, 27 },
                ["Ciencias de la Salud"] = new List<int> { 28, 29, 30, 31, 32, 33 },
                ["Ciencias Sociales"] = new List<int> { 34, 35, 36, 37, 38 },
                ["Ciencias Naturales"] = new List<int> { 39, 40, 41, 42, 43, 44, 45 },
                ["Ciencias de la Vida"] = new List<int> { 46, 47, 48, 49, 50, 51, 52 }
            };

            return mapeoPreguntas.ContainsKey(area) ? mapeoPreguntas[area] : new List<int>();
        }

        public void ProcesarRespuestasEspecificas(Dictionary<int, string> respuestasPorNumero)
        {

            ///Actualizar el objeto de las respuestas acumuladas por las nuevas respuestas especificas
            foreach (var respuesta in respuestasPorNumero)
            {
                var propiedad = _respuestasAcumuladas.GetType().GetProperty($"preguntaNo{respuesta.Key}");
                if (propiedad != null)
                {
                    propiedad.SetValue(_respuestasAcumuladas, respuesta.Value);
                }
            }

            ///Ejecutar todas las reglas con todas las repuestas Acumuladas //Alch no se ni que verga es este pedo
            _puntajesActuales = MotorOrientacionVocacional.ProcesarTodasLasReglas(_respuestasAcumuladas);
        }

        public Dictionary<string, string> ObtenerResultadosFinales()
        {
            var resultados = new Dictionary<string, string>();

            resultados["Area Principal"] = _puntajesActuales.ObtenerAreaGanadora();

            foreach (var area in _areasGanadoras)
            {
                var especialidad = area switch
                {
                    "Ingenierías" => _puntajesActuales.ObtenerEspecialidadIngenieriaGanadora(),
                    "Artes" => _puntajesActuales.ObtenerEspecialidadArtesGanadora(),
                    "Humanidades" => _puntajesActuales.ObtenerEspecialidadHumanidadesGanadora(),
                    "Ciencias de la Salud" => _puntajesActuales.ObtenerEspecialidadCienciasSaludGanadora(),
                    "Ciencias Sociales" => _puntajesActuales.ObtenerEspecialidadCienciasSocialesGanadora(),
                    "Ciencias Naturales" => _puntajesActuales.ObtenerEspecialidadCienciasNaturalesGanadora(),
                    "Ciencias de la Vida" => _puntajesActuales.ObtenerEspecialidadCienciasVidaGanadora(),
                    _ => "Sin determinar"
                };

                resultados[$"Especialidad en {area}"] = especialidad;
            }

            //agregar puntajes detallados si se necesitan
            resultados["Puntaje Ingenierías"] = _puntajesActuales.puntajeIngenieria.ToString();
            resultados["Puntaje Ciencias de la Salud"] = _puntajesActuales.puntajeCienciasSalud.ToString();
            ///quiza haya que aregar mas si se necestan
            ///
            return resultados;
        }

        public List<string> LimitarEmpateADosAreas(List<string> areasEmpatadas)
        {

            if (areasEmpatadas.Count <= 2)
                return areasEmpatadas;

            // Si hay más de 2 áreas empatadas, tomar las primeras 2 con mejor puntaje
            // (esto es un ejemplo, puedes implementar la lógica que prefieras)
            return areasEmpatadas.Take(2).ToList();
        }
        public List<string> AreasGanadoras => _areasGanadoras;
    }
}
