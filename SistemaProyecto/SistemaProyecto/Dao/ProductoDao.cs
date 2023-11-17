using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using SistemaProyecto.Controllers;
using SistemaProyecto.Models;
using System.Windows.Forms;

namespace SistemaProyecto.Dao
{
    public class ProductoDao : Conexion
    {
        public string respGral = "En proceso";

        #region "agregar a db de combox"
        /*
        public void aggComboBoxCat(Producto obj) // guardar_ca
        {
            //public void agregar(string nombre, int codigoprod, int cantidad, string categoria, string marca, string almacen)
            //insert into Productos(CodigoProducto, Nombre, Cantidad, categoria, marca, almacen) values(101, 'Samsung S22', 2, 'Telefonos', 'Samsung', 'Almacen1');
            string sql = "INSERT INTO Productos (CodigoProducto, Nombre, Cantidad, categoria, marca, almacen) VALUES (@p1,@p2,@p3,@p4,@p5,@p6);";
            string aggCat, aggMarca, aggAlmacen;


            aggCat = "SELECT CantidadProductos FROM Categorias WHERE CodigoProducto = @p1;";
            try
            {
                AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(aggCat, DBconexion);
                cmd.CommandType = CommandType.Text;
                //cmd.Prepare();
                cmd.Parameters.AddWithValue("@p1", obj.CodigoProducto);
                cmd.Parameters.AddWithValue("@p2", obj.Nombre);
                cmd.Parameters.AddWithValue("@p3", obj.Cantidad);
                cmd.Parameters.AddWithValue("@p4", obj.Categoria);
                cmd.Parameters.AddWithValue("@p5", obj.Marca);
                cmd.Parameters.AddWithValue("@p6", obj.Almacen);
                cmd.ExecuteNonQuery();
                Console.Write("grabo con exito");
                respGral = "ok";
            }
            catch (Exception ex)
            {
                new Exception("Error al grabar la tabla...!!!" + ex.Message);
            }
            finally
            {
                CerrarConexion();
                //respGral = "En proceso";
            }
        }

        public static void aggComboBoxCat2() // regresar todos los datos
        {
            // Conectarse a la base de datos
            string cadena = Conexion.getInstancia().getCadenaConexion();
            MySqlConnection conexionDB;
            DataTable datatable = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexionDB = new MySqlConnection(cadena);

                MySqlCommand cmd = new MySqlCommand("SELECT CantidadProductos FROM Categorias WHERE CodigoProducto = @p1;", conexionDB);
                cmd.CommandType = CommandType.Text;
                conexionDB.Open();
                resultado = cmd.ExecuteReader();    // se carga el valor numerico
                MessageBox.Show($"{resultado}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //return datatable;
        }*/

        #endregion

