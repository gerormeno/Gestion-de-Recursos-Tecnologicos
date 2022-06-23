using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Recursos_Tecnológicos.Entidades
{
    public class AsignacionResponsableTecnicoRT
    {
        #region Atributos
        private DateTime fechaHoraDesde;
        private DateTime? fechaHoraHasta;
        private List<RecursoTecnologico> recursosTecnologicos;
        private PersonalCientifico cientifico;
        #endregion

        #region Métodos de seteo
        public DateTime FechaHoraDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        public DateTime? FechaHoraHasta { get => fechaHoraHasta; set => fechaHoraHasta = value; }
        public List<RecursoTecnologico> RecursosTecnologicos { get => recursosTecnologicos; set => recursosTecnologicos = value; }
        public PersonalCientifico Cientifico { get => cientifico; set => cientifico = value; }
        #endregion

        #region Métodos
        public bool esDeUsuarioLogueadoYVigente(PersonalCientifico cientificoLogueado) 
        {
            if (cientificoLogueado.Nombre == cientifico.Nombre && esVigente())
            {
                return true;
            }
            return false;
        }
        public bool esVigente() 
        {
            if (fechaHoraHasta == null) { return true; }
            return false;
        }
        public (List<int>, List<String>, List<String>, List<String>) obtenerDatosRTsDisponibles()
        {
            List<RecursoTecnologico> rtsDisp = obtenerRTsDisponibles();
            return (obtenerDatosRT(rtsDisp));
        }
        public List<RecursoTecnologico> obtenerRTsDisponibles() 
        {
            List<RecursoTecnologico> recursosDisponibles = new List<RecursoTecnologico>();
            foreach (RecursoTecnologico recurso in recursosTecnologicos)
            {
                if (recurso.esDisponible()) 
                {
                    recursosDisponibles.Add(recurso);
                }
            }
            return recursosDisponibles;
        }
        public (List<int>, List<string>, List<string>, List<string>) obtenerDatosRT(List<RecursoTecnologico> recursos)
        {
            List<int> numeros = new List<int>();
            List<string> tipos = new List<string>();
            List<string> marcas = new List<string>();
            List<string> modelos = new List<string>();

            foreach (RecursoTecnologico recurso in recursos)
            {
                (int num, String tipo, String modelo, String marca) = recurso.obtenerDatos();

                numeros.Add(num);
                tipos.Add(tipo);
                modelos.Add(modelo);
                marcas.Add(marca);
            }

            return (numeros, tipos, marcas, modelos);

        }
        #endregion
    }
}
