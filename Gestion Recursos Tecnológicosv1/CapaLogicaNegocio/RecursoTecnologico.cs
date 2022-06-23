using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Recursos_Tecnológicos.Entidades
{
    public class RecursoTecnologico
    {
        #region Atributos
        private int numeroRT;
        private TipoRecursoTecnologico tipoRecurso;
        private Modelo modelo;
        private List<Mantenimiento> mantenimientos;
        private List<Turno> turnos;
        private List<CambioEstadoRT> cambiosEstadoRT;
        #endregion

        #region Métodos de seteo
        public int NumeroRT { get => numeroRT; set => numeroRT = value; }
        public TipoRecursoTecnologico TipoRecurso { get => tipoRecurso; set => tipoRecurso = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public List<Mantenimiento> Mantenimientos { get => mantenimientos; set => mantenimientos = value; }
        public List<Turno> Turnos { get => turnos; set => turnos = value; }
        public List<CambioEstadoRT> CambiosEstadoRT { get => cambiosEstadoRT; set => cambiosEstadoRT = value; }
        #endregion

        #region Métodos
        public bool esDisponible() 
        {
            foreach (CambioEstadoRT cambio in cambiosEstadoRT)
            {
                if (cambio.esActual()) 
                {
                    if (cambio.esDisponible()) 
                    {
                        return true;
                    }
                }
            }
            return false;
        
        }
        public (int, String, String, String) obtenerDatos()
        {
            return (numeroRT, tipoRecurso.Nombre, modelo.Nombre, modelo.Marca.Nombre);
        }
        public List<Turno> obtenerTurnosCancelablesYReservados(DateTime fechaFinMantenimiento)
        {
            List<Turno> resultado = new List<Turno>();

            foreach (Turno turno in turnos)
            {
                if (turno.esCancelableEnPeriodoYReservado(fechaFinMantenimiento))
                {
                    resultado.Add(turno);
                }
            }
            return resultado;
        }
        public void ingresarAMantenimientoCorrectivo(DateTime fechaHoraInicio, DateTime fechaHoraFin, 
            string motivoMantenimiento, Estado proximoEstadoRT)
        {
            crearMantenimiento(fechaHoraInicio, fechaHoraFin, motivoMantenimiento);
            crearCambioEstadoRT(fechaHoraFin,proximoEstadoRT);
        }
        public void crearMantenimiento(DateTime fechaHoraInicio, DateTime fechaHoraFin, string motivoMantenimiento)
        {
            Mantenimiento nuevoMantenimiento = new Mantenimiento(fechaHoraInicio, fechaHoraFin, motivoMantenimiento);
            mantenimientos.Add(nuevoMantenimiento);
        }
        public void crearCambioEstadoRT(DateTime fechaHoraInicioMantenimiento, Estado estado)
        {
            foreach (CambioEstadoRT cambio in cambiosEstadoRT)
            {
                if (cambio.esActual())
                {
                    cambio.FechaHoraHasta = fechaHoraInicioMantenimiento;
                    break;
                }
            }
            
            CambioEstadoRT nuevoCambioEstadoRT= new CambioEstadoRT(fechaHoraInicioMantenimiento, estado);
            cambiosEstadoRT.Add(nuevoCambioEstadoRT);
        }
        public void cancelarTurnos(List<Turno> turnosACancelar, Estado estado, DateTime fechaHoraHasta)
        {
            foreach (Turno turno in turnosACancelar)
            {
                turno.cancelarPorMantenimiento( fechaHoraHasta, estado);
            }
        }
        #endregion
    }

}
