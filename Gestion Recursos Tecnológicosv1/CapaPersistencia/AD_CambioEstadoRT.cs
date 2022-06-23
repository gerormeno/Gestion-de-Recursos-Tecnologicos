using Gestion_Recursos_Tecnológicos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Recursos_Tecnológicos.Acceso_a_datos
{
    public class AD_CambioEstadoRT
    {
        public static DataTable obtenerTabla()
        // devuelve una tabla luego de consultar a la BD  
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM CambioEstadoRT";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static List<CambioEstadoRT> mapearDesdeBD()
        // realiza el mapeo y devuelve una lista
        // con todos los objetos recuperados de la BD 
        {
            DataTable tablaCambioEstadoRT = obtenerTabla();
            List<CambioEstadoRT> listaCambiosEstadoRT = new List<CambioEstadoRT>();
            foreach (DataRow cambio in tablaCambioEstadoRT.Rows)
            {
                CambioEstadoRT cambioEstado = new CambioEstadoRT();
                cambioEstado.FechaHoraDesde = Convert.ToDateTime(cambio["fechaHoraDesde"]);
                if (!(cambio["fechaHoraHasta"] is DBNull))
                {
                    cambioEstado.FechaHoraHasta = Convert.ToDateTime(cambio["fechaHoraHasta"]);
                }
                else
                {
                    cambioEstado.FechaHoraHasta = null;
                }
                cambioEstado.Estado = AD_Estado.obtenerEstado(Convert.ToInt32(cambio["idEstado"]));
                listaCambiosEstadoRT.Add(cambioEstado);
            }
            return listaCambiosEstadoRT;
        }

        public static List<CambioEstadoRT> obtenerCambios(int idRT)
        // devuelve una tabla luego de consultar a la BD  
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM CambioEstadoRT WHERE numeroRT = " + idRT;
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                List<CambioEstadoRT> cambios = new List<CambioEstadoRT>();
                foreach (DataRow cambio in tabla.Rows)
                {
                    CambioEstadoRT change = new CambioEstadoRT();
                    change.FechaHoraDesde = Convert.ToDateTime(cambio["fechaHoraDesde"]);
                    if (!(cambio["fechaHoraHasta"] is DBNull))
                    {
                        change.FechaHoraHasta = Convert.ToDateTime(cambio["fechaHoraHasta"]);
                    }
                    else
                    {
                        change.FechaHoraHasta = null;
                    }
                    change.Estado = AD_Estado.obtenerEstado(Convert.ToInt32(cambio["idEstado"]));
                    cambios.Add(change);
                }
                return cambios;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool altaCambioEstadoRT(DateTime fechaHoraInicio,
             Estado proximoEstadoRT,int nroRT)
        {
            string nombre = Convert.ToString(proximoEstadoRT.Nombre);
            int idEstado = AD_Estado.obtenerIDEstado(nombre);
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlTransaction objetoTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO CambioEstadoRT (fechaHoraDesde, idEstado, numeroRT) VALUES (@fechaHoraDesde," +
                    " @idEstado, @numeroRT)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaHoraDesde", fechaHoraInicio);
                cmd.Parameters.AddWithValue("@idEstado", idEstado);
                cmd.Parameters.AddWithValue("@numeroRT", nroRT);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                objetoTransaccion = cn.BeginTransaction("Alta CambioEstadoRT");
                cmd.Transaction = objetoTransaccion;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                objetoTransaccion.Commit();
                return true;
            }
            catch (Exception ex)
            {
                objetoTransaccion.Rollback();
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool cargarFechaHoraFin(DateTime fechaHoraFin, int numeroRT) 
            // devuelve bool por  que asi aprendimos pero no hace falta chequear
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlTransaction objetoTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE CambioEstadoRT SET fechaHoraHasta=@fechaHoraHasta WHERE " +
                    "numeroRT=@numeroRT AND fechaHoraHasta IS NULL "; 
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaHoraHasta", fechaHoraFin);
                cmd.Parameters.AddWithValue("@numeroRT", numeroRT);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                objetoTransaccion = cn.BeginTransaction("Cargado atributo fecha hora fin");
                cmd.Transaction = objetoTransaccion;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                objetoTransaccion.Commit();
                return true;
            }
            catch (Exception ex)
            {
                objetoTransaccion.Rollback();
                return false;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
