using MySql.Data.MySqlClient;
using System;
using System.Windows;


/// <summary>
/// Conexion a la base de datos y funciones para hacer consultas en ella
/// </summary>

namespace LoginDeAbarrotech
{
    internal class ConexionBD
    {
        private string conexionString =
            "Server=localhost;" +
            "Port=3306;" +
            "Database=sistemaexperto_orientacion;" +
            "Uid=root;" +
            "Pwd=;";

        public ConexionBD()
        {

        }

        public bool validar_inicio_sesion(string usuario, string contrasena)
        {
            using (var conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string sql = "SELECT usuario, contrasena FROM usuarios";
                    using (var command = new MySqlCommand(sql, conexion))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string usuarioObtenido = reader.GetString(0);
                            string contrasenaObtenida = reader.GetString(1);
                            if (usuario == usuarioObtenido && contrasena == contrasenaObtenida)
                                return true;
                        }
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al validar el inicio de sesion con la base de datos: " + ex.Message);
                    return false;
                }
            }
        }
        public bool validar_usuarios_repetidos(string usuario)
        {
            using (var conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string sql = "SELECT usuario FROM usuarios";
                    using (var command = new MySqlCommand(sql, conexion))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string usuarioObtenido = reader.GetString(0);
                            if (usuario == usuarioObtenido)
                                return true;
                        }
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al validar el usuario en la base de datos: " + ex.Message);
                    return false;
                }
            }
        }
        public bool ingresar_usuarios(Usuario usuarioAux)
        {
            using (var conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string sql = @"INSERT INTO usuarios 
                (usuario, contrasena, nombre, apellido_paterno, apellido_materno, preparatoria_origen)
                VALUES (@usuario, @contrasena, @nombre, @apellido_paterno, @apellido_materno, @preparatoria_origen)";

                    using (var command = new MySqlCommand(sql, conexion))
                    {
                        command.Parameters.AddWithValue("@usuario", usuarioAux.usuario);
                        command.Parameters.AddWithValue("@contrasena", usuarioAux.contrasena);
                        command.Parameters.AddWithValue("@nombre", usuarioAux.nombre);
                        command.Parameters.AddWithValue("@apellido_paterno", usuarioAux.apellido_paterno);
                        command.Parameters.AddWithValue("@apellido_materno", usuarioAux.apellido_materno);
                        command.Parameters.AddWithValue("@preparatoria_origen", usuarioAux.preparatoria_origen);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar el usuario a la base de datos: " + ex.Message);
                    return false;
                }
            }
        }
        public bool modificar_usuarios(Usuario usuarioAux)
        {
            using (var conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string sql = @"UPDATE usuarios SET 
                contrasena = @contrasena,
                nombre = @nombre,
                apellido_paterno = @apellido_paterno,
                apellido_materno = @apellido_materno,
                preparatoria_origen = @preparatoria_origen
                WHERE usuario = @usuario";

                    using (var command = new MySqlCommand(sql, conexion))
                    {
                        command.Parameters.AddWithValue("@contrasena", usuarioAux.contrasena);
                        command.Parameters.AddWithValue("@nombre", usuarioAux.nombre);
                        command.Parameters.AddWithValue("@apellido_paterno", usuarioAux.apellido_paterno);
                        command.Parameters.AddWithValue("@apellido_materno", usuarioAux.apellido_materno);
                        command.Parameters.AddWithValue("@preparatoria_origen", usuarioAux.preparatoria_origen);
                        command.Parameters.AddWithValue("@usuario", usuarioAux.usuario);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el usuario en la base de datos: " + ex.Message);
                    return false;
                }
            }
        }

        public (bool, Usuario) obtener_datos_usuario(string usuario, string cont)
        {
            using (var conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string sql = "SELECT * FROM usuarios WHERE usuario = @usuario and contrasena = @contrasena";
                    using (var command = new MySqlCommand(sql, conexion))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@contrasena", cont);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Usuario usuarioObtenido = new Usuario
                                {
                                    id_usuario = reader.GetInt32("id_usuario"),
                                    usuario = reader.GetString("usuario"),
                                    contrasena = reader.GetString("contrasena"),
                                    nombre = reader.GetString("nombre"),
                                    apellido_paterno = reader.GetString("apellido_paterno"),
                                    apellido_materno = reader.GetString("apellido_materno"),
                                    preparatoria_origen = reader.GetString("preparatoria_origen"),
                                    diagnostico_area = reader.IsDBNull(reader.GetOrdinal("diagnostico_area")) ? null : reader.GetString("diagnostico_area"),
                                    diagnostico_carrera = reader.IsDBNull(reader.GetOrdinal("diagnostico_carrera")) ? null : reader.GetString("diagnostico_carrera"),
                                    comentarios = reader.IsDBNull(reader.GetOrdinal("comentarios")) ? null : reader.GetString("comentarios")
                                };
                                return (true, usuarioObtenido);
                            }
                            else
                            {
                                return (false, null);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos del usuario desde la base de datos: " + ex.Message);
                    return (false, null);
                }
            }
        }
    }
}