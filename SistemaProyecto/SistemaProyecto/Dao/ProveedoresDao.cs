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

using SistemaProyecto.Dao;


namespace SistemaProyecto.Dao
{
    public class ProveedoresDao : Conexion
    {
        Proveedores mod = new Proveedores();
        public string respGral= "En proceso";
        public void Insertar(Proveedores obj) // guardar_ca
        {
            
            string sql = "INSERT INTO Proveedores (nombre,direccion,telefono,gmail) VALUES (@p1,@p2,@p3,@p4);";
            try
            {

                AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(sql, DBconexion);
                cmd.CommandType = CommandType.Text;
                //cmd.Prepare();
                cmd.Parameters.AddWithValue("@p1", obj.Nombre);
                cmd.Parameters.AddWithValue("@p2", obj.Direccion);
                cmd.Parameters.AddWithValue("@p3", obj.Telefono);
                cmd.Parameters.AddWithValue("@p4", obj.Mail);
                cmd.ExecuteNonQuery();
                Console.Write("grabo con exito");
                respGral = "ok";
            }
            catch (Exception ex)
            {
                new Exception("Error al gravar la tabla...!!!" + ex.Message);
            }
            finally
            {
                CerrarConexion();
                //respGral = "En proceso";
            }
        }


        public void modificar(Proveedores obj)
        {
            string query = "UPDATE Proveedores SET direccion = @p2,telefono = @p3,gmail = @p4 WHERE nombre = @p1;";
            try
            {
                AbrirConexion();
                MySqlCommand Cmd = new MySqlCommand(query, DBconexion);
                Cmd.Parameters.AddWithValue("@p1", obj.Nombre);
                Cmd.Parameters.AddWithValue("@p2", obj.Direccion);
                Cmd.Parameters.AddWithValue("@p3", obj.Telefono);
                Cmd.Parameters.AddWithValue("@p4", obj.Mail);
                Cmd.ExecuteNonQuery();
                Console.Write("grabo con exito");
                respGral = "ok";

            }
            catch (Exception ex)
            {
                throw new Exception("Error al grabar la tabla...!!!"
                + ex.Message);
            }
            finally
            {
                CerrarConexion();
                //respGral = "En proceso";
            }
        }

        public void Eliminar_Prov(Proveedores obj) // guardar_ca
        {

            string sql = "DELETE FROM Proveedores WHERE nombre = @p1;";
            try
            {
                AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(sql, DBconexion);
                cmd.CommandType = CommandType.Text;
                //cmd.Prepare();
                cmd.Parameters.AddWithValue("@p1", obj.Nombre);
                cmd.ExecuteNonQuery();
                Console.Write("elimino con exito");
                respGral = "ok";
            }
            catch (Exception ex)
            {
                new Exception("Error al eliminar la tabla...!!!" + ex.Message);
            }
            finally
            {
                CerrarConexion();
                //respGral = "En proceso";
            }
        }

        public static DataTable getListaProveedores()
        {
            // Conectarse a la base de datos
            string cadena = Conexion.getInstancia().getCadenaConexion();
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


        //  FUNCIONAL DE BUSCAR DATOS
        /*
        public static DataTable getListaProveedores(string nombreProvListado) // overload si es que se busca un nombre
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

                string query = "SELECT * FROM Proveedores WHERE upper(trim(nombre)) like upper(trim(@nombreProvListado)) ;";
                //string query = "SELECT * FROM Empleados";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@nombreProvListado", nombreProvListado);
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
        */
        public static DataTable Listado_Proveedores(string nombreProvListado)
        {
            // Conectarse a la base de datos
            string cadena = Conexion.getInstancia().getCadenaConexion();
            MySqlConnection conexionDB;
            DataTable datatable = new DataTable();
            MySqlDataReader resultado;


            try
            {
                conexionDB = new MySqlConnection(cadena);
                string query = "SELECT * FROM Proveedores WHERE upper(trim(nombre)) like upper(trim(@nombreProvListado));";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@nombreProvListado", nombreProvListado+ "%");
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

        public DataTable Listado_Proveedores3(string nombreProvListado)
        {
            // Conectarse a la base de datos
            string cadena = Conexion.getInstancia().getCadenaConexion();
            MySqlConnection conexionDB;
            DataTable datatable = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexionDB = new MySqlConnection(cadena);
                string query = "SELECT * FROM Proveedores WHERE upper(trim(nombre)) like upper(trim(@nombreProvListado)) ;";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.CommandType = CommandType.Text;
                conexionDB.Open();
                resultado = cmd.ExecuteReader();
                datatable.Load(resultado);
                
                return datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return datatable;
        }

        public DataTable aListado_Proveedores2(string nombreProvListado)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection con = new MySqlConnection();

            try
            {
                con = Conexion.getInstancia().getCadenaConexionDB();

                //string query = "SELECT * FROM Proveedores WHERE nombre = @p1;";
                //string query = "SELECT * FROM Proveedores WHERE nombre like '%'+nombreProvListado+'%' ;";
                string query = "SELECT * FROM Proveedores WHERE upper(trim(nombre)) like upper(trim(@nombreProvListado)) ;";

                MySqlCommand comando = new MySqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@p1", nombreProvListado);
                comando.ExecuteNonQuery();
                //Console.Write("se busco con exito con exito");

                con.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);

                respGral = "ok";
                return tabla;

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
        }
           
    }
}
