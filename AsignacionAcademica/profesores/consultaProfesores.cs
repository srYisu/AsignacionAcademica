using AsignacionAcademica.profesores;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AsignacionAcademica
{
    internal class ConsultaProfesores
    {
        private Conexion conexion;
        public ConsultaProfesores()
        {
            conexion = new Conexion();
        }

        public List<GestionProfesores> GetProfesores(string filtro)
        {
            List<GestionProfesores> profesores = new List<GestionProfesores>();
            string query = "SELECT * FROM profesores";
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
                            profesores.Add(new GestionProfesores
                            {
                                id = reader.GetInt32("idProfesores"),
                                nombre = reader.GetString("nombre"),
                                apellidoPaterno = reader.GetString("apellido_P"),
                                apellidoMaterno = reader.GetString("apellido_M"),
                                especialidad = reader.GetString("especialidad"),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener profesores: " + ex.Message);
                }
                finally
                {
                    reader?.Close();
                }
            }

            return profesores;
        }

        public bool AgregarProfesor(GestionProfesores profesor)
        {
            string query = "INSERT INTO profesores (nombre, apellido_P, apellido_M, especialidad) VALUES (@nombre, @apellidoP, @apellidoM, @especialidad)";

            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", profesor.nombre);
                        cmd.Parameters.AddWithValue("@apellidoP", profesor.apellidoPaterno);
                        cmd.Parameters.AddWithValue("@apellidoM", profesor.apellidoMaterno);
                        cmd.Parameters.AddWithValue("@especialidad", profesor.especialidad);

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

        public bool EditarProfesor(GestionProfesores profesor, int id)
        {
            string query = $"UPDATE profesores SET nombre=@nombre, apellido_P=@apellidoP, apellido_M=@apellidoM, especialidad=@especialidad WHERE idProfesores={id}";

            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", profesor.id);
                        cmd.Parameters.AddWithValue("@nombre", profesor.nombre);
                        cmd.Parameters.AddWithValue("@apellidoP", profesor.apellidoPaterno);
                        cmd.Parameters.AddWithValue("@apellidoM", profesor.apellidoMaterno);
                        cmd.Parameters.AddWithValue("@especialidad", profesor.especialidad);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar profesor: " + ex.Message);
                    return false;
                }
            }
        }

        public bool EliminarProfesor(int id)
{
    using (MySqlConnection conn = conexion.ObtenerConexion())
    {
        try
        {
            conn.Open();

            // Verificar si el profesor tiene clases asignadas
            string queryVerificarClases = "SELECT COUNT(*) FROM clases WHERE profesor_id = @id";
            using (MySqlCommand cmdVerificar = new MySqlCommand(queryVerificarClases, conn))
            {
                cmdVerificar.Parameters.AddWithValue("@id", id);
                int clasesAsignadas = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                if (clasesAsignadas > 0)
                {
                    MessageBox.Show("Este profesor se encuentra asignado a una clase. Elimina la clase primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Eliminar el profesor si no tiene clases asignadas
            string queryEliminar = "DELETE FROM profesores WHERE idProfesores = @id";
            using (MySqlCommand cmdEliminar = new MySqlCommand(queryEliminar, conn))
            {
                cmdEliminar.Parameters.AddWithValue("@id", id);
                return cmdEliminar.ExecuteNonQuery() > 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al eliminar profesor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
    }
}
