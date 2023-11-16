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

        #region "Mis variables"
        
        string nombre_prove = "";       // variable guia o pk
        #endregion


        #region "Mis metodos"
        private void Estado_BotonesPrincipales(bool lEstado)            // region metodos
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

        private void listado_Proveedores(string nombreProvListado)
        {
            try
            {
                dataGridViewProveedores.DataSource = ProveedoresVo.listarDatos(nombreProvListado);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en listadoProveedores MenuProveedores" + ex.Message + ex.StackTrace);
            }
        }

        void cargarListaDatos()
        {
            dataGridViewProveedores.DataSource = ProveedoresDao.getListaProveedores();
        }

        private void Selecciona_item()
        {
            
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewProveedores.CurrentRow.Cells["nombre"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.nombre_prove = Convert.ToString(dataGridViewProveedores.CurrentRow.Cells["nombre"].Value);
                text_Categoria.Text = Convert.ToString(dataGridViewProveedores.CurrentRow.Cells["nombre"].Value);
                text_Direccion.Text = Convert.ToString(dataGridViewProveedores.CurrentRow.Cells["direccion"].Value);
                text_Telefono.Text = Convert.ToString(dataGridViewProveedores.CurrentRow.Cells["telefono"].Value);
                text_Mail.Text = Convert.ToString(dataGridViewProveedores.CurrentRow.Cells["gmail"].Value);
            }
        }
        #endregion



        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (nombre_prove == "") // crear nuevo proveedor (no se selcciono nada en el dgv)
            {
                if (text_Categoria.Text == String.Empty || text_Direccion.Text == String.Empty || text_Telefono.Text == String.Empty || text_Mail.Text == String.Empty) // Categoria == Nombre
                {
                    MessageBox.Show("Falta ingresar los datos requeridos! (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else // se procede a registrar la info
                {
                    Proveedores obj = new Proveedores();
                    ProveedoresVo vo = new ProveedoresVo();

                    obj.Nombre = text_Categoria.Text.Trim(); // // Categoria == Nombre
                    obj.Direccion = text_Direccion.Text.Trim();
                    obj.Telefono = text_Telefono.Text.Trim();
                    obj.Mail = text_Mail.Text.Trim();
                    vo.agregar(obj.Nombre, obj.Direccion, obj.Telefono, obj.Mail);
                    if (vo.resp == "ok")
                    {
                        cargarListaDatos();
                        MessageBox.Show("Los datos se han cargado correctamente.", "Aviso de Sistema", MessageBoxButtons.OK);
                        this.Estado_BotonesPrincipales(true);
                        this.Estado_Botonesprocesos(false);
                        text_Categoria.Text = "";
                        text_Direccion.Text = "";
                        text_Telefono.Text = "";
                        text_Mail.Text = "";
                        text_Categoria.ReadOnly = true;
                        text_Direccion.ReadOnly = true;
                        text_Telefono.ReadOnly = true;
                        text_Mail.ReadOnly = true;
                        ProveedorTabPrincipal.SelectedIndex = 0;
                        nombre_prove = "";
                    }
                    else if (vo.resp == "En proceso")
                    {
                        cargarListaDatos();
                        MessageBox.Show("El proceso no se termino con exito...", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (vo.resp == "aguardando dao")
                    {
                        cargarListaDatos();
                        MessageBox.Show("Aguardando dao...", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else { cargarListaDatos(); }                                        // se selecciono un proveedor del dgv (actualizar datos)
            {
                Proveedores obj = new Proveedores();
                ProveedoresVo vo = new ProveedoresVo();

                obj.Nombre = text_Categoria.Text.Trim(); // // Categoria == Nombre
                obj.Direccion = text_Direccion.Text.Trim();
                obj.Telefono = text_Telefono.Text.Trim();
                obj.Mail = text_Mail.Text.Trim();
                vo.modificar(obj.Nombre, obj.Direccion, obj.Telefono, obj.Mail);
                if (vo.resp == "ok")
                {
                    cargarListaDatos();
                    MessageBox.Show("Los datos se han cambiado/actualizado correctamente.", "Aviso de Sistema", MessageBoxButtons.OK);
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_Botonesprocesos(false);
                    text_Categoria.Text = "";
                    text_Direccion.Text = "";
                    text_Telefono.Text = "";
                    text_Mail.Text = "";
                    text_Categoria.ReadOnly = true;
                    text_Direccion.ReadOnly = true;
                    text_Telefono.ReadOnly = true;
                    text_Mail.ReadOnly = true;
                    ProveedorTabPrincipal.SelectedIndex = 0;
                    nombre_prove = "";
                }
                else if (vo.resp == "En proceso")
                {
                    cargarListaDatos();
                    MessageBox.Show("El proceso no se termino con exito...", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (vo.resp == "aguardando dao")
                {
                    cargarListaDatos();
                    MessageBox.Show("Aguardando dao...", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
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
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            ProveedorTabPrincipal.SelectedIndex = 1;
            text_Categoria.ReadOnly = true;
            text_Direccion.ReadOnly = false;
            text_Telefono.ReadOnly = false;
            text_Mail.ReadOnly = false;
            text_Categoria.Focus();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            nombre_prove = "";
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

        private void dataGridViewProveedores_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_Botonesprocesos(true);
            text_Categoria.ReadOnly = true; // no se puede modificar la pk (nombre del proveedor)
            text_Direccion.ReadOnly = false;
            text_Telefono.ReadOnly = false;
            text_Mail.ReadOnly = false;
            ProveedorTabPrincipal.SelectedIndex = 1;

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Estado_Botonesprocesos(false);
            this.Estado_BotonesPrincipales(true);
            text_Categoria.Text = "";
            text_Categoria.ReadOnly = true;
            text_Direccion.Text = "";
            text_Direccion.ReadOnly = true;
            text_Telefono.Text = "";
            text_Telefono.ReadOnly = true;
            text_Mail.Text = "";
            text_Mail.ReadOnly = true;
            ProveedorTabPrincipal.SelectedIndex = 0;
            nombre_prove = "";
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewProveedores.CurrentRow.Cells["nombre"].Value))) // seleccionar item
            {
                MessageBox.Show("No se tiene informacion para visualizar, no selecciono ningun item valido.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea eliminar el usuario seleccionado?", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(Opcion == DialogResult.Yes)
                {
                    this.nombre_prove = Convert.ToString(dataGridViewProveedores.CurrentRow.Cells["nombre"].Value);// cargar valor seleccionado
                    // enviar a ejecutar la eliminacion de datos


                    Proveedores obj = new Proveedores();
                    ProveedoresVo vo = new ProveedoresVo();

                    obj.Nombre = nombre_prove;
                    vo.eliminar(obj.Nombre);
                    if (vo.resp == "ok")
                    {
                        cargarListaDatos();
                        MessageBox.Show("Los datos se han eliminado correctamente.", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Estado_BotonesPrincipales(true);
                        this.Estado_Botonesprocesos(false);
                        text_Categoria.Text = "";
                        text_Direccion.Text = "";
                        text_Telefono.Text = "";
                        text_Mail.Text = "";
                        text_Categoria.ReadOnly = true;
                        text_Direccion.ReadOnly = true;
                        text_Telefono.ReadOnly = true;
                        text_Mail.ReadOnly = true;
                        ProveedorTabPrincipal.SelectedIndex = 0;
                        nombre_prove = "";
                    }
                    else if (vo.resp == "En proceso")
                    {
                        cargarListaDatos();
                        MessageBox.Show("El proceso no se termino con exito...", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (vo.resp == "aguardando dao")
                    {
                        cargarListaDatos();
                        MessageBox.Show("Aguardando dao...", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
                else if (Opcion == DialogResult.No)
                {
                    MessageBox.Show("Se ha cancelado la eliminacion: No se elimino ningun dato.", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                

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
                this.listado_Proveedores(text_Buscar.Text.Trim());
            }
            
        }
    }
}
