namespace SistemaProyecto.Views
{
    partial class MenuAlmacenes
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
            this.dataGridViewAlmacenes = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.text_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlmacenes)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "ALMACENES";
            // 
            // dataGridViewAlmacenes
            // 
            this.dataGridViewAlmacenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAlmacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlmacenes.Location = new System.Drawing.Point(22, 106);
            this.dataGridViewAlmacenes.Name = "dataGridViewAlmacenes";
            this.dataGridViewAlmacenes.Size = new System.Drawing.Size(756, 337);
            this.dataGridViewAlmacenes.TabIndex = 16;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(398, 68);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 15;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // text_Buscar
            // 
            this.text_Buscar.Location = new System.Drawing.Point(193, 68);
            this.text_Buscar.Name = "text_Buscar";
            this.text_Buscar.Size = new System.Drawing.Size(188, 20);
            this.text_Buscar.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(70, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Buscar (Nombre):  ";
            // 
            // MenuAlmacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewAlmacenes);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.text_Buscar);
            this.Controls.Add(this.label1);
            this.Name = "MenuAlmacenes";
            this.Text = "MenuAlmacenes";
            this.Load += new System.EventHandler(this.MenuAlmacenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlmacenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewAlmacenes;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox text_Buscar;
        private System.Windows.Forms.Label label1;
    }
}