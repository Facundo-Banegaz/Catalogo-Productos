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
            this.menu_agregar = new FontAwesome.Sharp.IconMenuItem();
            this.menu_modificar = new FontAwesome.Sharp.IconMenuItem();
            this.menu_detalle = new FontAwesome.Sharp.IconMenuItem();
            this.menu_suspender = new FontAwesome.Sharp.IconMenuItem();
            this.menu_eliminar = new FontAwesome.Sharp.IconMenuItem();
            this.menu_acerca = new FontAwesome.Sharp.IconMenuItem();
            this.menu_title = new System.Windows.Forms.MenuStrip();
            this.menu_salir = new FontAwesome.Sharp.IconMenuItem();
            this.lbl_title = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.menu_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_agregar,
            this.menu_modificar,
            this.menu_detalle,
            this.menu_suspender,
            this.menu_eliminar,
            this.menu_acerca});
            this.menuStrip1.Location = new System.Drawing.Point(0, 148);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1828, 88);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_agregar
            // 
            this.menu_agregar.AutoSize = false;
            this.menu_agregar.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_agregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.menu_agregar.IconColor = System.Drawing.Color.Black;
            this.menu_agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_agregar.IconSize = 60;
            this.menu_agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_agregar.Name = "menu_agregar";
            this.menu_agregar.Size = new System.Drawing.Size(100, 80);
            this.menu_agregar.Text = "Agregar";
            this.menu_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_modificar
            // 
            this.menu_modificar.AutoSize = false;
            this.menu_modificar.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_modificar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.menu_modificar.IconColor = System.Drawing.Color.Black;
            this.menu_modificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_modificar.IconSize = 60;
            this.menu_modificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_modificar.Name = "menu_modificar";
            this.menu_modificar.Size = new System.Drawing.Size(100, 80);
            this.menu_modificar.Text = "Modificar";
            this.menu_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_detalle
            // 
            this.menu_detalle.AutoSize = false;
            this.menu_detalle.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_detalle.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.menu_detalle.IconColor = System.Drawing.Color.Black;
            this.menu_detalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_detalle.IconSize = 60;
            this.menu_detalle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_detalle.Name = "menu_detalle";
            this.menu_detalle.Size = new System.Drawing.Size(100, 80);
            this.menu_detalle.Text = "Ver Detalle";
            this.menu_detalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_suspender
            // 
            this.menu_suspender.AutoSize = false;
            this.menu_suspender.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_suspender.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.menu_suspender.IconColor = System.Drawing.Color.Black;
            this.menu_suspender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_suspender.IconSize = 60;
            this.menu_suspender.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_suspender.Name = "menu_suspender";
            this.menu_suspender.Size = new System.Drawing.Size(100, 80);
            this.menu_suspender.Text = "Suspender";
            this.menu_suspender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_eliminar
            // 
            this.menu_eliminar.AutoSize = false;
            this.menu_eliminar.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_eliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.menu_eliminar.IconColor = System.Drawing.Color.Black;
            this.menu_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_eliminar.IconSize = 60;
            this.menu_eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_eliminar.Name = "menu_eliminar";
            this.menu_eliminar.Size = new System.Drawing.Size(100, 80);
            this.menu_eliminar.Text = "Emiminar";
            this.menu_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.menu_title.Size = new System.Drawing.Size(1828, 148);
            this.menu_title.TabIndex = 1;
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
            this.lbl_title.Location = new System.Drawing.Point(24, 49);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(760, 60);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Bienvenido al Catálogo del  Comercio";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 236);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1828, 714);
            this.contenedor.TabIndex = 3;
            // 
            // FrmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1828, 950);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menu_title);
            this.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCatalogo";
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
        private FontAwesome.Sharp.IconMenuItem menu_agregar;
        private FontAwesome.Sharp.IconMenuItem menu_modificar;
        private FontAwesome.Sharp.IconMenuItem menu_detalle;
        private FontAwesome.Sharp.IconMenuItem menu_suspender;
        private FontAwesome.Sharp.IconMenuItem menu_eliminar;
        private FontAwesome.Sharp.IconMenuItem menu_acerca;
        private FontAwesome.Sharp.IconMenuItem menu_salir;
        private System.Windows.Forms.Panel contenedor;
    }
}