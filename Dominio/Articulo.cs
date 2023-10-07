using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        //atributos
        int  Id {set; get; }
        string  Codigo { set; get; }

        string Nombre { set; get; }
        string Descripcion { set; get; }
        Marca Marca { set; get; }
        Categoria Categoria { set; get; }
        string Imagen {set; get; }
        decimal Precio { set; get; }

    }
}
