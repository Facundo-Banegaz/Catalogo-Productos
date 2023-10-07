using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        int Id { get; set; }
        [DisplayName("Descripción")]
        string Descripcion { get; set; }
    }
}
