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
    public class AD_TipoRecursoTecnologico

    {
        public static DataTable obtenerTabla()
        // devuelve una tabla luego de consultar a la BD  
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM TipoRecursoTecnologico";

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

        public static List<TipoRecursoTecnologico> mapearDesdeBD()
        // realiza el mapeo y devuelve una lista
        // con todos los objetos recuperados de la BD 
        {
            DataTable tablaTipoRecursoT = obtenerTabla();
            List<TipoRecursoTecnologico> listaTiposRT = new List<TipoRecursoTecnologico>();

            foreach (DataRow tip in tablaTipoRecursoT.Rows)
            {
                TipoRecursoTecnologico tipo = new TipoRecursoTecnologico();

                tipo.Nombre = Convert.ToString(tip["nombre"]);
                

                listaTiposRT.Add(tipo);

            }

            return listaTiposRT;
        }
        public static TipoRecursoTecnologico obtenerTipoRecurso(int idTipoBuscado)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM TipoRecursoTecnologico WHERE idTipoRecurso = " + idTipoBuscado;

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                TipoRecursoTecnologico tipoRT = new TipoRecursoTecnologico();

                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    
                        tipoRT.Nombre = Convert.ToString(tabla.Rows[i][1]);
                        
                        return tipoRT;
                    
                }
                return null;
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
