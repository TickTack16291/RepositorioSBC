using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            "Database=abarrotech_v2;" +
            "Uid=root;" +
            "Pwd=;";

        public ConexionBD()
        {

        }

        /// <summary>
        /// Operaciones de productos en la base de datos
        /// </summary>
        public List<Producto> ObtenerProductos()
        {
            List<Producto> listaProductos = new List<Producto>();

            using (var Conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    Conexion.Open();

                    string sql = "SELECT * FROM productos";
                    using (var command = new MySqlCommand(sql, Conexion))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producto productoAux = new Producto(
                                reader.GetInt32(0),       // Id de producto
                                reader.GetString(1),      // Nombre
                                reader.GetString(2),      // Marca
                                reader.GetString(3),      // Presentacion
                                reader.GetString(4),      // Unidad de medida
                                reader.GetFloat(5),       // Precio de venta
                                reader.GetFloat(6),       // Precio de compra
                                reader.GetInt32(7),       // Estado
                                reader.GetString(8),      // Categoria
                                reader.GetInt32(9)        // Id de provedor
                            );

                            listaProductos.Add(productoAux);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }

            return listaProductos;
        }
        public bool AgregarProducto(Producto nuevoProducto)
        {
            using (var Conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    Conexion.Open();

                    string sql = @"INSERT INTO `productos` (`nombre_producto`, `marca_producto`, `presentacion_producto`, `unidad_medida_producto`,
                                  `estado_producto` ,`precio_venta_producto`, `precio_compra_producto`, `categoria_producto`) 
                                   VALUES(@nombre_producto, @marca_producto, @presentacion_producto, @unidad_medida_producto, @estado_producto,
                                   @precio_venta_producto, @precio_compra_producto, @categoria_producto);";

                    using (var command = new MySqlCommand(sql, Conexion))
                    {
                        // Agregamos parámetros para evitar una inyecion de SQL
                        //command.Parameters.AddWithValue("@Id_Producto", nuevoProducto.idProducto); // Es autoincrementable
                        command.Parameters.AddWithValue("@nombre_producto", nuevoProducto.nombre);
                        command.Parameters.AddWithValue("@marca_producto", nuevoProducto.marca);
                        command.Parameters.AddWithValue("@presentacion_producto", nuevoProducto.presentacion);
                        command.Parameters.AddWithValue("@unidad_medida_producto", nuevoProducto.unidadMedida);
                        command.Parameters.AddWithValue("@estado_producto", 1); // Se colocara por defecto 1
                        command.Parameters.AddWithValue("@precio_venta_producto", nuevoProducto.precioVenta);
                        command.Parameters.AddWithValue("@precio_compra_producto", nuevoProducto.precioCompra);
                        command.Parameters.AddWithValue("@categoria_producto", nuevoProducto.categoria);
                        //command.Parameters.AddWithValue("@id_proveedor_producto", nuevoProducto.idProveedor); // No tenemos la tabla de provedores y el campo puede ser null

                        int result = command.ExecuteNonQuery();
                        return result > 0; // Retorna true si se insertó correctamente
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
        public bool ModificarProducto(Producto productoActualizado)
        {
            using (var Conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    Conexion.Open();

                    string sql = @"UPDATE productos SET
                            nombre_producto = @nombre_producto,
                            marca_producto = @marca_producto,
                            presentacion_producto = @presentacion_producto,
                            unidad_medida_producto = @unidad_medida_producto,
                            precio_venta_producto = @precio_venta_producto,
                            precio_compra_producto = @precio_compra_producto,
                            estado_producto = @estado_producto,
                            categoria_producto = @categoria_producto,
                            id_proveedor_producto = @id_proveedor_producto
                        WHERE id_producto = @id_producto";

                    using (var command = new MySqlCommand(sql, Conexion))
                    {
                        command.Parameters.AddWithValue("@id_producto", productoActualizado.idProducto);
                        command.Parameters.AddWithValue("@nombre_producto", productoActualizado.nombre);
                        command.Parameters.AddWithValue("@marca_producto", productoActualizado.marca);
                        command.Parameters.AddWithValue("@presentacion_producto", productoActualizado.presentacion);
                        command.Parameters.AddWithValue("@unidad_medida_producto", productoActualizado.unidadMedida);
                        command.Parameters.AddWithValue("@precio_venta_producto", productoActualizado.precioVenta);
                        command.Parameters.AddWithValue("@precio_compra_producto", productoActualizado.precioCompra);
                        command.Parameters.AddWithValue("@estado_producto", productoActualizado.estado);
                        command.Parameters.AddWithValue("@categoria_producto", productoActualizado.categoria);
                        command.Parameters.AddWithValue("@id_proveedor_producto", productoActualizado.idProveedor);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar producto: " + ex.Message);
                    return false;
                }
            }
        }
        public bool EliminarProducto(int idProducto)
        {
            using (var Conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    Conexion.Open();

                    string sql = "DELETE FROM productos WHERE id_producto = @id_producto";

                    using (var command = new MySqlCommand(sql, Conexion))
                    {
                        command.Parameters.AddWithValue("@id_producto", idProducto);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar producto: " + ex.Message);
                    return false;
                }
            }
        }
  
        /// <summary>
        /// Funciones de validacion para las operciones de la base de datos
        /// </summary>
        public List<int> ObtenerIDs()
        {
            List<int> ids = new List<int>();

            using (var conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string sql = "SELECT Id_Producto FROM productos";

                    using (var comando = new MySqlCommand(sql, conexion))
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("Id_Producto");
                            ids.Add(id);
                        }
                    }

                    return ids;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener IDs: {ex.Message}");
                    return new List<int>();
                }
            }
        }

        /// <summary>
        /// Funciones para el Login
        /// </summary>
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

                    string sql = @"INSERT INTO usuarios (id_empleado, usuario, contrasena, rol_usuario)
                                   VALUES (@id_empleado, @usuario, @contrasena, @rol_usuario)";

                    using (var command = new MySqlCommand(sql, conexion))
                    {
                        command.Parameters.AddWithValue("@id_empleado", usuarioAux.id_empleado);
                        command.Parameters.AddWithValue("@usuario", usuarioAux.usuario);
                        command.Parameters.AddWithValue("@contrasena", usuarioAux.contrasena);
                        command.Parameters.AddWithValue("@rol_usuario", usuarioAux.rol_usuario);

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
    }
}