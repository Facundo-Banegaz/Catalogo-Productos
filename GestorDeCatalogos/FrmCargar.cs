using Negocio;
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
using System.Configuration;
using System.IO;

namespace GestorDeCatalogos
{
    public partial class FrmCargar : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public FrmCargar()
        {
            InitializeComponent();
            Text = "Cargar Articulos";
        }

        public FrmCargar(Articulo articulo) 
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Editar Articulos";
        }
        private void FrmCargar_Load(object sender, EventArgs e)
        {

            ////logica del comboBox
            LogicaCategoria logicaCategoria = new LogicaCategoria();
            LogicaMarca logicaMarca = new LogicaMarca();

            try
            {

                cbo_categoria.DataSource = logicaCategoria.CategoriaList();
                cbo_categoria.ValueMember = "Id";
                cbo_categoria.DisplayMember = "Descripcion";

                cbo_marca.DataSource = logicaMarca.MarcaList();
                cbo_marca.ValueMember = "Id";
                cbo_marca.DisplayMember = "Descripcion";

                if(articulo!=null)
                {
                    txt_codigo.Text = articulo.Codigo;
                    txt_nombre.Text = articulo.Nombre;
                    txt_precio.Text = articulo.Precio.ToString();
                    txt_img.Text    = articulo.ImagenUrl;
                    cargarImg(txt_img.Text);
                    txt_descripcion.Text = articulo.Descripcion;

                    cbo_marca.SelectedValue = articulo.Marca.Id;
                    cbo_categoria.SelectedValue = articulo.Categoria.Id;
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void guadarArticulo()
        {
            
          LogicaArticulo logicaArticulo = new LogicaArticulo();

            try
            {

                if (validarcampos())
                {

                    if(articulo == null)
                        articulo = new Articulo();


                    articulo.Codigo = txt_codigo.Text;
                    articulo.Nombre = txt_nombre.Text;
                    articulo.Descripcion = txt_descripcion.Text;

                    articulo.Marca = (Marca)cbo_marca.SelectedItem;

                    articulo.Categoria = (Categoria)cbo_categoria.SelectedItem;

                    articulo.ImagenUrl = txt_img.Text;
                    articulo.Precio = decimal.Parse(txt_precio.Text);

                    cargarImg(articulo.ImagenUrl);

                    if (articulo.id != 0)
                    {
                        logicaArticulo.ArticuloModify(articulo);
                        MessageBox.Show("El articulo Fue Modificado Exitosamente!!");
                    }
                    else
                    {
                        logicaArticulo.ArticuloAdd(articulo);
                        MessageBox.Show("El articulo Fue Agregado Exitosamente!!");
                    }
                    limpiarCamposProvider();
                    limpiarCampos(gbx_campos);
                    this.Close();

                }


                else
                {
                    MessageBox.Show("Debe Completar Todos los Campos!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

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

        private void limpiarCamposProvider()
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
            string codigo = txt_codigo.Text;

            if (txt_codigo.Text == "")
            {

                ok = false;
                errorProvider.SetError(txt_codigo, "Ingresar Codigo");
            }
            if (txt_nombre.Text == "")
            {
                ok = false;
                errorProvider.SetError(txt_nombre, "Ingresar Nombre");
            }
            if (txt_descripcion.Text == "")
            {
                ok = false;
                errorProvider.SetError(txt_descripcion, "Ingresar Descripcion");
            }
            if (txt_img.Text == "")
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


        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            guadarArticulo();
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void txt_img_Leave(object sender, EventArgs e)
        {
            cargarImg(txt_img.Text);
        }

        private void btn_img_local_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txt_img.Text = archivo.FileName;
                cargarImg(archivo.FileName);

            }
        }
    }
}
