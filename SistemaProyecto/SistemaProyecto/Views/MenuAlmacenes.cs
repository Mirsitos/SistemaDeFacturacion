using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistemaProyecto.Controllers;
using SistemaProyecto.Dao;

namespace SistemaProyecto.Views
{
    public partial class MenuAlmacenes : Form
    {
        public MenuAlmacenes()
        {
            InitializeComponent();
        }

        void cargarListaDatos()
        {
            dataGridViewAlmacenes.DataSource = AlmacenDao.getListaAlmacenes();
        }

        private void listado_Almacenes(string nomCat)
        {
            try
            {
                dataGridViewAlmacenes.DataSource = AlmacenVo.listarDatos(nomCat);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MenuAlmacenes_Load(object sender, EventArgs e)
        {
            cargarListaDatos();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_Buscar.Text))
            {
                cargarListaDatos();
            }
            else
            {
                this.listado_Almacenes(text_Buscar.Text.Trim());
            }
        }
    }
}
