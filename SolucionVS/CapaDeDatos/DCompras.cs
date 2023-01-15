using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace CapaDeDatos
{
    public class DCompras
    {
        CDConexion conn = new CDConexion();
        SqlParameterCollection param = null;
        public DataTable CD_MostrarProveedor()
        {
            param.AddWithValue("@TIPO_ENTIDAD","P");
            return conn.ConsultarDatosProcedimiento("sp_BuscarClienteProveedor", param);
        }

        public DataTable CD_MostrarProducto()
        {
            return conn.ConsultarDatosProcedimiento("sp_MostrarProducto", param);
        }

        public DataTable CD_InsertarCompra()
        {
            return conn.ConsultarDatosProcedimiento("sp_MostrarProducto", param);
        }
    }
}
