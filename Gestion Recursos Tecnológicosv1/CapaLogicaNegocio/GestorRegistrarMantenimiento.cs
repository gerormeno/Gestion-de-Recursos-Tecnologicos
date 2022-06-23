using Gestion_Recursos_Tecnológicos.Acceso_a_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Recursos_Tecnológicos.Entidades
{
    public class GestorRegistrarMantenimiento
    {
        #region Atributos
        private PantallaRegistrarMantenimiento pantalla;
        private DateTime fechaHoraInicioMantenimiento;
        private DateTime fechaHoraFinMantenimiento;
        private List<PersonalCientifico> cientificosANotificar;
        private List<Turno> turnosDelRTACancelar;
        private Estado proximoEstadoRT;
        private Estado proximoEstadoTurno;
        private String razonMantenimiento;
        private RecursoTecnologico recursoTecnologicoSeleccionado;
        private PersonalCientifico cientificoLogueado;
        private AsignacionResponsableTecnicoRT asignacionLogueadoVigente;
        private Sesion sesionActiva;
        private List<int> listaNumerosRecursosDisp;
        private List<String> listaTiposRecursosDisp;
        private List<String> listaModelosRecursosDisp;
        private List<String> listaMarcasRecursosDisp;
        #endregion

        #region Métodos de seteo
        public DateTime FechaInicioMantenimiento { get => fechaHoraInicioMantenimiento; set => fechaHoraInicioMantenimiento = value; }
        public DateTime FechaFinMantenimiento { get => fechaHoraFinMantenimiento; set => fechaHoraFinMantenimiento = value; }
        public List<PersonalCientifico> CientificosANotificar { get => cientificosANotificar; set => cientificosANotificar = value; }
        public List<Turno> TurnosDelRTACancelar { get => turnosDelRTACancelar; set => turnosDelRTACancelar = value; }
        public Estado ProximoEstadoRT { get => proximoEstadoRT; set => proximoEstadoRT = value; }        public Estado ProximoEstadoTurno { get => proximoEstadoTurno; set => proximoEstadoTurno = value; }
        public string RazonMantenimiento { get => razonMantenimiento; set => razonMantenimiento = value; }
        public RecursoTecnologico RecursoTecnologicoSeleccionado { get => recursoTecnologicoSeleccionado; set => recursoTecnologicoSeleccionado = value; }
        public AsignacionResponsableTecnicoRT AsignacionLogueadoVigente { get => asignacionLogueadoVigente; set => asignacionLogueadoVigente = value; }
        public Sesion SesionActiva { get => sesionActiva; set => sesionActiva = value; }
        public List<int> ListaNumerosRecursosDisp { get => listaNumerosRecursosDisp; set => listaNumerosRecursosDisp = value; }
        public List<string> ListaModelosRecursosDisp { get => listaModelosRecursosDisp; set => listaModelosRecursosDisp = value; }
        public List<string> ListaMarcasRecursosDisp { get => listaMarcasRecursosDisp; set => listaMarcasRecursosDisp = value; }
        public List<string> ListaTiposRecursosDisp { get => listaTiposRecursosDisp; set => listaTiposRecursosDisp = value; }
        public PantallaRegistrarMantenimiento Pantalla { get => pantalla; set => pantalla = value; }
        public PersonalCientifico CientificoLogueado { get => cientificoLogueado; set => cientificoLogueado = value; }
        #endregion

        #region Métodos
        public void registrarMantenimientoCorrectivo()
        {
            obtenerRecursosTecnologicosDisp();
        }
        public void obtenerRecursosTecnologicosDisp()
        //desencadena una seguidilla de metodos del foco de control
        {
            obtenerDatosDesdeBD();
            obtenerSesionActiva();
            obtenerUsuarioLogueado();
            obtenerDatosRTsDisponibles();
            agruparPorTipoRecurso();
            pantalla.pedirSeleccionRT(listaNumerosRecursosDisp, listaTiposRecursosDisp,
                listaModelosRecursosDisp, listaMarcasRecursosDisp);
        }
        public void obtenerSesionActiva()

        {
            foreach (Sesion sesion in sesiones)
            {
                if (sesion.FechaHoraHasta == null)
                {
                    sesionActiva = sesion;
                }
            }
        }
        public void obtenerUsuarioLogueado()
        {
            cientificoLogueado = sesionActiva.obtenerCientificoLogueado();
        }
        public void obtenerDatosRTsDisponibles()
        {
            foreach (AsignacionResponsableTecnicoRT asig in asignacionesResp)
            {
                if (asig.esDeUsuarioLogueadoYVigente(cientificoLogueado))
                {
                    (listaNumerosRecursosDisp, listaTiposRecursosDisp, listaMarcasRecursosDisp,
                        listaModelosRecursosDisp) = asig.obtenerDatosRTsDisponibles();
                }
            }
        }
        public void agruparPorTipoRecurso()
        {
            int[] numeros = listaNumerosRecursosDisp.ToArray();
            string[] tipos = listaTiposRecursosDisp.ToArray();
            string[] modelos = listaModelosRecursosDisp.ToArray();
            string[] marcas = listaMarcasRecursosDisp.ToArray();

            int i, j;
            int n = tipos.Length;

            for (j = n - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (tipos[i].CompareTo(tipos[i + 1]) > 0)
                    {
                        (numeros[i], numeros[i + 1]) = (numeros[i + 1], numeros[i]);
                        (tipos[i], tipos[i + 1]) = (tipos[i + 1], tipos[i]);
                        (modelos[i], modelos[i + 1]) = (modelos[i + 1], modelos[i]);
                        (marcas[i], marcas[i + 1]) = (marcas[i + 1], marcas[i]);
                    }
                }
            }
            listaNumerosRecursosDisp = numeros.ToList<int>();
            listaTiposRecursosDisp = tipos.ToList<string>();
            listaModelosRecursosDisp = modelos.ToList<string>();
            listaMarcasRecursosDisp = marcas.ToList<string>();
        }
        public void tomarSeleccionRT(int numeroRTSeleccionado)
        {
            foreach (RecursoTecnologico recurso in recursosTecnologicos)
            {
                if (recurso.NumeroRT == numeroRTSeleccionado)
                {
                    recursoTecnologicoSeleccionado = recurso;
                    break;
                }
            }
        }
        public void tomarFechaFin(DateTime fechaFin)
        {
            fechaHoraFinMantenimiento = fechaFin;
        }
        public void tomarRazonMantenimiento(string razonMant)
        {
            razonMantenimiento = razonMant;
        }
        public void obtenerReservasVigentes()
        {
            turnosDelRTACancelar = recursoTecnologicoSeleccionado.obtenerTurnosCancelablesYReservados(fechaHoraFinMantenimiento);
            obtenerDatosTurnos();
            agruparTurnosPorCientifico();
            pantalla.mostrarTurnos(cientificosANotificar, turnosDelRTACancelar);
        }
        public void obtenerDatosTurnos()
        {
            List<PersonalCientifico> listaPersonal = new List<PersonalCientifico>();
            foreach (Turno turno in turnosDelRTACancelar)
            {
                listaPersonal.Add(obtenerCientificoDeTurno(turno));
            }
            cientificosANotificar = listaPersonal;
        }
        public PersonalCientifico obtenerCientificoDeTurno(Turno turno)
        {
            foreach (AsignacionCientificoDelCI asignacion in asignacionesCientif)
            {
                if (asignacion.esTuTurno(turno))
                {
                    return asignacion.Cientifico;
                }
            }
            return null;
        }
        public void agruparTurnosPorCientifico()
        {
            PersonalCientifico[] cientificos = cientificosANotificar.ToArray();
            Turno[] turnos = turnosDelRTACancelar.ToArray();

            int i, j;
            int n = turnos.Length;

            for (j = n - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (cientificos[i].Apellido.CompareTo(cientificos[i + 1].Apellido) > 0)
                    {
                        (cientificos[i], cientificos[i + 1]) = (cientificos[i + 1], cientificos[i]);
                        (turnos[i], turnos[i + 1]) = (turnos[i + 1], turnos[i]);
                    }
                }
            }
            cientificosANotificar = cientificos.ToList<PersonalCientifico>();
            turnosDelRTACancelar = turnos.ToList<Turno>();
        }
        public void generarIngresoAMantenimiento()
        {
            buscarEstadosParaCreacion();
            obtenerFechaHoraActual();
            recursoTecnologicoSeleccionado.ingresarAMantenimientoCorrectivo(fechaHoraInicioMantenimiento,
                fechaHoraFinMantenimiento, razonMantenimiento, proximoEstadoRT);
            recursoTecnologicoSeleccionado.cancelarTurnos(turnosDelRTACancelar, proximoEstadoTurno, fechaHoraInicioMantenimiento);
            insertarEnBD();
            generarMailsNotificacion();
            // finCU();
        }
        public void buscarEstadosParaCreacion()
        {
            foreach (Estado estado in estados)
            {
                if (estado.Ambito == "Turno" && estado.Nombre == "Cancelado")
                {
                    proximoEstadoTurno = estado;
                }
                if (estado.Ambito == "Recurso Tecnologico" &&
                    estado.Nombre == "Ingresado a Mantenimiento Correctivo")
                {
                    proximoEstadoRT = estado;
                }
            }
        }
        public void obtenerFechaHoraActual()
        {
            fechaHoraInicioMantenimiento = DateTime.Now;
        }
        public void generarMailsNotificacion()
        {
            string resultado = "El recurso tecnológico fue ingresado a mantenimiento correctivo.\n" +
                "Se notificó via mail a todos los científicos cuyos turnos fueron cancelados.\n\n" +
                "Cientificos notificados:\n";
            List<PersonalCientifico> lista = cientificosANotificar.Distinct().ToList();
            foreach (PersonalCientifico cientifico in lista)
            {
                resultado += cientifico.obtenerNombreCompleto() + " - " + cientifico.CorreoElectronicoInstitucional + "\n";
            }
            MessageBox.Show(resultado, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void generarWhatsAppNotificacion()
        {
            string resultado = "El recurso tecnológico fue ingresado a mantenimiento correctivo.\n" +
                "Se notificó via WhatsApp a todos los científicos cuyos turnos fueron cancelados.\n\n" +
                "Cientificos notificados:\n";
            List<PersonalCientifico> lista = cientificosANotificar.Distinct().ToList();
            foreach (PersonalCientifico cientifico in lista)
            {
                resultado += cientifico.obtenerNombreCompleto() + "\n";
            }
            MessageBox.Show(resultado, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // public void finCU()
        // {
        //    // este metodo se encarga de limpiar la RAM utilizada durante la ejecucion del CU. 
        // }

        #endregion

        #region Listas que almacenan los datos de la BD para ser recorridos
        private List<AsignacionCientificoDelCI> asignacionesCientif;
        private List<AsignacionResponsableTecnicoRT> asignacionesResp;
        private List<CambioEstadoRT> cambiosEstadoRT;
        private List<CambioEstadoTurno> cambiosEstadoTurno;
        private List<Estado> estados;
        private List<Mantenimiento> mantenimientos;
        private List<Marca> marcas;
        private List<Modelo> modelos;
        private List<PersonalCientifico> cientificos;
        private List<RecursoTecnologico> recursosTecnologicos;
        private List<Sesion> sesiones;
        private List<TipoRecursoTecnologico> tiposRecursoTecnologico;
        private List<Turno> turnos;
        private List<Usuario> usuarios;
        #endregion

        #region Métodos de persistencia
        public void obtenerDatosDesdeBD()
        // recupera TODOS los objetos de la BD con sus relaciones.
        {
            sesiones = AD_Sesion.mapearDesdeBD();
            usuarios = AD_Usuario.mapearDesdeBD();
            marcas = AD_Marca.mapearDesdeBD();
            modelos = AD_Modelo.mapearDesdeBD();
            estados = AD_Estado.mapearDesdeBD();
            tiposRecursoTecnologico = AD_TipoRecursoTecnologico.mapearDesdeBD();
            turnos = AD_Turno.mapearDesdeBD();
            recursosTecnologicos = AD_RecursoTecnologico.mapearDesdeBD();
            cambiosEstadoRT = AD_CambioEstadoRT.mapearDesdeBD();
            cambiosEstadoTurno = AD_CambioEstadoTurno.mapearDesdeBD();
            mantenimientos = AD_Mantenimiento.mapearDesdeBD();
            cientificos = AD_PersonalCientifico.mapearDesdeBD();
            asignacionesCientif = AD_AsignacionCientificoDelCI.mapearDesdeBD();
            asignacionesResp = AD_AsignacionResponsableTecnicoRT.mapearDesdeBD();
            recursosTecnologicos = AD_RecursoTecnologico.mapearDesdeBD();
        }
        public void insertarEnBD() // se comunica con la capa de persistencia Acceso a Datos e inserta las nuevas instancias
        {
            AD_Mantenimiento.altaMantenimiento(fechaHoraInicioMantenimiento, fechaHoraFinMantenimiento
                , razonMantenimiento, recursoTecnologicoSeleccionado);

            AD_CambioEstadoRT.cargarFechaHoraFin(fechaHoraInicioMantenimiento, recursoTecnologicoSeleccionado.NumeroRT);
            AD_CambioEstadoRT.altaCambioEstadoRT(fechaHoraInicioMantenimiento, proximoEstadoRT, recursoTecnologicoSeleccionado.NumeroRT);

            foreach (Turno turno in turnosDelRTACancelar)
            {
                int idTurno = AD_Turno.obtenerIDTurno(recursoTecnologicoSeleccionado.NumeroRT, turno.FechaHoraInicio);

                AD_CambioEstadoTurno.cargarFechaHoraFin(fechaHoraInicioMantenimiento, idTurno);
                AD_CambioEstadoTurno.altaCambioEstadoTurno(fechaHoraInicioMantenimiento, proximoEstadoTurno, idTurno);
            }
        }
        #endregion
    }
}
