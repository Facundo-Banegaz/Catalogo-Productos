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

            //logica del comboBox
            LogicaCategoria logicaCategoria = new LogicaCategoria();
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
            guadarArticulo();
        }

        private void btn_detalle_Click(object sender, EventArgs e)
        {
            FrmDetalleArticulo frmDetalleArticulo = new FrmDetalleArticulo();
            frmDetalleArticulo.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgv_articulos_SelectionChanged(object sender, EventArgs e)
        {

            Articulo seleccionado = (Articulo)dgv_articulos.CurrentRow.DataBoundItem;

            cargarImg(seleccionado.ImagenUrl);
        }

        private void guadarArticulo()
        {
            Articulo articulo = new Articulo();
            LogicaArticulo logicaArticulo = new LogicaArticulo();

            try
            {

                string codigo = txt_codigo.Text;

                if (validarcampos())
                {

                    if (codigo != txt_codigo.Text)
                    {
                        if (logicaArticulo.validarCodigo(articulo.Codigo))
                        {

                            MessageBox.Show("El código ingresado ya existe, ingrese uno nuevo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_codigo.Focus();
                            return;
                        }
                    }
                    
                    
                        articulo.Codigo = txt_codigo.Text;
                        articulo.Nombre = txt_nombre.Text;
                        articulo.Descripcion = txt_descripcion.Text;

                        articulo.Marca = (Marca)cbo_marca.SelectedItem;

                        articulo.Categoria = (Categoria)cbo_categoria.SelectedItem;

                        articulo.ImagenUrl = txt_img.Text;
                        articulo.Precio = decimal.Parse(txt_precio.Text);

                        //validarcampos();

                        logicaArticulo.ArticuloAdd(articulo);

                        limpiarCamposProvider();
                        limpiarCampos(gbx_campos);
                        MessageBox.Show("El articulo Fue Agregado Exitosamente!!");



                        cargarGrilla();
                    }

                
                else
                {
                    MessageBox.Show("Debe Completar Todos los Campos!!");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

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
        private void limpiarCampos(Control control)
        {
            foreach (Control txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {

                    ((ComboBox)txt).SelectedItem = -1;
                }

            } 
        }
        
        private void limpiarCamposProvider( )
        {
            errorProvider.SetError(txt_codigo, "");
            errorProvider.SetError(txt_nombre, "");
            errorProvider.SetError(txt_descripcion, "");
            errorProvider.SetError(txt_img, "");
            errorProvider.SetError(txt_precio, "");
        }
        private bool validarcampos()
        {
            bool ok = true;

            if(txt_codigo.Text =="")
            {

                ok = false;
                errorProvider.SetError(txt_codigo,"Ingresar Codigo");
            }
            if(txt_nombre.Text =="")
            {
                ok = false;
                errorProvider.SetError(txt_nombre, "Ingresar Nombre");
            }
            if(txt_descripcion.Text=="")
            {
                ok= false;
                errorProvider.SetError(txt_descripcion, "Ingresar Descripcion");
            }
            if(txt_img.Text=="")
            {
                ok = false;
                errorProvider.SetError(txt_img, "Ingresar Url de Imagen");
            }
            if (txt_precio.Text == "")
            {
                ok = false;
                errorProvider.SetError(txt_precio, "Ingresar  Precio");
            }

            return ok;
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
