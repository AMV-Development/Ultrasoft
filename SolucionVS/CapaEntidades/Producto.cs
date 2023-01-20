using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class Producto
    {
        private int id_producto;
        private Metrica metrica;
        private string nombre_producto;
        private decimal unidades;
        private DateTime fecha_registro;
        private DateTime fecha_actualziacion;
        private DateTime fecha_eliminacion;
        private decimal precio_compra;
        private decimal precio_venta;
        private string estado;

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public Metrica Metrica { get => metrica; set => metrica = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public decimal Unidades { get => unidades; set => unidades = value; }
        public DateTime Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        public DateTime Fecha_actualziacion { get => fecha_actualziacion; set => fecha_actualziacion = value; }
        public DateTime Fecha_eliminacion { get => fecha_eliminacion; set => fecha_eliminacion = value; }
        public decimal Precio_compra { get => precio_compra; set => precio_compra = value; }
        public decimal Precio_venta { get => precio_venta; set => precio_venta = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
