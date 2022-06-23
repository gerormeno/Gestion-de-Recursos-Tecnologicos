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
    public class AD_PersonalCientifico
    {
        public static DataTable obtenerTabla()
        // devuelve una tabla luego de consultar a la BD  
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM PersonalCientifico";

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

        public static List<PersonalCientifico> mapearDesdeBD()
        // realiza el mapeo y devuelve una lista
        // con todos los objetos recuperados de la BD 
        {
            DataTable tablaPersonalCientifico = obtenerTabla();
            List<PersonalCientifico> listaCientificos = new List<PersonalCientifico>();

            foreach (DataRow cientif in tablaPersonalCientifico.Rows)
            {
                PersonalCientifico cientifico = new PersonalCientifico();

                cientifico.Nombre = Convert.ToString(cientif["nombre"]);
                cientifico.Apellido = Convert.ToString(cientif["apellido"]);
                cientifico.CorreoElectronicoInstitucional = Convert.ToString(cientif["correoElectronico"]);
                //cientifico.Usuario = AD_Usuario.obtenerUsuario(Convert.ToInt32(cientif["idUsuario"]));

                listaCientificos.Add(cientifico);
            }

            return listaCientificos;
        }

        public static PersonalCientifico obtenerCientifico(int idPersonal)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM PersonalCientifico WHERE idPersonalCientifico = " + idPersonal;

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                PersonalCientifico personal = new PersonalCientifico();

                for (int i = 0; i < tabla.Rows.Count; i++)
                {

                    personal.Apellido = Convert.ToString(tabla.Rows[i][1]);
                    personal.Nombre = Convert.ToString(tabla.Rows[i][2]);
                    personal.CorreoElectronicoInstitucional = Convert.ToString(tabla.Rows[i][3]);
                    return personal;

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

        public static PersonalCientifico obtenerCientificoUsuario(int idU)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM PersonalCientifico WHERE idUsuario = " + idU;

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                PersonalCientifico personal = new PersonalCientifico();

                for (int i = 0; i < tabla.Rows.Count; i++)
                {

                    personal.Apellido = Convert.ToString(tabla.Rows[i][1]);
                    personal.Nombre = Convert.ToString(tabla.Rows[i][2]);
                    personal.CorreoElectronicoInstitucional = Convert.ToString(tabla.Rows[i][4]);
                    return personal;

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
