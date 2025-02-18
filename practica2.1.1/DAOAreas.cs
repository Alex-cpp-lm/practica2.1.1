using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practica2._1._1;

namespace Practica2._1
{
    internal class DAOArea
    {
        private string connectionString = "Server=52.249.217.6;Database=practica1;UserID=alex;Password=alex123";

        public MySqlConnection conectar()
        {
            return new MySqlConnection(connectionString);
        }

        public bool AgregarArea(Area a)
        {
            using (var connection = conectar())
            {
                string query = "INSERT INTO AREAS(Nombre, Ubicacion) VALUES(@nombre,@ubicacion)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", a.Nombre);
                command.Parameters.AddWithValue("@ubicacion", a.Ubicacion);
                connection.Open();
                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al agregar área: " + ex.Message);
                    return false;
                }
            }
        }

        public void EliminarArea(Area a)
        {
            using (var connection = conectar())
            {
                string query = "DELETE FROM AREAS WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", a.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void EliminarArea(int id)
        {
            using (var connection = conectar())
            {
                string query = "DELETE FROM AREAS WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void ModificarArea(Area a)
        {
            using (var connection = conectar())
            {
                string query = "UPDATE AREAS SET Nombre = @nombre , Ubicacion = @ubicacion WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", a.Id); // Se corrige aquí
                command.Parameters.AddWithValue("@nombre", a.Nombre);
                command.Parameters.AddWithValue("@ubicacion", a.Ubicacion);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<string> ObtenerIDAreas()
        {
            List<string> areas = new List<string>();
            using (var connection = conectar())
            {
                string query = "SELECT id,Nombre FROM AREAS";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    areas.Add(reader.GetInt32("id") + "-" + reader.GetString("Nombre"));
                }
            }
            return areas;
        }

        public Area ObtenerArea(int id)
        {
            Area a = new Area();
            using (var connection = conectar())
            {
                string query = "SELECT * FROM AREAS WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    a.Id = reader.GetInt32("id");
                    a.Nombre = reader.GetString("Nombre");
                    a.Ubicacion = reader.GetString("Ubicacion");
                }
            }
            return a;
        }

        public List<Area> ObtenerAreas()
        {
            List<Area> lista = new List<Area>();
            using (var connection = conectar())
            {
                string query = "SELECT * FROM AREAS";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Area a = new Area
                    {
                        Id = reader.GetInt32("id"),
                        Nombre = reader.GetString("Nombre"),
                        Ubicacion = reader.GetString("Ubicacion")
                    };
                    lista.Add(a);
                }
            }
            return lista;
        }
    }
}
