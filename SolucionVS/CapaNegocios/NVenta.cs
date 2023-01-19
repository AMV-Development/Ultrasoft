using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NVenta
    {
       /* public static int insertarVenta(int idCliente, int idEmpleado, int secuencia, DateTime fecha, DataTable dtDetalle)
        {
            
                DVenta venta = new DVenta();
                venta.IdCliente = idCliente;
                venta.IdEmpleado = idEmpleado;
                venta.Secuencia = secuencia;
                venta.Fecha = fecha;
                List<DDetalleV> detalles = new List<DDetalleV>();
                foreach (DataRow row in dtDetalle.Rows)
                {
                    DDetalleV detalle = new DDetalleV();
                    detalle.IdProducto = int.Parse(row["IdProducto"].ToString());
                    detalle.Unidades = decimal.Parse(row["Unidades"].ToString());
                    detalle.PrecioUnitario = decimal.Parse(row["PrecioUnitario"].ToString());
                    detalle.DescUnitario = decimal.Parse(row["descuentoUnitario"].ToString());
                    detalles.Add(detalle);
                }
                //return venta.InsertarVenta(venta, detalles);
        }*/
    }
}

