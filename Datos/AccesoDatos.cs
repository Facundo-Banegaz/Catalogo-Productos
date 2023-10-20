using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class AccesoDatos
    {
        private SqlConnection conection;
        private SqlCommand comand;
        private SqlDataReader lector;

        public SqlDataReader Lector
        { 
            get { return lector; }
        }


        public AccesoDatos()
        { 
        
            conection = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB;  integrated security=true");
            comand = new SqlCommand();
        }
        public void setConsutar(string consulta)
        {
            comand.CommandType = System.Data.CommandType.Text;
            comand.CommandText = consulta;  
        }

        public void ejecutarLectura()
        { 
            comand.Connection = conection;
            try
            {
                conection.Open();

                lector = comand.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ejecutarAccion()
        {
            comand.Connection = conection;

            try
            {
                conection.Open();
                comand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }
        public void setearParametro(string nombre, object valor)
        {
            comand.Parameters.AddWithValue(nombre,valor);
        }
        public void CerrarConection()
        {
            if (lector != null)
            { 
                lector.Close();
                conection.Close();
            }
        
        }
    }
}
