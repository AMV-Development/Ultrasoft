using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaNegocios
{
    public class NCompras
    {
        DCompras nCompras = new DCompras();
        public DataTable CN_CargarProveedor()
        {
            return nCompras.CD_MostrarProveedor();
        }

        public DataTable CN_CargarProducto()
        {
            return nCompras.CD_MostrarProveedor();
        }

        public DataTable CN_AgregarCompra(int codigo, string nombreProducto, double precioUnitario, double cantidadBruta, double cantidadNeta)
        {
            return nCompras.CD_InsertarCompra();
        }
    }
}
