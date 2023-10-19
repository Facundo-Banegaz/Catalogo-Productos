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
    public class LogicaMarca
    {
        public List<Marca> MarcaList()
        { 
            List<Marca> marcas = new List<Marca>();

            try
            {

                return marcas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }
    }
}
