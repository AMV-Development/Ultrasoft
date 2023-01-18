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
        List<SqlParameter> parameters = new List<SqlParameter>();
        SqlParameter param = null;

        public DataTable CD_MostrarProducto()
        {
            return conn.ConsultarDatosProcedimiento("sp_MostrarProducto", parameters);
        }

        public DataTable CD_InsertarCompra()
        {
            return conn.ConsultarDatosProcedimiento("sp_MostrarProducto", null);
        }
    }
}
