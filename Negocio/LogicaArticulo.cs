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
    public class LogicaArticulo
    {

        public List<Articulo> ArticuloList()
        {

            AccesoDatos accesoDatos = new AccesoDatos();    
            List<Articulo> articulos = new List<Articulo>();
            
            try
            {


                accesoDatos.setConsutar("select art.Id, art.Codigo, art.Nombre, art.Descripcion,art.ImagenUrl, art.Precio,cat.Descripcion as categoria,mar.Descripcion as Marca  from ARTICULOS as art  join CATEGORIAS as cat  on art.IdCategoria= cat.Id join MARCAS as mar on art.IdMarca = mar.Id;");

                accesoDatos.ejecutarLectura();




                while (accesoDatos.Lector.Read())
                { 
                    Articulo aux = new Articulo();


                    aux.id = (int)accesoDatos.Lector["Id"];
                    aux.Codigo = (string)accesoDatos.Lector["Codigo"];
                    aux.Nombre = (string)accesoDatos.Lector["Nombre"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)accesoDatos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)accesoDatos.Lector["Precio"];
                    Marca marca = new Marca();

                    aux.Marca = marca;

                    Categoria categoria = new Categoria();
                    aux.Categoria = categoria;  



                    articulos.Add(aux);

                }

                return articulos;
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
