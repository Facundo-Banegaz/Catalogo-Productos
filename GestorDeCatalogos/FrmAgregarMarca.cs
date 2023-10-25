using Dominio;
using Negocio;
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
    public partial class FrmAgregarMarca : Form
    {
        private Marca marca = null;
        public FrmAgregarMarca()
        {
            InitializeComponent();
            Text = "Agregar Nueva Marca";
        }
        public FrmAgregarMarca( Marca marca)
        {
            InitializeComponent();
            Text = "Modificar Marca";
            this.marca = marca;
        }
        private void FrmAgregarMarca_Load(object sender, EventArgs e)
        {
            if(marca != null)
            {
                txt_descripcion.Text = marca.Descripcion;
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

        private void guardarMarca()
        {
            if (validarcampos())
            {

                LogicaMarca logicaMarca = new LogicaMarca();

                try
                {
                    if (marca == null)
                       marca = new Marca();

                    marca.Descripcion = txt_descripcion.Text;

                    if (marca.Id != 0)
                    {
                        logicaMarca.MarcaModify(marca);
                        MessageBox.Show("La Marca Fue Modificada Exitosamente!!");
                    }
                    else
                    {

                        logicaMarca.MarcaAdd(marca);
                        MessageBox.Show("La Marca Fue Agregado Exitosamente!!");

                    }
                    limpiarCamposProvider();
                    limpiarCampos(gbx_marcas);
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
            guardarMarca();
            this.Close();   
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
