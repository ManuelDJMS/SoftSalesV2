using System;
using System.Collections.Generic;
using System.Data;
using SoftSales.Datos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftSales.Negocio
{
    public class NMarcas
    {
        public static DataTable Listar()
        {
            DMarcas Marcas = new DMarcas();
            return Marcas.Listar();
        }
    }
}
