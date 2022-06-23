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
    public class AD_CambioEstadoTurno
    {
        public static DataTable obtenerTabla()
        // devuelve una tabla luego de consultar a la BD  
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM CambioEstadoTurno";
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

        public static List<CambioEstadoTurno> mapearDesdeBD()
        // realiza el mapeo y devuelve una lista
        // con todos los objetos recuperados de la BD 
        {
            DataTable tablaCambioEstadoTurno = obtenerTabla();
            List<CambioEstadoTurno> listaCambiosEstadoTurno = new List<CambioEstadoTurno>();
            foreach (DataRow cambio in tablaCambioEstadoTurno.Rows)
            {
                CambioEstadoTurno cambioEstado = new CambioEstadoTurno();
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
                listaCambiosEstadoTurno.Add(cambioEstado);
            }
            return listaCambiosEstadoTurno;
        }

        public static List<CambioEstadoTurno> obtenerCambios(int idTurno)
        // devuelve una tabla luego de consultar a la BD  
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM CambioEstadoTurno WHERE idTurno = " + idTurno;
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                List<CambioEstadoTurno> cambios = new List<CambioEstadoTurno>();
                foreach (DataRow cambio in tabla.Rows)
                {
                    CambioEstadoTurno change = new CambioEstadoTurno();
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

        public static bool altaCambioEstadoTurno(DateTime fechaHoraInicio,
             Estado proximoEstadoRT, int idTurno)
        {
            int idEstado = AD_Estado.obtenerIDEstado(proximoEstadoRT.Nombre);
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlTransaction objetoTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO CambioEstadoTurno (fechaHoraDesde, idEstado, idTurno) VALUES (@fechaHoraDesde," +
                    " @idEstado, @idTurno)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaHoraDesde", fechaHoraInicio);
                cmd.Parameters.AddWithValue("@idEstado", idEstado);
                cmd.Parameters.AddWithValue("@idTurno", idTurno);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                objetoTransaccion = cn.BeginTransaction("Alta CambioEstadoTurno");
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

        public static bool cargarFechaHoraFin(DateTime fechaHoraFin, int idTurno) // devuelve bool por  que asi aprendimos pero no hace falta chequear
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlTransaction objetoTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE CambioEstadoTurno SET fechaHoraHasta=@fechaHoraHasta " +
                    "WHERE idTurno=@idTurno AND fechaHoraHasta IS NULL ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaHoraHasta", fechaHoraFin);
                cmd.Parameters.AddWithValue("@idTurno", idTurno);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                objetoTransaccion = cn.BeginTransaction("Cargado atributo  fecha hora fin");
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
