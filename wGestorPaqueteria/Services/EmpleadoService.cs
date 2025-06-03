using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wGestorPaqueteria.Entities;
using wGestorPaqueteria.Utils;

namespace wGestorPaqueteria.Services
{
    public class EmpleadoService
    {
        private readonly SqlConnection conn;

        public EmpleadoService()
        {
            conn = DbConnectionSingleton.Instancia;
        }
        public List<Empleado> ListarEmpleados(string nombreRol = default)
        {
            var paquetes = new List<Empleado>();

            using (var cmd = new SqlCommand("SELECT e.EmpleadoID, e.Nombre,r.NombreRol, e.Telefono FROM Empleados e INNER JOIN Roles r ON e.RolId = r.IdRol WHERE (e.RolId != 1 AND (@NombreRol IS NULL OR e.RolId = (SELECT  TOP 1 IdRol FROM Roles WHERE NombreRol= @NombreRol)))", conn))
            {
                cmd.Parameters.AddWithValue("@NombreRol", (object)nombreRol?? DBNull.Value);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        paquetes.Add(new Empleado
                        {
                            EmpleadoID = (int)reader["EmpleadoID"],
                            Nombre = reader["Nombre"].ToString(),
                            Rol = reader["NombreRol"].ToString(),
                            Celular = reader["Telefono"].ToString()
                        });
                    }
                }
                conn.Close();
            }

            return paquetes;
        }

        public List<Empleado> ListarUsuarios(string nombreRol = default)
        {
            var paquetes = new List<Empleado>();

            using (var cmd = new SqlCommand("SELECT e.EmpleadoID, e.Nombre,r.NombreRol, e.Telefono FROM Empleados e INNER JOIN Roles r ON e.RolId = r.IdRol WHERE (e.RolId != 1 AND (@NombreRol IS NULL OR e.RolId = (SELECT  TOP 1 IdRol FROM Roles WHERE NombreRol= @NombreRol)))", conn))
            {
                cmd.Parameters.AddWithValue("@NombreRol", (object)nombreRol ?? DBNull.Value);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        paquetes.Add(new Empleado
                        {
                            EmpleadoID = (int)reader["EmpleadoID"],
                            Nombre = reader["Nombre"].ToString(),
                            Rol = reader["NombreRol"].ToString(),
                            Celular = reader["Telefono"].ToString()
                        });
                    }
                }
                conn.Close();
            }

            return paquetes;
        }

        public bool RegistrarEmpleado(Empleado empleado)
        {
            using (var cmd = new SqlCommand("sp_RegistrarEmpleado", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("@RolNombre", empleado.Rol);
                cmd.Parameters.AddWithValue("@Telefono", empleado.Celular);
               

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                return rows > 0;
            }
        }

        public void EliminarEmpleado(int empleadoID)
        {
            var conn = DbConnectionSingleton.Instancia;
            var cmd = new SqlCommand("sp_EliminarEmpleado", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);

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
