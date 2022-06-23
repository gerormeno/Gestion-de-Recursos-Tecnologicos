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
    class AD_AsignacionCientificoDelCI
    {
        public static DataTable obtenerTabla()
        // devuelve una tabla luego de consultar a la BD  
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM AsignacionCientificoDelCI";
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

        public static List<AsignacionCientificoDelCI> mapearDesdeBD()
        // realiza el mapeo y devuelve una lista
        // con todos los objetos recuperados de la BD 
        {
            DataTable tablaAsignacionesCientificoDelCI= obtenerTabla();
            List<AsignacionCientificoDelCI> listaAsignacionesCientificoDelCI= new List<AsignacionCientificoDelCI>();
            foreach (DataRow asignacion in tablaAsignacionesCientificoDelCI.Rows)
            {
                AsignacionCientificoDelCI asig = new AsignacionCientificoDelCI();
                asig.FechaHoraDesde = Convert.ToDateTime(asignacion["fechaHoraDesde"]);
                if (!(asignacion["fechaHoraHasta"] is DBNull))
                {
                    asig.FechaHoraHasta = Convert.ToDateTime(asignacion["fechaHoraHasta"]);
                }
                else
                {
                    asig.FechaHoraHasta = null;
                }
                asig.Cientifico = AD_PersonalCientifico.obtenerCientifico(Convert.ToInt32(asignacion["idPersonalCientifico"]));
                asig.Turnos = AD_Turno.obtenerTurnosDeAsignacion(Convert.ToInt32(asignacion["idAsignacionCientifico"]));
                listaAsignacionesCientificoDelCI.Add(asig);
            }
            return listaAsignacionesCientificoDelCI;
        }
    }
}
