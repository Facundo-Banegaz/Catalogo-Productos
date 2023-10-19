using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Dominio;

namespace Negocio
{
    public class LogicaArticulo
    {

        public List<Articulo> ArticuloList()
        {
            List<Articulo> articulos = new List<Articulo>();
            try
            {

                return articulos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }; 
    }
}
