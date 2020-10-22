using SoftSales.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftSales.Negocio
{
    public class NCategoria
    {
        public static DataTable Listar()
        {
            DCategorias Datos = new DCategorias();
            return Datos.Listar();

        }
    }
}
