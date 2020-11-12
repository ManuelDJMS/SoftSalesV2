using System;
using System.Data;
using System.Data.SqlClient;

namespace SoftSales.Datos
{
    public class DMarcas
    {
        public DataTable Listar()
        {
            SqlDataReader resultado;
            SqlConnection conexion = new SqlConnection();
            DataTable Tabla = new DataTable();
            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Marcas_Listar", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                resultado = comando.ExecuteReader();
                Tabla.Load(resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }
    }
}
