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
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

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
    }
}
