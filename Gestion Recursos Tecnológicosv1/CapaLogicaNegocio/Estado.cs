using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Recursos_Tecnológicos.Entidades
{
    public class Estado
    {
        #region Atributos
        private String ambito;
        private String nombre;
        private Boolean esCancelable;
        private Boolean esReservable;
        #endregion

        #region Métodos de seteo
        public string Ambito { get => ambito; set => ambito = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool EsCancelable { get => esCancelable; set => esCancelable = value; }
        public bool EsReservable { get => esReservable; set => esReservable = value; }
        #endregion

        #region Métodos
        public bool esDisponible()
        {
            if (nombre == "Disponible") { return true; }
            return false;
        }
        public bool sosCancelable()
        {
            if (this.esCancelable)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool esPendienteConfirmacionReserva()
        {
            if (nombre == "Pendiente de confirmacion") { return true; }
            return false;
        }
        public bool esConfirmadoReserva()
        {
            if (nombre == "Confirmado") { return true; }
            return false;
        }
        #endregion
    }
}
