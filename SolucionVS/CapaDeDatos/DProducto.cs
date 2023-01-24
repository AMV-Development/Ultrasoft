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

        //  Made by ChurriGOD
        public DataTable buscarPrecioMetrica(int id_producto)
        {
            CDConexion conexion = new CDConexion();
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("@id_producto", id_producto);
            parameters.Add(param);
            string sp = "sp_BuscarPrecioMetrica";
            return conexion.ConsultarDatosProcedimiento(sp, parameters);
        }
        //  Made by ChurriGOD

        public DataTable buscarProductoCod(int id)
        {
            CDConexion conexion = new CDConexion();
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("NOMBRE DEL PARAMETRO",IdProducto);
            parameters.Add(param);
            string sp = "nombre del procedimiento";
            return conexion.ConsultarDatosProcedimiento(sp, parameters);
        }

        public DataTable buscarProductoNombre(string nombre)
        {
            CDConexion conexion = new CDConexion();
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("NOMBRE DEL PARAMETRO", NombreProducto);
            parameters.Add(param);
            string sp = "nombre del procedimiento";
            return conexion.ConsultarDatosProcedimiento(sp, parameters);
        }

    }
}
