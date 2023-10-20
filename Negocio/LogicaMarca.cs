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
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setConsutar("select id, descripcion from categorias;");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                { 
                Marca marca = new Marca();

                    marca.Id = (int)accesoDatos.Lector["Id"];
                    marca.Descripcion = (string)accesoDatos.Lector["Descripcion"];

                    marcas.Add(marca);  
                
                }
                return marcas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                accesoDatos.CerrarConection();
            }
        
        }
    }
}
