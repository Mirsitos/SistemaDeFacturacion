using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SistemaProyecto.Models;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaProyecto.Views;
using System.Drawing;
using System.Web;

namespace SistemaProyecto.Dao
{
    public class ProveedoresDao : Conexion
    {
        Proveedores mod = new Proveedores();
        public void Insertar(Proveedores obj) // guardar_ca
        {
            string sql = "INSERT INTO Proveedores (nombre,direccion,telefono,gmail) VALUES (@p1,@p2,@p3,@p4)";
            try
            {
                AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(sql, DBconexion);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@p1", obj.Nombre);
                cmd.Parameters.AddWithValue("@p2", obj.Direccion);
                cmd.Parameters.AddWithValue("@p3", obj.Telefono);
                cmd.Parameters.AddWithValue("@p4", obj.Mail);
                cmd.ExecuteNonQuery();
                Console.Write("grabo con exito");
            }
            catch (Exception ex)
            {
                new Exception("Error al gravar la tabla...!!!" + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void modificar(Proveedores obj)
        {
            string query = "UPDATE Proveedores SET nombre = @p1,direccion = @p2,telefono = @p3,gmail = @p4)";
            try
            {
                AbrirConexion();
                MySqlCommand Cmd = new MySqlCommand(query, DBconexion);
                Cmd.Parameters.AddWithValue("@p1", obj.Nombre);
                Cmd.Parameters.AddWithValue("@p2", obj.Direccion);
                Cmd.Parameters.AddWithValue("@p3", obj.Telefono);
                Cmd.Parameters.AddWithValue("@p4", obj.Mail);
                Cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al grabar la tabla...!!!"
                + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }
        public static DataTable getListaProveedores()
        {
            // Conectarse a la base de datos
            string cadena = "Server=localhost;"
                + "Port = 3306;"
                + "User Id = root;"
                + "Password= root;"
                + "Database = Facturacion;";
            MySqlConnection conexionDB;
            DataTable datatable = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexionDB = new MySqlConnection(cadena);

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Proveedores;", conexionDB);
                cmd.CommandType = CommandType.Text;
                conexionDB.Open();
                resultado = cmd.ExecuteReader();
                datatable.Load(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return datatable;
        }
            /*
             *

            using (var db = new MySqlConnection(cadena))
            {
                // Ejecutar la consulta
                db.Open();
                var comando = new MySqlCommand("SELECT * FROM Proveedores", db);
                var reader = comando.ExecuteReader();

                // Crear una lista de proveedores
                List<Proveedores> proveedores = new List<Proveedores>();

                // Llenar la lista de proveedores
                while (reader.Read())
                {
                    // Crear un nuevo proveedor
                    Proveedores proveedor = new Proveedores();

                    // Asignar los datos del proveedor
                    proveedor.Nombre = reader["nombre"].ToString();
                    proveedor.Direccion = reader["direccion"].ToString();
                    proveedor.Telefono = reader["telefono"].ToString();
                    proveedor.Mail = reader["mail"].ToString();

                    // Agregar el proveedor a la lista
                    proveedores.Add(proveedor);
                }

                // Cerrar la conexión a la base de datos
                db.Close();

                // Devolver la lista de proveedores
                return proveedores;*/
            


        /*
        public DataTable Listado_Proveedores(string pTexto)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();

            MySqlConnection con = new MySqlConnection();

            try
            {
                con = Conexion.getInstancia().getCadenaConexionDB();
                MySqlCommand comando = new MySqlCommand("", con);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                
            }
        }*/
    }
}
