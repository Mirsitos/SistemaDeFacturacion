using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistemaProyecto.Models;
using MySql.Data.MySqlClient;
using System.Data;
using SistemaProyecto.Dao;
using SistemaProyecto.Views;
using System.Management;

namespace SistemaProyecto.Controllers
{
    public  class ProductoVo
    {
        Producto bean = new Producto();
        ProductoDao dao = new ProductoDao();
        public string resp;
        public static void cargarBoxes(ComboBox cboxCat, ComboBox cboxMar, ComboBox cboxAlm)
        {
            ProductoDao.cargarBoxes(cboxCat, cboxMar, cboxAlm);
        }
        /*
         private string nombre;
        private int codigoprod;
        private int cantidad;
        private string categoria;
        private string marca;
        private string almacen;
         */

        public static DataTable listarDatos(string nombreProdListado)
        {
            return ProductoDao.Listado_Productos(nombreProdListado);

        }

        public void agregar(string nombre, int codigoprod, int cantidad, string categoria, string marca, string almacen)
        {
            resp = "aguardando dao";
            bean.Nombre = nombre;
            bean.CodigoProducto = codigoprod;
            bean.Cantidad = cantidad;
            bean.Categoria = categoria;
            bean.Marca = marca;
            bean.Almacen = almacen;
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

        public void modificar(string nombre, int codigoprod, int cantidad, string categoria, string marca, string almacen)
        {
            resp = "aguardando dao";
            bean.Nombre = nombre;
            bean.CodigoProducto = codigoprod;
            bean.Cantidad = cantidad;
            bean.Categoria = categoria;
            bean.Marca = marca;
            bean.Almacen = almacen; ;
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

        public void eliminar(string nom, Producto obj)
        {
            resp = "aguardando dao";
            bean.Nombre = nom;
            bean.Cantidad = obj.Cantidad;
            bean.Categoria = obj.Categoria;
            bean.Marca = obj.Marca;
            bean.Almacen = obj.Almacen;

            dao.Eliminar_Prod(bean);
            if (dao.respGral == "En proceso")
                
            {
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


    }
}
