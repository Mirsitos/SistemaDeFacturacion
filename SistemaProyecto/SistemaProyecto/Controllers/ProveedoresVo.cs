using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaProyecto.Dao;
using SistemaProyecto.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaProyecto.Controllers
{
    public class ProveedoresVo // fachada o regla de negocio, que se comunica entre la vista y el dao
    {
        Proveedores bean = new Proveedores();
        ProveedoresDao dao = new ProveedoresDao();
        public string resp;
        public void agregar(string nom, string dir, string tel, string mail)
        {
            resp = "aguardando dao";
            bean.Nombre = nom;
            bean.Direccion = dir;
            bean.Telefono = tel;
            bean.Mail = mail;
            dao.Insertar(bean);
            if (dao.respGral == "En proceso")
            {
                resp = dao.respGral;
                //MessageBox.Show("El proceso no se realizo con exito");
            } else if (dao.respGral == "ok")
            {
                resp = dao.respGral;
                //MessageBox.Show("Cargado correctamente en base de datos");
            } else if (resp == "aguardando dao")
            {
                //MessageBox.Show("Aguardando dao...");
            }
        }
        public void modificar(string nom, string dir, string tel, string mail)
        {
            resp = "aguardando dao";
            bean.Nombre = nom;
            bean.Direccion = dir;
            bean.Telefono = tel;
            bean.Mail = mail;
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
        
        public void eliminar(string nom)
        {
            resp = "aguardando dao";
            bean.Nombre = nom;
            dao.Eliminar_Prov(bean);
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

        public static DataTable listarDatos(string nombreProvListado)
        {
            return ProveedoresDao.Listado_Proveedores(nombreProvListado);
            
        }

    }
}
