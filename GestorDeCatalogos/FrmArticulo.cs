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
    public partial class FrmArticulo : Form
    {

        private List<Articulo> listaArticulos;


        public FrmArticulo()
        {
            InitializeComponent();
        }
        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            cargadCbo();
        }

        private void cargadCbo()
        {
            cbo_campo.Items.Clear();
            cbo_campo.Items.Add("Id");
            cbo_campo.Items.Add("Codigo");
            cbo_campo.Items.Add("Nombre");
            cbo_campo.Items.Add("Marca");
            cbo_campo.Items.Add("Categoria");
            cbo_campo.Items.Add("Precio");
        }
        private void cargarGrilla()
        {
            //logica del dataGridView
            LogicaArticulo logicaArticulo = new LogicaArticulo();

            listaArticulos = logicaArticulo.ArticuloList();

            dgv_articulos.DataSource = listaArticulos;

            dgv_articulos.Columns["ImagenUrl"].Visible = false;
            dgv_articulos.Columns["Descripcion"].Visible = false;

            cargarImg(listaArticulos[0].ImagenUrl);

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
          FrmCargar frmCargar   = new FrmCargar();
            frmCargar.ShowDialog();
            cargarGrilla();
        }

        private void btn_detalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgv_articulos.CurrentRow.DataBoundItem;

            FrmDetalleArticulo frmDetalleArticulo = new FrmDetalleArticulo(seleccionado);
            frmDetalleArticulo.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            DialogResult respuesta = MessageBox.Show("¿Quieres Editar este Articulo?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                seleccionado = (Articulo)dgv_articulos.CurrentRow.DataBoundItem;
                FrmCargar frmEditar = new FrmCargar(seleccionado);


                frmEditar.ShowDialog();
                cargarGrilla();
            }
        }



        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            LogicaArticulo logicaArticulo = new LogicaArticulo();
            Articulo articuloSeleccionado;

            try
            {
               DialogResult respuesta =  MessageBox.Show("¿Quieres Eliminar este Articulo?","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);   

                if(respuesta == DialogResult.Yes) 
                {
                    articuloSeleccionado = (Articulo)dgv_articulos.CurrentRow.DataBoundItem;

                    logicaArticulo.ArticuloDelete(articuloSeleccionado.id);
                    cargarGrilla();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgv_articulos_SelectionChanged(object sender, EventArgs e)
        {

            Articulo seleccionado = (Articulo)dgv_articulos.CurrentRow.DataBoundItem;

            cargarImg(seleccionado.ImagenUrl);
        }



        private void cargarImg(string img)
        {
            try
            {
                pbx_img.Load(img);
            }
            catch (Exception)
            {

                pbx_img.Load("https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-image_large.png?format=jpg&quality=90&v=1530129081");
            }
        }

        private void cbo_campo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbo_campo.SelectedItem.ToString();

            if(opcion == "Id" || opcion == "Precio")
            {
                cbo_criterio.Items.Clear();
                cbo_criterio.Items.Add("Mayor a");
                cbo_criterio.Items.Add("Menor a");
                cbo_criterio.Items.Add("Igual a");
            }
            else if(opcion== "Codigo" || opcion=="Nombre" || opcion=="Marca" || opcion=="Categoria") 
            {
                cbo_criterio.Items.Clear();
                cbo_criterio.Items.Add("Comienza con");
                cbo_criterio.Items.Add("Termina con");
                cbo_criterio.Items.Add("Igual a");

            }


        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscador.Clear();
            cargarGrilla();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            LogicaArticulo  logicaArticulo = new LogicaArticulo();

            try
            {
                if (validarCampo())
                    return;
                string campo = cbo_campo.SelectedItem.ToString();
                string criterio = cbo_criterio.SelectedItem.ToString();
                string filtro = txt_buscador.Text;

                dgv_articulos.DataSource = logicaArticulo.ArticuloFilter(campo,criterio,filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private bool validarCampo()
        {

            if (cbo_campo.SelectedIndex < 0) 
            {
                MessageBox.Show("Por favor, Seleccione el campo para filtrar.");
                return true;
            }
            if(cbo_criterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, Seleccione el Criteria a filtrar.");
                return true;
            }
            if(cbo_campo.SelectedItem.ToString() == "Id" || cbo_campo.SelectedItem.ToString() == "Precio")
            {
                if(string.IsNullOrEmpty(txt_buscador.Text))
                {
                    MessageBox.Show("El campo no puede Quedar vacio", "Warning");
                    
                    return true;
                }
                if(!(soloNumeros(txt_buscador.Text)))
                {
                    MessageBox.Show("Solo se pueden cargar numeros!!", "Warning");
                    txt_buscador.Clear();
                    return true;
                }
            }
            return false;
        }
    
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
    
    }
}   
