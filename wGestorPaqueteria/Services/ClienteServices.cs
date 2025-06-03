using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using wGestorPaqueteria.Entities;
using wGestorPaqueteria.Utils;

namespace wGestorPaqueteria.Services
{
    public class ClienteService
    {
        private readonly SqlConnection conn;

        public ClienteService()
        {
            conn = DbConnectionSingleton.Instancia;
        }
        public List<Cliente> ObtenerClientes()
        {
            var clientes = new List<Cliente>();
            var cmd = new SqlCommand("SELECT * FROM Clientes", conn);

            conn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clientes.Add(new Cliente
                {
                    ClienteID = (int)reader["ClienteID"],
                    Nombre = reader["Nombre"].ToString(),
                    Telefono = reader["Telefono"].ToString(),
                    Email = reader["Email"].ToString(),
                    Direccion = reader["Direccion"].ToString()
                });
            }
            conn.Close();
            return clientes;
        }

        public bool RegistrarCliente(Cliente cliente)
        {
            using (var cmd = new SqlCommand("sp_RegistrarCliente", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                return rows > 0;
            }
        }

        public void EliminarCliente(int clienteID)
        {
            var conn = DbConnectionSingleton.Instancia;
            var cmd = new SqlCommand("sp_EliminarCliente", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ClienteID", clienteID);

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
