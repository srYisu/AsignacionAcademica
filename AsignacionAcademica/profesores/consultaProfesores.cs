using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        // Método para agregar un profesor
        public bool GuardarProfesor(string nombre, string apellidoP, string apellidoM, string especialidad)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO profesores (nombre, apellido_P, apellido_M, especialidad) 
                             VALUES (@nombre, @apellidoP, @apellidoM, @especialidad)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellidoP", apellidoP);
                    cmd.Parameters.AddWithValue("@apellidoM", apellidoM);
                    cmd.Parameters.AddWithValue("@especialidad", especialidad);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para eliminar un profesor
        public bool EliminarProfesor(int idProfesor)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                // Verificar si el profesor tiene clases asignadas
                string queryVerificar = @"SELECT COUNT(*) FROM clases WHERE profesor_id = @idProfesor";
                using (MySqlCommand cmdVerificar = new MySqlCommand(queryVerificar, conn))
                {
                    cmdVerificar.Parameters.AddWithValue("@idProfesor", idProfesor);
                    int clasesAsignadas = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                    if (clasesAsignadas > 0)
                    {
                        MessageBox.Show("El profesor tiene clases asignadas. Elimina las clases primero.");
                        return false;
                    }
                }

                // Eliminar el profesor si no tiene clases asignadas
                string queryEliminar = @"DELETE FROM profesores WHERE idProfesores = @idProfesor";
                using (MySqlCommand cmdEliminar = new MySqlCommand(queryEliminar, conn))
                {
                    cmdEliminar.Parameters.AddWithValue("@idProfesor", idProfesor);
                    return cmdEliminar.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para actualizar un profesor
        public bool ActualizarProfesor(int idProfesor, string nombre, string apellidoP, string apellidoM, string especialidad)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE profesores 
                             SET nombre = @nombre, apellido_P = @apellidoP, apellido_M = @apellidoM, especialidad = @especialidad 
                             WHERE idProfesores = @idProfesor";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idProfesor", idProfesor);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellidoP", apellidoP);
                    cmd.Parameters.AddWithValue("@apellidoM", apellidoM);
                    cmd.Parameters.AddWithValue("@especialidad", especialidad);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para consultar todos los profesores
        public DataTable ConsultarProfesores()
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT idProfesores AS ID, 
                                    nombre AS Nombre, 
                                    apellido_P AS ApellidoPaterno, 
                                    apellido_M AS ApellidoMaterno, 
                                    especialidad AS Especialidad
                             FROM profesores";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}