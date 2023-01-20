using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Venta
    {
        private int id_venta;
        private int id_cliente;
        private int id_empleado;
        private int secuencia;
        private DateTime fecha;
        private List<DetalleVenta> detalles;

        public Venta()
        {
            this.detalles = new List<DetalleVenta>();
        }

        public int Id_venta { get => id_venta; set => id_venta = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public int Secuencia { get => secuencia; set => secuencia = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        internal List<DetalleVenta> Detalles { get => detalles; set => detalles = value; }
    }
}
