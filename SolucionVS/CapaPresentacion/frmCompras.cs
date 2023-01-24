using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocios;

namespace CapaPresentacion
{
    public partial class frmCompras : Form
    {
        NCompras Compras;
        NCliente_Proveedor Proveedor;
        DataTable dt = new DataTable();

        public frmCompras()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            cargarCombos();
        }

        private void cargarCombos()
        {
            Compras = new NCompras();

            cboProducto.DataSource = Compras.CN_CargarProducto();
            cboProducto.DisplayMember = "NOMBRE_PRODUCTO";
            cboProducto.ValueMember = "ID_PRODUCTO";

            cboProducto.SelectedIndex = -1;

            cboProveedor.DataSource = Compras.CN_CargarProveedor();
            cboProveedor.DisplayMember = "NOMBRE_COMERCIAL";
            cboProveedor.ValueMember = "ID_CLIENTE_PROVEEDOR";

            cboProveedor.SelectedIndex = -1;
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int producto_id = Convert.ToInt32(cboProducto.SelectedValue);
            dt = Compras.CN_BuscarPrecioMetrica(producto_id);
            txtPrecio.Text = dt.Rows[0][1].ToString();
            txtMetrica.Text = dt.Rows[0][0].ToString();
        }

        private void cargarPrecio(int producto_id)
        {
            cboPrecio.DataSource = Compras.CN_CargarProducto();
            cboProducto.DisplayMember = "NOMBRE_PRODUCTO";
            cboProducto.ValueMember = "ID_PRODUCTO";
        }
    }
}
