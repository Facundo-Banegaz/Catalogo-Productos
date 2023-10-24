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

namespace GestorDeCatalogos
{
    public partial class FrmCargar : Form
    {
        public FrmCargar()
        {
            InitializeComponent();
        }

        ////logica del comboBox
        //LogicaCategoria logicaCategoria = new LogicaCategoria();
        //LogicaMarca logicaMarca = new LogicaMarca();

        //    try
        //    {

        //        cbo_categoria.DataSource = logicaCategoria.CategoriaList();

        //        cbo_marca.DataSource = logicaMarca.MarcaList();
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.ToString());
        //    }

        //private void guadarArticulo()
        //{
        //    Articulo articulo = new Articulo();
        //    LogicaArticulo logicaArticulo = new LogicaArticulo();

        //    try
        //    {

        //        if (validarcampos())
        //        {



        //            articulo.Codigo = txt_codigo.Text;
        //            articulo.Nombre = txt_nombre.Text;
        //            articulo.Descripcion = txt_descripcion.Text;

        //            articulo.Marca = (Marca)cbo_marca.SelectedItem;

        //            articulo.Categoria = (Categoria)cbo_categoria.SelectedItem;

        //            articulo.ImagenUrl = txt_img.Text;
        //            articulo.Precio = decimal.Parse(txt_precio.Text);

        //            //validarcampos();

        //            logicaArticulo.ArticuloAdd(articulo);

        //            limpiarCamposProvider();
        //            limpiarCampos(gbx_campos);
        //            MessageBox.Show("El articulo Fue Agregado Exitosamente!!");



        //            cargarGrilla();
        //        }


        //        else
        //        {
        //            MessageBox.Show("Debe Completar Todos los Campos!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        //}
        //private void limpiarCampos(Control control)
        //{
        //    foreach (Control txt in control.Controls)
        //    {
        //        if (txt is TextBox)
        //        {
        //            ((TextBox)txt).Clear();
        //        }
        //        else if (txt is ComboBox)
        //        {

        //            ((ComboBox)txt).SelectedItem = -1;
        //        }

        //    } 
        //}

        //private void limpiarCamposProvider( )
        //{
        //    errorProvider.SetError(txt_codigo, "");
        //    errorProvider.SetError(txt_nombre, "");
        //    errorProvider.SetError(txt_descripcion, "");
        //    errorProvider.SetError(txt_img, "");
        //    errorProvider.SetError(txt_precio, "");
        //}
        //private bool validarcampos()
        //{

        //    bool ok = true;
        //    string codigo= txt_codigo.Text;

        //    if(txt_codigo.Text =="")
        //    {

        //        ok = false;
        //        errorProvider.SetError(txt_codigo,"Ingresar Codigo");
        //    }
        //    if(txt_nombre.Text =="")
        //    {
        //        ok = false;
        //        errorProvider.SetError(txt_nombre, "Ingresar Nombre");
        //    }
        //    if(txt_descripcion.Text=="")
        //    {
        //        ok= false;
        //        errorProvider.SetError(txt_descripcion, "Ingresar Descripcion");
        //    }
        //    if(txt_img.Text=="")
        //    {
        //        ok = false;
        //        errorProvider.SetError(txt_img, "Ingresar Url de Imagen");
        //    }
        //    if (txt_precio.Text == "")
        //    {
        //        ok = false;
        //        errorProvider.SetError(txt_precio, "Ingresar  Precio");
        //    }

        //    return ok;
        //}

        //private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
        //    {
        //        MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        e.Handled = true;
        //        return;
        //    }
        //}
    }
}
