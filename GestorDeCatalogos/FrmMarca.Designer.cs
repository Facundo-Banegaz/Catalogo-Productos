﻿namespace GestorDeCatalogos
{
    partial class FrmMarca
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
            this.panel_filtro = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel_contenedor_articulo = new System.Windows.Forms.Panel();
            this.gbo_container = new System.Windows.Forms.GroupBox();
            this.btn_editar = new FontAwesome.Sharp.IconButton();
            this.btn_eliminar = new FontAwesome.Sharp.IconButton();
            this.btn_guardar = new FontAwesome.Sharp.IconButton();
            this.label16 = new System.Windows.Forms.Label();
            this.dgv_marcas = new System.Windows.Forms.DataGridView();
            this.panel_filtro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_contenedor_articulo.SuspendLayout();
            this.gbo_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_filtro
            // 
            this.panel_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_filtro.BackColor = System.Drawing.SystemColors.Control;
            this.panel_filtro.Controls.Add(this.groupBox2);
            this.panel_filtro.Location = new System.Drawing.Point(406, 12);
            this.panel_filtro.Name = "panel_filtro";
            this.panel_filtro.Size = new System.Drawing.Size(1392, 149);
            this.panel_filtro.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.iconButton2);
            this.groupBox2.Controls.Add(this.iconButton3);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.iconButton1);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1370, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Marcas:";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.LimeGreen;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton2.Location = new System.Drawing.Point(6, 57);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(243, 37);
            this.iconButton2.TabIndex = 63;
            this.iconButton2.Text = "Descargar PDF";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.BackColor = System.Drawing.Color.Crimson;
            this.iconButton3.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton3.Location = new System.Drawing.Point(1206, 31);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(149, 46);
            this.iconButton3.TabIndex = 69;
            this.iconButton3.Text = "Limpiar";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(436, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 37);
            this.comboBox1.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 68;
            this.label1.Text = "Buscar por:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(757, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(267, 37);
            this.textBox2.TabIndex = 65;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.LimeGreen;
            this.iconButton1.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(1030, 31);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(158, 46);
            this.iconButton1.TabIndex = 64;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // panel_contenedor_articulo
            // 
            this.panel_contenedor_articulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_contenedor_articulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_contenedor_articulo.Controls.Add(this.gbo_container);
            this.panel_contenedor_articulo.Controls.Add(this.label16);
            this.panel_contenedor_articulo.Location = new System.Drawing.Point(2, 12);
            this.panel_contenedor_articulo.Name = "panel_contenedor_articulo";
            this.panel_contenedor_articulo.Size = new System.Drawing.Size(398, 830);
            this.panel_contenedor_articulo.TabIndex = 5;
            // 
            // gbo_container
            // 
            this.gbo_container.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbo_container.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gbo_container.Controls.Add(this.btn_editar);
            this.gbo_container.Controls.Add(this.btn_eliminar);
            this.gbo_container.Controls.Add(this.btn_guardar);
            this.gbo_container.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_container.Location = new System.Drawing.Point(18, 217);
            this.gbo_container.Name = "gbo_container";
            this.gbo_container.Size = new System.Drawing.Size(349, 467);
            this.gbo_container.TabIndex = 64;
            this.gbo_container.TabStop = false;
            this.gbo_container.Text = "Acciones:";
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btn_editar.IconColor = System.Drawing.Color.White;
            this.btn_editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_editar.IconSize = 50;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar.Location = new System.Drawing.Point(16, 191);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(317, 70);
            this.btn_editar.TabIndex = 29;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.BackColor = System.Drawing.Color.Crimson;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_eliminar.IconColor = System.Drawing.Color.White;
            this.btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_eliminar.IconSize = 50;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.Location = new System.Drawing.Point(16, 308);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(317, 70);
            this.btn_eliminar.TabIndex = 28;
            this.btn_eliminar.Text = "Eminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btn_guardar.IconColor = System.Drawing.Color.White;
            this.btn_guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_guardar.IconSize = 50;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.Location = new System.Drawing.Point(16, 74);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(317, 70);
            this.btn_guardar.TabIndex = 27;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label16.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(30, -71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(191, 35);
            this.label16.TabIndex = 41;
            this.label16.Text = "Detalle Articulo";
            // 
            // dgv_marcas
            // 
            this.dgv_marcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_marcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_marcas.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgv_marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_marcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_marcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_marcas.Location = new System.Drawing.Point(494, 229);
            this.dgv_marcas.MultiSelect = false;
            this.dgv_marcas.Name = "dgv_marcas";
            this.dgv_marcas.RowHeadersWidth = 62;
            this.dgv_marcas.RowTemplate.Height = 28;
            this.dgv_marcas.Size = new System.Drawing.Size(1219, 467);
            this.dgv_marcas.TabIndex = 4;
            this.dgv_marcas.SelectionChanged += new System.EventHandler(this.dgv_marcas_SelectionChanged);
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1810, 730);
            this.Controls.Add(this.panel_contenedor_articulo);
            this.Controls.Add(this.dgv_marcas);
            this.Controls.Add(this.panel_filtro);
            this.Name = "FrmMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMarca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            this.panel_filtro.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_contenedor_articulo.ResumeLayout(false);
            this.panel_contenedor_articulo.PerformLayout();
            this.gbo_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_filtro;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel_contenedor_articulo;
        private System.Windows.Forms.GroupBox gbo_container;
        private FontAwesome.Sharp.IconButton btn_editar;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private FontAwesome.Sharp.IconButton btn_guardar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgv_marcas;
    }
}