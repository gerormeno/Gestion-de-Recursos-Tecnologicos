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
    public class AD_Turno
    {
        public static DataTable obtenerTabla()
        // devuelve una tabla luego de consultar a la BD  
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Turno";

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

        public static List<Turno> mapearDesdeBD()
        // realiza el mapeo y devuelve una lista
        // con todos los objetos recuperados de la BD 
        {
            DataTable tablaTurno = obtenerTabla();
            List<Turno> listaTurnos = new List<Turno>();

            foreach (DataRow turro in tablaTurno.Rows)
            {
                Turno turno = new Turno();
                if (!(turro["fechaHoraFin"] is DBNull))
                {
                    turno.FechaHoraFin = Convert.ToDateTime(turro["fechaHoraFin"]);
                }
                else
                {
                    turno.FechaHoraFin = null;
                }
                turno.FechaHoraInicio = Convert.ToDateTime(turro["fechaHoraInicio"]);
                turno.CambiosEstado = AD_CambioEstadoTurno.obtenerCambios(Convert.ToInt32(turro["idTurno"]));
                listaTurnos.Add(turno);
            }

            return listaTurnos;
        }

        public static List<Turno> obtenerTurnosDeRecurso(int idRecurso)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Turno WHERE numeroRT = " + idRecurso;

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                List<Turno> turnos = new List<Turno>();

                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    Turno turno = new Turno();

                    if (!(tabla.Rows[i][0] is DBNull))
                    {
                        turno.FechaHoraFin = Convert.ToDateTime(tabla.Rows[i][0]);
                    }
                    else
                    {
                        turno.FechaHoraFin = null;
                    }
                    turno.FechaHoraInicio = Convert.ToDateTime(tabla.Rows[i][1]);
                    turno.CambiosEstado = AD_CambioEstadoTurno.obtenerCambios(Convert.ToInt32(tabla.Rows[i][2]));
                    turnos.Add(turno);

                }
                return turnos;
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

        public static List<Turno> obtenerTurnosDeAsignacion(int idAsignacion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Turno WHERE idAsignacionCientifico = " + idAsignacion;

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                List<Turno> turnos = new List<Turno>();

                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    Turno turno = new Turno();

                    if (!(tabla.Rows[i][0] is DBNull))
                    {
                        turno.FechaHoraFin = Convert.ToDateTime(tabla.Rows[i][0]);
                    }
                    else
                    {
                        turno.FechaHoraFin = null;
                    }
                    turno.FechaHoraInicio = Convert.ToDateTime(tabla.Rows[i][1]);
                    turno.CambiosEstado = AD_CambioEstadoTurno.obtenerCambios(Convert.ToInt32(tabla.Rows[i][2]));
                    turnos.Add(turno);
                }
                return turnos;
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
        
        public static int obtenerIDTurno(int nroRT, DateTime fechaHoraInicio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Turno WHERE numeroRT = @nroRT and fechaHoraInicio = @fechaHoraInicio";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroRT", nroRT);
                cmd.Parameters.AddWithValue("@fechaHoraInicio",fechaHoraInicio);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                int idTurno = Convert.ToInt32(tabla.Rows[0][2]);

                return idTurno;

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
    }
}
