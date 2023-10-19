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
    public partial class FrmAgregar : Form
    {
        public FrmAgregar()
        {
            InitializeComponent();
        }

   

        private void FrmAgregar_Load(object sender, EventArgs e)
        {

        }

        private void panel_filtro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_detalle_Click(object sender, EventArgs e)
        {
            FrmDetalleArticulo frmDetalleArticulo = new FrmDetalleArticulo();   
            frmDetalleArticulo.ShowDialog();
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
    }
}
