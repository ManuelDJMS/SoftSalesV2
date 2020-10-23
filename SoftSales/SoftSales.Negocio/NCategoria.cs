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
    }
}
