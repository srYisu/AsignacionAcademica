using System;
using System.Data;
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

        // Método para agregar una asignatura
        public bool GuardarAsignatura(string asignatura, string tipo)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO asignaturas (nombre, tipo) 
                                 VALUES (@asignatura, @tipo)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@asignatura", asignatura);
                    cmd.Parameters.AddWithValue("@tipo", tipo);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para eliminar una asignatura
        public bool EliminarAsignatura(int idAsignatura)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();

                    // Verificar si la asignatura está vinculada a una clase
                    string queryVerificarClases = @"SELECT COUNT(*) FROM clases WHERE asignatura_id = @idAsignatura";
                    using (MySqlCommand cmdVerificar = new MySqlCommand(queryVerificarClases, conn))
                    {
                        cmdVerificar.Parameters.AddWithValue("@idAsignatura", idAsignatura);
                        int clasesAsignadas = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                        if (clasesAsignadas > 0)
                        {
                            MessageBox.Show("La asignatura está asignada a una clase. Elimina la clase primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }

                    // Eliminar la asignatura si no está vinculada a ninguna clase
                    string queryEliminar = @"DELETE FROM asignaturas WHERE idAsignaturas = @idAsignatura";
                    using (MySqlCommand cmdEliminar = new MySqlCommand(queryEliminar, conn))
                    {
                        cmdEliminar.Parameters.AddWithValue("@idAsignatura", idAsignatura);
                        return cmdEliminar.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la asignatura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        // Método para actualizar una asignatura
        public bool ActualizarAsignatura(int idAsignatura, string asignatura, string tipo)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE asignaturas 
                                 SET nombre = @asignatura, tipo = @tipo 
                                 WHERE idAsignaturas = @idAsignatura";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idAsignatura", idAsignatura);
                    cmd.Parameters.AddWithValue("@asignatura", asignatura);
                    cmd.Parameters.AddWithValue("@tipo", tipo);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para consultar todas las asignaturas
        public DataTable ConsultarAsignaturas()
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT idAsignaturas AS ID, 
                                        nombre AS Asignatura, 
                                        tipo AS Tipo
                                 FROM asignaturas";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Método para obtener una asignatura por ID
        public DataRow ObtenerAsignaturaPorId(int idAsignatura)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT * FROM asignaturas WHERE idAsignaturas = @idAsignatura";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@idAsignatura", idAsignatura);
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
