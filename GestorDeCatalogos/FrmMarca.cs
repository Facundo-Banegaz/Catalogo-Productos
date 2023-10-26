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
    public partial class FrmMarca : Form
    {
        private List<Marca> listaMarcas;
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            FrmAgregarMarca frmAgregarMarca = new FrmAgregarMarca();
            frmAgregarMarca.ShowDialog();
            cargarGrilla();
        }



        private void btn_editar_Click(object sender, EventArgs e)
        {
            Marca marcaSeleccionada;
            marcaSeleccionada = (Marca)dgv_marcas.CurrentRow.DataBoundItem;

            FrmAgregarMarca frmModificarMarca = new FrmAgregarMarca(marcaSeleccionada);

            frmModificarMarca.ShowDialog();
            cargarGrilla();
        }



        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            LogicaMarca logicaMarca = new LogicaMarca();
            Marca marcaSeleccionada;
            try
            {

                DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar esta Marca?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    marcaSeleccionada = (Marca)dgv_marcas.CurrentRow.DataBoundItem;
                    logicaMarca.MarcaDelete(marcaSeleccionada.Id);
                    cargarGrilla();
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgv_marcas_SelectionChanged(object sender, EventArgs e)
        {
            Marca seleccion = (Marca)dgv_marcas.CurrentRow.DataBoundItem;
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            LogicaMarca LogicaMarca = new LogicaMarca();

            listaMarcas = LogicaMarca.MarcaList();

            dgv_marcas.DataSource = listaMarcas;

        }

    
    }
}
