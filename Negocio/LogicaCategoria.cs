using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos;
using Dominio;

namespace Negocio
{
    public class LogicaCategoria
    {
        public List<Categoria>  CategoriaList()
        { 
            List<Categoria> categorias = new List<Categoria>();
            try
            {

                return categorias;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
