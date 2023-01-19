using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class DProducto
    {
        private int idProducto;
        private int idMetrica;
        private string nombreProducto;
        private decimal unidades;
        private DateTime fechaRegistro;
        private DateTime fechaActualizacion;
        private DateTime fechaEliminacion;
        private decimal precioCompra;
        private decimal precioVenta;
        private char estado;

        public DProducto()
        {
        }

        public DProducto(int idProducto, int idMetrica, string nombreProducto, decimal unidades, DateTime fechaRegistro, 
            DateTime fechaActualizacion, DateTime fechaEliminacion, decimal precioCompra, decimal precioVenta, char estado)
        {
            this.idProducto = idProducto;
            this.idMetrica = idMetrica;
            this.nombreProducto = nombreProducto;
            this.unidades = unidades;
            this.fechaRegistro = fechaRegistro;
            this.fechaActualizacion = fechaActualizacion;
            this.fechaEliminacion = fechaEliminacion;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
            this.estado = estado;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdMetrica { get => idMetrica; set => idMetrica = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public decimal Unidades { get => unidades; set => unidades = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public DateTime FechaActualizacion { get => fechaActualizacion; set => fechaActualizacion = value; }
        public DateTime FechaEliminacion { get => fechaEliminacion; set => fechaEliminacion = value; }
        public decimal PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public char Estado { get => estado; set => estado = value; }

        public DataTable buscarProductoNombre(string nombre)
        {
            CDConexion conexion = new CDConexion();
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("NOMBRE DEL PARAMETRO", NombreProducto);
            parameters.Add(param);
            string sp = "sp_buscarProducto";
            return conexion.ConsultarDatosProcedimiento(sp, parameters);
        }




















        /*private CDConexion conexion;
        public DProducto()
        {
            this.conexion= new CDConexion();
        }

       /* public DataTable ObtenerProductos(string nombre)
        {
           /* try
            {
                string consulta = "Select p.ID_PRODUCTO, p.NOMBRE_PRODUCTO, p.UNIDADES, m.SIMBOLO, " +
                    "p.PRECIO_COMPRA, p.PRECIO_VENTA, P.FECHA_REGISTRO, " +
                    "CASE WHEN P.FECHA_ACTUALIZACION IS NULL THEN '' else p.FECHA_ACTUALIZACION END as \"FECHA_ACTUALIZACION\", " +
                    "CASE WHEN P.FECHA_ELIMINACION IS NULL THEN '' else p.FECHA_ELIMINACION END as \"FECHA_ELIMINACION\"" +
                    "from dbo.PRODUCTO p INNER JOIN dbo.METRICA m on p.ID_METRICA = m.ID_METRICA where p.NOMBRE_PRODUCTO like '%" +
                    nombre + "%';";
                return conexion.ConsultarDatosTexto(consulta);
            }catch(Exception ex)
            {
                return null;
            }
        }*/
    }
}
