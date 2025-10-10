namespace LoginDeAbarrotech
{

    public class Usuario
    {
        public int id_usuario { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string nombre { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string preparatoria_origen { get; set; }
        public string diagnostico_area { get; set; }
        public string diagnostico_carrera { get; set; }
        public string comentarios { get; set; }
        public Usuario() { }

        public Usuario(int id_usuario, string usuario, string contrasena, string nombre, string apellido_paterno, string apellido_materno, string preparatoria_origen, string diagnostico_area, string diagnostico_carrera, string comentarios)
        {
            this.id_usuario = id_usuario;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.nombre = nombre;
            this.apellido_paterno = apellido_paterno;
            this.apellido_materno = apellido_materno;
            this.preparatoria_origen = preparatoria_origen;
            this.diagnostico_area = diagnostico_area;
            this.diagnostico_carrera = diagnostico_carrera;
            this.comentarios = comentarios;
        }
    }
}
