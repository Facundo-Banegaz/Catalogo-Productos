using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace GestorDeCatalogos
{
    public partial class FrmAgregar : Form
    {

        private List<Articulo> listaArticulos;
        public FrmAgregar()
        {
            InitializeComponent();
        }

   

        private void FrmAgregar_Load(object sender, EventArgs e)
        {

            LogicaArticulo logicaArticulo = new LogicaArticulo();

            listaArticulos = logicaArticulo.ArticuloList();

            dgv_articulos.DataSource = listaArticulos;


            cargarImg(listaArticulos[0].ImagenUrl);


        }

        private void panel_filtro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_detalle_Click(object sender, EventArgs e)
        {
            FrmDetalleArticulo frmDetalleArticulo = new FrmDetalleArticulo();   
            frmDetalleArticulo.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_suspender_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgv_articulos_SelectionChanged(object sender, EventArgs e)
        {
          Articulo seleccion = (Articulo)dgv_articulos.CurrentRow.DataBoundItem;
           cargarImg(seleccion.ImagenUrl);
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
