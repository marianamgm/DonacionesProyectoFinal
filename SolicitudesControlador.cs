using DonacionesProyectoFinal;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;
using System.Net.Sockets;

internal class SolicitudesControlador 
{
    private string connectionString = "workstation id=BDDonacionesSolidaridad.mssql.somee.com;packet size = 4096; user id = YamiOs_SQLLogin_1; pwd=loebqsyiq6;data source = BDDonacionesSolidaridad.mssql.somee.com; persist security info=False;initial catalog = BDDonacionesSolidaridad; TrustServerCertificate=True";

    public bool AgregarSolicitud(Solicitud solicitud)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(Conexion.strConexion))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Solicitud_Insert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@usuario_id", solicitud.UsuarioId);
                    cmd.Parameters.AddWithValue("@nombre", solicitud.Nombre);
                    cmd.Parameters.AddWithValue("@categoria", solicitud.Categoria);
                    cmd.Parameters.AddWithValue("@telefono", solicitud.Telefono);
                    cmd.Parameters.AddWithValue("@email", solicitud.Email);
                    cmd.Parameters.AddWithValue("@domicilio", solicitud.Domicilio);
                    cmd.Parameters.AddWithValue("@curp", solicitud.Curp);
                    cmd.Parameters.AddWithValue("@descripcion", solicitud.Descripcion);


                    conn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al guardar: " + ex.Message);
            return false;
        }
    }

    public bool ActualizarSolicitud(Solicitud solicitud)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(Conexion.strConexion))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Solicitud_Update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@solicitud_id", solicitud.SolicitudId);
                    cmd.Parameters.AddWithValue("@usuario_id", solicitud.UsuarioId);
                    cmd.Parameters.AddWithValue("@nombre", solicitud.Nombre);
                    cmd.Parameters.AddWithValue("@categoria", solicitud.Categoria);
                    cmd.Parameters.AddWithValue("@telefono", solicitud.Telefono);
                    cmd.Parameters.AddWithValue("@email", solicitud.Email);
                    cmd.Parameters.AddWithValue("@domicilio", solicitud.Domicilio);
                    cmd.Parameters.AddWithValue("@curp", solicitud.Curp);
                    cmd.Parameters.AddWithValue("@descripcion", solicitud.Descripcion);

                    conn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
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
                using (SqlCommand cmd = new SqlCommand("sp_Solicitud_Delete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@solicitud_id", id);

                    conn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al eliminar: " + ex.Message);
            return false;
        }
    }

    public List<Solicitud> ListarSolicitudes()
    {
        var solicitudes = new List<Solicitud>();

        try
        {
            using (SqlConnection conn = new SqlConnection(Conexion.strConexion))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Solicitud_GetAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            solicitudes.Add(new Solicitud()
                            {
                                SolicitudId = Convert.ToInt32(reader["solicitud_id"]),
                                UsuarioId = Convert.ToInt32(reader["usuario_id"]),
                                Nombre = reader["nombre"].ToString(),
                                Categoria = reader["categoria"].ToString(),
                                Telefono = reader["telefono"].ToString(),
                                Email = reader["email"].ToString(),
                                Domicilio = reader["domicilio"].ToString(),
                                Curp = reader["curp"].ToString(),
                                Descripcion = reader["descripcion"].ToString()
                            });
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al listar: " + ex.Message);
        }

        return solicitudes;
    }
}
