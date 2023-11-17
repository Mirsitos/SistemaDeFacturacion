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
    public partial class MenuMarcas : Form
    {
        public MenuMarcas()
        {
            InitializeComponent();
        }

        void cargarListaDatos()
        {
            dataGridViewMarcas.DataSource = MarcasDao.getListaClientes();
        }

        private void listado_Marcas(string nombreMarc)
        {
            try
            {
                dataGridViewMarcas.DataSource = MarcasVo.listarDatos(nombreMarc);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en listadoProveedores MenuClientes" + ex.Message + ex.StackTrace);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_Buscar.Text))
            {
                cargarListaDatos();
            }
            else
            {
                this.listado_Marcas(text_Buscar.Text.Trim());
            }
        }

        private void MenuMarcas_Load(object sender, EventArgs e)
        {
            cargarListaDatos();
        }
    }
}
