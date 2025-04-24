using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionAcademica.profesores
{
    internal class consultaProfesores
    {
        /*
        private Conexion conexionMySQL;
        private List<GestionProfesores> listaProfesores;
        public consultaProfesores()
        {
            conexionMySQL = new Conexion();
            listaProfesores = new List<GestionProfesores>();
        }
        public List<GestionProfesores> GetProfesores(string filtro)
        {
            string query = "SELECT * FROM profesores";
            MySqlDataReader reader = null;

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                query += " WHERE nombre LIKE @filtro OR apellidoP LIKE @filtro OR apellidoM LIKE @filtro OR especialidad LIKE @filtro";
            }

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conexionMySQL.conect()))
                {
                    if (!string.IsNullOrWhiteSpace(filtro))
                        cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        GestionProfesores p = new GestionProfesores
                        {
                            id = reader.GetInt32("id"),
                            nombre = reader.GetString("nombre"),
                            apellidoP = reader.GetString("apellidoP"),
                            apellidoM = reader.GetString("apellidoM"),
                            especialidad = reader.GetString("especialidad"),
                            disponibilidad = reader.GetBoolean("disponibilidad")
                        };
                        profesores.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                reader?.Close();
            }

            return profesores;
        }

        public bool AgregarProfesor(GestionProfesores profesor)
        {
            string query = "INSERT INTO profesores (nombre, apellidoP, apellidoM, especialidad, disponibilidad) " +
                           "VALUES (@nombre, @apellidoP, @apellidoM, @especialidad, @disponibilidad)";

            using (MySqlCommand cmd = new MySqlCommand(query, conexionMySQL.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@nombre", profesor.nombre);
                cmd.Parameters.AddWithValue("@apellidoP", profesor.apellidoP);
                cmd.Parameters.AddWithValue("@apellidoM", profesor.apellidoM);
                cmd.Parameters.AddWithValue("@especialidad", profesor.especialidad);
                cmd.Parameters.AddWithValue("@disponibilidad", profesor.disponibilidad);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool EditarProfesor(GestionProfesores profesor)
        {
            string query = "UPDATE profesores SET nombre=@nombre, apellidoP=@apellidoP, apellidoM=@apellidoM, " +
                           "especialidad=@especialidad, disponibilidad=@disponibilidad WHERE id=@id";

            using (MySqlCommand cmd = new MySqlCommand(query, conexionMySQL.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@nombre", profesor.nombre);
                cmd.Parameters.AddWithValue("@apellidoP", profesor.apellidoP);
                cmd.Parameters.AddWithValue("@apellidoM", profesor.apellidoM);
                cmd.Parameters.AddWithValue("@especialidad", profesor.especialidad);
                cmd.Parameters.AddWithValue("@disponibilidad", profesor.disponibilidad);
                cmd.Parameters.AddWithValue("@id", profesor.id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool EliminarProfesor(int id)
        {
            string query = "DELETE FROM profesores WHERE id=@id";

            using (MySqlCommand cmd = new MySqlCommand(query, conexionMySQL.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }*/
    }
    
}
