using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using SistemaProyecto.Dao;
using SistemaProyecto.Models;

namespace SistemaProyecto.Views
{
    public partial class MenuProveedores : Form
    {
        public MenuProveedores()
        {
            InitializeComponent();
        }

        private void tabPage1Proveedor_Click(object sender, EventArgs e)
        {

        }

        private void MenuProveedores_Load(object sender, EventArgs e) // form load
        {
            cargarListaDatos();
        }

        #region
        int Estadoguarda = 0;
        #endregion

        private void Estado_BotonesPrincipales(bool lEstado)
        {
            this.btn_Nuevo.Enabled = lEstado;
            this.btn_Actualizar.Enabled = lEstado;
            this.btn_Eliminar.Enabled = lEstado;
            this.btn_Salir.Enabled = lEstado;  
        }

        private void Estado_Botonesprocesos(bool lEstado)
        {
            this.btn_Cancelar.Visible = lEstado;
            this.btn_Guardar.Visible = lEstado;
            this.btn_Regresar.Visible = lEstado;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        void cargarListaDatos()
        {
            dataGridViewProveedores.DataSource = ProveedoresDao.getListaProveedores();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (text_Categoria.Text == String.Empty || text_Direccion.Text == String.Empty || text_Telefono.Text == String.Empty || text_Mail.Text == String.Empty) // Categoria == Nombre
            {
                MessageBox.Show("Falta ingresar los datos requeridos! (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // se procede a registrar la info
            {
                ProveedoresDao Pdao = new ProveedoresDao();
                Proveedores obj = new Proveedores();
                
                obj.Nombre = text_Categoria.Text.Trim(); // // Categoria == Nombre
                obj.Direccion = text_Direccion.Text.Trim();
                obj.Telefono = text_Telefono.Text.Trim();
                obj.Mail = text_Mail.Text.Trim();
                Pdao.Insertar(obj);
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1; // nuevo registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            text_Categoria.Text = "";
            text_Categoria.ReadOnly = false;
            text_Direccion.Text = "";
            text_Direccion.ReadOnly = false;
            text_Telefono.Text = "";
            text_Telefono.ReadOnly = false;
            text_Mail.Text = "";
            text_Mail.ReadOnly = false;
            ProveedorTabPrincipal.SelectedIndex = 1;
            text_Categoria.Focus();
             
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; // actualizar registro
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; // sin ninguna accion
            text_Categoria.Text = "";
            text_Categoria.ReadOnly = true;
            text_Direccion.Text = "";
            text_Direccion.ReadOnly = true;
            text_Telefono.Text = "";
            text_Telefono.ReadOnly = true;
            text_Mail.Text = "";
            text_Mail.ReadOnly = true;
            this.Estado_BotonesPrincipales(true);
            this.Estado_Botonesprocesos(false);
            ProveedorTabPrincipal.SelectedIndex = 0;
        }
    }
}
