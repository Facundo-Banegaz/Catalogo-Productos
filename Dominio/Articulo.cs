using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int id { get; set; }

        //atributos
        [DisplayName("Código")]
        public string  Codigo { set; get; }

        public string Nombre { set; get; }

        [DisplayName("Descripción")]
        public string Descripcion { set; get; }
        public Marca Marca { set; get; }

        [DisplayName("Categoría")]
        public Categoria Categoria { set; get; }
        public string Imagen {set; get; }
        public decimal Precio { set; get; }

    }
}
