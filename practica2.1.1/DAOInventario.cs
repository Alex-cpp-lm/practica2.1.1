using MySql.Data.MySqlClient;
using practica2._1._1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2._1
{
    internal class DAOInventario
    {
        private string connectionString = "Server=52.249.217.6;Database=practica1;UserID=alex;Password=alex123";


        public MySqlConnection conectar()
        {
            return new MySqlConnection(connectionString);
        }

        public Inventario ObtenerInventarioPorId(int id)
        {
            Inventario inventario = new Inventario();
            using (var connection = conectar())
            {
                string query = "SELECT * FROM Inventario WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    inventario.Id = reader.GetInt32("id");
                    inventario.NombreCorto = reader.GetString("NombreCorto");
                    inventario.Color = reader.GetString("Color");
                    inventario.FechaAdquisicion = reader.GetString("FechaAdquisicion");
                    inventario.Descripcion = reader.GetString("Descripcion");
                    inventario.Serie = reader.GetString("Serie");
                    inventario.TipoAdquisicion = reader.GetString("TipoAdquisicion");
                    inventario.Observaciones = reader.GetString("Observaciones");
                    inventario.AreaId = reader.GetInt32("Areas_Id");
                }
            }
            return inventario;
        }

        public List<Inventario> ObtenerInventario()
        {
            List<Inventario> inventarios = new List<Inventario>();
            using (var connection = conectar())
            {
                string query = "SELECT * FROM Inventario";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Inventario inv = new Inventario
                    {
                        Id = reader.GetInt32("id"),
                        NombreCorto = reader.GetString("NombreCorto"),
                        Color = reader.GetString("Color"),
                        // Comprobamos si el valor de la fecha es DBNull antes de asignarlo
                        FechaAdquisicion = reader.GetString("FechaAdquisicion"),
                        Descripcion = reader.GetString("Descripcion"),
                        Serie = reader.GetString("Serie"),
                        TipoAdquisicion = reader.GetString("TipoAdquisicion"),
                        Observaciones = reader.GetString("Observaciones"),
                        AreaId = reader.GetInt32("AREAS_id")
                    };

                    inventarios.Add(inv);
                }
            }
            return inventarios;
        }

        public bool AgregarInventario(Inventario a)
        {
            using (var connection = conectar())
            {
                string query = "INSERT INTO Inventario(NombreCorto, Color, FechaAdquisicion, Descripcion, Serie, TipoAdquisicion, Observaciones, Areas_Id) " +
                               "VALUES(@nombreCorto, @color, @fechaAdquisicion, @descripcion, @serie, @tipoAdquisicion, @observaciones, @areaId)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombreCorto", a.NombreCorto);
                command.Parameters.AddWithValue("@color", a.Color);
                command.Parameters.AddWithValue("@fechaAdquisicion", a.FechaAdquisicion);
                command.Parameters.AddWithValue("@descripcion", a.Descripcion);
                command.Parameters.AddWithValue("@serie", a.Serie);
                command.Parameters.AddWithValue("@tipoAdquisicion", a.TipoAdquisicion);
                command.Parameters.AddWithValue("@observaciones", a.Observaciones);
                command.Parameters.AddWithValue("@areaId", a.AreaId);

                connection.Open();
                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al agregar inventario: " + ex.Message);
                    return false;
                }
            }
        }

        public void EliminarInventario(Inventario a)
        {
            using (var connection = conectar())
            {
                string query = "DELETE FROM Inventario WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", a.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void EliminarInventario(int id)
        {
            using (var connection = conectar())
            {
                string query = "DELETE FROM Inventario WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        
        public void ModificarInventario(Inventario inventario)
        {
            using (var connection = conectar())
            {
                string query = "UPDATE Inventario SET NombreCorto = @nombreCorto, Descripcion = @descripcion, " +
                               "Serie = @serie, Color = @color, FechaAdquisicion = @fechaAdquisicion, " +
                               "TipoAdquisicion = @tipoAdquisicion, Observaciones = @observaciones, AREAS_id = @areasId " +
                               "WHERE id = @id";

                MySqlCommand command = new MySqlCommand(query, connection);

                // Asignamos los parámetros al comando de la consulta SQL
                command.Parameters.AddWithValue("@nombreCorto", inventario.NombreCorto);
                command.Parameters.AddWithValue("@descripcion", inventario.Descripcion);
                command.Parameters.AddWithValue("@serie", inventario.Serie);
                command.Parameters.AddWithValue("@color", inventario.Color);
                command.Parameters.AddWithValue("@fechaAdquisicion", inventario.FechaAdquisicion);
                command.Parameters.AddWithValue("@tipoAdquisicion", inventario.TipoAdquisicion);
                command.Parameters.AddWithValue("@observaciones", inventario.Observaciones);
                command.Parameters.AddWithValue("@areasId", inventario.AreaId);
                command.Parameters.AddWithValue("@id", inventario.Id);

                // Ejecutamos la consulta SQL
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
       

    }
}
