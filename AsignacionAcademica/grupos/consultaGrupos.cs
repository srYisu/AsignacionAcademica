using AsignacionAcademica.asignaturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace AsignacionAcademica.grupos
{
    internal class consultaGrupos
    {
        private Conexion conexion;

        public consultaGrupos()
        {
            conexion = new Conexion();
        }

        // Método para agregar un grupo
        public bool GuardarGrupo(string nombre, int numAlumnos, string carrera)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO grupos (nombre, n_alumnos, curso) 
                             VALUES (@nombre, @numAlumnos, @carrera)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@numAlumnos", numAlumnos);
                    cmd.Parameters.AddWithValue("@carrera", carrera);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para eliminar un grupo
        public bool EliminarGrupo(int idGrupo)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                // Verificar si el grupo tiene clases asignadas
                string queryVerificar = @"SELECT COUNT(*) FROM clases WHERE grupo_id = @idGrupo";
                using (MySqlCommand cmdVerificar = new MySqlCommand(queryVerificar, conn))
                {
                    cmdVerificar.Parameters.AddWithValue("@idGrupo", idGrupo);
                    int clasesAsignadas = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                    if (clasesAsignadas > 0)
                    {
                        MessageBox.Show("Este grupo tiene clases asignadas. Elimina las clases primero.");
                        return false;
                    }
                }

                // Eliminar el grupo si no tiene clases asignadas
                string queryEliminar = @"DELETE FROM grupos WHERE idGrupos = @idGrupo";
                using (MySqlCommand cmdEliminar = new MySqlCommand(queryEliminar, conn))
                {
                    cmdEliminar.Parameters.AddWithValue("@idGrupo", idGrupo);
                    return cmdEliminar.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para actualizar un grupo
        public bool ActualizarGrupo(int idGrupo, string nombre, int numAlumnos, string carrera)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE grupos 
                             SET nombre = @nombre, n_alumnos = @numAlumnos, curso = @carrera 
                             WHERE idGrupos = @idGrupo";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idGrupo", idGrupo);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@numAlumnos", numAlumnos);
                    cmd.Parameters.AddWithValue("@carrera", carrera);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para consultar todos los grupos
        public DataTable ConsultarGrupos()
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT idGrupos AS ID, 
                                    nombre AS Grupo, 
                                    n_alumnos AS NumeroAlumnos, 
                                    curso AS Carrera
                             FROM grupos";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Método para obtener un grupo por ID
        public DataRow ObtenerGrupoPorId(int idGrupo)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT * FROM grupos WHERE idGrupos = @idGrupo";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@idGrupo", idGrupo);
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
