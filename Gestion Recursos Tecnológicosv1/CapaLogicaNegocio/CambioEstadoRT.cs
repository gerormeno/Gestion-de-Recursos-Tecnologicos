using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Recursos_Tecnológicos.Entidades
{
    public class CambioEstadoRT
    {
        #region Atributos
        private DateTime fechaHoraDesde;
        private DateTime? fechaHoraHasta;
        private Estado estado;
        #endregion

        #region Métodos de seteo
        public DateTime FechaHoraDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        public DateTime? FechaHoraHasta { get => fechaHoraHasta; set => fechaHoraHasta = value; }
        public Estado Estado { get => estado; set => estado = value; }
        #endregion

        #region Métodos
        // Los siguientes dos métodos corresponden al método new():
        public CambioEstadoRT()
        {
            
        }
        public CambioEstadoRT(DateTime fechaHoraDesde, Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = null;
            this.estado = estado;
        }
        public bool esActual() 
        {
            if (fechaHoraHasta == null) 
            {
                return true;
            }
            return false;
        
        }
        public bool esDisponible()
        {
            if (estado.esDisponible())
            {
                return true;
            }
            return false;

        }
        #endregion
    }
}
