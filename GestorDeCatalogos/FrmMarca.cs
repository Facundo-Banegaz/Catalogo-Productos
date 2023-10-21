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
            Marca marca = new Marca();   
            LogicaMarca logicaMarca = new LogicaMarca();    

            try
            {
                marca.Descripcion = txt_descripcion.Text;
                logicaMarca.MarcaAdd(marca);

                MessageBox.Show("La Marca Fue Agregado Exitosamente!!");
                cargarGrilla();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn_detalle_Click(object sender, EventArgs e)
        {
            FrmDetalle frmDetalle = new FrmDetalle();
            frmDetalle.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_suspender_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

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
