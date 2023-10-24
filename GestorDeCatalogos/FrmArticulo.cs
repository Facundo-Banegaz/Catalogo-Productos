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
    public partial class FrmArticulo : Form
    {

        private List<Articulo> listaArticulos;


        public FrmArticulo()
        {
            InitializeComponent();
        }
        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }


        private void cargarGrilla()
        {


            //logica del dataGridView
            LogicaArticulo logicaArticulo = new LogicaArticulo();

            listaArticulos = logicaArticulo.ArticuloList();

            dgv_articulos.DataSource = listaArticulos;

            dgv_articulos.Columns["ImagenUrl"].Visible = false;
            dgv_articulos.Columns["Descripcion"].Visible = false;

            cargarImg(listaArticulos[0].ImagenUrl);

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           FrmArticulo frmArticulo = new FrmArticulo();
            frmArticulo.ShowDialog();
        }

        private void btn_detalle_Click(object sender, EventArgs e)
        {
            FrmDetalleArticulo frmDetalleArticulo = new FrmDetalleArticulo();
            frmDetalleArticulo.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            FrmArticulo frmEditar =  new FrmArticulo();
            frmEditar.ShowDialog();
        }



        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgv_articulos_SelectionChanged(object sender, EventArgs e)
        {

            Articulo seleccionado = (Articulo)dgv_articulos.CurrentRow.DataBoundItem;

            cargarImg(seleccionado.ImagenUrl);
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

        private void txt_img_Leave(object sender, EventArgs e)
        {
            cargarImg(txt_img.Text);
        }



    }
}
