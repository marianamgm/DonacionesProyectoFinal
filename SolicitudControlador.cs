using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DonacionesProyectoFinal;

namespace DonacionesProyectoFinal
{
    internal class SolicitudControlador
    {
        public SolicitudControlador() 
        {
            
        }
        public bool AgregarSolicitud(Solicitud solicitud)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if(conn.State==0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Ins_Solicitud", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario_Id", solicitud.Sol_Solicitud_Id1);
                cmd.Parameters.AddWithValue("@Nombre", solicitud.Sol_Nombre1);
                cmd.Parameters.AddWithValue("@Email", solicitud.Sol_Email1);
                cmd.Parameters.AddWithValue("@Telefono", solicitud.Sol_Telefono1);
                cmd.Parameters.AddWithValue("@CURP", solicitud.Sol_CURP1);
                cmd.Parameters.AddWithValue("@Direccion", solicitud.Sol_Domicilio1);
                cmd.Parameters.AddWithValue("@Descripcion", solicitud.Sol_Descripcion1);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            { 
                return false;
            }
        }

        public bool ActualizarSolicitud(Solicitud solicitud)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Act_Cliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario_Id", solicitud.Sol_Solicitud_Id1);
                cmd.Parameters.AddWithValue("@Nombre", solicitud.Sol_Nombre1);
                cmd.Parameters.AddWithValue("@Email", solicitud.Sol_Email1);
                cmd.Parameters.AddWithValue("@Telefono", solicitud.Sol_Telefono1);
                cmd.Parameters.AddWithValue("@CURP", solicitud.Sol_CURP1);
                cmd.Parameters.AddWithValue("@Direccion", solicitud.Sol_Domicilio1);
                cmd.Parameters.AddWithValue("@Descripcion", solicitud.Sol_Descripcion1);
                cmd.Parameters.AddWithValue("@Descripcion", solicitud.Sol_Descripcion1);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Solicitud ObtenerCliente(int id)
        {
            Solicitud Sol = null;
            try
            {
                SqlConnection conn= new SqlConnection(Conexion.strConexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                DataTable datos = new DataTable();
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Bus_Cliente", conn);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cli_Id",id);
                adaptador.SelectCommand = cmd;
                adaptador.Fill(datos);
                if (datos.Rows.Count > 0)
                {
                    Sol = new Solicitud
                    {
                        Sol_Solicitud_Id1 = Convert.ToInt32(datos.Rows[0].ItemArray[0]),
                        Sol_Nombre1 = datos.Rows[0].ItemArray[1].ToString(),
                        Sol_CURP1 = datos.Rows[0].ItemArray[1].ToString(),
                        Sol_Telefono1 = datos.Rows[0].ItemArray[3].ToString(),
                        Sol_Email1 = datos.Rows[0].ItemArray[1].ToString(),
                        Sol_Domicilio1 = datos.Rows[0].ItemArray[1].ToString(),
                        Sol_Descripcion1 = datos.Rows[0].ItemArray[1].ToString(),
                        Sol_Categoria1 = datos.Rows[0].ItemArray[1].ToString()
                    };
                }
                return ;
            }
            catch 
            {
                return Sol;
            }
        }
        public bool EliminarCliente(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexion.strConexion);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Bor_Cliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cli_Id", id);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Solicitud> ListarClientes()
        { 
            SqlConnection conn= new SqlConnection(Conexion.strConexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataTable datos = new DataTable();
            List<Solicitud> clientes = new List<Solicitud>();

            try
            {
                if(conn.State==0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Lst_Clientes",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand = cmd;
                adaptador.Fill(datos);
                if (datos.Rows.Count > 0)
                {
                    for (int i = 0; i < datos.Rows.Count; i++)
                    {
                        Solicitud.Add(new Solicitud
                        {
                            Sol_Solicitud_Id1 = Convert.ToInt32(datos.Rows[0].ItemArray[0]),
                            Sol_Nombre1 = datos.Rows[0].ItemArray[1].ToString(),
                            Sol_CURP1 = datos.Rows[0].ItemArray[1].ToString(),
                            Sol_Telefono1 = datos.Rows[0].ItemArray[3].ToString(),
                            Sol_Email1 = datos.Rows[0].ItemArray[1].ToString(),
                            Sol_Domicilio1 = datos.Rows[0].ItemArray[1].ToString(),
                            Sol_Descripcion1 = datos.Rows[0].ItemArray[1].ToString(),
                            Sol_Categoria1 = datos.Rows[0].ItemArray[1].ToString()
                        }
                        );
                    
                    }
                }
                return clientes;
            }
            catch 
            { 
                return clientes;
            }
        }
    }
}
