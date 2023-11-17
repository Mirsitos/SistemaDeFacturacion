using SistemaProyecto.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProyecto.Controllers
{
    public class MarcasVo
    {
        public static DataTable listarDatos(string nombreMarc)
        {
            return MarcasDao.Listado_Marcas(nombreMarc);

        }
        
    }
}
