using MySql.Data.MySqlClient;
using CapaEntidad;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CDCliente
    {
        string CadenaConexion = "server=192.168.1.49;User=root;Password=usbw;Port=3306;database=Solucion1;";


        // Método para probar la conexión a la base de datos
        public void PruebaConexion()
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    mySqlConnection.Open();
                    string query = "DELETE FROM cliente WHERE id = @Id";
                    MessageBox.Show("¡Conexión Exitosa a la BD!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("¡Error de Conexión a la BD! " + ex.Message);
                }
            }
        }

        // Método para crear un cliente en la base de datos
        public void Crear(CECliente cE)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    mySqlConnection.Open();
                    string query = "INSERT INTO `cliente` (`nombres`, `apellidos`, `foto`) VALUES (@nombres, @apellidos, @foto)";

                    using (MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection))
                    {
                        // Usar parámetros para evitar inyecciones SQL
                        mySqlCommand.Parameters.AddWithValue("@nombres", cE.Nombres);
                        mySqlCommand.Parameters.AddWithValue("@apellidos", cE.Apellidos);
                        mySqlCommand.Parameters.AddWithValue("@foto", cE.Foto);

                        mySqlCommand.ExecuteNonQuery();
                        MessageBox.Show("¡El Registro ha sido creado!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("¡Error al Guardar usuario: " + ex.Message);
                }
            }
        }

        // Método para listar clientes
        public DataSet Listar()
        {
            DataSet dataset = new DataSet();

            using (MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    mySqlConnection.Open();
                    string query = "SELECT * FROM `cliente`";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, mySqlConnection);
                    adapter.Fill(dataset, "tbl"); // Corregido de "Fiel" a "Fill"
                    return dataset;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("¡Error de conexión a la BD! " + ex.Message);
                    return dataset;
                }
            }
        }

        public void Eliminar(int id)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    mySqlConnection.Open();
                    string query = "DELETE FROM cliente WHERE id = @Id";
                    MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                    mySqlCommand.Parameters.AddWithValue("@Id", id); // Agregar parámetro

                    mySqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("¡Error al eliminar el cliente: " + ex.Message);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }

    }
}
