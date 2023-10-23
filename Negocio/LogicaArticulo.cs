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


                    if (!(accesoDatos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)accesoDatos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)accesoDatos.Lector["Precio"];
                    
                    aux.Marca = new Marca();

                    aux.Marca.Descripcion = (string)accesoDatos.Lector["Marca"];

                    aux.Categoria = new Categoria();

                    aux.Categoria.Descripcion = (string)accesoDatos.Lector["Categoria"] ;  

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

        public  void ArticuloAdd( Articulo Nuevo)
        {

            AccesoDatos  accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setConsutar("insert into articulos(Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio)values(@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,@Precio)");
                accesoDatos.setearParametro("@Codigo",Nuevo.Codigo);
                accesoDatos.setearParametro("@Nombre", Nuevo.Nombre);
                accesoDatos.setearParametro("@Descripcion", Nuevo.Descripcion);
                accesoDatos.setearParametro("@IdMarca", Nuevo.Marca.Id);
                accesoDatos.setearParametro("@IdCategoria", Nuevo.Categoria.Id);
                accesoDatos.setearParametro("@ImagenUrl", Nuevo.ImagenUrl);
                accesoDatos.setearParametro("@Precio", Nuevo.Precio);


                accesoDatos.ejecutarAccion();
            
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

        public void ArticuloModify()
        { 
        
        

        }

        public bool validarCodigo(string codigo)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setConsutar("select Codigo from ARTICULOS");

                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)accesoDatos.Lector["Codigo"];

                    lista.Add(aux);
                }

                for (int x = 0; x < lista.Count(); x++)
                {
                    string codigoExistente = lista[x].Codigo;

                    if (codigoExistente.ToUpper() == codigo.ToUpper())
                        return true;
                }

                return false;
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

            public void ArticuloDelete()
            {


            } 
    
    }
}
