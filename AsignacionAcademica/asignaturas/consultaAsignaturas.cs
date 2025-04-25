using AsignacionAcademica.aulas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AsignacionAcademica.asignaturas
{
    internal class consultaAsignaturas
    {
        private Conexion conexion;
        public consultaAsignaturas()
        {
            conexion = new Conexion();
        }

        public List<GestionAsignaturas> GetAsignaturas(string filtro)
        {
            List<GestionAsignaturas> asignaturas = new List<GestionAsignaturas>();
            string query = "SELECT * FROM asignaturas";
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
                            asignaturas.Add(new GestionAsignaturas
                            {
                                id = reader.GetInt32("idAsignaturas"),
                                asignatura = reader.GetString("nombre"),
                                tipo = reader.GetString("tipo"),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener asignaturas: " + ex.Message);
                }
                finally
                {
                    reader?.Close();
                }
            }

            return asignaturas;
        }

        public bool AgregarAsignatura(GestionAsignaturas asignaturas)
        {
            string query = "INSERT INTO asignaturas (nombre, tipo) VALUES (@asignatura, @tipo)";

            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@asignatura", asignaturas.asignatura);
                        cmd.Parameters.AddWithValue("@tipo", asignaturas.tipo);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la asignatura: " + ex.Message);
                    return false;
                }
            }
        }

        public bool EditarAsignatura(GestionAsignaturas asignaturas, int id)
        {
            string query = $"UPDATE asignaturas SET nombre=@asignatura, tipo=@tipo WHERE idAsignaturas={id}";

            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@asignatura", asignaturas.asignatura);
                        cmd.Parameters.AddWithValue("@tipo", asignaturas.tipo);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar asignaturas: " + ex.Message);
                    return false;
                }
            }
        }

        public bool EliminarAsignatura(int id)
        {
            string query = "DELETE FROM asignaturas WHERE idAsignaturas=@id";

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
                    MessageBox.Show("Error al eliminar asignatura: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
