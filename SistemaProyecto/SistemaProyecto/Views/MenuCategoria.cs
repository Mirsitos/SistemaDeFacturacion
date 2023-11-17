using SistemaProyecto.Controllers;
using SistemaProyecto.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaProyecto.Views
{
    public partial class MenuCategoria : Form
    {
        public MenuCategoria()
        {
            InitializeComponent();
        }

        void cargarListaDatos()
        {
            dataGridViewCategorias.DataSource = CategoriaDao.getListaCategorias();
        }

        private void listado_Categorias(string nomCat)
        {
            try
            {
                dataGridViewCategorias.DataSource = CategoriaVo.listarDatos(nomCat);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MenuCategoria_Load(object sender, EventArgs e)
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
                this.listado_Categorias(text_Buscar.Text.Trim());
            }
        }
    }
}
