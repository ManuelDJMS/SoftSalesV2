using SoftSales.Datos;
using SoftSales.Entidades;
using System.Data;

namespace SoftSales.Negocio
{
    public class NCategoria
    {
        public static DataTable Listar()
        {
            DCategorias Datos = new DCategorias();
            return Datos.Listar();

        }
        public static DataTable Buscar(string valor_buscar)
        {
            DCategorias Datos = new DCategorias();
            return Datos.Buscar(valor_buscar);
        }
        public static string Insertar(string nombre, string descripcion)
        {
            DCategorias Datos = new DCategorias();
            string existe = Datos.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "La categoria ya existe";
            }
            else
            {
                Categorias Obj = new Categorias();
                Obj.Nombre = nombre;
                Obj.Descripcion = descripcion;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int Id, string NombreAnt, string Nombre, string Descripcion)
        {
            DCategorias Datos = new DCategorias();
            Categorias Obj = new Categorias();

            if (NombreAnt.Equals(Nombre))
            {
                Obj.idCategoria = Id;
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "La categoría ya existe";
                }
                else
                {
                    Obj.idCategoria = Id;
                    Obj.Nombre = Nombre;
                    Obj.Descripcion = Descripcion;
                    return Datos.Actualizar(Obj);
                }
            }

        }
        public static string Eliminar(int idcategoria)
        {
            DCategorias Datos = new DCategorias();
            return Datos.Eliminar(idcategoria);
        }

        public static string Activar(int idcategoria)
        {
            DCategorias Datos = new DCategorias();
            return Datos.Activar(idcategoria);
        }

        public static string Desactivar(int idcategoria)
        {
            DCategorias Datos = new DCategorias();
            return Datos.Desactivar(idcategoria);
        }
    }
}
