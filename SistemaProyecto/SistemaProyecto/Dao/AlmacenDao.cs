﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaProyecto.Dao
{
    public class AlmacenDao : Conexion
    {
        public string respGral = "En proceso";
        public static DataTable getListaAlmacenes() // regresar todos los datos
        {
            // Conectarse a la base de datos
            string cadena = Conexion.getInstancia().getCadenaConexion();
            MySqlConnection conexionDB;
            DataTable datatable = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexionDB = new MySqlConnection(cadena);

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Almacenes;", conexionDB);
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

        public static DataTable Listado_Almacenes(string nombreCat) // regresar solo el dato en el input
        {
            // Conectarse a la base de datos
            string cadena = Conexion.getInstancia().getCadenaConexion();
            MySqlConnection conexionDB;
            DataTable datatable = new DataTable();
            MySqlDataReader resultado;


            try
            {
                conexionDB = new MySqlConnection(cadena);
                string query = "SELECT * FROM Almacenes WHERE upper(trim(nombre)) like upper(trim(@nombreCat));";
                MySqlCommand cmd = new MySqlCommand(query, conexionDB);
                cmd.Parameters.AddWithValue("@nombreCat", "%" + nombreCat + "%");
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
