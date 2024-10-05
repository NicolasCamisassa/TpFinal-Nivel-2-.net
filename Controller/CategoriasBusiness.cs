using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace Controller
{
    public class CategoriasBusiness
    {
        public List<Categorias> Listar()
        {
            List<Categorias> lista = new List<Categorias>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetConsulta("select Id, Descripcion from CATEGORIAS");
                datos.EjecutarLectura();

                while (datos.lector.Read())
                {
                    Categorias aux = new Categorias();
                    aux.Id = (int)datos.lector["Id"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        
          
    }
}
