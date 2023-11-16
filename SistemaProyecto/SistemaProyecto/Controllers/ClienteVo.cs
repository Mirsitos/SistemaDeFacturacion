using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaProyecto.Dao;
using SistemaProyecto.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaProyecto.Controllers
{
    public  class ClienteVo
    {
        Cliente bean = new Cliente();
        ClienteDao dao = new ClienteDao();
        public string resp;

        public void agregar(string nom, string ape, string ced, string mail, string tel, string dir)
        {
            resp = "aguardando dao";
            bean.Nombre = nom;
            bean.Apellido = ape;
            bean.Cedula = ced;
            bean.Mail = mail;
            bean.Telefono = tel;
            bean.Direccion = dir;
            dao.Insertar(bean);
            if (dao.respGral == "En proceso")
            {
                resp = dao.respGral;
                //MessageBox.Show("El proceso no se realizo con exito");
            }
            else if (dao.respGral == "ok")
            {
                resp = dao.respGral;
                //MessageBox.Show("Cargado correctamente en base de datos");
            }
            else if (resp == "aguardando dao")
            {
                //MessageBox.Show("Aguardando dao...");
            }
        }

        public void modificar(string nom, string ape, string ced, string mail, string tel, string dir)
        {
            resp = "aguardando dao";
            bean.Nombre = nom;
            bean.Apellido = ape;
            bean.Cedula = ced;
            bean.Mail = mail;
            bean.Telefono = tel;
            bean.Direccion = dir;
            dao.modificar(bean);
            if (dao.respGral == "En proceso")
            {
                resp = dao.respGral;
                //MessageBox.Show("El proceso no se realizo con exito");
            }
            else if (dao.respGral == "ok")
            {
                resp = dao.respGral;
                //MessageBox.Show("Cargado correctamente en base de datos");
            }
            else if (resp == "aguardando dao")
            {
                //MessageBox.Show("Aguardando dao...");
            }
        }

        public void eliminar(string ced)
        {
            resp = "aguardando dao";
            bean.Cedula = ced;
            dao.Eliminar_Cli(bean);
            if (dao.respGral == "En proceso")
            {
                resp = dao.respGral;
                //MessageBox.Show("El proceso no se realizo con exito");
            }
            else if (dao.respGral == "ok")
            {
                resp = dao.respGral;
                //MessageBox.Show("Cargado correctamente en base de datos");
            }
            else if (resp == "aguardando dao")
            {
                //MessageBox.Show("Aguardando dao...");
            }
        }

        public static DataTable listarDatos(string nombreCliListado)
        {
            return ClienteDao.Listado_Clientes(nombreCliListado);

        }
    }
}
