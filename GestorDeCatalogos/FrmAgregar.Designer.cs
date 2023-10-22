namespace GestorDeCatalogos
{
    partial class FrmAgregar
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
            this.components = new System.ComponentModel.Container();
            this.panel_contenedor_articulo = new System.Windows.Forms.Panel();
            this.gbx_campos = new System.Windows.Forms.GroupBox();
            this.cbo_marca = new System.Windows.Forms.ComboBox();
            this.cbo_categoria = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_img = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.gbo_container = new System.Windows.Forms.GroupBox();
            this.btn_detalle = new FontAwesome.Sharp.IconButton();
            this.btn_editar = new FontAwesome.Sharp.IconButton();
            this.btn_eliminar = new FontAwesome.Sharp.IconButton();
            this.btn_guardar = new FontAwesome.Sharp.IconButton();
            this.label16 = new System.Windows.Forms.Label();
            this.dgv_articulos = new System.Windows.Forms.DataGridView();
            this.panel_filtro = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pbx_img = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.panel_contenedor_articulo.SuspendLayout();
            this.gbx_campos.SuspendLayout();
            this.gbo_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).BeginInit();
            this.panel_filtro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_contenedor_articulo
            // 
            this.panel_contenedor_articulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_contenedor_articulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_contenedor_articulo.Controls.Add(this.gbx_campos);
            this.panel_contenedor_articulo.Controls.Add(this.gbo_container);
            this.panel_contenedor_articulo.Controls.Add(this.label16);
            this.panel_contenedor_articulo.Location = new System.Drawing.Point(0, 12);
            this.panel_contenedor_articulo.Name = "panel_contenedor_articulo";
            this.panel_contenedor_articulo.Size = new System.Drawing.Size(420, 830);
            this.panel_contenedor_articulo.TabIndex = 1;
            // 
            // gbx_campos
            // 
            this.gbx_campos.Controls.Add(this.cbo_marca);
            this.gbx_campos.Controls.Add(this.cbo_categoria);
            this.gbx_campos.Controls.Add(this.label9);
            this.gbx_campos.Controls.Add(this.label10);
            this.gbx_campos.Controls.Add(this.label11);
            this.gbx_campos.Controls.Add(this.label12);
            this.gbx_campos.Controls.Add(this.label13);
            this.gbx_campos.Controls.Add(this.txt_nombre);
            this.gbx_campos.Controls.Add(this.txt_descripcion);
            this.gbx_campos.Controls.Add(this.txt_img);
            this.gbx_campos.Controls.Add(this.txt_precio);
            this.gbx_campos.Controls.Add(this.label14);
            this.gbx_campos.Controls.Add(this.label15);
            this.gbx_campos.Controls.Add(this.txt_codigo);
            this.gbx_campos.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_campos.Location = new System.Drawing.Point(12, 12);
            this.gbx_campos.Name = "gbx_campos";
            this.gbx_campos.Size = new System.Drawing.Size(405, 689);
            this.gbx_campos.TabIndex = 1;
            this.gbx_campos.TabStop = false;
            this.gbx_campos.Text = "Detalle de Articulos:";
            // 
            // cbo_marca
            // 
            this.cbo_marca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_marca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_marca.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_marca.FormattingEnabled = true;
            this.cbo_marca.Location = new System.Drawing.Point(36, 566);
            this.cbo_marca.Name = "cbo_marca";
            this.cbo_marca.Size = new System.Drawing.Size(338, 37);
            this.cbo_marca.TabIndex = 6;
            // 
            // cbo_categoria
            // 
            this.cbo_categoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_categoria.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_categoria.FormattingEnabled = true;
            this.cbo_categoria.Location = new System.Drawing.Point(36, 640);
            this.cbo_categoria.Name = "cbo_categoria";
            this.cbo_categoria.Size = new System.Drawing.Size(338, 37);
            this.cbo_categoria.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 22);
            this.label9.TabIndex = 76;
            this.label9.Text = "Url Imagen:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 22);
            this.label10.TabIndex = 75;
            this.label10.Text = "Precio:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 525);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 22);
            this.label11.TabIndex = 74;
            this.label11.Text = "Marca:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 22);
            this.label12.TabIndex = 73;
            this.label12.Text = "Descripción:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 22);
            this.label13.TabIndex = 72;
            this.label13.Text = "Nombre Completo:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombre.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(36, 128);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(338, 32);
            this.txt_nombre.TabIndex = 2;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descripcion.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(36, 199);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(338, 170);
            this.txt_descripcion.TabIndex = 3;
            // 
            // txt_img
            // 
            this.txt_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_img.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_img.Location = new System.Drawing.Point(36, 410);
            this.txt_img.Name = "txt_img";
            this.txt_img.Size = new System.Drawing.Size(338, 32);
            this.txt_img.TabIndex = 4;
            this.txt_img.Leave += new System.EventHandler(this.txt_img_Leave);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label14.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 606);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 22);
            this.label14.TabIndex = 66;
            this.label14.Text = "Categoría:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label15.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 22);
            this.label15.TabIndex = 1;
            this.label15.Text = "Nro Codigo:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_codigo.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(36, 58);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(338, 32);
            this.txt_codigo.TabIndex = 2;
            // 
            // gbo_container
            // 
            this.gbo_container.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbo_container.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gbo_container.Controls.Add(this.btn_detalle);
            this.gbo_container.Controls.Add(this.btn_editar);
            this.gbo_container.Controls.Add(this.btn_eliminar);
            this.gbo_container.Controls.Add(this.btn_guardar);
            this.gbo_container.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_container.Location = new System.Drawing.Point(31, 717);
            this.gbo_container.Name = "gbo_container";
            this.gbo_container.Size = new System.Drawing.Size(323, 318);
            this.gbo_container.TabIndex = 2;
            this.gbo_container.TabStop = false;
            this.gbo_container.Text = "Acciones:";
            // 
            // btn_detalle
            // 
            this.btn_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_detalle.BackColor = System.Drawing.Color.Black;
            this.btn_detalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detalle.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalle.ForeColor = System.Drawing.Color.White;
            this.btn_detalle.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_detalle.IconColor = System.Drawing.Color.White;
            this.btn_detalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_detalle.IconSize = 30;
            this.btn_detalle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_detalle.Location = new System.Drawing.Point(16, 110);
            this.btn_detalle.Name = "btn_detalle";
            this.btn_detalle.Size = new System.Drawing.Size(291, 45);
            this.btn_detalle.TabIndex = 25;
            this.btn_detalle.Text = "Ver Detalle";
            this.btn_detalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_detalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_detalle.UseVisualStyleBackColor = false;
            this.btn_detalle.Click += new System.EventHandler(this.btn_detalle_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btn_editar.IconColor = System.Drawing.Color.White;
            this.btn_editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_editar.IconSize = 30;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar.Location = new System.Drawing.Point(16, 177);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(291, 45);
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
            this.btn_eliminar.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_eliminar.IconColor = System.Drawing.Color.White;
            this.btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_eliminar.IconSize = 30;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.Location = new System.Drawing.Point(16, 242);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(291, 45);
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
            this.btn_guardar.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btn_guardar.IconColor = System.Drawing.Color.White;
            this.btn_guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_guardar.IconSize = 30;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.Location = new System.Drawing.Point(16, 48);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(291, 45);
            this.btn_guardar.TabIndex = 2;
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
            this.label16.Location = new System.Drawing.Point(52, -71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(191, 35);
            this.label16.TabIndex = 41;
            this.label16.Text = "Detalle Articulo";
            // 
            // dgv_articulos
            // 
            this.dgv_articulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_articulos.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgv_articulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_articulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_articulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_articulos.Location = new System.Drawing.Point(460, 265);
            this.dgv_articulos.MultiSelect = false;
            this.dgv_articulos.Name = "dgv_articulos";
            this.dgv_articulos.RowHeadersWidth = 62;
            this.dgv_articulos.RowTemplate.Height = 28;
            this.dgv_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_articulos.Size = new System.Drawing.Size(523, 467);
            this.dgv_articulos.TabIndex = 0;
            this.dgv_articulos.SelectionChanged += new System.EventHandler(this.dgv_articulos_SelectionChanged);
            // 
            // panel_filtro
            // 
            this.panel_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_filtro.BackColor = System.Drawing.SystemColors.Control;
            this.panel_filtro.Controls.Add(this.groupBox2);
            this.panel_filtro.Location = new System.Drawing.Point(426, 12);
            this.panel_filtro.Name = "panel_filtro";
            this.panel_filtro.Size = new System.Drawing.Size(1394, 149);
            this.panel_filtro.TabIndex = 2;
            this.panel_filtro.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_filtro_Paint);
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
            this.groupBox2.Size = new System.Drawing.Size(1372, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Articulos:";
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
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton3.Location = new System.Drawing.Point(1208, 31);
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
            this.comboBox1.Location = new System.Drawing.Point(438, 34);
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
            this.label1.Location = new System.Drawing.Point(287, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 68;
            this.label1.Text = "Buscar por:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(759, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(267, 37);
            this.textBox2.TabIndex = 65;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.LimeGreen;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(1032, 31);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(158, 46);
            this.iconButton1.TabIndex = 64;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // pbx_img
            // 
            this.pbx_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_img.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pbx_img.Location = new System.Drawing.Point(1012, 265);
            this.pbx_img.Name = "pbx_img";
            this.pbx_img.Size = new System.Drawing.Size(783, 467);
            this.pbx_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_img.TabIndex = 3;
            this.pbx_img.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txt_precio
            // 
            this.txt_precio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_precio.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(36, 490);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(338, 32);
            this.txt_precio.TabIndex = 5;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1832, 786);
            this.Controls.Add(this.pbx_img);
            this.Controls.Add(this.panel_filtro);
            this.Controls.Add(this.dgv_articulos);
            this.Controls.Add(this.panel_contenedor_articulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 188);
            this.Name = "FrmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAgregar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAgregar_Load);
            this.panel_contenedor_articulo.ResumeLayout(false);
            this.panel_contenedor_articulo.PerformLayout();
            this.gbx_campos.ResumeLayout(false);
            this.gbx_campos.PerformLayout();
            this.gbo_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulos)).EndInit();
            this.panel_filtro.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor_articulo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgv_articulos;
        private System.Windows.Forms.Panel panel_filtro;
        private System.Windows.Forms.GroupBox gbo_container;
        private System.Windows.Forms.GroupBox gbx_campos;
        private System.Windows.Forms.ComboBox cbo_marca;
        private System.Windows.Forms.ComboBox cbo_categoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_img;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_codigo;
        private FontAwesome.Sharp.IconButton btn_detalle;
        private FontAwesome.Sharp.IconButton btn_editar;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private FontAwesome.Sharp.IconButton btn_guardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pbx_img;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txt_precio;
    }
}