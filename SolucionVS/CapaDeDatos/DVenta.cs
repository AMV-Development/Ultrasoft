using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Xml;

namespace CapaDeDatos
{
    public class DVenta
    {
        private int _idVenta;
        private int _idCliente;
        private int _idEmpleado;
        private int _secuencia;
        private DateTime _fecha;

        //detalle de venta
        private int _idDetalle;
        private int _idProducto;
        private decimal _unidades;
        private decimal _precioUnitario;
        private decimal _descUnitario;


        public DVenta()
        {

        }

        public DVenta(int idVenta, int idCliente, int idEmpleado, int secuencia, DateTime fecha, int idDetalle, int idProducto, decimal unidades, 
            decimal precioUnitario, decimal descUnitario)
        {
            _idVenta = idVenta;
            _idCliente = idCliente;
            _idEmpleado = idEmpleado;
            _secuencia = secuencia;
            _fecha = fecha;
            _idDetalle = idDetalle;
            _idProducto = idProducto;
            _unidades = unidades;
            _precioUnitario = precioUnitario;
            _descUnitario = descUnitario;
        }

        public int IdVenta { get => _idVenta; set => _idVenta = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public int Secuencia { get => _secuencia; set => _secuencia = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public int IdDetalle { get => _idDetalle; set => _idDetalle = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public decimal Unidades { get => _unidades; set => _unidades = value; }
        public decimal PrecioUnitario { get => _precioUnitario; set => _precioUnitario = value; }
        public decimal DescUnitario { get => _descUnitario; set => _descUnitario = value; }



        /*   public int InsertarVenta(DVenta dVenta,List<DDetalleV>detalle)
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
               parameters.Add(new SqlParameter("parametro 4", Fecha));
               SqlParameter outparam = new SqlParameter("parametro de salida del id venta", SqlDbType.Int);
               outparam.Direction = ParameterDirection.Output;
               parameters.Add(outparam);

               string sp = "nombre del procedimiento";


               rpta = conexion.EjecutarConsultaProcedimiento(sp, parameters) == 1 ? 1 : 0;

               if (rpta.Equals(1))
               {
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
           */

        public int insertarVenta(DataGridView dgv)
        {
            try
            {
                XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                                                  new XElement("nombre del XElement"));
                XElement xl;
                foreach (DataGridView gridView in dgv.Rows)
                {

                    xl = new XElement("rows",
                        new XElement("Codigo del producto", gridView.Rows[0].ToString()),
                        new XElement("Unidades", gridView.Rows[1].ToString()),
                        new XElement("Precio Unitario", gridView.Rows[3].ToString()),
                        new XElement("Unidades", gridView.Rows[4].ToString()),
                        new XElement("descuento", gridView.Rows[5].ToString())
                        );
                    //Agregamos los elementos del rows al xml general
                    xml.Element("nombre del xelement").Add(xl);
                }

                CDConexion conexion = new CDConexion();
                List<SqlParameter> parameters = new List<SqlParameter>();
                SqlParameter param = new SqlParameter();
                parameters.Add(new SqlParameter("parametro 1", IdCliente));
                parameters.Add(new SqlParameter("parametro 2", IdEmpleado));
                parameters.Add(new SqlParameter("parametro 4", Fecha));
                parameters.Add(new SqlParameter("Parametro del xml", xml.ToString()));
                /*  SqlParameter outparam = new SqlParameter("@newid", SqlDbType.Int);
                  outparam.Direction = ParameterDirection.Output;
                  parameters.Add();*/

                string sp = "nombre del procedimiento";

                return conexion.EjecutarConsultaProcedimiento(sp, parameters);


            }
            catch(Exception ex)
            {
                throw ex;
            }
        }





    }
}
