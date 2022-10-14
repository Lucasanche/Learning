using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace Comercio
{
    public class DataFilter
    {
        public List<Articulo> listar(string consulta, string columna, string criterio)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesData acceso = new AccesData();
            switch (columna)
            {
                case "Código":
                    columna = "Codigo";
                    break;
                case "Marca":
                    columna = "M.Descripcion";
                    break;
                case "Categoría":
                    columna = "C.Descripcion";
                    break;
                default:
                    break;
            }
            switch (criterio)
            {
                case "Menor que":
                    consulta = $" <= '{consulta}";
                    break;
                case "Mayor que":
                    break;
                case "Contiene":
                    consulta = $"LIKE '%{consulta}%";
                    break;
                case "Termina con":
                    consulta = $"LIKE '%{consulta}";
                    break;
                case "Empieza con":
                    consulta = $"LIKE '{consulta}%";
                    break;
            }
            try
            {
                acceso.setQuery($"Select A.Id id, Codigo, Nombre, A.Descripcion descr, ImagenUrl, Precio, M.Descripcion Marca, C.Descripcion Categoria From ARTICULOS A left JOIN MARCAS M ON M.Id = A.IdMarca left JOIN CATEGORIAS AS C ON C.Id = A.IdCategoria WHERE {columna} {consulta}'");
                acceso.executeQuery();

                //lectura con VARIAS validaciones por los NULL en DB_CATALOGO
                while (acceso.Reader.Read())
                {
                    Articulo articulo = new Articulo();

                    articulo.Id = (int)acceso.Reader["id"];
                    articulo.Codigo = acceso.Reader["Codigo"] is DBNull ?
                        "" : (string)acceso.Reader["Codigo"];
                    articulo.Nombre = acceso.Reader["Nombre"] is DBNull ?
                        "-sin nombre-" : (string)acceso.Reader["Nombre"];

                    articulo.Descripcion = acceso.Reader["descr"] is DBNull ?
                        "" : (string)acceso.Reader["descr"];

                    articulo.ImagenUrl = acceso.Reader["ImagenUrl"] is DBNull ?
                        "" : (string)acceso.Reader["ImagenUrl"];

                    if (!(acceso.Reader["Precio"] is DBNull))
                    {
                        articulo.Precio = (decimal)acceso.Reader["Precio"];
                    }
                    articulo.Marca = new Clasificacion();
                    articulo.Categoria = new Clasificacion();

                    articulo.Marca.Descripcion = acceso.Reader["Marca"] is DBNull ?
                        "" : (string)acceso.Reader["Marca"];

                    articulo.Categoria.Descripcion = acceso.Reader["Categoria"] is DBNull ?
                        "" : (string)acceso.Reader["Categoria"];

                    lista.Add(articulo);
                }
                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //IMPORTANTE, cerrar la conexion
                acceso.closeConnection();
            }
        }
    }
}
