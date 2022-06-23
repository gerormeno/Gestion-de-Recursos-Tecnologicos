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
    public class AD_Modelo
    {
        public static DataTable obtenerTabla()
        // devuelve una tabla luego de consultar a la BD  
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Modelo";

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

        public static List<Modelo> mapearDesdeBD()
        // realiza el mapeo y devuelve una lista
        // con todos los objetos recuperados de la BD 
        {
            DataTable tablaModelo = obtenerTabla();
            List<Modelo> listasModelo = new List<Modelo>();
            
            foreach (DataRow mod in tablaModelo.Rows)
            {
                Modelo modelo = new Modelo();
                modelo.Nombre = Convert.ToString(mod["nombre"]);
                modelo.Marca = AD_Marca.obtenerMarca(Convert.ToInt32(mod["idMarca"]));
                listasModelo.Add(modelo);
            }
            return listasModelo;
        }
        public static List<Modelo> obtenerModelos(int idMarca)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Modelo WHERE idMarca = " + idMarca;

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                List<Modelo> modelos = new List<Modelo>();

                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    Modelo modelo = new Modelo();
                   
                    modelo.Nombre = Convert.ToString(tabla.Rows[i][1]);
                    modelo.Marca = AD_Marca.obtenerMarca(Convert.ToInt32(tabla.Rows[i][2]));
                    modelos.Add(modelo);

                }
                return modelos;
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

        public static Modelo obtenerModelo(int idModelo) 
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD_GestionRecursosTecnologicos"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Modelo WHERE idModelo = " + idModelo;

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                Modelo modelo = new Modelo();

                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    

                    modelo.Nombre = Convert.ToString(tabla.Rows[i][1]);
                    modelo.Marca = AD_Marca.obtenerMarca(Convert.ToInt32(tabla.Rows[i][2]));
                    return modelo;



                }
                return modelo;
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
