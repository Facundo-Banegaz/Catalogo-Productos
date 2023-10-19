namespace GestorDeCatalogos
{
    partial class FrmPresentacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_title.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_title.Location = new System.Drawing.Point(153, 54);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(675, 44);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Bienvenido A Nuestro Catalogo de Productos.";
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_siguiente.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_siguiente.Location = new System.Drawing.Point(267, 541);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(211, 52);
            this.btn_siguiente.TabIndex = 1;
            this.btn_siguiente.Text = "Ver Catalogo";
            this.btn_siguiente.UseVisualStyleBackColor = false;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestorDeCatalogos.Properties.Resources.Catalog_icon_png;
            this.pictureBox1.Location = new System.Drawing.Point(288, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Crimson;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salir.Location = new System.Drawing.Point(511, 541);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(211, 52);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // FrmPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1023, 626);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.lbl_title);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentacion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_salir;
    }
}

