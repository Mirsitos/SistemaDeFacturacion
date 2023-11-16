using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
using SistemaProyecto.Models;
using MySql.Data.MySqlClient;

namespace SistemaProyecto.Dao
{
    public class EmpleadoDao : Conexion
    {
        Empleado mod = new Empleado();


        // Conexion por cada tabla

        /*
        // string conexion
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        // instancia
        private static EmpleadoDao _instancia = null;

        public EmpleadoDao()
        {

        }

        public static EmpleadoDao Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new EmpleadoDao();
                }
                return _instancia;
            }
        }




        */

        /*
        public bool Guardar(Empleado obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "insert into Persona(Nombre,Apellido,Telefono) values (@nombre,@apellido,@telefono)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@apellido", obj.Apellido));
                cmd.Parameters.Add(new SQLiteParameter("@telefono", obj.Telefono));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }

        public List<Empleado> Listar()
        {
            List<Empleado> oLista = new List<Empleado>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select Id,Nombre,Apellido,Telefono from Persona";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Empleado()
                        {
                            IdPersona = int.Parse(dr["Id"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                        });
                    }
                }
            }
            return oLista;
        }



        public bool Editar(Empleado obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "Update Persona set Nombre = @nombre ,Apellido = @apellido ,Telefono = @telefono where Id = @idpersona";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@idpersona", obj.IdPersona));
                cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@apellido", obj.Apellido));
                cmd.Parameters.Add(new SQLiteParameter("@telefono", obj.Telefono));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }


        public bool Eliminar(Empleado obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "delete from persona where Id = @idpersona";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@idpersona", obj.IdPersona));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;
        }
        */
    }
}
