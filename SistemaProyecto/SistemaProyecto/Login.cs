using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


using MySql.Data.MySqlClient;
using SistemaProyecto.Dao;
using SistemaProyecto.Views;

namespace SistemaProyecto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        
        private void checkEmpleado()
        {
            string cadenaConexion = Conexion.getInstancia().getCadenaConexion();
            string Usuario_datos = textUsuario.Text;
            string Contrasena_datos = textUsuario.Text;

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = "SELECT * FROM Empleados WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                    using (MySqlCommand command = new MySqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@Usuario", Usuario_datos);
                        command.Parameters.AddWithValue("@Contraseña", Contrasena_datos);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Los datos coinciden, usuario autenticado
                                MessageBox.Show("Inicio de sesión exitoso");
                                abrirMenuPrincipal();
                            }
                            else
                            {
                                // Los datos no coinciden, mostrar error
                                MessageBox.Show("Error: Usuario o contraseña incorrectos");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            checkEmpleado();   
        }

          
        public void abrirMenuPrincipal()
        {
            MenuPrincipal mnu = new MenuPrincipal();
            mnu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal obj = new MenuPrincipal();
            obj.probarConexion();
        }
    }
}
