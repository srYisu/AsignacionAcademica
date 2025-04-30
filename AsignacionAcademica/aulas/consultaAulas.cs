using System.Data;
using MySql.Data.MySqlClient;

namespace AsignacionAcademica.aulas
{
    internal class consultaAulas
    {
        private Conexion conexion;

        public consultaAulas()
        {
            conexion = new Conexion();
        }

        // Método para agregar un aula
        public bool GuardarAula(string nombre, int capacidad, string ubicacion)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO aulas (nombre, capacidad, ubicacion) 
                                 VALUES (@nombre, @capacidad, @ubicacion)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@capacidad", capacidad);
                    cmd.Parameters.AddWithValue("@ubicacion", ubicacion);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para eliminar un aula
        public bool EliminarAula(int idAula)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                // Verificar si el aula tiene clases asignadas
                string queryVerificar = @"SELECT COUNT(*) FROM clases WHERE aula_id = @idAula";
                using (MySqlCommand cmdVerificar = new MySqlCommand(queryVerificar, conn))
                {
                    cmdVerificar.Parameters.AddWithValue("@idAula", idAula);
                    int clasesAsignadas = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                    if (clasesAsignadas > 0)
                    {
                        MessageBox.Show("Esta aula tiene clases asignadas. Elimina las clases primero.");
                        return false;
                    }
                }

                // Eliminar el aula si no tiene clases asignadas
                string queryEliminar = @"DELETE FROM aulas WHERE idAulas = @idAula";
                using (MySqlCommand cmdEliminar = new MySqlCommand(queryEliminar, conn))
                {
                    cmdEliminar.Parameters.AddWithValue("@idAula", idAula);
                    return cmdEliminar.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para actualizar un aula
        public bool ActualizarAula(int idAula, string nombre, int capacidad, string ubicacion)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE aulas 
                                 SET nombre = @nombre, capacidad = @capacidad, ubicacion = @ubicacion 
                                 WHERE idAulas = @idAula";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idAula", idAula);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@capacidad", capacidad);
                    cmd.Parameters.AddWithValue("@ubicacion", ubicacion);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para consultar todas las aulas
        public DataTable ConsultarAulas()
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT idAulas AS ID, 
                                        nombre AS Nombre, 
                                        capacidad AS Capacidad, 
                                        ubicacion AS Ubicacion
                                 FROM aulas";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Método para obtener un aula por ID
        public DataRow ObtenerAulaPorId(int idAula)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT * FROM aulas WHERE idAulas = @idAula";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@idAula", idAula);
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

