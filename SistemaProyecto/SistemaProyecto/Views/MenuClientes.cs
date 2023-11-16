using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistemaProyecto.Controllers;
using SistemaProyecto.Dao;
using SistemaProyecto.Models;

namespace SistemaProyecto.Views
{
    public partial class MenuClientes : Form
    {
        public MenuClientes()
        {
            InitializeComponent();
            
        }

        #region "Mis variables"
        string nombre_cliente = "";       // variable guia o pk
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

        private void listado_Clientes(string nombreCliListado)
        {
            try
            {
                dataGridViewCliente.DataSource = ClienteVo.listarDatos(nombreCliListado);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en listadoProveedores MenuClientes" + ex.Message + ex.StackTrace);
            }
        }

        void cargarListaDatos()
        {
            dataGridViewCliente.DataSource = ClienteDao.getListaClientes();
        }

        private void Selecciona_item()
        {

            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewCliente.CurrentRow.Cells["cedula"].Value))) // la pk de cliente es cedula
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.nombre_cliente = Convert.ToString(dataGridViewCliente.CurrentRow.Cells["cedula"].Value);
                text_Cedula.Text = Convert.ToString(dataGridViewCliente.CurrentRow.Cells["cedula"].Value);
                text_Nombre.Text = Convert.ToString(dataGridViewCliente.CurrentRow.Cells["nombre"].Value);
                text_Apellido.Text = Convert.ToString(dataGridViewCliente.CurrentRow.Cells["apellido"].Value);
                text_Mail.Text = Convert.ToString(dataGridViewCliente.CurrentRow.Cells["gmail"].Value);
                text_Telefono.Text = Convert.ToString(dataGridViewCliente.CurrentRow.Cells["telefono"].Value);
                text_Direccion.Text = Convert.ToString(dataGridViewCliente.CurrentRow.Cells["direccion"].Value);
            }
        }
        #endregion

        private void MenuClientes_Load(object sender, EventArgs e)
        {
            cargarListaDatos();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            text_Nombre.Text = "";
            text_Apellido.Text = "";
            text_Cedula.Text = "";
            text_Mail.Text = "";
            text_Telefono.Text = "";
            text_Direccion.Text = "";

            text_Nombre.ReadOnly = false;
            text_Apellido.ReadOnly = false;
            text_Cedula.ReadOnly = false;
            text_Mail.ReadOnly = false;
            text_Telefono.ReadOnly = false;
            text_Direccion.ReadOnly = false;

            ClienteTabPrincipal.SelectedIndex = 1;
            text_Nombre.Focus();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            ClienteTabPrincipal.SelectedIndex = 1;

            text_Nombre.ReadOnly = false;
            text_Apellido.ReadOnly = false;
            text_Cedula.ReadOnly = true ;       // pk
            text_Mail.ReadOnly = false;
            text_Telefono.ReadOnly = false;
            text_Direccion.ReadOnly = false;
            text_Nombre.Focus();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            nombre_cliente = "";
            
            text_Nombre.Text = "";
            text_Apellido.Text = "";
            text_Cedula.Text = "";
            text_Mail.Text = "";
            text_Telefono.Text = "";
            text_Direccion.Text = "";

            text_Nombre.ReadOnly = true;
            text_Apellido.ReadOnly = true;
            text_Cedula.ReadOnly = true;
            text_Mail.ReadOnly = true;
            text_Telefono.ReadOnly = true;
            text_Direccion.ReadOnly = true;

            this.Estado_BotonesPrincipales(true);
            this.Estado_Botonesprocesos(false);
            ClienteTabPrincipal.SelectedIndex = 0;
        }

       

        private void dataGridViewClientes_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_item();
            this.Estado_Botonesprocesos(true);
            text_Cedula.ReadOnly = true; // no se puede modificar la pk (nombre del proveedor)

            text_Nombre.ReadOnly = false;
            text_Apellido.ReadOnly = false;
            text_Mail.ReadOnly = false;
            text_Telefono.ReadOnly = false;
            text_Direccion.ReadOnly = false;
            ClienteTabPrincipal.SelectedIndex = 1;
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Estado_Botonesprocesos(false);
            this.Estado_BotonesPrincipales(true);
            text_Nombre.Text = "";
            text_Apellido.Text = "";
            text_Cedula.Text = "";
            text_Mail.Text = "";
            text_Telefono.Text = "";
            text_Direccion.Text = "";

            text_Nombre.ReadOnly = true;
            text_Apellido.ReadOnly = true;
            text_Cedula.ReadOnly = true;
            text_Mail.ReadOnly = true;
            text_Telefono.ReadOnly = true;
            text_Direccion.ReadOnly = true;
            ClienteTabPrincipal.SelectedIndex = 0;
            nombre_cliente = "";
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewCliente.CurrentRow.Cells["cedula"].Value))) // seleccionar item
            {
                MessageBox.Show("No se tiene informacion para visualizar, no selecciono ningun item valido.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea eliminar el usuario seleccionado?", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    this.nombre_cliente = Convert.ToString(dataGridViewCliente.CurrentRow.Cells["cedula"].Value);// cargar valor seleccionado
                    // enviar a ejecutar la eliminacion de datos


                    Cliente obj = new Cliente();
                    ClienteVo vo = new ClienteVo();

                    obj.Cedula = nombre_cliente;
                    vo.eliminar(obj.Cedula);
                    if (vo.resp == "ok")
                    {
                        cargarListaDatos();
                        MessageBox.Show("Los datos se han eliminado correctamente.", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Estado_BotonesPrincipales(true);
                        this.Estado_Botonesprocesos(false);
                        text_Nombre.Text = "";
                        text_Apellido.Text = "";
                        text_Cedula.Text = "";
                        text_Mail.Text = "";
                        text_Telefono.Text = "";
                        text_Direccion.Text = "";

                        text_Nombre.ReadOnly = true;
                        text_Apellido.ReadOnly = true;
                        text_Cedula.ReadOnly = true;
                        text_Mail.ReadOnly = true;
                        text_Telefono.ReadOnly = true;
                        text_Direccion.ReadOnly = true;
                        ClienteTabPrincipal.SelectedIndex = 0;
                        nombre_cliente = "";
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

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (nombre_cliente == "") // crear nuevo cliente (no se selcciono nada en el dgv)
            {
                if (text_Nombre.Text == String.Empty || text_Apellido.Text == String.Empty || text_Cedula.Text == String.Empty || text_Mail.Text == String.Empty || text_Telefono.Text == String.Empty || text_Direccion.Text == String.Empty ) // Categoria == Nombre
                {
                    MessageBox.Show("Falta ingresar los datos requeridos! (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else // se procede a registrar la info
                {
                    Cliente obj = new Cliente();
                    ClienteVo vo = new ClienteVo();

                    obj.Nombre = text_Nombre.Text.Trim();
                    obj.Apellido = text_Apellido.Text.Trim();
                    obj.Cedula = text_Cedula.Text.Trim();
                    obj.Mail = text_Mail.Text.Trim();
                    obj.Telefono = text_Telefono.Text.Trim();
                    obj.Direccion = text_Direccion.Text.Trim();
                    vo.agregar(obj.Nombre, obj.Apellido, obj.Cedula, obj.Mail, obj.Telefono, obj.Direccion);
                    if (vo.resp == "ok")
                    {
                        cargarListaDatos();
                        MessageBox.Show("Los datos se han cargado correctamente.", "Aviso de Sistema", MessageBoxButtons.OK);
                        this.Estado_BotonesPrincipales(true);
                        this.Estado_Botonesprocesos(false);
                        text_Nombre.Text = "";
                        text_Apellido.Text = "";
                        text_Cedula.Text = "";
                        text_Mail.Text = "";
                        text_Telefono.Text = "";
                        text_Direccion.Text = "";

                        text_Nombre.ReadOnly = true;
                        text_Apellido.ReadOnly = true;
                        text_Cedula.ReadOnly = true;
                        text_Mail.ReadOnly = true;
                        text_Telefono.ReadOnly = true;
                        text_Direccion.ReadOnly = true;
                        ClienteTabPrincipal.SelectedIndex = 0;
                        nombre_cliente = "";
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
            else { cargarListaDatos(); }                                // se selecciono un cliente del dgv (actualizar datos)
            {
                Cliente obj = new Cliente();
                ClienteVo vo = new ClienteVo();

                obj.Nombre = text_Nombre.Text.Trim();
                obj.Apellido = text_Apellido.Text.Trim();
                obj.Cedula = text_Cedula.Text.Trim();
                obj.Mail = text_Mail.Text.Trim();
                obj.Telefono = text_Telefono.Text.Trim();
                obj.Direccion = text_Direccion.Text.Trim();

                vo.modificar(obj.Nombre, obj.Apellido, obj.Cedula, obj.Mail, obj.Telefono, obj.Direccion);
                if (vo.resp == "ok")
                {
                    cargarListaDatos();
                    MessageBox.Show("Los datos se han cambiado/actualizado correctamente.", "Aviso de Sistema", MessageBoxButtons.OK);
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_Botonesprocesos(false);
                    text_Nombre.Text = "";
                    text_Apellido.Text = "";
                    text_Cedula.Text = "";
                    text_Mail.Text = "";
                    text_Telefono.Text = "";
                    text_Direccion.Text = "";

                    text_Nombre.ReadOnly = true;
                    text_Apellido.ReadOnly = true;
                    text_Cedula.ReadOnly = true;
                    text_Mail.ReadOnly = true;
                    text_Telefono.ReadOnly = true;
                    text_Direccion.ReadOnly = true;
                    ClienteTabPrincipal.SelectedIndex = 0;
                    nombre_cliente = "";
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

        private void MenuClientes_Load_1(object sender, EventArgs e)
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
                this.listado_Clientes(text_Buscar.Text.Trim());
            }
        }
    }
}
