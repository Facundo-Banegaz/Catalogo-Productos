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

            //logica del dataGridView
            LogicaArticulo logicaArticulo = new LogicaArticulo();

            listaArticulos = logicaArticulo.ArticuloList();

            dgv_articulos.DataSource = listaArticulos;

            //dgv_articulos.Columns["ImagenUrl"].Visible = false;
            //dgv_articulos.Columns["Id"].Visible = false;

            cargarImg(listaArticulos[0].ImagenUrl);

            //logica del comboBox
            LogicaCategoria logicaCategoria  = new LogicaCategoria();
            LogicaMarca logicaMarca = new LogicaMarca();    

            try
            {

                cbo_categoria.DataSource = logicaCategoria.CategoriaList();

                cbo_marca.DataSource = logicaMarca.MarcaList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }





        }

        private void panel_filtro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            LogicaArticulo logicaArticulo = new LogicaArticulo();

            try
            {
                articulo.Codigo = txt_codigo.Text ;
                articulo.Nombre= txt_nombre.Text ;
                articulo.Descripcion = txt_descripcion.Text;

                articulo.Marca = (Marca)cbo_marca.SelectedItem;

                articulo.Categoria = (Categoria)cbo_categoria.SelectedItem;

                articulo.ImagenUrl = txt_img.Text;
                articulo.Precio= int.Parse(txt_precio.Text);


                logicaArticulo.ArticuloAdd(articulo);
                MessageBox.Show("El articulo Fue Agregado Exitosamente!!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
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
    }
}
