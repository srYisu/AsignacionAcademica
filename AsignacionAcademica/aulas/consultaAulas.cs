using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionAcademica.aulas
{
    internal class consultaAulas
    {
        private Conexion conexion;
        public consultaAulas()
        {
            conexion = new Conexion();
        }

        public List<GestionAulas> GetAulas(string filtro)
        {
            List<GestionAulas> aulas = new List<GestionAulas>();
            string query = "SELECT * FROM aulas";
            MySqlDataReader reader = null;

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                query += " WHERE nombre LIKE @filtro OR apellidoP LIKE @filtro OR apellidoM LIKE @filtro OR especialidad LIKE @filtro";
            }

            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(filtro))
                            cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            aulas.Add(new GestionAulas
                            {
                                id = reader.GetInt32("idAulas"),
                                nombre = reader.GetString("nombre"),
                                capacidad = reader.GetInt32("capacidad"),
                                ubicacion = reader.GetString("ubicacion"),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener aulas: " + ex.Message);
                }
                finally
                {
                    reader?.Close();
                }
            }

            return aulas;
        }

        public bool AgregarAula(GestionAulas aulas)
        {
            string query = "INSERT INTO aulas (nombre, capacidad, ubicacion) VALUES (@nombre, @capacidad, @ubicacion)";

            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", aulas.nombre);
                        cmd.Parameters.AddWithValue("@capacidad", aulas.capacidad);
                        cmd.Parameters.AddWithValue("@ubicacion", aulas.ubicacion);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar profesor: " + ex.Message);
                    return false;
                }
            }
        }

        public bool EditarAula(GestionAulas aulas, int id)
        {
            string query = $"UPDATE aulas SET nombre=@nombre, capacidad=@capacidad, ubicacion=@ubicacion WHERE idAulas={id}";

            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", aulas.nombre);
                        cmd.Parameters.AddWithValue("@capacidad", aulas.capacidad);
                        cmd.Parameters.AddWithValue("@ubicacion", aulas.ubicacion);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar aulas: " + ex.Message);
                    return false;
                }
            }
        }

        public bool EliminarAula(int id)
        {
            string query = "DELETE FROM aulas WHERE idAulas=@id";

            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar aula: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
