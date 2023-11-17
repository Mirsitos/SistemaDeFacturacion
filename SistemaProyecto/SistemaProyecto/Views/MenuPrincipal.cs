
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MySql.Data.MySqlClient;
using SistemaProyecto.Dao;


namespace SistemaProyecto.Views
{
    public partial class MenuPrincipal : Form
    {
        private Conexion mConexion; // cadena para conexion
        private int childFormNumber = 0;

        public MenuPrincipal()
        {
            InitializeComponent();
            mConexion = new Conexion(); // cadena para conexion
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pruebaConexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = "";
            MySqlDataReader mySqlDataReader = null;
            string consulta = "select * from empleados";
            if (mConexion.getPruebaDeConexion() != null)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                mySqlCommand.Connection = mConexion.getPruebaDeConexion();
                mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    result = mySqlDataReader.GetString("gmail");
                    result = "(select * from empleados)El mail del usuario es: " + result;
                }
                //MessageBox.Show(result);
                MessageBox.Show("Conexion al servidor exitosa!");
            }
            else
            {
                MessageBox.Show("Error al conectar.");
            }
        }

        private void movimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuProveedores mnu = new MenuProveedores();
            mnu.MdiParent = this;
            mnu.Show();
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuClientes mnu = new MenuClientes();
            mnu.MdiParent = this;
            mnu.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuCategoria mnu = new MenuCategoria();
            mnu.MdiParent = this;
            mnu.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuMarcas mnu = new MenuMarcas();
            mnu.MdiParent = this;
            mnu.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuProducto mnu = new MenuProducto();
            mnu.MdiParent = this;
            mnu.Show();
        }
    }
}
