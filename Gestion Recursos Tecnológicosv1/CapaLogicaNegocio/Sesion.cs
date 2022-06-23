using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Recursos_Tecnológicos.Entidades
{
    public class Sesion
    {
        #region Atributos
        private Usuario usuario;
        private DateTime fechaHoraDesde;
        private DateTime? fechaHoraHasta;
        #endregion

        #region Métodos de seteo
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public DateTime FechaHoraDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        public DateTime? FechaHoraHasta { get => fechaHoraHasta; set => fechaHoraHasta = value; }
        #endregion

        #region Métodos

        public PersonalCientifico obtenerCientificoLogueado() 
        {
            return usuario.PersonalCientifico;
        }
        #endregion
    }
}
