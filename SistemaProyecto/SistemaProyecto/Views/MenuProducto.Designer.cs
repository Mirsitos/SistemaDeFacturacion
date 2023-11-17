namespace SistemaProyecto.Views
{
    partial class MenuProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.ProductoTabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1Producto = new System.Windows.Forms.TabPage();
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.text_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2Producto = new System.Windows.Forms.TabPage();
            this.comboBox_Almacen = new System.Windows.Forms.ComboBox();
            this.comboBox_Marca = new System.Windows.Forms.ComboBox();
            this.comboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.text_Cantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.text_CodigoProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductoTabPrincipal.SuspendLayout();
            this.tabPage1Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            this.tabPage2Producto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "PRODUCTOS";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(348, 428);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(79, 49);
            this.btn_Salir.TabIndex = 16;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(249, 428);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(79, 49);
            this.btn_Eliminar.TabIndex = 15;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.Location = new System.Drawing.Point(152, 428);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(79, 49);
            this.btn_Actualizar.TabIndex = 14;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Location = new System.Drawing.Point(51, 428);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(79, 49);
            this.btn_Nuevo.TabIndex = 13;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // ProductoTabPrincipal
            // 
            this.ProductoTabPrincipal.Controls.Add(this.tabPage1Producto);
            this.ProductoTabPrincipal.Controls.Add(this.tabPage2Producto);
            this.ProductoTabPrincipal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoTabPrincipal.Location = new System.Drawing.Point(12, 47);
            this.ProductoTabPrincipal.Name = "ProductoTabPrincipal";
            this.ProductoTabPrincipal.SelectedIndex = 0;
            this.ProductoTabPrincipal.Size = new System.Drawing.Size(776, 375);
            this.ProductoTabPrincipal.TabIndex = 12;
            // 
            // tabPage1Producto
            // 
            this.tabPage1Producto.Controls.Add(this.dataGridViewProducto);
            this.tabPage1Producto.Controls.Add(this.btn_Buscar);
            this.tabPage1Producto.Controls.Add(this.text_Buscar);
            this.tabPage1Producto.Controls.Add(this.label1);
            this.tabPage1Producto.Location = new System.Drawing.Point(4, 25);
            this.tabPage1Producto.Name = "tabPage1Producto";
            this.tabPage1Producto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Producto.Size = new System.Drawing.Size(768, 346);
            this.tabPage1Producto.TabIndex = 0;
            this.tabPage1Producto.Text = "Listado";
            this.tabPage1Producto.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Location = new System.Drawing.Point(6, 72);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.Size = new System.Drawing.Size(756, 268);
            this.dataGridViewProducto.TabIndex = 3;
            this.dataGridViewProducto.DoubleClick += new System.EventHandler(this.dataGridViewProducto_DoubleClick);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(373, 32);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // text_Buscar
            // 
            this.text_Buscar.Location = new System.Drawing.Point(168, 32);
            this.text_Buscar.Name = "text_Buscar";
            this.text_Buscar.Size = new System.Drawing.Size(188, 23);
            this.text_Buscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar (CodProd):  ";
            // 
            // tabPage2Producto
            // 
            this.tabPage2Producto.Controls.Add(this.comboBox_Almacen);
            this.tabPage2Producto.Controls.Add(this.comboBox_Marca);
            this.tabPage2Producto.Controls.Add(this.comboBox_Categoria);
            this.tabPage2Producto.Controls.Add(this.text_Cantidad);
            this.tabPage2Producto.Controls.Add(this.label7);
            this.tabPage2Producto.Controls.Add(this.label8);
            this.tabPage2Producto.Controls.Add(this.text_Nombre);
            this.tabPage2Producto.Controls.Add(this.label4);
            this.tabPage2Producto.Controls.Add(this.label5);
            this.tabPage2Producto.Controls.Add(this.label3);
            this.tabPage2Producto.Controls.Add(this.btn_Regresar);
            this.tabPage2Producto.Controls.Add(this.btn_Guardar);
            this.tabPage2Producto.Controls.Add(this.btn_Cancelar);
            this.tabPage2Producto.Controls.Add(this.text_CodigoProducto);
            this.tabPage2Producto.Controls.Add(this.label2);
            this.tabPage2Producto.Location = new System.Drawing.Point(4, 25);
            this.tabPage2Producto.Name = "tabPage2Producto";
            this.tabPage2Producto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Producto.Size = new System.Drawing.Size(768, 346);
            this.tabPage2Producto.TabIndex = 1;
            this.tabPage2Producto.Text = "Movimientos";
            this.tabPage2Producto.UseVisualStyleBackColor = true;
            // 
            // comboBox_Almacen
            // 
            this.comboBox_Almacen.Enabled = false;
            this.comboBox_Almacen.FormattingEnabled = true;
            this.comboBox_Almacen.Location = new System.Drawing.Point(136, 212);
            this.comboBox_Almacen.Name = "comboBox_Almacen";
            this.comboBox_Almacen.Size = new System.Drawing.Size(427, 24);
            this.comboBox_Almacen.TabIndex = 17;
            // 
            // comboBox_Marca
            // 
            this.comboBox_Marca.Enabled = false;
            this.comboBox_Marca.FormattingEnabled = true;
            this.comboBox_Marca.Location = new System.Drawing.Point(136, 176);
            this.comboBox_Marca.Name = "comboBox_Marca";
            this.comboBox_Marca.Size = new System.Drawing.Size(427, 24);
            this.comboBox_Marca.TabIndex = 16;
            // 
            // comboBox_Categoria
            // 
            this.comboBox_Categoria.Enabled = false;
            this.comboBox_Categoria.FormattingEnabled = true;
            this.comboBox_Categoria.Location = new System.Drawing.Point(136, 142);
            this.comboBox_Categoria.Name = "comboBox_Categoria";
            this.comboBox_Categoria.Size = new System.Drawing.Size(427, 24);
            this.comboBox_Categoria.TabIndex = 15;
            // 
            // text_Cantidad
            // 
            this.text_Cantidad.Location = new System.Drawing.Point(136, 106);
            this.text_Cantidad.Name = "text_Cantidad";
            this.text_Cantidad.ReadOnly = true;
            this.text_Cantidad.Size = new System.Drawing.Size(427, 23);
            this.text_Cantidad.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Categoria (*): ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cantidad (*): ";
            // 
            // text_Nombre
            // 
            this.text_Nombre.Location = new System.Drawing.Point(136, 70);
            this.text_Nombre.Name = "text_Nombre";
            this.text_Nombre.ReadOnly = true;
            this.text_Nombre.Size = new System.Drawing.Size(427, 23);
            this.text_Nombre.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Almacen (*): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Marca (*): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre (*): ";
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Location = new System.Drawing.Point(386, 268);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(75, 31);
            this.btn_Regresar.TabIndex = 4;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Visible = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(151, 268);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 31);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Visible = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(271, 268);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 31);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Visible = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // text_CodigoProducto
            // 
            this.text_CodigoProducto.Location = new System.Drawing.Point(136, 35);
            this.text_CodigoProducto.Name = "text_CodigoProducto";
            this.text_CodigoProducto.ReadOnly = true;
            this.text_CodigoProducto.Size = new System.Drawing.Size(427, 23);
            this.text_CodigoProducto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "CodigoProd (*): ";
            // 
            // MenuProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.ProductoTabPrincipal);
            this.Name = "MenuProducto";
            this.Text = "MenuProducto";
            this.Load += new System.EventHandler(this.MenuProducto_Load);
            this.ProductoTabPrincipal.ResumeLayout(false);
            this.tabPage1Producto.ResumeLayout(false);
            this.tabPage1Producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            this.tabPage2Producto.ResumeLayout(false);
            this.tabPage2Producto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.TabControl ProductoTabPrincipal;
        private System.Windows.Forms.TabPage tabPage1Producto;
        private System.Windows.Forms.DataGridView dataGridViewProducto;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox text_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2Producto;
        private System.Windows.Forms.TextBox text_Cantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox text_CodigoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Categoria;
        private System.Windows.Forms.ComboBox comboBox_Almacen;
        private System.Windows.Forms.ComboBox comboBox_Marca;
    }
}