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
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setConsutar("select id, descripcion from categorias;");
                accesoDatos.ejecutarLectura();

                while(accesoDatos.Lector.Read())
                { 
                    Categoria categoria = new Categoria();

                    categoria.Id = (int)accesoDatos.Lector["Id"];
                    categoria.Descripcion= (string)accesoDatos.Lector["Descripcion"];
                    categorias.Add(categoria);
                }
                return categorias;
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


        public void CategoriaAdd(Categoria Nuevo)
        {

            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {


                accesoDatos.setConsutar("insert into Categorias(Descripcion)values(@Descripcion);");

                accesoDatos.setearParametro("@Descripcion",Nuevo.Descripcion);
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

        public bool validarCategoria(string categoria)
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsutar("select Descripcion from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                for (int x = 0; x < lista.Count(); x++)
                {
                    string CatExistente = lista[x].Descripcion;

                    if (CatExistente.ToUpper() == categoria.ToUpper())
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                datos.CerrarConection(); 
            }
        }
    }
}
