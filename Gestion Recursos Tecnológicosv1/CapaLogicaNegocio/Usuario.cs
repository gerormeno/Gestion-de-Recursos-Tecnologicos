using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Recursos_Tecnológicos.Entidades
{
    public class Usuario
    {
        #region Atributos
        private String nombre;
        private String password;
        private PersonalCientifico personalCientifico;
        #endregion

        #region Métodos de seteo
        public string Nombre { get => nombre; set => nombre = value; }
        public string Password { get => password; set => password = value; }
        public PersonalCientifico PersonalCientifico { get => personalCientifico; set => personalCientifico = value; }
        #endregion
    }
}
