using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DonacionesProyectoFinal;
using System.Windows.Forms;

namespace proyectoLogin
{
    internal class SAnimalesControlador
    {
        public SAnimalesControlador() 
        {
            
        }
        public bool AgregarSolicitud(Solicitud solicitud)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.strConexion))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Ins_Solicitud", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", solicitud.Nombre);
                    cmd.Parameters.AddWithValue("@Email", solicitud.Email);
                    cmd.Parameters.AddWithValue("@Telefono", solicitud.Telefono);
                    cmd.Parameters.AddWithValue("@CURP", solicitud.CURP);
                    cmd.Parameters.AddWithValue("@Direccion", solicitud.Domicilio);
                    cmd.Parameters.AddWithValue("@Descripcion", solicitud.Descripcion);
                    cmd.Parameters.AddWithValue("@Categoria", solicitud.Categoria);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
                return false;

            }
        }

        public bool ActualizarSolicitud(Solicitud solicitud)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.strConexion))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Act_Solicitud", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", solicitud.Id);
                    cmd.Parameters.AddWithValue("@Nombre", solicitud.Nombre);
                    cmd.Parameters.AddWithValue("@Email", solicitud.Email);
                    cmd.Parameters.AddWithValue("@Telefono", solicitud.Telefono);
                    cmd.Parameters.AddWithValue("@CURP", solicitud.CURP);
                    cmd.Parameters.AddWithValue("@Direccion", solicitud.Domicilio);
                    cmd.Parameters.AddWithValue("@Descripcion", solicitud.Descripcion);
                    cmd.Parameters.AddWithValue("@Categoria", solicitud.Categoria);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
                return false;
            }
        }

        public bool EliminarSolicitud(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.strConexion))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Bor_Solicitud", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
                return false;
            }
        }

        public List<Solicitud> ListarSolicitud()
        {
            List<Solicitud> lista = new List<Solicitud>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.strConexion))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Lst_Solicitudes", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable datos = new DataTable();
                    adaptador.Fill(datos);

                    foreach (DataRow row in datos.Rows)
                    {
                        lista.Add(new Solicitud
                        {
                            Id = Convert.ToInt32(row["Id"]),
                            Nombre = row["Nombre"].ToString(),
                            CURP = row["CURP"].ToString(),
                            Telefono = row["Telefono"].ToString(),
                            Email = row["Email"].ToString(),
                            Domicilio = row["Direccion"].ToString(),
                            Descripcion = row["Descripcion"].ToString(),
                            Categoria = row["Categoria"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar: " + ex.Message);
            }
            return lista;
        }
    }
}