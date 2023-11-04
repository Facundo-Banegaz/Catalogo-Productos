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


                accesoDatos.setConsutar("select art.Id, art.Codigo, art.Nombre, art.Descripcion,art.ImagenUrl, art.Precio,art.IdMarca,cat.Descripcion as categoria,art.IdCategoria,mar.Descripcion as Marca  from ARTICULOS as art  join CATEGORIAS as cat  on art.IdCategoria= cat.Id join MARCAS as mar on art.IdMarca = mar.Id;");

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

                    aux.Marca.Id = (int)accesoDatos.Lector["IdMarca"];

                    aux.Marca.Descripcion = (string)accesoDatos.Lector["Marca"];

                    aux.Categoria = new Categoria();

                    aux.Categoria.Id = (int)accesoDatos.Lector["IdCategoria"];
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

        public void ArticuloModify(Articulo Articulo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();    

            try
            {
                accesoDatos.setConsutar("update articulos set  Codigo=@Codigo, Nombre=@Nombre, Descripcion=@Descripcion, IdMarca=@IdMarca, Idcategoria=@IdCategoria,ImagenUrl=@ImagenUrl,Precio=@Precio where Id=@Id;");

                accesoDatos.setearParametro("@Id", Articulo.id);
                accesoDatos.setearParametro("@Codigo", Articulo.Codigo);
                accesoDatos.setearParametro("@Nombre", Articulo.Nombre);
                accesoDatos.setearParametro("@Descripcion", Articulo.Descripcion);
                accesoDatos.setearParametro("@ImagenUrl", Articulo.ImagenUrl);
                accesoDatos.setearParametro("@Precio", Articulo.Precio);
                accesoDatos.setearParametro("@IdMarca", Articulo.Marca.Id);
                accesoDatos.setearParametro("@IdCategoria", Articulo.Categoria.Id);

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


        public void ArticuloDelete(int Id)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setConsutar("Delete from ARTICULOS where Id=@Id");
                accesoDatos.setearParametro("@Id", Id);

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

        public List<Articulo> ArticuloFilter(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select art.Id, art.Codigo, art.Nombre, art.Descripcion,art.ImagenUrl, art.Precio,art.IdMarca,cat.Descripcion as categoria,art.IdCategoria,mar.Descripcion as Marca  from ARTICULOS as art  join CATEGORIAS as cat  on art.IdCategoria= cat.Id join MARCAS as mar on art.IdMarca = mar.Id and ";

                switch (campo)
                {
                    case "Id":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "art.Id > " + filtro;
                                break;
                            case "Menor a":
                                consulta += "art.Id < " + filtro;
                                break;
                            default:
                                consulta += "art.Id = " + filtro;
                                break;
                        }
                        break;

                    case "Codigo":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "art.Codigo like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "art.Codigo like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "art.Codigo  like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "art.Nombre like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "art.Nombre like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "art.Nombre like '%" + filtro + "%'";
                                break;
                        }
                        break;

                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "art.Precio > " + filtro;
                                break;
                            case "Menor a":
                                consulta += "art.Precio < " + filtro;
                                break;
                            default:
                                consulta += "art.Precio = " + filtro;
                                break;
                        }
                        break;
                    case "Marca":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "mar.Descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "mar.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "mar.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Categoria":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "cat.Descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "cat.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "cat.Descripcion  like '%" + filtro + "%'";
                                break;
                        }
                        break;

                }

                datos.setConsutar(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];


                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
