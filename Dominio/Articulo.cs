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
        //atributos
        [DisplayName("Código")]
        string  Codigo { set; get; }

        string Nombre { set; get; }

        [DisplayName("Descripción")]
        string Descripcion { set; get; }
        Marca Marca { set; get; }

        [DisplayName("Categoría")]
        Categoria Categoria { set; get; }
        string Imagen {set; get; }
        decimal Precio { set; get; }

    }
}
