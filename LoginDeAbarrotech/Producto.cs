using System;

namespace LoginDeAbarrotech
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string presentacion { get; set; }
        public string unidadMedida { get; set; }
        public float precioCompra { get; set; }
        public float precioVenta { get; set; }
        public int estado { get; set; }
        public string categoria { get; set; }
        public int idProveedor { get; set; }

        public Producto() { }

        public Producto(int idProducto, string nombre, string marca, string presentacion, string unidadMedida, float precioCompra, float precioVenta, int estado, string categoria, int idProveedor){
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.marca = marca;
            this.presentacion = presentacion;
            this.unidadMedida = unidadMedida;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
            this.estado = estado;
            this.categoria = categoria;
            this.idProveedor = idProveedor;
        }
    }
}