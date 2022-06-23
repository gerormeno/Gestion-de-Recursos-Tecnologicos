using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Recursos_Tecnológicos.Entidades
{
    public class Mantenimiento
    {
        #region Atributos
        private DateTime fechaHoraInicio;
        private DateTime? fechaHoraFin;
        private String motivoMantenimiento;
        #endregion

        #region Métodos de seteo
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime? FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public string MotivoMantenimiento { get => motivoMantenimiento; set => motivoMantenimiento = value; }
        #endregion

        #region Métodos
        public Mantenimiento(DateTime fechaHoraInicio, DateTime? fechaHoraFin, string motivoMantenimiento)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.motivoMantenimiento = motivoMantenimiento;
        }
        
        // El siguiente método corresponde a new():
        public Mantenimiento()
        {

        }
        #endregion
    }
}
