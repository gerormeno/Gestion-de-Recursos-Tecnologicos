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
    public class AD_Sesion
    {
        public static DataTable obtenerTabla()
        // devuelve una tabla luego de consultar a la BD  
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Sesion";

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

        public static List<Sesion> mapearDesdeBD()
        // realiza el mapeo y devuelve una lista
        // con todos los objetos recuperados de la BD 
        {
            DataTable tablaSesion = obtenerTabla();
            List<Sesion> listaSesiones = new List<Sesion>();

            foreach (DataRow sesion in tablaSesion.Rows)
            {
                Sesion ses = new Sesion();

                ses.FechaHoraDesde = Convert.ToDateTime(sesion["fechaHoraDesde"]);

                //if (sesion["fechaHoraHasta"] == DBNull.Value)
                if (!(sesion["fechaHoraHasta"] is DBNull))
                {
                    ses.FechaHoraHasta = Convert.ToDateTime(sesion["fechaHoraHasta"]);
                }
                else
                {
                    ses.FechaHoraHasta = null;
                }

                ses.Usuario = AD_Usuario.obtenerUsuario(Convert.ToInt32(sesion["idUsuario"]));

                listaSesiones.Add(ses);
            }

            return listaSesiones;
        }
    }
}
