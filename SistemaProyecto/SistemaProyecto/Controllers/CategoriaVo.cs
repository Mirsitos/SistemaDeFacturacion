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
    internal class CategoriaVo
    {
        Categoria bean = new Categoria();
        CategoriaDao dao = new CategoriaDao();
        public string resp;
        public static DataTable listarDatos(string nomCat)
        {
            return CategoriaDao.Listado_Categorias(nomCat);

        }
    }
}
