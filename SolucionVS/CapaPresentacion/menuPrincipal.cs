﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xa1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int Wparam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]

        public static extern bool ReleaseCapture();
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrivilegioUusario()
        {
            if (Program.Cargo == "2")
            {
            }
            if (Program.Cargo == "3")
            {
            }
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
        private void menuVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirFormulario(object Formhijo)
        {
            if (this.pnlarea.Controls.Count > 0)
                this.pnlarea.Controls.RemoveAt(0);
            Form fn = Formhijo as Form;
            fn.TopLevel = false;
            fn.Dock = DockStyle.Fill;
            this.pnlarea.Controls.Add(fn);
            this.pnlarea.Tag = fn;
            fn.Show();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Compras());
        }

        private void barraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            AbrirFormulario(new menuInicio());
            PrivilegioUusario();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(new Venta());
            AbrirFormulario(new frmVentas());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuCliente());
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuTrabajador());
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuProveedor());
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Registro());
        }

        private void btnProveedor_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuProveedor());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new eliminar());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuConfiguracion());
        }

        private void btnCliente_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void btnActividad_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void btnInicio_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void barraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void pnlarea_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void pnlContenedor_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Inicio_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuCliente());
        }

        private void btnEmpleado_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuTrabajador());
        }

        private void btnProveedor_Click_2(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuProveedor());
        }

        private void btnRegistro_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new frmListaProductos());
            
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new eliminar());
        }

        private void btnConfiguracion_Click_1(object sender, EventArgs e)
        {
        }

        private void btnActividad_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void btnRegistro_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void btnCliente_Click_2(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
=======
            panel2.Visible = false;
            panel3.Visible = false;
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            AbrirFormulario(new frmCliente_Proveedor());
        }

        private void btnEmpleado_Click_2(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            AbrirFormulario(new MenuTrabajador());
=======
            panel2.Visible = false;
            panel3.Visible = false;
            AbrirFormulario(new frmEmpleado());
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        }

        private void btnProveedor_Click_3(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuProveedor());
        }

        private void btnConfiguracion_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuConfiguracion());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new DatosDelComercial());
        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new menuInicio());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Reportes());
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

