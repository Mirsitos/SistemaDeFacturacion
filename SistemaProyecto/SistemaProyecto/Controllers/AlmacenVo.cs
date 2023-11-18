using SistemaProyecto.Dao;
using SistemaProyecto.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProyecto.Controllers
{
    public  class AlmacenVo
    {
        Almacen bean = new Almacen();
        AlmacenDao dao = new AlmacenDao();
        //public string resp;
        public static DataTable listarDatos(string nomCat)
        {
            return AlmacenDao.Listado_Almacenes(nomCat);

        }
    }
}
