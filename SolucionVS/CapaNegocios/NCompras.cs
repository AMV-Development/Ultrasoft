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
        readonly DCliente_Proveedor dCliente_Proveedor = new DCliente_Proveedor();
        readonly DCompras dCompras = new DCompras();
        public DataTable CN_CargarProveedor()
        {
            return dCliente_Proveedor.CN_BuscarClienteProveedor("P");
        }

        public DataTable CN_CargarProducto()
        {
            return dCompras.CD_MostrarProducto();
        }

        public DataTable CN_AgregarCompra(int codigo, string nombreProducto, double precioUnitario,
                                          double cantidadBruta, double cantidadNeta, string metrica,
                                          string fecha)
        {
            return dCompras.CD_InsertarCompra();
        }
    }
}
