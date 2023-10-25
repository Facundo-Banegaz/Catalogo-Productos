namespace GestorDeCatalogos
{
    partial class FrmAgregarMarca
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
            this.gbx_marcas = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.gbx_marcas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_marcas
            // 
            this.gbx_marcas.Controls.Add(this.label12);
            this.gbx_marcas.Controls.Add(this.txt_descripcion);
            this.gbx_marcas.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_marcas.Location = new System.Drawing.Point(209, 60);
            this.gbx_marcas.Name = "gbx_marcas";
            this.gbx_marcas.Size = new System.Drawing.Size(382, 331);
            this.gbx_marcas.TabIndex = 10;
            this.gbx_marcas.TabStop = false;
            this.gbx_marcas.Text = "Detalle de Marcas:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 22);
            this.label12.TabIndex = 73;
            this.label12.Text = "Nombre de la Marca:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descripcion.Location = new System.Drawing.Point(19, 125);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(329, 186);
            this.txt_descripcion.TabIndex = 71;
            // 
            // FrmAgregarMarCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx_marcas);
            this.Name = "FrmAgregarMarCat";
            this.Text = "FrmAgregarMarCat";
            this.gbx_marcas.ResumeLayout(false);
            this.gbx_marcas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_marcas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_descripcion;
    }
}