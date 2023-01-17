using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class DVenta
    {
        private int _idVenta;
        private int _idCliente;
        private int _idEmpleado;
        private int _secuencia;
        private DateTime _fecha;


        public DVenta()
        {

        }

        public DVenta(int idVenta, int idCliente, int idEmpleado, int secuencia, DateTime fecha)
        {
            _idVenta = idVenta;
            _idCliente = idCliente;
            _idEmpleado = idEmpleado;
            _secuencia = secuencia;
            _fecha = fecha;
        }

        public int IdVenta { get => _idVenta; set => _idVenta = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public int Secuencia { get => _secuencia; set => _secuencia = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }


        public int InsertarVenta(DVenta dVenta,List<DDetalleV>detalle)
        {
            int rpta;
            SqlConnection SqlCon = new SqlConnection();
            SqlCommand SqlCmd = new SqlCommand();
            SqlTransaction sqlTra = SqlCon.BeginTransaction();
            CDConexion conexion = new CDConexion();
            SqlCmd.Transaction = sqlTra;
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter();
            parameters.Add(new SqlParameter("parametro 1", IdCliente));
            parameters.Add(new SqlParameter("parametro 2", IdEmpleado));
            parameters.Add(new SqlParameter("parametro 3", Secuencia));
            parameters.Add(new SqlParameter("parametro 4", Fecha));
            SqlParameter outparam = new SqlParameter("parametro de salida del id venta", SqlDbType.Int);
            outparam.Direction = ParameterDirection.Output;
            parameters.Add(outparam);

            string sp = "nombre del procedimiento";

            // return conexion.EjecutarConsultaProcedimiento(sp, parameters);

            rpta = conexion.EjecutarConsultaProcedimiento(sp, parameters) == 1 ? 1 : 0;

            if (rpta.Equals(1))
            {
                //obtener el codigo de la venta generada
                this.IdVenta = Convert.ToInt32(SqlCmd.Parameters["Parametro ID VENTA"].Value);

                foreach (DDetalleV det in detalle)
                {

                    det.IdVenta = this.IdVenta;
                    rpta = det.insertarDetalleV(det, ref SqlCon, ref sqlTra);
                }
            }
            else
            {
                return 0;
            }

            return rpta;
        }

    }
}
