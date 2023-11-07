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
            FrmAgregarCategoria frmAgregarCategoria = new FrmAgregarCategoria();
            frmAgregarCategoria.ShowDialog();
            cargarGrilla();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Categoria categoriaSeleccionada;

            DialogResult respuesta = MessageBox.Show("¿Quieres Editar esta Categoria?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                categoriaSeleccionada = (Categoria)dgv_categorias.CurrentRow.DataBoundItem;

                FrmAgregarCategoria frmModificarCategoria = new FrmAgregarCategoria(categoriaSeleccionada);
                frmModificarCategoria.ShowDialog();
                cargarGrilla();
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            LogicaCategoria logicaCategoria = new LogicaCategoria();
            Categoria categoriaSeleccionada;
            try
            {

                DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar esta Categoria?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    categoriaSeleccionada = (Categoria)dgv_categorias.CurrentRow.DataBoundItem;

                    logicaCategoria.CategoriaDelete(categoriaSeleccionada.Id);
                    cargarGrilla();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            List<Categoria> listCategorias;


            string fitro = txt_buscador.Text;



            if (fitro.Length >= 1)
            {


                listCategorias = listaCategoria.FindAll(x => x.Descripcion.ToUpper().Contains(fitro.ToUpper()) || x.Descripcion.ToUpper().Contains(fitro.ToUpper()));
            }
            else
            {
                MessageBox.Show("El campo no puede ser vacio!!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                listCategorias = listaCategoria;

            }

            dgv_categorias.DataSource = null;

            dgv_categorias.DataSource = listCategorias;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscador.Clear();
            cargarGrilla();
        }

        private void txt_buscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
