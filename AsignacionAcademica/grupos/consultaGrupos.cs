using AsignacionAcademica.asignaturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AsignacionAcademica.grupos
{
    internal class consultaGrupos
    {
        private Conexion conexion;
        public consultaGrupos()
        {
            conexion = new Conexion();
        }

        public List<GestionGrupos> GetGrupos(string filtro)
        {
            List<GestionGrupos> grupos = new List<GestionGrupos>();
            string query = "SELECT * FROM grupos";
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
                            grupos.Add(new GestionGrupos
                            {
                                id = reader.GetInt32("idGrupos"),
                                grupo = reader.GetString("nombre"),
                                numAlumnos = reader.GetInt32("n_alumnos"),
                                carrera = reader.GetString("curso")
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener grupos: " + ex.Message);
                }
                finally
                {
                    reader?.Close();
                }
            }

            return grupos;
        }

        public bool AgregarGrupo(GestionGrupos grupos)
        {
            string query = "INSERT INTO grupos (nombre, n_alumnos, curso) VALUES (@nombre, @numAlumnos, @carrera)";

            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", grupos.grupo);
                        cmd.Parameters.AddWithValue("@numAlumnos", grupos.numAlumnos);
                        cmd.Parameters.AddWithValue("@carrera", grupos.carrera);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el grupo: " + ex.Message);
                    return false;
                }
            }
        }

        public bool EditarGrupos(GestionGrupos grupos, int id)
        {
            string query = $"UPDATE grupos SET nombre=@nombre, n_alumnos=@numAlumnos, curso=@carrera WHERE idGrupos={id}";

            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", grupos.grupo);
                        cmd.Parameters.AddWithValue("@numAlumnos", grupos.numAlumnos);
                        cmd.Parameters.AddWithValue("@carrera", grupos.carrera);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar grupo: " + ex.Message);
                    return false;
                }
            }
        }

        public bool EliminarGrupo(int id)
        {
            string query = "DELETE FROM grupos WHERE idGrupos=@id";

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
                    MessageBox.Show("Error al eliminar grupo: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
