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
        public static DataTable Buscar(string valor_buscar)
        {
            DMarcas Datos = new DMarcas();
            return Datos.Buscar(valor_buscar);
        }
    }
}
