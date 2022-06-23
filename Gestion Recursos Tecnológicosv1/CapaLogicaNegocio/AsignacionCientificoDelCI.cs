using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Recursos_Tecnológicos.Entidades
{
    public class AsignacionCientificoDelCI
    {
        #region Atributos
        private DateTime fechaHoraDesde;
        private DateTime? fechaHoraHasta;
        private PersonalCientifico cientifico;
        private List<Turno> turnos;
        #endregion

        #region Métodos de seteo
        public DateTime FechaHoraDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        public DateTime? FechaHoraHasta { get => fechaHoraHasta; set => fechaHoraHasta = value; }
        public PersonalCientifico Cientifico { get => cientifico; set => cientifico = value; }
        public List<Turno> Turnos { get => turnos; set => turnos = value; }
        #endregion

        #region Métodos
        public bool esTuTurno(Turno turno)
        {
            foreach (Turno turro in turnos)
            {
                if (turro.FechaHoraFin == turno.FechaHoraFin) { return true; }
            }
            return false;
        }
        #endregion
    }
}
