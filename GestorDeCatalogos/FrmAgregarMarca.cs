using Dominio;
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
    public partial class FrmAgregarMarca : Form
    {
        public FrmAgregarMarca()
        {
            InitializeComponent();
        }


        //private void limpiarCampos(Control control)
        //{
        //    foreach (Control txt in control.Controls)
        //    {
        //        if (txt is TextBox)
        //        {
        //            ((TextBox)txt).Clear();
        //        }
        //    }

        //}

        //private void guadarMarca()
        //{
        //    if (validarcampos())
        //    {
        //        Marca marca = new Marca();
        //        LogicaMarca logicaMarca = new LogicaMarca();

        //        try
        //        {
        //            marca.Descripcion = txt_descripcion.Text;
        //            logicaMarca.MarcaAdd(marca);

        //            MessageBox.Show("La Marca Fue Agregado Exitosamente!!");
        //            cargarGrilla();
        //            limpiarCamposProvider();
        //            limpiarCampos(gbx_marcas);
        //        }
        //        catch (Exception ex)
        //        {

        //            throw ex;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Debe Completar Todos los Campos!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void limpiarCamposProvider()
        //{
        //    errorProvider.SetError(txt_descripcion, "");
        //}
        //private bool validarcampos()
        //{
        //    bool ok = true;
        //    if (txt_descripcion.Text == "")
        //    {
        //        ok = false;
        //        errorProvider.SetError(txt_descripcion, "Ingresar Descripcion");
        //    }
        //    return ok;
        //}
    }
}
