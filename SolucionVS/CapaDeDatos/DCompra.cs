using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CapaDeDatos
{
    public class DCompra
    {
        private int _idCompra;
        private int _idProveedor;
        private int _idEmpleado;
        private int _secuencia;
        private DateTime _fecha;

        //detalle de compra
        private int _idDetalleCompra;
        private int _idProducto;
        private decimal _unidadesBruto;
        private decimal _unidadesNeto;
        private decimal _precioUnitario;

        public DCompra()
        {

        }

        public DCompra(int idCompra, int idProveedor, int idEmpleado, int secuencia, DateTime fecha, 
                       int idDetalleCompra, int idProducto, decimal unidadesBruto, decimal unidadesNeto,
                       decimal precioUnitario)
        {
            _idCompra = idCompra;
            _idProveedor = idProveedor;
            _idEmpleado = idEmpleado;
            _secuencia = secuencia;
            _fecha = fecha;
            _idDetalleCompra = idDetalleCompra;
            _idProducto = idProducto;
            _unidadesBruto = unidadesBruto;
            _unidadesNeto = unidadesNeto;
            _precioUnitario = precioUnitario;
        }

        //Propiedades
        public int IdCompra { get => _idCompra; set => _idCompra = value; }
        public int IdProveedor { get => _idProveedor; set => _idProveedor = value; }
        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public int Secuencia { get => _secuencia; set => _secuencia = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public int IdDetalleCompra { get => _idDetalleCompra; set => _idDetalleCompra = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public decimal UnidadesBruto { get => _unidadesBruto; set => _unidadesBruto = value; }
        public decimal UnidadesNeto { get => _unidadesNeto; set => _unidadesNeto = value; }
        public decimal PrecioUnitario { get => _precioUnitario; set => _precioUnitario = value; }

        CDConexion conn = new CDConexion();

        public int InsertarCompra(DataGridView dgvCompra)
        {
            try
            {
                XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                                                  new XElement("nombre del XElement"));
                XElement xl;
                foreach (DataGridView gridView in dgvCompra.Rows)
                {
                    xl = new XElement("rows",
                        new XElement("Codigo del producto", gridView.Rows[0].ToString()),
                        new XElement("Nombre del producto", gridView.Rows[1].ToString()),
                        new XElement("Unidad Bruta", gridView.Rows[2].ToString()),
                        new XElement("Unidad Neto", gridView.Rows[3].ToString()),
                        new XElement("Metrica", gridView.Rows[4].ToString()),
                        new XElement("Precio Unitario", gridView.Rows[5].ToString()),
                        new XElement("Subtotal", gridView.Rows[6].ToString())
                        );
                    //Agregamos los elementos del rows al xml general
                    xml.Element("nombre del xelement").Add(xl);
                }

                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("parametro 1", IdProducto));
                parameters.Add(new SqlParameter("parametro 2", IdEmpleado));
                parameters.Add(new SqlParameter("parametro 4", Fecha));
                parameters.Add(new SqlParameter("Parametro del xml", xml.ToString()));

                string sp = "nombre del procedimiento";

                return conn.EjecutarConsultaProcedimiento(sp, parameters) == 1 ? 1 : 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
