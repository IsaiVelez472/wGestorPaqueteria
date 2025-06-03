using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using wGestorPaqueteria.Entities;
using wGestorPaqueteria.Utils;
using System.Windows.Forms;
using System;

namespace wGestorPaqueteria.Services
{
    public class PaqueteService
    {
        private readonly SqlConnection conn;

        public PaqueteService()
        {
            conn = DbConnectionSingleton.Instancia;
        }

        public List<Paquete> ListarPaquetes(int? paqueteId = null)
        {
            var paquetes = new List<Paquete>();

            using (var cmd = new SqlCommand("SELECT * FROM Paquetes WHERE (@PaqueteID IS NULL OR PaqueteID = @PaqueteID) ", conn))
            {
                cmd.Parameters.AddWithValue("@PaqueteID", (object)paqueteId ?? DBNull.Value);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        paquetes.Add(new Paquete
                        {
                            PaqueteID = (int)reader["PaqueteID"],
                            NumeroSeguimiento = reader["NumeroSeguimiento"].ToString(),
                            Peso = (decimal)reader["Peso"],
                            Dimensiones = reader["Dimensiones"].ToString(),
                            ValorDeclarado = (decimal)reader["ValorDeclarado"],
                            Estado = reader["Estado"].ToString(),
                            RemitenteID = (int)reader["RemitenteID"],
                            DestinatarioID = (int)reader["DestinatarioID"]
                        });
                    }
                }
                conn.Close();
            }

            return paquetes;
        }

        public bool RegistrarPaquete(Paquete paquete)
        {
            using (var cmd = new SqlCommand("sp_RegistrarPaquete", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroSeguimiento", paquete.NumeroSeguimiento);
                cmd.Parameters.AddWithValue("@Peso", paquete.Peso);
                cmd.Parameters.AddWithValue("@Dimensiones", paquete.Dimensiones);
                cmd.Parameters.AddWithValue("@ValorDeclarado", paquete.ValorDeclarado);
                cmd.Parameters.AddWithValue("@RemitenteID", paquete.RemitenteID);
                cmd.Parameters.AddWithValue("@DestinatarioID", paquete.DestinatarioID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                return rows > 0;
            }
        }

        public bool CambiarEstado(int paqueteId, string nuevoEstado)
        {
            using (var cmd = new SqlCommand("sp_CambiarEstadoPaquete", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PaqueteID", paqueteId);
                cmd.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                return rows > 0;
            }
        }

        public bool RegistrarSeguimiento(int paqueteId, DateTime fechaEvento, string descripcion, string ubicacion)
        {
            var conn = DbConnectionSingleton.Instancia;
            using (var cmd = new SqlCommand("sp_RegistrarEventoSeguimiento", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PaqueteID", paqueteId);
                cmd.Parameters.AddWithValue("@FechaEvento", fechaEvento);
                cmd.Parameters.AddWithValue("@DescripcionEvento", descripcion);
                cmd.Parameters.AddWithValue("@Ubicacion", ubicacion);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                return rows > 0;
            }
        }

        public void EliminarPaquete(int paqueteID)
        {
            var conn = DbConnectionSingleton.Instancia;
            var cmd = new SqlCommand("sp_EliminarPaquete", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdPaquete", paqueteID);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public bool AsignarPaqueteAConductor(int paqueteId, int empleadoId, out string error)
        {
            error = null;
            var conn = DbConnectionSingleton.Instancia;

            try
            {
                using (var cmd = new SqlCommand("sp_AsignarPaqueteConductor", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PaqueteID", paqueteId);
                    cmd.Parameters.AddWithValue("@EmpleadoID", empleadoId);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (SqlException ex)
            {
                // Detectar si el error vino del RAISERROR en SQL Server
                if (ex.Number == 50000 && ex.Message.Contains("ya ha sido asignado"))
                {
                    error = "ya_asignado";
                }
                else
                {
                    error = "otro_error";
                }
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }


        public List<AsignacionPaquete> ObtenerAsignaciones(int? empleadoId = null)
        {
            var paquetes = new List<AsignacionPaquete>();

            using (var cmd = new SqlCommand("SELECT * FROM Vista_PaquetesAsignados WHERE (@EmpleadoID IS NULL OR EmpleadoID = @EmpleadoID) ORDER BY UltimaFechaEvento DESC", conn))
            {
                cmd.Parameters.AddWithValue("@EmpleadoID", (object)empleadoId ?? DBNull.Value);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        paquetes.Add(new AsignacionPaquete
                        {
                            AsignacionID = (int)reader["AsignacionID"],
                            PaqueteID = (int)reader["PaqueteID"],
                            NumeroSeguimiento = reader["NumeroSeguimiento"].ToString(),
                            Estado = reader["Estado"].ToString(),
                            UltimaFechaEvento = (DateTime)reader["UltimaFechaEvento"],
                            RemitenteID = (int)reader["RemitenteID"],
                            RemitenteNombre = reader["RemitenteNombre"].ToString(),
                            DireccionRemitente = reader["DireccionRemitente"].ToString(),
                            DestinatarioID = (int)reader["DestinatarioID"],
                            DestinatarioNombre = reader["DestinatarioNombre"].ToString(),
                            DireccionDestinatario = reader["DireccionDestinatario"].ToString()
                        });
                    }
                }
                conn.Close();
            }

            return paquetes;
        }


        public DataTable GenerarReporteEnvios()
        {
            var conn = DbConnectionSingleton.Instancia;
            using (SqlCommand cmd = new SqlCommand("sp_GenerarReporteEnvios", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();
                adapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }
    }
}
