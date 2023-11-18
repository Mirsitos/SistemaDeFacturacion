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
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SistemaProyecto.Views
{
    public partial class MenuProducto : Form
    {
        public MenuProducto()
        {
            InitializeComponent();
        }

        void cargarComboBoxes()
        {
            //ComboBox cboxCat, ComboBox cboxMar, ComboBox cboxAlm)
            ProductoVo.cargarBoxes(comboBox_Categoria, comboBox_Marca, comboBox_Almacen);

            // obtener el item seleccionado del combobox
            //MessageBox.Show($"El valor seleccionado es {comboBox_Categoria.SelectedItem.ToString()}");

        }

        #region "Mis variables"
        string nombre_producto = "";       // variable guia o pk
        #endregion


        private void Selecciona_item()
        {

            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewProducto.CurrentRow.Cells["nombre"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*
                 
                 text_Nombre.ReadOnly = false;           // activar campos
            text_CodigoProducto.ReadOnly = false;
            text_Cantidad.ReadOnly = false;
            comboBox_Categoria.Enabled = true;
            comboBox_Marca.Enabled = true;
            comboBox_Almacen.Enabled = true;
                 */
                this.nombre_producto = Convert.ToString(dataGridViewProducto.CurrentRow.Cells["Nombre"].Value);
                text_Nombre.Text = Convert.ToString(dataGridViewProducto.CurrentRow.Cells["Nombre"].Value);
                text_CodigoProducto.Text = Convert.ToString(dataGridViewProducto.CurrentRow.Cells["CodigoProducto"].Value);
                text_Cantidad.Text = Convert.ToString(dataGridViewProducto.CurrentRow.Cells["Cantidad"].Value);

                //(dataGridViewProducto.CurrentRow.Cells["categoria"].Value)  // el valor de la cantidad

                //comboBox_Categoria.Items.IndexOf((dataGridViewProducto.CurrentRow.Cells["categoria"].Value)); // encuentra el indice del elemento cantidad
                
                comboBox_Categoria.SelectedIndex = comboBox_Categoria.Items.IndexOf((dataGridViewProducto.CurrentRow.Cells["categoria"].Value)); // selecciona el elemento del combox
                comboBox_Marca.SelectedIndex = comboBox_Marca.Items.IndexOf((dataGridViewProducto.CurrentRow.Cells["marca"].Value));
                comboBox_Almacen.SelectedIndex = comboBox_Almacen.Items.IndexOf((dataGridViewProducto.CurrentRow.Cells["almacen"].Value));
                
            }
        }

        void cargarListaDatos()
        {
            dataGridViewProducto.DataSource = ProductoDao.getListaProductos();
        }

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

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            
            text_Nombre.Text = "";
            text_CodigoProducto.Text = "";
            text_Cantidad.Text = "";


            text_Nombre.ReadOnly = false;           // activar campos
            text_CodigoProducto.ReadOnly = false;
            text_Cantidad.ReadOnly = false;
            comboBox_Categoria.Enabled = true;
            comboBox_Marca.Enabled = true;
            comboBox_Almacen.Enabled = true;

            dataGridViewProducto.Enabled = false;


            ProductoTabPrincipal.SelectedIndex = 1;
            text_CodigoProducto.Focus();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (nombre_producto == "") // crear nuevo cliente (no se selcciono nada en el dgv)
            {
                if (text_Nombre.Text == String.Empty || text_CodigoProducto.Text == String.Empty || text_Cantidad.Text == String.Empty)
                {
                    MessageBox.Show("Falta ingresar los datos requeridos! (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else // se procede a registrar la info
                {
                    Producto obj = new Producto();
                    ProductoVo vo = new ProductoVo();
                    //CodigoProducto, Nombre, Cantidad, categoria, marca, almacen
                    obj.Nombre = text_Nombre.Text.Trim();
                    obj.CodigoProducto = Convert.ToInt32(text_CodigoProducto.Text.Trim());
                    //MessageBox.Show($"{obj.CodigoProducto }, {obj.CodigoProducto.GetType()}");
                    obj.Cantidad = Convert.ToInt32(text_Cantidad.Text.Trim());

                    obj.Categoria = comboBox_Categoria.SelectedItem.ToString();
                    obj.Marca = comboBox_Marca.SelectedItem.ToString();
                    obj.Almacen = comboBox_Almacen.SelectedItem.ToString();


                    vo.agregar(obj.Nombre, obj.CodigoProducto, obj.Cantidad, obj.Categoria, obj.Marca, obj.Almacen);    
                    if (vo.resp == "ok")
                    {
                        cargarListaDatos();   
                        MessageBox.Show("Los datos se han cargado correctamente.", "Aviso de Sistema", MessageBoxButtons.OK);
                        this.Estado_BotonesPrincipales(true);
                        this.Estado_Botonesprocesos(false);

                        text_Nombre.Text = "";
                        text_CodigoProducto.Text = "";
                        text_Cantidad.Text = "";


                        text_Nombre.ReadOnly = true;
                        text_CodigoProducto.ReadOnly = true;
                        text_Cantidad.ReadOnly = true;
                        comboBox_Categoria.Enabled = false;
                        comboBox_Marca.Enabled = false;
                        comboBox_Almacen.Enabled = false;

                        desactivarCampos();

                        ProductoTabPrincipal.SelectedIndex = 0;
                        nombre_producto = "";
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
            else 
            { 
                cargarListaDatos();                                 // se selecciono un cliente del dgv (actualizar datos) // modificar datos
            
                Producto obj = new Producto();
                ProductoVo vo = new ProductoVo();

                obj.Nombre = text_Nombre.Text.Trim();
                obj.CodigoProducto = int.Parse(text_CodigoProducto.Text); // quizas de problemas
                obj.CodigoProducto = int.Parse(text_CodigoProducto.Text);
                obj.Cantidad = int.Parse(text_Cantidad.Text.Trim());

                obj.Categoria = comboBox_Categoria.SelectedItem.ToString();
                obj.Marca = comboBox_Marca.SelectedItem.ToString();
                obj.Almacen = comboBox_Almacen.SelectedItem.ToString();
                //(string nombre, int codigoprod, int cantidad, string categoria, string marca, string almacen)

                vo.modificar(obj.Nombre, obj.CodigoProducto, obj.Cantidad, obj.Categoria, obj.Marca, obj.Almacen);
                if (vo.resp == "ok")
                {
                    cargarListaDatos();
                    MessageBox.Show("Los datos se han cambiado/actualizado correctamente.", "Aviso de Sistema", MessageBoxButtons.OK);
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_Botonesprocesos(false);
                    
                    text_Nombre.Text = "";
                    text_CodigoProducto.Text = "";
                    text_Cantidad.Text = "";


                    text_Nombre.ReadOnly = true;            // desactivar campos
                    text_CodigoProducto.ReadOnly = true;
                    text_Cantidad.ReadOnly = true;
                    comboBox_Categoria.Enabled = false;
                    comboBox_Marca.Enabled = false;
                    comboBox_Almacen.Enabled = false;

                    desactivarCampos();

                    ProductoTabPrincipal.SelectedIndex = 0;
                    nombre_producto = "";
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
            dataGridViewProducto.Enabled = true;
        }

        private void MenuProducto_Load(object sender, EventArgs e)
        {
            cargarComboBoxes();
            cargarListaDatos();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            

            text_Nombre.Text = "";                  // desactivar campos
            text_CodigoProducto.Text = "";
            text_Cantidad.Text = "";

            text_Nombre.ReadOnly = true;            // desactivar campos
            text_CodigoProducto.ReadOnly = true;
            text_Cantidad.ReadOnly = true;
            comboBox_Categoria.Enabled = false;
            comboBox_Marca.Enabled = false;
            comboBox_Almacen.Enabled = false;

            this.Estado_BotonesPrincipales(true);
            this.Estado_Botonesprocesos(false);

            desactivarCampos();
            dataGridViewProducto.Enabled = true;

            ProductoTabPrincipal.SelectedIndex = 0;
        }

        private void desactivarCampos()
        {
            text_Nombre.Text = "";                  // desactivar campos
            text_CodigoProducto.Text = "";
            text_Cantidad.Text = "";

            text_Nombre.ReadOnly = true;            // desactivar campos
            text_CodigoProducto.ReadOnly = true;
            text_Cantidad.ReadOnly = true;
            comboBox_Categoria.Enabled = false;
            comboBox_Marca.Enabled = false;
            comboBox_Almacen.Enabled = false;

            comboBox_Categoria.SelectedIndex = -1;
            comboBox_Marca.SelectedIndex = -1;
            comboBox_Almacen.SelectedIndex = -1;
            
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            

            text_Nombre.Text = "";                  // desactivar campos
            text_CodigoProducto.Text = "";
            text_Cantidad.Text = "";

            text_Nombre.ReadOnly = true;            // desactivar campos
            text_CodigoProducto.ReadOnly = true;
            text_Cantidad.ReadOnly = true;
            comboBox_Categoria.Enabled = false;
            comboBox_Marca.Enabled = false;
            comboBox_Almacen.Enabled = false;

            this.Estado_BotonesPrincipales(true);
            this.Estado_Botonesprocesos(false);

            dataGridViewProducto.Enabled = true;
            desactivarCampos();

            ProductoTabPrincipal.SelectedIndex = 0;
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            ProductoTabPrincipal.SelectedIndex = 1;

            text_Nombre.ReadOnly = false;            // desactivar campos
            text_CodigoProducto.ReadOnly = true;
            text_Cantidad.ReadOnly = false;
            comboBox_Categoria.Enabled = true;
            comboBox_Marca.Enabled = true;
            comboBox_Almacen.Enabled = true;

            text_Nombre.Focus();
        }

        private void dataGridViewProducto_DoubleClick(object sender, EventArgs e)
        {
            /*this.Selecciona_item();
            this.Estado_Botonesprocesos(true);
            text_Nombre.ReadOnly = false;            // desactivar campos
            text_CodigoProducto.ReadOnly = true;
            text_Cantidad.ReadOnly = false;
            comboBox_Categoria.Enabled = true;
            comboBox_Marca.Enabled = true;
            comboBox_Almacen.Enabled = true;
            ProductoTabPrincipal.SelectedIndex = 1;*/


            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Selecciona_item();
            ProductoTabPrincipal.SelectedIndex = 1;

            text_Nombre.ReadOnly = false;            // desactivar campos
            text_CodigoProducto.ReadOnly = true;
            text_Cantidad.ReadOnly = false;
            comboBox_Categoria.Enabled = true;
            comboBox_Marca.Enabled = true;
            comboBox_Almacen.Enabled = true;

            text_Nombre.Focus();

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewProducto.CurrentRow.Cells["nombre"].Value))) // seleccionar item
            {
                MessageBox.Show("No se tiene informacion para visualizar, no selecciono ningun item valido.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea eliminar el usuario seleccionado?", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    this.nombre_producto = Convert.ToString(dataGridViewProducto.CurrentRow.Cells["CodigoProducto"].Value);// cargar valor seleccionado // valor cambiado de nombre a codigoProd
                    // enviar a ejecutar la eliminacion de datos

                    
                    Producto obj = new Producto();
                    ProductoVo vo = new ProductoVo();

                    // this.nombre_producto = Convert.ToString(dataGridViewProducto.CurrentRow.Cells["CodigoProducto"].Value);// cargar valor seleccionado // valor cambiado de nombre a codigoProd

                    obj.Nombre = nombre_producto; // en realidad es CodigoProducto pero en string
                    //obj.Cantidad = 
                    string cat =  Convert.ToString(dataGridViewProducto.CurrentRow.Cells["Cantidad"].Value);
                    obj.Cantidad = Convert.ToInt32(cat);
                    obj.Categoria= Convert.ToString(dataGridViewProducto.CurrentRow.Cells["categoria"].Value);
                    obj.Marca= Convert.ToString(dataGridViewProducto.CurrentRow.Cells["marca"].Value);
                    obj.Almacen= Convert.ToString(dataGridViewProducto.CurrentRow.Cells["almacen"].Value);

                    vo.eliminar(obj.Nombre, obj);
                    if (vo.resp == "ok")
                    {
                        cargarListaDatos();
                        MessageBox.Show("Los datos se han eliminado correctamente.", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Estado_BotonesPrincipales(true);
                        this.Estado_Botonesprocesos(false);

                        text_Nombre.Text = "";                  // desactivar campos
                        text_CodigoProducto.Text = "";
                        text_Cantidad.Text = "";

                        text_Nombre.ReadOnly = true;            // desactivar campos
                        text_CodigoProducto.ReadOnly = true;
                        text_Cantidad.ReadOnly = true;
                        comboBox_Categoria.Enabled = false;
                        comboBox_Marca.Enabled = false;
                        comboBox_Almacen.Enabled = false;

                        ProductoTabPrincipal.SelectedIndex = 0;
                        nombre_producto = "";
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

        #region "agregar +x a cat, marca, almacen" 
        public ComboBox getComboBoxCategoria()
        {
            return comboBox_Categoria;
        }

        public ComboBox getComboBoxMarca()
        {
            return comboBox_Marca;
        }

        public ComboBox getComboBoxAlmacen()
        {
            return comboBox_Almacen;
        }
        #endregion

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_Buscar.Text))
            {
                cargarListaDatos();
            }
            else
            {
                this.listado_Productos(text_Buscar.Text.Trim());
            }
        }

        private void listado_Productos(string nombreCliListado)
        {
            try
            {
                dataGridViewProducto.DataSource = ProductoVo.listarDatos(nombreCliListado);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en listado Productos" + ex.Message + ex.StackTrace);
            }
        }
    }
}
