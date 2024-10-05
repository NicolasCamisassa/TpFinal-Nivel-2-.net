using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Model;

namespace Controller
{
    public class ArticulosBusiness
    {
        public List<Articulos> Listar()
        {
            
            List<Articulos> Lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("select Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, C.Descripcion Categoria, M.Descripcion Marca, A.IdCategoria, A.IdMarca, A.Id from ARTICULOS A, CATEGORIAS C, MARCAS M where C.Id = A.IdCategoria And M.Id = A.IdMarca");
                datos.EjecutarLectura();

                while (datos.lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.lector["Id"];
                    aux.Codigo = (string)datos.lector["Codigo"];
                    aux.Nombre = (string)datos.lector["Nombre"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];
                    if (!(datos.lector["ImagenUrl"] is DBNull))
                            aux.ImagenUrl = (string)datos.lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.lector["Precio"];
                    aux.Categoria = new Categorias();
                    aux.Categoria.Id = (int)datos.lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.lector["Categoria"];
                    aux.Marcas = new Marcas();
                    aux.Marcas.Id = (int)datos.lector["IdMarca"];
                    aux.Marcas.Descripcion = (string)datos.lector["Marca"];
                    

                    Lista.Add(aux);
                }
                return Lista;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        public void Agregar(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdCategoria, IdMarca, ImagenUrl) VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @IdCategoria, @IdMarca, @ImagenUrl)");

                datos.SetParametro("@Codigo", nuevo.Codigo);
                datos.SetParametro("@Nombre", nuevo.Nombre);
                datos.SetParametro("@Descripcion", nuevo.Descripcion);
                datos.SetParametro("@Precio", nuevo.Precio);
                datos.SetParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.SetParametro("@IdMarca", nuevo.Marcas.Id);
                datos.SetParametro("@ImagenUrl", nuevo.ImagenUrl);
                
               
                datos.EjecutarAccion();
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
        public void Modificar(Articulos modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("Update ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, IdCategoria = @IdCategoria, IdMarca = @IdMarca, ImagenUrl = @ImagenUrl where Id = @Id");
                
                datos.SetParametro("@Codigo", modificar.Codigo);
                datos.SetParametro("@Nombre", modificar.Nombre);
                datos.SetParametro("@Descripcion", modificar.Descripcion);
                datos.SetParametro("@Precio", modificar.Precio);
                datos.SetParametro("@IdCategoria", modificar.Categoria.Id);
                datos.SetParametro("@IdMarca", modificar.Marcas.Id);
                datos.SetParametro("@ImagenUrl", modificar.ImagenUrl);
                datos.SetParametro("@Id", modificar.Id);

                datos.EjecutarAccion();
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
        public void Eliminar(int Id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("delete from ARTICULOS where Id = @Id");
                datos.SetParametro("@Id", Id);
                datos.EjecutarAccion();
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
        public List<Articulos> Filtrar(string campo, string criterio, string comentario)
        {
            List<Articulos> Lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string Consulta = "select Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, C.Descripcion Categoria, M.Descripcion Marca, A.IdCategoria, A.IdMarca, A.Id from ARTICULOS A, CATEGORIAS C, MARCAS M where C.Id = A.IdCategoria And M.Id = A.IdMarca And ";
                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            Consulta += "Precio > " + comentario;
                            break;
                        case "Menor a":
                            Consulta += "Precio < " + comentario;
                            break;
                        default: 
                            Consulta += "Precio = " + comentario;
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            Consulta += "Nombre like '" + comentario + "%' ";
                            break;
                        case "Termina con":
                            Consulta += "Nombre like '%" + comentario + "'";
                            break;
                        default: 
                            Consulta += "Nombre like '%" + comentario + "%' ";
                            break;
                    }
                }
                else if (campo == "Marca")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            Consulta += "M.Descripcion like '" + comentario + "%' ";
                            break;
                        case "Termina con":
                            Consulta += "M.Descripcion like '%" + comentario + "'";
                            break;
                        default:
                            Consulta += "M.Descripcion like '%" + comentario + "%' ";
                            break;
                    }
                }
                else if (campo == "Categoria")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            Consulta += "C.Descripcion like '" + comentario + "%' ";
                            break;
                        case "Termina con":
                            Consulta += "C.Descripcion like '%" + comentario + "'";
                            break;
                        default:
                            Consulta += "C.Descripcion like '%" + comentario + "%' ";
                            break;
                    }
                }

                datos.SetConsulta(Consulta);
                datos.EjecutarLectura();
                while (datos.lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.lector["Id"];
                    aux.Codigo = (string)datos.lector["Codigo"];
                    aux.Nombre = (string)datos.lector["Nombre"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];
                    if (!(datos.lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.lector["Precio"];
                    aux.Categoria = new Categorias();
                    aux.Categoria.Id = (int)datos.lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.lector["Categoria"];
                    aux.Marcas = new Marcas();
                    aux.Marcas.Id = (int)datos.lector["IdMarca"];
                    aux.Marcas.Descripcion = (string)datos.lector["Marca"];


                    Lista.Add(aux);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
    }
}      
    
