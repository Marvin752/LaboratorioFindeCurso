using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Data;
using LaboratorioEnClase.Data.DataAcces;

namespace LaboratorioEnClase.Data
{
    internal class ConexionPro
    {
        string connectionString = "server=localhost;database=laboratorio_en_clase;user=root;password=EggTortuga78";
        MySqlConnection connection;

        //constructor
        public ConexionPro()
        {
            connection = new MySqlConnection(connectionString);
        }
        //Meter datos
        public void InsertarConsolas(ConsolasPros Consolita)
        {
            try
            {
                string query = "INSERT INTO catalogo_consolas (nombre_consola, compania, anio_lanzamiento, generacion) VALUES (@nombre,@compania,@fecha_lanzar,@generacion)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombre", Consolita.Nombre);
                cmd.Parameters.AddWithValue("@compania", Consolita.Compania);
                cmd.Parameters.AddWithValue("@fecha_lanzar", Consolita.Fecha_lanzamiento);
                cmd.Parameters.AddWithValue("@generacion", Consolita.Generacion);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        //Actualizar datos
        public void Actualizar(ConsolasPros Consolita)
        {
            try
            {
                string query = "UPTADATE catalogo_consolas Set nombre = @nombre, compania = @compania, fecha_lanzar = @fecha_lanzar, generacion = @generacion where id_consola";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id_consola", Consolita.id_consola);
                cmd.Parameters.AddWithValue("@nombre", Consolita.Nombre);
                cmd.Parameters.AddWithValue("@compania", Consolita.Compania);
                cmd.Parameters.AddWithValue("@fecha_lanzar", Consolita.Fecha_lanzamiento);
                cmd.Parameters.AddWithValue("@generacion", Consolita.Generacion);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        //Imprimir la consola
        public DataTable LeerTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM catalogo_consola";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los registros: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public DataRow LeerPorId(ConsolasPros Consolita)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM Usuarios WHERE id_consola = @id_consola";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id_consola", Consolita.id_consola);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt.Rows[0];
        }
    }
}
