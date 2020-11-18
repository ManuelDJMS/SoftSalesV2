using System;
using System.Data;
using System.Data.SqlClient;
using SoftSales.Entidades;
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

        public DataTable Buscar(string valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Marcas_Buscar", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                conexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return tabla;
        }
        public string Existe(string valor)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Marcas_Existe", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@existe";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);
                conexion.Open();
                comando.ExecuteNonQuery();
                respuesta = Convert.ToString(parametro.Value);
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return respuesta;
        }
        public string Insertar (Marcas Obj)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Marcas_Insertar", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                comando.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = Obj.Observaciones;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar la Marca";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return respuesta;
        }

        public string Actualizar(Marcas Obj)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Marcas_Actualizar", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                comando.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = Obj.Observaciones;
                comando.Parameters.Add("@idmarca", SqlDbType.Int).Value = Obj.idMarca;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar la marca";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return respuesta;
        }
        public string Activar(int idmarca)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Marcas_Activar", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idmarca", SqlDbType.Int).Value = idmarca;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar la marca";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return respuesta;
        }
        public string Desactivar(int idmarca)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Marcas_Desactivar", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idmarca", SqlDbType.Int).Value = idmarca;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar la marca";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)conexion.Close();
            }
            return respuesta;
        }

        public string Eliminar(int idmarca)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Marcas_Eliminar", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idmarca", SqlDbType.Int).Value = idmarca;
                conexion.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar la marca";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return respuesta;
        }
    }
}
