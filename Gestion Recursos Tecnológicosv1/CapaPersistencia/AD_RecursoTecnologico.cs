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
    public class AD_RecursoTecnologico
    {
        public static DataTable obtenerTabla()
        // devuelve una tabla luego de consultar a la BD  
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM RecursoTecnologico";

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

        public static List<RecursoTecnologico> mapearDesdeBD()
        // realiza el mapeo y devuelve una lista
        // con todos los objetos recuperados de la BD 
        {
            DataTable tablaRecursosT = obtenerTabla();
            List<RecursoTecnologico> listaRecursos = new List<RecursoTecnologico>();

            foreach (DataRow rt in tablaRecursosT.Rows)
            {
                RecursoTecnologico recurso = new RecursoTecnologico();

                recurso.NumeroRT = Convert.ToInt32(rt["numeroRT"]);
                recurso.TipoRecurso = AD_TipoRecursoTecnologico.obtenerTipoRecurso(Convert.ToInt32(rt["idTipoRecurso"]));
                recurso.Modelo = AD_Modelo.obtenerModelo(Convert.ToInt32(rt["idModelo"]));
                recurso.Mantenimientos = AD_Mantenimiento.obtenerMantenimientos(Convert.ToInt32(rt["numeroRT"]));
                recurso.Turnos = AD_Turno.obtenerTurnosDeRecurso(Convert.ToInt32(rt["numeroRT"]));
                recurso.CambiosEstadoRT = AD_CambioEstadoRT.obtenerCambios(Convert.ToInt32(rt["numeroRT"]));


                listaRecursos.Add(recurso);

            }

            return listaRecursos;
        }

        public static List<RecursoTecnologico> obtenerRecursos(int idAsignacion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM RecursoTecnologico WHERE idAsignacionResponsableRT = " + idAsignacion;

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                List<RecursoTecnologico> recursos = new List<RecursoTecnologico>();

                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    RecursoTecnologico recurso = new RecursoTecnologico();
                    recurso.NumeroRT = Convert.ToInt32(tabla.Rows[i][0]);
                    recurso.TipoRecurso = AD_TipoRecursoTecnologico.obtenerTipoRecurso(Convert.ToInt32(tabla.Rows[i][2]));
                    recurso.Mantenimientos = AD_Mantenimiento.obtenerMantenimientos(Convert.ToInt32(tabla.Rows[i][0]));
                    recurso.CambiosEstadoRT = AD_CambioEstadoRT.obtenerCambios(Convert.ToInt32(tabla.Rows[i][0]));
                    recurso.Modelo = AD_Modelo.obtenerModelo(Convert.ToInt32(tabla.Rows[i][3]));
                    recursos.Add(recurso);

                }
                return recursos;
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
