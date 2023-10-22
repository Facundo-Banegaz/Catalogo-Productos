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
    public partial class FrmCategoria : Form
    {

        private List<Categoria> listaCategoria;
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void dgv_categorias_SelectionChanged(object sender, EventArgs e)
        {
            Categoria seleccion = (Categoria)dgv_categorias.CurrentRow.DataBoundItem;
          
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            cargarGrilla();

        }

        private void cargarGrilla()
        {

            LogicaCategoria logicaCategoria = new LogicaCategoria();

            listaCategoria = logicaCategoria.CategoriaList();

            dgv_categorias.DataSource = listaCategoria;

        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            guardarCategoria();
        }

        private void guardarCategoria()
        {
            if (validarcampos())
            {
                Categoria categoria = new Categoria();
                LogicaCategoria logicaCategoria = new LogicaCategoria();

                try
                {
                    categoria.Descripcion = txt_descripcion.Text;

                    logicaCategoria.CategoriaAdd(categoria);

                    MessageBox.Show("La Categoria Fue Agregado Exitosamente!!");

                    cargarGrilla();

                    limpiarCamposProvider();

                    limpiarCampos(gbx_categorias);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Debe Completar Todos los Campos!!");
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
    }
}
