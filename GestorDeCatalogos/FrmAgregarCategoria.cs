using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;



namespace GestorDeCatalogos
{
    public partial class FrmAgregarCategoria : Form
    {
        Categoria Categoria = null;
        public FrmAgregarCategoria()
        {
            InitializeComponent();
            Text = "Agregar Nueva Categoria";
        }
        public FrmAgregarCategoria(Categoria categoria)
        {
            InitializeComponent();
            Categoria = categoria;
            Text = "Modificar Categoria";
        }

        private void FrmAgregarCategoria_Load(object sender, EventArgs e)
        {
            if (Categoria != null)
            {
                txt_descripcion.Text = Categoria.Descripcion;
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
            }

        }

        private void guardarCategoria()
        {
            if (validarcampos())
            {
              
                LogicaCategoria logicaCategoria = new LogicaCategoria(); 

                try
                {
                    if (Categoria == null)
                        Categoria = new Categoria();

                    Categoria.Descripcion = txt_descripcion.Text;
                    if (Categoria.Id != 0)
                    {
                        logicaCategoria.CategoriaModify(Categoria);
                        MessageBox.Show("La Marca Fue Modificada Exitosamente!!");
                    }
                    else
                    {
                        logicaCategoria.CategoriaModify(Categoria);
                        MessageBox.Show("La Marca Fue Agregado Exitosamente!!");

                    }
                    limpiarCamposProvider();
                    limpiarCampos(gbx_categoria);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Debe Completar Todos los Campos!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarCamposProvider()
        {
            errorProvider.SetError(txt_descripcion, "");
        }
        private bool validarcampos()
        {
            bool ok = true;
            if (txt_descripcion.Text == "")
            {
                ok = false;
                errorProvider.SetError(txt_descripcion, "Ingresar Descripcion");
            }
            return ok;
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            guardarCategoria();
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
