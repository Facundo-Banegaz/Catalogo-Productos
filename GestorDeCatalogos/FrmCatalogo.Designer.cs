namespace GestorDeCatalogos
{
    partial class FrmCatalogo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_articulos = new FontAwesome.Sharp.IconMenuItem();
            this.menu_marcas = new FontAwesome.Sharp.IconMenuItem();
            this.menu_categoria = new FontAwesome.Sharp.IconMenuItem();
            this.menu_acerca = new FontAwesome.Sharp.IconMenuItem();
            this.menu_title = new System.Windows.Forms.MenuStrip();
            this.menu_salir = new FontAwesome.Sharp.IconMenuItem();
            this.lbl_title = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menu_consulta = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menu_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_articulos,
            this.menu_marcas,
            this.menu_categoria,
            this.menu_consulta,
            this.menu_acerca});
            this.menuStrip1.Location = new System.Drawing.Point(0, 100);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1854, 88);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // menu_articulos
            // 
            this.menu_articulos.AutoSize = false;
            this.menu_articulos.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_articulos.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.menu_articulos.IconColor = System.Drawing.Color.Black;
            this.menu_articulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_articulos.IconSize = 60;
            this.menu_articulos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_articulos.Name = "menu_articulos";
            this.menu_articulos.Size = new System.Drawing.Size(100, 80);
            this.menu_articulos.Text = "Articulos";
            this.menu_articulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_articulos.Click += new System.EventHandler(this.menu_articulos_Click);
            // 
            // menu_marcas
            // 
            this.menu_marcas.AutoSize = false;
            this.menu_marcas.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_marcas.IconChar = FontAwesome.Sharp.IconChar.EarthAmericas;
            this.menu_marcas.IconColor = System.Drawing.Color.Black;
            this.menu_marcas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_marcas.IconSize = 60;
            this.menu_marcas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_marcas.Name = "menu_marcas";
            this.menu_marcas.Size = new System.Drawing.Size(100, 80);
            this.menu_marcas.Text = "Marcas";
            this.menu_marcas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_marcas.Click += new System.EventHandler(this.menu_marcas_Click);
            // 
            // menu_categoria
            // 
            this.menu_categoria.AutoSize = false;
            this.menu_categoria.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_categoria.IconChar = FontAwesome.Sharp.IconChar.ListNumeric;
            this.menu_categoria.IconColor = System.Drawing.Color.Black;
            this.menu_categoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_categoria.IconSize = 60;
            this.menu_categoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_categoria.Name = "menu_categoria";
            this.menu_categoria.Size = new System.Drawing.Size(100, 80);
            this.menu_categoria.Text = "Categoria";
            this.menu_categoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_categoria.Click += new System.EventHandler(this.menu_categoria_Click);
            // 
            // menu_acerca
            // 
            this.menu_acerca.AutoSize = false;
            this.menu_acerca.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_acerca.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menu_acerca.IconColor = System.Drawing.Color.Black;
            this.menu_acerca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_acerca.IconSize = 62;
            this.menu_acerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_acerca.Name = "menu_acerca";
            this.menu_acerca.Size = new System.Drawing.Size(100, 80);
            this.menu_acerca.Text = "Acerca De";
            this.menu_acerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_acerca.Click += new System.EventHandler(this.menu_acerca_Click);
            // 
            // menu_title
            // 
            this.menu_title.AutoSize = false;
            this.menu_title.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menu_title.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu_title.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_title.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_salir});
            this.menu_title.Location = new System.Drawing.Point(0, 0);
            this.menu_title.Name = "menu_title";
            this.menu_title.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menu_title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu_title.Size = new System.Drawing.Size(1854, 100);
            this.menu_title.TabIndex = 1;
            this.menu_title.UseWaitCursor = true;
            // 
            // menu_salir
            // 
            this.menu_salir.AutoSize = false;
            this.menu_salir.BackColor = System.Drawing.Color.DodgerBlue;
            this.menu_salir.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_salir.ForeColor = System.Drawing.Color.Black;
            this.menu_salir.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            this.menu_salir.IconColor = System.Drawing.Color.Red;
            this.menu_salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_salir.IconSize = 80;
            this.menu_salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_salir.Name = "menu_salir";
            this.menu_salir.Size = new System.Drawing.Size(182, 140);
            this.menu_salir.Text = "Salir";
            this.menu_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menu_salir.Click += new System.EventHandler(this.menu_salir_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_title.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_title.Location = new System.Drawing.Point(12, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(760, 60);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Bienvenido al Catálogo del  Comercio";
            this.lbl_title.UseWaitCursor = true;
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 188);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1854, 842);
            this.contenedor.TabIndex = 3;
            // 
            // menu_consulta
            // 
            this.menu_consulta.AutoSize = false;
            this.menu_consulta.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_consulta.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.menu_consulta.IconColor = System.Drawing.Color.Black;
            this.menu_consulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_consulta.IconSize = 62;
            this.menu_consulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_consulta.Name = "menu_consulta";
            this.menu_consulta.Size = new System.Drawing.Size(182, 80);
            this.menu_consulta.Text = "Area De Consultas";
            this.menu_consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_consulta.Click += new System.EventHandler(this.menu_consulta_Click);
            // 
            // FrmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1854, 1030);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menu_title);
            this.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCatalogo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCatalogo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menu_title.ResumeLayout(false);
            this.menu_title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menu_title;
        private System.Windows.Forms.Label lbl_title;
        private FontAwesome.Sharp.IconMenuItem menu_articulos;
        private FontAwesome.Sharp.IconMenuItem menu_marcas;
        private FontAwesome.Sharp.IconMenuItem menu_categoria;
        private FontAwesome.Sharp.IconMenuItem menu_acerca;
        private FontAwesome.Sharp.IconMenuItem menu_salir;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem menu_consulta;
    }
}