using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace GestorDeCatalogos
{
    public partial class FrmCatalogo : Form
    {
        private static IconMenuItem menuActivo = null;
        private static  Form formularioActivo = null;

        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void FrmCatalogo_Load(object sender, EventArgs e)
        {

        }

        private void menu_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void abrirForm(IconMenuItem menu, Form formulario)
        {
            if(menuActivo !=null)
            {
                menuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if(formularioActivo!= null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle= FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            contenedor.Controls.Add(formulario);
            formulario.Show();




        }
        private void menu_articulos_Click(object sender, EventArgs e)
        {
            abrirForm((IconMenuItem)sender,new FrmAgregar());
        }

        private void menu_marcas_Click(object sender, EventArgs e)
        {
            abrirForm((IconMenuItem)sender,new FrmMarca());
        }

        private void menu_categoria_Click(object sender, EventArgs e)
        {
            abrirForm((IconMenuItem)sender, new FrmMarca());
        }

        private void menu_acerca_Click(object sender, EventArgs e)
        {
            abrirForm((IconMenuItem)sender, new FrmAcercaDe());
        }
    }
}
