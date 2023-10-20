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

        private void btn_detalle_Click(object sender, EventArgs e)
        {
            FrmDetalle frmDetalle = new FrmDetalle();
            frmDetalle.ShowDialog();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            LogicaCategoria logicaCategoria = new LogicaCategoria();

            listaCategoria = logicaCategoria.CategoriaList();

            dgv_categorias.DataSource = listaCategoria;


        }
    }
}
