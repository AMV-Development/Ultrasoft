using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDeDatos
{
   public class DDetalleV
    {
        private int _idDetalle;
        private int _idVenta;
        private int _idProducto;
        private decimal _unidades;
        private decimal _precioUnitario;
        private decimal _descUnitario;

        public DDetalleV()
        {
        }

        public DDetalleV(int idDetalle, int idVenta, int idProducto, decimal unidades, decimal precioUnitario, decimal descUnitario)
        {
            _idDetalle = idDetalle;
            _idVenta = idVenta;
            _idProducto = idProducto;
            _unidades = unidades;
            _precioUnitario = precioUnitario;
            _descUnitario = descUnitario;
        }

        public int IdDetalle { get => _idDetalle; set => _idDetalle = value; }
        public int IdVenta { get => _idVenta; set => _idVenta = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public decimal Unidades { get => _unidades; set => _unidades = value; }
        public decimal PrecioUnitario { get => _precioUnitario; set => _precioUnitario = value; }
        public decimal DescUnitario { get => _descUnitario; set => _descUnitario = value; }

        public int insertarDetalleV(DDetalleV detalleV, ref SqlConnection sqlCon, ref SqlTransaction sqlTra)
        {
            CDConexion conexion = new CDConexion();
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter();
            SqlParameter outparam = new SqlParameter("Output de iddetalle", SqlDbType.Int);
            outparam.Direction = ParameterDirection.Output;
            parameters.Add(outparam);
            parameters.Add(new SqlParameter("id de venta",IdVenta));
            parameters.Add(new SqlParameter("id de producto", IdProducto));
            parameters.Add(new SqlParameter(" unidades ", Unidades));
            parameters.Add(new SqlParameter("precio unitario", PrecioUnitario));
            parameters.Add(new SqlParameter("descuento", DescUnitario));
            

            string sp = "nombre del procedimiento";

            return conexion.EjecutarConsultaProcedimiento(sp, parameters) == 1 ? 1 : 0;
        }
    }
}
