using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class DetalleVenta
    {
        private int id_detalle_venta;
        private int id_venta;
        private Producto Producto;
        private decimal unidades;
        private decimal precio_unitario;

        public int Id_detalle_venta { get => id_detalle_venta; set => id_detalle_venta = value; }
        public int Id_venta { get => id_venta; set => id_venta = value; }
        public decimal Unidades { get => unidades; set => unidades = value; }
        public decimal Precio_unitario { get => precio_unitario; set => precio_unitario = value; }
        internal Producto Producto1 { get => Producto; set => Producto = value; }
    }
}
