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
                accesoDatos.setConsutar("select id, descripcion from Marcas;");
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

        public void MarcaAdd(Marca Nuevo)
        {

            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setConsutar("insert into Marcas(Descripcion)values(@Descripcion);");
                accesoDatos.setearParametro("@Descripcion", Nuevo.Descripcion);
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

        public bool validarMarca(string marca)
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsutar("select Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                for (int x = 0; x < lista.Count(); x++)
                {
                    string marcaExistente = lista[x].Descripcion;

                    if (marcaExistente.ToUpper() == marca.ToUpper())
                        return true;
                }
                return false;

            }
            catch (Exception)
            {

                throw;
            }
            finally { datos.CerrarConection(); }
        }

        public void MarcaModify(Marca marca)
        {
            AccesoDatos accesoDatos = new AccesoDatos();    

            try
            {
                accesoDatos.setConsutar("update Marcas set  Descripcion=@Descripcion where Id=@Id");

                accesoDatos.setearParametro("@Descripcion",marca.Descripcion);
                accesoDatos.setearParametro("@Id", marca.Id);


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

        public void MarcaDelete(int Id)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setConsutar("Delete from Marcas where Id=@Id");
                accesoDatos.setearParametro("@Id",Id);

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
    }
}
