using System;
using System.Collections.Generic;
using System.Data;
using SoftSales.Datos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftSales.Entidades;

namespace SoftSales.Negocio
{
    public class NMarcas
    {
        public static DataTable Listar()
        {
            DMarcas Marcas = new DMarcas();
            return Marcas.Listar();
        }
        public static DataTable Buscar(string valor_buscar)
        {
            DMarcas Datos = new DMarcas();
            return Datos.Buscar(valor_buscar);
        }

        public static string Insertar(string nombre, string observaciones)
        {
            DMarcas Datos = new DMarcas();
            string existe = Datos.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "La categoría ya existe";
            }
            else
            {
                Marcas Obj = new Marcas();
                Obj.Nombre = nombre;
                Obj.Observaciones = observaciones;
                return Datos.Insertar(Obj);
            }
        }

        public static string Actualizar(int id, string nombre, string nombreAnt, string observaciones)
        {
            DMarcas Datos = new DMarcas();
            Marcas Obj = new Marcas();
            if (nombreAnt.Equals(nombre))
            {
                Obj.idMarca = id;
                Obj.Nombre = nombre;
                Obj.Observaciones = observaciones;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string existe = Datos.Existe(nombre);
                if(existe.Equals("1"))
                {
                    return "La marca ya existe";
                }
                else
                {
                    Obj.idMarca = id;
                    Obj.Nombre = nombre;
                    Obj.Observaciones = observaciones;
                    return Datos.Actualizar(Obj);
                }
            }
        }

        public static string Eliminar(int id)
        {
            DMarcas Datos = new DMarcas();
            return Datos.Eliminar(id);
        }

        public static string Activar(int id)
        {
            DMarcas Datos = new DMarcas();
            return Datos.Activar(id);
        }
        public static string Desactivar(int id)
        {
            DMarcas Datos = new DMarcas();
            return Datos.Desactivar(id);
        }
    }
}
