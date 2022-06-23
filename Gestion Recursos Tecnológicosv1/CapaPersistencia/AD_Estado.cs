using Gestion_Recursos_Tecnológicos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Recursos_Tecnológicos.Acceso_a_datos
{
    public class AD_Estado
    {
        public static DataTable obtenerTabla()
        // devuelve una tabla luego de consultar a la BD  
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Estado";

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

        public static List<Estado> mapearDesdeBD()
        // realiza el mapeo y devuelve una lista
        // con todos los objetos recuperados de la BD 
        {
            DataTable tablaEstado = obtenerTabla();
            List<Estado> listaEstados = new List<Estado>();
            foreach (DataRow esta in tablaEstado.Rows)
            {
                Estado estado = new Estado();

                estado.Nombre = Convert.ToString(esta["nombre"]);
                estado.Ambito = Convert.ToString(esta["ambito"]);
                estado.EsCancelable = Convert.ToBoolean(esta["esCancelable"]);
                estado.EsReservable = Convert.ToBoolean(esta["esReservable"]);
                listaEstados.Add(estado);                
            }
            return listaEstados;
        }

        public static Estado obtenerEstado(int idEstado) 
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Estado WHERE idEstado = " + idEstado;
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                Estado estado = new Estado();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                        estado.Nombre = Convert.ToString(tabla.Rows[i][0]);
                        estado.Ambito = Convert.ToString(tabla.Rows[i][1]);
                        estado.EsCancelable = Convert.ToBoolean(tabla.Rows[i][2]);
                        estado.EsReservable = Convert.ToBoolean(tabla.Rows[i][3]);
                        return estado;
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

        public static int obtenerIDEstado(string nombre) 
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            int id;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Estado WHERE nombre = @nombre" ;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre",nombre);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                id = Convert.ToInt32(tabla.Rows[0][4]);
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
    

