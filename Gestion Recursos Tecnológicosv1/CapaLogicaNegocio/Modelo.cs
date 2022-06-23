using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Recursos_Tecnológicos.Entidades
{
    public class Modelo
    {
        #region Atributos
        private String nombre;
        private Marca marca;
        #endregion

        #region Métodos de seteo
        public string Nombre { get => nombre; set => nombre = value; }
        public Marca Marca { get => marca; set => marca = value; }
        #endregion
    }
}
