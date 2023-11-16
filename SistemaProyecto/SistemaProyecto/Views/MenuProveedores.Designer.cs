namespace SistemaProyecto.Views
{
    partial class MenuProveedores
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
            this.ProveedorTabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1Proveedor = new System.Windows.Forms.TabPage();
            this.dataGridViewProveedores = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.text_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2Proveedor = new System.Windows.Forms.TabPage();
            this.text_Mail = new System.Windows.Forms.TextBox();
            this.text_Telefono = new System.Windows.Forms.TextBox();
            this.text_Direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.text_Categoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ProveedorTabPrincipal.SuspendLayout();
            this.tabPage1Proveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedores)).BeginInit();
            this.tabPage2Proveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProveedorTabPrincipal
            // 
            this.ProveedorTabPrincipal.Controls.Add(this.tabPage1Proveedor);
            this.ProveedorTabPrincipal.Controls.Add(this.tabPage2Proveedor);
            this.ProveedorTabPrincipal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedorTabPrincipal.Location = new System.Drawing.Point(12, 46);
            this.ProveedorTabPrincipal.Name = "ProveedorTabPrincipal";
            this.ProveedorTabPrincipal.SelectedIndex = 0;
            this.ProveedorTabPrincipal.Size = new System.Drawing.Size(776, 375);
            this.ProveedorTabPrincipal.TabIndex = 0;
            // 
            // tabPage1Proveedor
            // 
            this.tabPage1Proveedor.Controls.Add(this.dataGridViewProveedores);
            this.tabPage1Proveedor.Controls.Add(this.btn_Buscar);
            this.tabPage1Proveedor.Controls.Add(this.text_Buscar);
            this.tabPage1Proveedor.Controls.Add(this.label1);
            this.tabPage1Proveedor.Location = new System.Drawing.Point(4, 25);
            this.tabPage1Proveedor.Name = "tabPage1Proveedor";
            this.tabPage1Proveedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Proveedor.Size = new System.Drawing.Size(768, 346);
            this.tabPage1Proveedor.TabIndex = 0;
            this.tabPage1Proveedor.Text = "Listado";
            this.tabPage1Proveedor.UseVisualStyleBackColor = true;
            this.tabPage1Proveedor.Click += new System.EventHandler(this.tabPage1Proveedor_Click);
            // 
            // dataGridViewProveedores
            // 
            this.dataGridViewProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProveedores.Location = new System.Drawing.Point(6, 72);
            this.dataGridViewProveedores.Name = "dataGridViewProveedores";
            this.dataGridViewProveedores.Size = new System.Drawing.Size(756, 268);
            this.dataGridViewProveedores.TabIndex = 3;
            this.dataGridViewProveedores.DoubleClick += new System.EventHandler(this.dataGridViewProveedores_DoubleClick);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(342, 31);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // text_Buscar
            // 
            this.text_Buscar.Location = new System.Drawing.Point(113, 35);
            this.text_Buscar.Name = "text_Buscar";
            this.text_Buscar.Size = new System.Drawing.Size(188, 23);
            this.text_Buscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar: ";
            // 
            // tabPage2Proveedor
            // 
            this.tabPage2Proveedor.Controls.Add(this.text_Mail);
            this.tabPage2Proveedor.Controls.Add(this.text_Telefono);
            this.tabPage2Proveedor.Controls.Add(this.text_Direccion);
            this.tabPage2Proveedor.Controls.Add(this.label4);
            this.tabPage2Proveedor.Controls.Add(this.label5);
            this.tabPage2Proveedor.Controls.Add(this.label3);
            this.tabPage2Proveedor.Controls.Add(this.btn_Regresar);
            this.tabPage2Proveedor.Controls.Add(this.btn_Guardar);
            this.tabPage2Proveedor.Controls.Add(this.btn_Cancelar);
            this.tabPage2Proveedor.Controls.Add(this.text_Categoria);
            this.tabPage2Proveedor.Controls.Add(this.label2);
            this.tabPage2Proveedor.Location = new System.Drawing.Point(4, 25);
            this.tabPage2Proveedor.Name = "tabPage2Proveedor";
            this.tabPage2Proveedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Proveedor.Size = new System.Drawing.Size(768, 346);
            this.tabPage2Proveedor.TabIndex = 1;
            this.tabPage2Proveedor.Text = "Movimientos";
            this.tabPage2Proveedor.UseVisualStyleBackColor = true;
            // 
            // text_Mail
            // 
            this.text_Mail.Location = new System.Drawing.Point(136, 141);
            this.text_Mail.Name = "text_Mail";
            this.text_Mail.ReadOnly = true;
            this.text_Mail.Size = new System.Drawing.Size(427, 23);
            this.text_Mail.TabIndex = 10;
            // 
            // text_Telefono
            // 
            this.text_Telefono.Location = new System.Drawing.Point(136, 105);
            this.text_Telefono.Name = "text_Telefono";
            this.text_Telefono.ReadOnly = true;
            this.text_Telefono.Size = new System.Drawing.Size(427, 23);
            this.text_Telefono.TabIndex = 9;
            // 
            // text_Direccion
            // 
            this.text_Direccion.Location = new System.Drawing.Point(136, 70);
            this.text_Direccion.Name = "text_Direccion";
            this.text_Direccion.ReadOnly = true;
            this.text_Direccion.Size = new System.Drawing.Size(427, 23);
            this.text_Direccion.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mail (*): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono (*): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion (*): ";
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Location = new System.Drawing.Point(386, 197);
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
            this.btn_Guardar.Location = new System.Drawing.Point(151, 197);
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
            this.btn_Cancelar.Location = new System.Drawing.Point(271, 197);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 31);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Visible = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // text_Categoria
            // 
            this.text_Categoria.Location = new System.Drawing.Point(136, 35);
            this.text_Categoria.Name = "text_Categoria";
            this.text_Categoria.ReadOnly = true;
            this.text_Categoria.Size = new System.Drawing.Size(427, 23);
            this.text_Categoria.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre (*): ";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Location = new System.Drawing.Point(51, 427);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(79, 49);
            this.btn_Nuevo.TabIndex = 1;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.Location = new System.Drawing.Point(152, 427);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(79, 49);
            this.btn_Actualizar.TabIndex = 2;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(249, 427);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(79, 49);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(348, 427);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(79, 49);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "PROVEEDORES";
            // 
            // MenuProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.ProveedorTabPrincipal);
            this.Name = "MenuProveedores";
            this.Text = "MenuProveedores";
            this.Load += new System.EventHandler(this.MenuProveedores_Load);
            this.ProveedorTabPrincipal.ResumeLayout(false);
            this.tabPage1Proveedor.ResumeLayout(false);
            this.tabPage1Proveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedores)).EndInit();
            this.tabPage2Proveedor.ResumeLayout(false);
            this.tabPage2Proveedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ProveedorTabPrincipal;
        private System.Windows.Forms.TabPage tabPage1Proveedor;
        private System.Windows.Forms.TabPage tabPage2Proveedor;
        private System.Windows.Forms.DataGridView dataGridViewProveedores;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox text_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox text_Categoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_Mail;
        private System.Windows.Forms.TextBox text_Telefono;
        private System.Windows.Forms.TextBox text_Direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}