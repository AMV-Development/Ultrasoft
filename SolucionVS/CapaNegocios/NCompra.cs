using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDatos;

namespace CapaNegocios
{
    public class NCompra
    {
        DCompra dCompra = new DCompra();
        public DataTable BuscarProveedor(string nombreProveedor)
        {
            DCliente_Proveedor dCliente_Proveedor = new DCliente_Proveedor();
            return dCliente_Proveedor.BuscarClienteProveedor(nombreProveedor, "P");
        }

        public DataTable BuscarProducto(string nombreProducto)
        {
            DProducto dProducto = new DProducto();
            return dProducto.buscarProductoNombre(nombreProducto);
        }

        public int AgregarCompra(DataGridView dgvDetalleCompra)
        {
            return dCompra.InsertarCompra(dgvDetalleCompra) == 1 ? 1 : 0;
        }
    }
}
