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
    public class AD_Mantenimiento
    {
        public static DataTable obtenerTabla()
        // devuelve una tabla luego de consultar a la BD  
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Mantenimiento";

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
        public static List<Mantenimiento> obtenerMantenimientos(int idRecurso)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Mantenimiento WHERE numeroRT = " + idRecurso;

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                List<Mantenimiento> mantenimientos = new List<Mantenimiento>();

                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    Mantenimiento mantenimiento = new Mantenimiento();
                    mantenimiento.FechaHoraInicio = Convert.ToDateTime(tabla.Rows[i][1]);
                    if (!(tabla.Rows[i][0] is DBNull))
                    {
                        mantenimiento.FechaHoraFin = Convert.ToDateTime(tabla.Rows[i][0]);
                    }
                    else
                    {
                        mantenimiento.FechaHoraFin = null;
                    }
                    mantenimiento.MotivoMantenimiento = Convert.ToString(tabla.Rows[i][2]);
                    mantenimientos.Add(mantenimiento);
                }
                return mantenimientos;
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

        public static List<Mantenimiento> mapearDesdeBD()
        // realiza el mapeo y devuelve una lista
        // con todos los objetos recuperados de la BD 
        {
            DataTable tablaMantenimiento = obtenerTabla();
            List<Mantenimiento> listaMantenimientos = new List<Mantenimiento>();

            foreach (DataRow man in tablaMantenimiento.Rows)
            {
                Mantenimiento mantenimiento = new Mantenimiento();

                if (!(man["fechaHoraFin"] is DBNull))
                {
                    mantenimiento.FechaHoraFin = Convert.ToDateTime(man["fechaHoraFin"]);
                }
                else
                {
                    mantenimiento.FechaHoraFin = null;
                }
                mantenimiento.FechaHoraInicio = Convert.ToDateTime(man["fechaHoraInicio"]);
                mantenimiento.MotivoMantenimiento = Convert.ToString(man["motivoMantenimiento"]);
                listaMantenimientos.Add(mantenimiento);
            }
            return listaMantenimientos;
        }

        public static bool altaMantenimiento(DateTime fechaHoraInicio,DateTime fechaHoraFin, 
            string motivo, RecursoTecnologico recurso)
        {
            int nroRT = recurso.NumeroRT;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlTransaction objetoTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Mantenimiento (fechaHoraFin, fechaHoraInicio, motivoMantenimiento, numeroRT) VALUES (@fechaHoraFin," +
                    " @fechaHoraInicio, @motivoMantenimiento, @numeroRT)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaHoraFin", fechaHoraFin);
                cmd.Parameters.AddWithValue("@fechaHoraInicio", fechaHoraInicio);
                cmd.Parameters.AddWithValue("@motivoMantenimiento", motivo);
                cmd.Parameters.AddWithValue("@numeroRT", nroRT);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                objetoTransaccion = cn.BeginTransaction("Alta Mantenimiento");
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
