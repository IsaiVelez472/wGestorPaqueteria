using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using wGestorPaqueteria.Entities;
using wGestorPaqueteria.Utils;

namespace wGestorPaqueteria.Services
{
    public class PaqueteService
    {
        private readonly SqlConnection conn;

        public PaqueteService()
        {
            conn = DbConnectionSingleton.Instancia;
        }

        public List<Paquete> ListarPaquetes()
        {
            var paquetes = new List<Paquete>();

            using (var cmd = new SqlCommand("SELECT * FROM Paquetes", conn))
            {
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
    }
}
