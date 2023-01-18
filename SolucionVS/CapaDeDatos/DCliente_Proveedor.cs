﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class DCliente_Proveedor
    {
        // Variables
        private int _ID_Cliente_Proveedor;
        private string _Tipo_Identificacion;
        private string _Identificacion;
        private string _Razon_Social;
        private string _Nombre_Comercial;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _Tipo_Entidad;
        private char _Habilitado;

        //Constructor sin parámetros
        public DCliente_Proveedor()
        {

        }

        //Constructor con parámetros
        public DCliente_Proveedor(int iD_Cliente_Proveedor, string tipo_Identificacion, string identificacion,
                                  string razon_Social, string nombre_Comercial, string direccion, string telefono,
                                  string email, string tipo_Entidad, char habilitado)
        {
            _ID_Cliente_Proveedor = iD_Cliente_Proveedor;
            _Tipo_Identificacion = tipo_Identificacion;
            _Identificacion = identificacion;
            _Razon_Social = razon_Social;
            _Nombre_Comercial = nombre_Comercial;
            _Direccion = direccion;
            _Telefono = telefono;
            _Email = email;
            _Tipo_Entidad = tipo_Entidad;
            _Habilitado = habilitado;
        }

        //  Propiedades
        public int ID_Cliente_Proveedor { get => _ID_Cliente_Proveedor; set => _ID_Cliente_Proveedor = value; }
        public string Tipo_Identificacion { get => _Tipo_Identificacion; set => _Tipo_Identificacion = value; }
        public string Identificacion { get => _Identificacion; set => _Identificacion = value; }
        public string Razon_Social { get => _Razon_Social; set => _Razon_Social = value; }
        public string Nombre_Comercial { get => _Nombre_Comercial; set => _Nombre_Comercial = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Tipo_Entidad { get => _Tipo_Entidad; set => _Tipo_Entidad = value; }
        public char Habilitado { get => _Habilitado; set => _Habilitado = value; }


        //Metodo para buscar un cliente por el numero de identificación
        public DataTable buscarCliente(string identificacion)
        {
            CDConexion conexion = new CDConexion();
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("NOMBRE DEL PARAMETRO",Identificacion);
            parameters.Add(param);
            string sp = "nombre del procedimiento";
            return conexion.ConsultarDatosProcedimiento(sp, parameters);
        }

        //Metodo para registrar cliente y proveedor
        public int insertarClienteProveedorD(DCliente_Proveedor cliente_Proveedor)
        {
            
            CDConexion conexion = new CDConexion();
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter();
            parameters.Add(new SqlParameter("@tipo_identificacion", Tipo_Identificacion));
            parameters.Add(new SqlParameter("@identificacion", Identificacion));
            parameters.Add(new SqlParameter("@razon_social", Razon_Social));
            parameters.Add(new SqlParameter("@nombre_comercial", Nombre_Comercial));
            parameters.Add(new SqlParameter("@direccion", Direccion));
            parameters.Add(new SqlParameter("@telefono", Telefono));
            parameters.Add(new SqlParameter("@email", Email));
            parameters.Add(new SqlParameter("@tipo_entidad", Tipo_Entidad));
          /*  SqlParameter outparam = new SqlParameter("@newid", SqlDbType.Int);
            outparam.Direction = ParameterDirection.Output;
            parameters.Add();*/

            string sp = "sp_registrarClienteProveedor";

           return conexion.EjecutarConsultaProcedimiento(sp, parameters) == 1 ? 1 : 0;




            
        }

        //Método Mostrar
        public DataTable Mostrar()
        {
             DataTable DtResultado = new DataTable("cliente_proveedor");
             SqlConnection SqlCon = new SqlConnection();
             CDConexion conn = new CDConexion();
             try
             {

                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.Connection = conn.AbrirConexion();
                 SqlCmd.CommandText = "sp_mostraDatosClientesProv";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                 SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                 SqlDat.Fill(DtResultado);

             }
             catch (Exception ex)
             {
                 DtResultado = null;
             }
             return DtResultado;

     
            




        }

    }
}
