using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Recursos_Tecnológicos.Entidades;

namespace Gestion_Recursos_Tecnológicos.Acceso_a_datos
{
    public class AD_Usuario
    {
        public static DataTable obtenerTabla()
        // devuelve una tabla luego de consultar a la BD  
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Usuario";

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
        public static Usuario obtenerUsuario(int idUsuarioBuscado) 
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Usuario WHERE idUsuario = " + idUsuarioBuscado;

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                Usuario usuario = new Usuario();

                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    
                    usuario.Nombre = Convert.ToString(tabla.Rows[i][0]);
                    usuario.Password = Convert.ToString(tabla.Rows[i][2]);
                    usuario.PersonalCientifico = AD_PersonalCientifico.obtenerCientificoUsuario(idUsuarioBuscado);
                    
                    return usuario;
                }
                return usuario;
                //return null;
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

        public static List<Usuario> mapearDesdeBD()
        // realiza el mapeo y devuelve una lista
        // con todos los objetos recuperados de la BD 
        {
            DataTable tablaUsuario = obtenerTabla();
            List<Usuario> listaUsuarios = new List<Usuario>();

            foreach (DataRow usuario in tablaUsuario.Rows)
            {
                Usuario usu = new Usuario();

                usu.Nombre = Convert.ToString(usuario["nombre"]);
                usu.Password = Convert.ToString(usuario["password"]);
                //usu.PersonalCientifico = AD_PersonalCientifico.obtenerCientifico(Convert.ToInt32(usuario["idUsuario"]));

                listaUsuarios.Add(usu);
            }

            return listaUsuarios;
        }
    }
}
