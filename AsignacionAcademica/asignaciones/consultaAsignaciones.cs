using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AsignacionAcademica.asignaciones
{
    internal class consultaAsignaciones
    {
        Conexion conexion = new Conexion();

        public bool GuardarClaseSiDisponible(int grupoId, int profesorId, int aulaId, int asignaturaId, string dia, TimeSpan horaInicio, TimeSpan horaFin)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                // Validar que el profesor no tenga otra clase en ese horario
                string queryProfesorClase = @"SELECT COUNT(*) FROM clases 
                                WHERE profesor_id = @profesorId AND dia = @dia 
                                AND ((hora_inicio < @horaFin AND hora_fin > @horaInicio))";
                using (MySqlCommand cmd = new MySqlCommand(queryProfesorClase, conn))
                {
                    cmd.Parameters.AddWithValue("@profesorId", profesorId);
                    cmd.Parameters.AddWithValue("@dia", dia);
                    cmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                    cmd.Parameters.AddWithValue("@horaFin", horaFin);

                    int enUso = Convert.ToInt32(cmd.ExecuteScalar());
                    if (enUso > 0)
                    {
                        MessageBox.Show("El profesor ya tiene otra clase en ese horario.");
                        return false;
                    }
                }

                // Validar que el aula no tenga otra clase en ese horario
                string queryAulaClase = @"SELECT COUNT(*) FROM clases 
                            WHERE aula_id = @aulaId AND dia = @dia 
                            AND ((hora_inicio < @horaFin AND hora_fin > @horaInicio))";
                using (MySqlCommand cmd = new MySqlCommand(queryAulaClase, conn))
                {
                    cmd.Parameters.AddWithValue("@aulaId", aulaId);
                    cmd.Parameters.AddWithValue("@dia", dia);
                    cmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                    cmd.Parameters.AddWithValue("@horaFin", horaFin);

                    int enUso = Convert.ToInt32(cmd.ExecuteScalar());
                    if (enUso > 0)
                    {
                        MessageBox.Show("El aula ya está ocupada en ese horario.");
                        return false;
                    }
                }

                // Insertar la clase si todo es válido
                string insertQuery = @"INSERT INTO clases (grupo_id, profesor_id, aula_id, asignatura_id, dia, hora_inicio, hora_fin)
                       VALUES (@grupoId, @profesorId, @aulaId, @asignaturaId, @dia, @horaInicio, @horaFin)";
                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@grupoId", grupoId);
                    insertCmd.Parameters.AddWithValue("@profesorId", profesorId);
                    insertCmd.Parameters.AddWithValue("@aulaId", aulaId);
                    insertCmd.Parameters.AddWithValue("@asignaturaId", asignaturaId);
                    insertCmd.Parameters.AddWithValue("@dia", dia);
                    insertCmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                    insertCmd.Parameters.AddWithValue("@horaFin", horaFin);

                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        // ELIMINAR clase
        public bool EliminarClase(int idClase)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string deleteQuery = "DELETE FROM clases WHERE idClases = @idClase";
                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@idClase", idClase);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ACTUALIZAR clase
        public bool ActualizarClase(int idClase, int grupoId, int profesorId, int aulaId, int asignaturaId, string dia, TimeSpan horaInicio, TimeSpan horaFin)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                // Validar que el profesor no tenga otra clase en ese horario (excluyendo esta clase)
                string queryProfesor = @"SELECT COUNT(*) FROM clases 
                          WHERE profesor_id = @profesorId AND dia = @dia 
                          AND ((hora_inicio < @horaFin AND hora_fin > @horaInicio))
                          AND idClases != @idClase";
                using (MySqlCommand cmd = new MySqlCommand(queryProfesor, conn))
                {
                    cmd.Parameters.AddWithValue("@profesorId", profesorId);
                    cmd.Parameters.AddWithValue("@dia", dia);
                    cmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                    cmd.Parameters.AddWithValue("@horaFin", horaFin);
                    cmd.Parameters.AddWithValue("@idClase", idClase);

                    int enUso = Convert.ToInt32(cmd.ExecuteScalar());
                    if (enUso > 0)
                    {
                        MessageBox.Show("El profesor ya tiene otra clase en ese horario.");
                        return false;
                    }
                }

                // Validar que el aula no tenga otra clase en ese horario (excluyendo esta clase)
                string queryAula = @"SELECT COUNT(*) FROM clases 
                      WHERE aula_id = @aulaId AND dia = @dia 
                      AND ((hora_inicio < @horaFin AND hora_fin > @horaInicio))
                      AND idClases != @idClase";
                using (MySqlCommand cmd = new MySqlCommand(queryAula, conn))
                {
                    cmd.Parameters.AddWithValue("@aulaId", aulaId);
                    cmd.Parameters.AddWithValue("@dia", dia);
                    cmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                    cmd.Parameters.AddWithValue("@horaFin", horaFin);
                    cmd.Parameters.AddWithValue("@idClase", idClase);

                    int enUso = Convert.ToInt32(cmd.ExecuteScalar());
                    if (enUso > 0)
                    {
                        MessageBox.Show("El aula ya está ocupada en ese horario.");
                        return false;
                    }
                }

                // Actualizar la clase
                string updateQuery = @"UPDATE clases SET grupo_id = @grupoId, profesor_id = @profesorId, aula_id = @aulaId, 
                        asignatura_id = @asignaturaId, dia = @dia, hora_inicio = @horaInicio, hora_fin = @horaFin
                        WHERE idClases = @idClase";
                using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@grupoId", grupoId);
                    cmd.Parameters.AddWithValue("@profesorId", profesorId);
                    cmd.Parameters.AddWithValue("@aulaId", aulaId);
                    cmd.Parameters.AddWithValue("@asignaturaId", asignaturaId);
                    cmd.Parameters.AddWithValue("@dia", dia);
                    cmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                    cmd.Parameters.AddWithValue("@horaFin", horaFin);
                    cmd.Parameters.AddWithValue("@idClase", idClase);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private bool ValidarDisponibilidadProfesor(int profesorId, string dia, TimeSpan horaInicio, TimeSpan horaFin, int idClaseExcluir = 0)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                // Validar horario disponible del profesor
                string queryDisponibilidad = @"SELECT COUNT(*) FROM profesordisponibilidad 
                                      WHERE profesor_id = @profesorId AND dia_semana = @dia 
                                      AND hora_inicio <= @horaInicio AND hora_fin >= @horaFin";
                using (MySqlCommand cmd = new MySqlCommand(queryDisponibilidad, conn))
                {
                    cmd.Parameters.AddWithValue("@profesorId", profesorId);
                    cmd.Parameters.AddWithValue("@dia", dia);
                    cmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                    cmd.Parameters.AddWithValue("@horaFin", horaFin);

                    int disponible = Convert.ToInt32(cmd.ExecuteScalar());
                    if (disponible == 0)
                    {
                        MessageBox.Show("El profesor no está disponible en ese horario.");
                        return false;
                    }
                }

                // Validar que no tenga otra clase en ese horario (excluyendo la actual si es una actualización)
                string queryClases = @"SELECT COUNT(*) FROM clases 
                                 WHERE profesor_id = @profesorId AND dia = @dia 
                                 AND ((hora_inicio < @horaFin AND hora_fin > @horaInicio))
                                 AND idClases != @idClaseExcluir";
                using (MySqlCommand cmd = new MySqlCommand(queryClases, conn))
                {
                    cmd.Parameters.AddWithValue("@profesorId", profesorId);
                    cmd.Parameters.AddWithValue("@dia", dia);
                    cmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                    cmd.Parameters.AddWithValue("@horaFin", horaFin);
                    cmd.Parameters.AddWithValue("@idClaseExcluir", idClaseExcluir);

                    int enUso = Convert.ToInt32(cmd.ExecuteScalar());
                    if (enUso > 0)
                    {
                        MessageBox.Show("El profesor ya tiene otra clase en ese horario.");
                        return false;
                    }
                }

                return true;
            }
        }

        private bool ValidarDisponibilidadAula(int aulaId, string dia, TimeSpan horaInicio, TimeSpan horaFin, int idClaseExcluir = 0)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                // Validar horario disponible del aula
                string queryDisponibilidad = @"SELECT COUNT(*) FROM auladisponibilidad 
                                      WHERE aula_id = @aulaId AND dia_semana = @dia 
                                      AND hora_inicio <= @horaInicio AND hora_fin >= @horaFin";
                using (MySqlCommand cmd = new MySqlCommand(queryDisponibilidad, conn))
                {
                    cmd.Parameters.AddWithValue("@aulaId", aulaId);
                    cmd.Parameters.AddWithValue("@dia", dia);
                    cmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                    cmd.Parameters.AddWithValue("@horaFin", horaFin);

                    int disponible = Convert.ToInt32(cmd.ExecuteScalar());
                    if (disponible == 0)
                    {
                        MessageBox.Show("El aula no está disponible en ese horario.");
                        return false;
                    }
                }

                // Validar que no tenga otra clase en ese horario (excluyendo la actual si es una actualización)
                string queryClases = @"SELECT COUNT(*) FROM clases 
                                 WHERE aula_id = @aulaId AND dia = @dia 
                                 AND ((hora_inicio < @horaFin AND hora_fin > @horaInicio))
                                 AND idClases != @idClaseExcluir";
                using (MySqlCommand cmd = new MySqlCommand(queryClases, conn))
                {
                    cmd.Parameters.AddWithValue("@aulaId", aulaId);
                    cmd.Parameters.AddWithValue("@dia", dia);
                    cmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                    cmd.Parameters.AddWithValue("@horaFin", horaFin);
                    cmd.Parameters.AddWithValue("@idClaseExcluir", idClaseExcluir);

                    int enUso = Convert.ToInt32(cmd.ExecuteScalar());
                    if (enUso > 0)
                    {
                        MessageBox.Show("El aula ya está ocupada en ese horario.");
                        return false;
                    }
                }

                return true;
            }
        }

        public DataTable ConsultarClases()
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT c.idClases, g.nombre AS Grupo, p.nombre AS Profesor, a.nombre AS Aula, asig.nombre AS Asignatura, c.dia, c.hora_inicio, c.hora_fin
                             FROM clases c
                             JOIN grupos g ON c.grupo_id = g.idGrupos
                             JOIN profesores p ON c.profesor_id = p.idProfesores
                             JOIN aulas a ON c.aula_id = a.idAulas
                             JOIN asignaturas asig ON c.asignatura_id = asig.idAsignaturas";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataRow ObtenerClasePorId(int idClase)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT * FROM clases WHERE idClases = @idClase";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@idClase", idClase);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                    return dt.Rows[0];
                else
                    return null;
            }
        }
    }
}