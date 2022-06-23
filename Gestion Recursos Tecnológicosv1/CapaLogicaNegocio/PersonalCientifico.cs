using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Recursos_Tecnológicos.Entidades
{
    public class PersonalCientifico
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private string correoElectronicoInstitucional;
        #endregion

        #region Métodos de seteo
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string CorreoElectronicoInstitucional { get => correoElectronicoInstitucional; set => correoElectronicoInstitucional = value; }
        #endregion

        #region Métodos
        public string obtenerNombreCompleto()
        {
            return apellido + ", " + nombre;
        }
        #endregion
    }
}
