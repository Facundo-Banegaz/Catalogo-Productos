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
            DialogResult respuesta = MessageBox.Show("¿Quieres Editar esta Marca?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                marcaSeleccionada = (Marca)dgv_marcas.CurrentRow.DataBoundItem;

                FrmAgregarMarca frmModificarMarca = new FrmAgregarMarca(marcaSeleccionada);

                frmModificarMarca.ShowDialog();
                cargarGrilla();
            }

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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            List<Marca> listMarcas;


            string fitro = txt_buscador.Text;



            if (fitro.Length >=1)
            {

                
                listMarcas = listaMarcas.FindAll(x => x.Descripcion.ToUpper().Contains(fitro.ToUpper()) || x.Descripcion.ToUpper().Contains(fitro.ToUpper()));
            }
            else
            {
                 MessageBox.Show("El campo no puede ser vacio!!","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    listMarcas = listaMarcas;

            }

            dgv_marcas.DataSource = null;

            dgv_marcas.DataSource = listMarcas;
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
