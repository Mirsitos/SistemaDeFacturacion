namespace SistemaProyecto.Views
{
    partial class MenuMarcas
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
            this.dataGridViewMarcas = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.text_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "MARCAS";
            // 
            // dataGridViewMarcas
            // 
            this.dataGridViewMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarcas.Location = new System.Drawing.Point(22, 125);
            this.dataGridViewMarcas.Name = "dataGridViewMarcas";
            this.dataGridViewMarcas.Size = new System.Drawing.Size(756, 337);
            this.dataGridViewMarcas.TabIndex = 16;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(398, 87);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 15;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // text_Buscar
            // 
            this.text_Buscar.Location = new System.Drawing.Point(193, 87);
            this.text_Buscar.Name = "text_Buscar";
            this.text_Buscar.Size = new System.Drawing.Size(188, 20);
            this.text_Buscar.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Buscar (Nombre):  ";
            // 
            // MenuMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewMarcas);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.text_Buscar);
            this.Controls.Add(this.label1);
            this.Name = "MenuMarcas";
            this.Text = "MenuMarcas";
            this.Load += new System.EventHandler(this.MenuMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewMarcas;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox text_Buscar;
        private System.Windows.Forms.Label label1;
    }
}