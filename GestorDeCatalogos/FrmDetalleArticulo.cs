using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeCatalogos
{
    public partial class FrmDetalleArticulo : Form
    {
        private Articulo Articulo;
        public FrmDetalleArticulo()
        {
            InitializeComponent();
        }

        public FrmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.Articulo = articulo;
            Text = "Detalle del Articulo";
        }

        private void FrmDetalleArticulo_Load(object sender, EventArgs e)
        {
            lbl_codigo.Text = Articulo.Codigo;  
            lbl_nombre.Text = Articulo.Nombre;
            lbl_img.Text = Articulo.ImagenUrl;
            lbl_precio.Text = Articulo.Precio.ToString();
            lbl_categoria.Text = Articulo.Categoria.ToString();
            lbl_marca.Text = Articulo.Marca.ToString();
            txt_descrcipcion.Text = Articulo.Descripcion;

            cargarImg(lbl_img.Text);
        }


        private void cargarImg(string img)
        {
            try
            {
                pbx_img.Load(img);
            }
            catch (Exception)
            {

                pbx_img.Load("https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-image_large.png?format=jpg&quality=90&v=1530129081");
            }
        }

    }
}
