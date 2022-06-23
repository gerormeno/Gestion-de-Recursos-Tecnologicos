using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Recursos_Tecnológicos.Entidades
{
    public class Turno
    {
        #region Atributos
        private DateTime fechaHoraInicio;
        private DateTime? fechaHoraFin;
        private List<CambioEstadoTurno> cambiosEstado;
        #endregion

        #region Métodos de seteo
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime? FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public List<CambioEstadoTurno> CambiosEstado { get => cambiosEstado; set => cambiosEstado = value; }
        #endregion

        #region Métodos
        public bool esCancelableEnPeriodoYReservado(DateTime fecha)
        {
            foreach (CambioEstadoTurno cambioEstado in cambiosEstado)
            {
                if (cambioEstado.esActual() && cambioEstado.esCancelable() && cambioEstado.esNoDisponible())
                {
                    if (fechaHoraInicio < fecha)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void cancelarPorMantenimiento(DateTime fechaHoraInicioMantenimiento, Estado estado)
        {
            foreach (CambioEstadoTurno cambio in cambiosEstado)
            {
                if (cambio.esActual())
                {
                    cambio.FechaHoraHasta = fechaHoraInicioMantenimiento;
                    break;
                }
            }
            CambioEstadoTurno nuevoCambioEstadoTurno = new CambioEstadoTurno(fechaHoraInicioMantenimiento, estado);
            cambiosEstado.Add(nuevoCambioEstadoTurno);
        }
        #endregion 
    }
}
