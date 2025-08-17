using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DonacionesProyectoFinal
{
    internal class SDonacionControlador
    {
        public bool AgregarDonacion(DonacionesMS donaciones)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.strConexion))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Ins_Donacion", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@dNombre", donaciones.dNombre);
                    cmd.Parameters.AddWithValue("@dEmail", donaciones.dEmail);
                    cmd.Parameters.AddWithValue("@dTelefono", donaciones.dTelefono);
                    cmd.Parameters.AddWithValue("@dCURP", donaciones.dCURP);
                    cmd.Parameters.AddWithValue("@dDireccion", donaciones.dDireccion);
                    cmd.Parameters.AddWithValue("@dDescripcion", donaciones.dDescripcion);
                    cmd.Parameters.AddWithValue("@dCategoria", donaciones.dCategoria);

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

        public bool ActualizarDonacion(DonacionesMS donaciones)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.strConexion))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Act_Donacion", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@dId", donaciones.dId);
                    cmd.Parameters.AddWithValue("@dNombre", donaciones.dNombre);
                    cmd.Parameters.AddWithValue("@dEmail", donaciones.dEmail);
                    cmd.Parameters.AddWithValue("@dTelefono", donaciones.dTelefono);
                    cmd.Parameters.AddWithValue("@dCURP", donaciones.dCURP);
                    cmd.Parameters.AddWithValue("@dDireccion", donaciones.dDireccion);
                    cmd.Parameters.AddWithValue("@dDescripcion", donaciones.dDescripcion);
                    cmd.Parameters.AddWithValue("@dCategoria", donaciones.dCategoria);

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

        public bool EliminarDonacion(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.strConexion))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Bor_Donacion", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@dId", id);

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

        public List<DonacionesMS> ListarDonacion()
        {
            List<DonacionesMS> lista = new List<DonacionesMS>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.strConexion))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Lst_Donaciones", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable datos = new DataTable();
                    adaptador.Fill(datos);

                    foreach (DataRow row in datos.Rows)
                    {
                        lista.Add(new DonacionesMS
                        {
                            dId = Convert.ToInt32(row["dId"]),
                            dNombre = row["dNombre"].ToString(),
                            dCURP = row["dCURP"].ToString(),
                            dTelefono = row["dTelefono"].ToString(),
                            dEmail = row["dEmail"].ToString(),
                            dDireccion = row["dDireccion"].ToString(),
                            dDescripcion = row["dDescripcion"].ToString(),
                            dCategoria = row["dCategoria"].ToString()
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