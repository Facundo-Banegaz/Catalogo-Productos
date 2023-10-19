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
            SqlConnection connection = new SqlConnection();
            SqlCommand comando = new SqlCommand();    
            SqlDataReader lector;




            List<Articulo> articulos = new List<Articulo>();
            
            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB;  integrated security=true";

                comando.CommandType= System.Data.CommandType.Text;

                comando.CommandText = " select art.Id, Codigo, Nombre, art.Descripcion,ImagenUrl, Precio,cat.Descripcion as categoria,mar.Descripcion as Marca  from Articulos art,Categorias cat, Marcas mar  where art.IdCategoria= cat.Id and art.IdMarca = mar.Id";




                    //"select art.Id, art.Codigo, art.Nombre, art.Descripcion,art.ImagenUrl, art.Precio,cat.Descripcion as categoria,mar.Descripcion as Marca  from ARTICULOS as art  join CATEGORIAS as cat  on art.IdCategoria= cat.Id join MARCAS as mar on art.IdMarca = mar.Id;";

                comando.Connection = connection;

                connection.Open();

                lector = comando.ExecuteReader();    


                while (lector.Read())
                { 
                    Articulo aux = new Articulo();


                    aux.id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Imagen = (string)lector["Imagen"];

                    aux.Precio = (decimal)lector["Precio"];

                    articulos.Add(aux);

                }
                
                connection.Close();

                return articulos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }
    }
}
