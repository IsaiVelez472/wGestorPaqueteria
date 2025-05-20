using System.Collections.Generic;
using System.Data.SqlClient;
using wGestorPaqueteria.Entities;
using wGestorPaqueteria.Utils;

namespace wGestorPaqueteria.Services
{
    public class ClienteService
    {
        public List<Cliente> ObtenerClientes()
        {
            var clientes = new List<Cliente>();
            var conn = DbConnectionSingleton.Instancia;
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
    }
}