        public void Insertar(Producto obj) // guardar_ca
        {


            //public void agregar(string nombre, int codigoprod, int cantidad, string categoria, string marca, string almacen)
            //insert into Productos(CodigoProducto, Nombre, Cantidad, categoria, marca, almacen) values(101, 'Samsung S22', 2, 'Telefonos', 'Samsung', 'Almacen1');
            string sql = "INSERT INTO Productos (CodigoProducto, Nombre, Cantidad, categoria, marca, almacen) VALUES (@p1,@p2,@p3,@p4,@p5,@p6);";
            //string aggCat, aggMarca, aggAlmacen;
            //aggCat = "SELECT CantidadProductos FROM Categorias WHERE CodigoProducto = @p1;";
            try
            {
                AbrirConexion();
                MySqlCommand cmd = new MySqlCommand(sql, DBconexion);
                cmd.CommandType = CommandType.Text;
                //cmd.Prepare();
                cmd.Parameters.AddWithValue("@p1", obj.CodigoProducto);
                cmd.Parameters.AddWithValue("@p2", obj.Nombre);
                cmd.Parameters.AddWithValue("@p3", obj.Cantidad);
                cmd.Parameters.AddWithValue("@p4", obj.Categoria);
                cmd.Parameters.AddWithValue("@p5", obj.Marca);
                cmd.Parameters.AddWithValue("@p6", obj.Almacen);
                cmd.ExecuteNonQuery();
                Console.Write("grabo con exito");
                //aggComboBoxCat2();                                        // ACA ESTA EL ERROR O BUG DE MIERDA
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

        public void modificar(Producto obj)
        {

            //string sql = "INSERT INTO Clientes (nombre,apellido,cedula,mail,telefono,direccion)) VALUES (@p1,@p2,@p3,@p4,@p5,@p6);";
            //string sql = "UPDATE  Productos SET CodigoProducto = @p1, Nombre = @p2, Cantidad = @p3, categoria = @p4, marca = @p5, almacen = @p6;";
            //string query = "UPDATE Productos SET nombre = @p2,apellido = @p3,gmail = @p4,telefono = @p5,direccion= @p6 WHERE cedula = @p1;";

            string query = "UPDATE Productos SET Nombre = @p2, Cantidad = @p3, categoria = @p4, marca = @p5, almacen = @p6 WHERE CodigoProducto = @p1;";
            try
            {
                AbrirConexion();
                MySqlCommand Cmd = new MySqlCommand(query, DBconexion);
                Cmd.Parameters.AddWithValue("@p1", obj.CodigoProducto);
                Cmd.Parameters.AddWithValue("@p2", obj.Nombre);
                Cmd.Parameters.AddWithValue("@p3", obj.Cantidad);
                Cmd.Parameters.AddWithValue("@p4", obj.Categoria);
                Cmd.Parameters.AddWithValue("@p5", obj.Marca);
                Cmd.Parameters.AddWithValue("@p6", obj.Almacen);

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

        public void Eliminar_Prod(Producto obj) // guardar_ca
        {

            string sql = "DELETE FROM Productos WHERE CodigoProducto = @p1;";
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


        public static DataTable getListaProductos() // regresar todos los datos
        {
            // Conectarse a la base de datos
            string cadena = Conexion.getInstancia().getCadenaConexion();
            MySqlConnection conexionDB;
            DataTable datatable = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexionDB = new MySqlConnection(cadena);

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Productos;", conexionDB);
                cmd.CommandType = CommandType.Text;
                conexionDB.Open();
                resultado = cmd.ExecuteReader();
                datatable.Load(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en ProductoDao getListaProductos()"); 
                MessageBox.Show(ex.Message);
            }
            return datatable;
        }

        public static void cargarBoxes(ComboBox cboxCat, ComboBox cboxMar, ComboBox cboxAlm)
        {

            string cadenaConex = Conexion.getInstancia().getCadenaConexion();
            MySqlConnection connection = new MySqlConnection(cadenaConex);

            MySqlCommand command = new MySqlCommand("SELECT Nombre FROM Categorias;", connection);      // cargar Categorias
            MySqlCommand command2 = new MySqlCommand("SELECT Nombre FROM Marcas;", connection);
            MySqlCommand command3 = new MySqlCommand("SELECT Nombre FROM Almacenes;", connection);

            command.CommandType = CommandType.Text;// Ejecuta la consulta
            command2.CommandType = CommandType.Text;
            command3.CommandType = CommandType.Text;
            connection.Open();

            MySqlDataReader reader = command.ExecuteReader();// Obtiene el resultado de la consulta

            while (reader.Read())
            {
                // Agrega los resultados de la consulta al combobox
                cboxCat.Items.Add(reader["Nombre"].ToString());
            }
            reader.Close(); // Cierra el lector




            MySqlDataReader reader2 = command2.ExecuteReader();// Obtiene el resultado de la consulta       Cargar Marcas

            while (reader2.Read())
            {
                // Agrega los resultados de la consulta al combobox
                cboxMar.Items.Add(reader2["Nombre"].ToString());
            }
            reader2.Close();

            MySqlDataReader reader3 = command3.ExecuteReader();// Obtiene el resultado de la consulta       Cargar Almacenes

            while (reader3.Read())
            {
                // Agrega los resultados de la consulta al combobox
                cboxAlm.Items.Add(reader3["Nombre"].ToString());
            }
            reader3.Close();

            // obtener el item seleccionado del combobox
            //MessageBox.Show($"El valor seleccionado es {comboBox_Categoria.SelectedItem.ToString()}");
        }
    }
}
