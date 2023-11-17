using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using SistemaProyecto.Dao;
using SistemaProyecto.Models;


namespace SistemaProyecto.Dao
{
    public class MarcasDao : Conexion
    {
        public static DataTable getListaClientes() // regresar todos los datos
        {
            // Conectarse a la base de datos
            string cadena = Conexion.getInstancia().getCadenaConexion();
            MySqlConnection conexionDB;
            DataTable datatable = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexionDB = new MySqlConnection(cadena);

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Marcas;", conexionDB);
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

        public static DataTable Listado_Marcas(string nombreMarc) // regresar solo el dato en el input
        {
            // Conectarse a la base de datos
            string cadena = Conexion.getInstancia().getCadenaConexion();
            MySqlConnection conexionDB;
            DataTable datatable = new DataTable();
            MySqlDataReader resultado;


            try
            {
                conexionDB = new MySqlConnection(cadena);
                string query = "SELECT * FROM Marcas WHERE upper(trim(Nombre)) like upper(trim(@nombreMarc));";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@nombreMarc", "%" + nombreMarc + "%");
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
    }
}
