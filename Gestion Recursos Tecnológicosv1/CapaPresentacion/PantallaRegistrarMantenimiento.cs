using Gestion_Recursos_Tecnológicos.CapaPresentacion;
using Gestion_Recursos_Tecnológicos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Recursos_Tecnológicos
{
    public partial class PantallaRegistrarMantenimiento : Form
    {
        #region Atributos
        GestorRegistrarMantenimiento gestor;
        int numeroRTSeleccionado = 0;
        DateTime fechaFinSeleccionada;
        int indiceFila;
        #endregion

        #region Métodos

        // El siguiente método es el equivalente a habilitarPantalla():
        private void PantallaRegistrarMantenimiento_Load(object sender, EventArgs e)
        {
            gestor = new GestorRegistrarMantenimiento();
            gestor.Pantalla = this;

            gestor.registrarMantenimientoCorrectivo();
            lblUsuarioLogueado.Text = "Usuario logueado: " + gestor.CientificoLogueado.obtenerNombreCompleto();
            lblFechaActual.Text = "Fecha: " + DateTime.Now.ToShortDateString();
            grillaRecursosTecnologicos.CurrentCell.Selected = false;
            calendario.Enabled = false;
            txtRazonMantenimiento.Enabled = false;
        }
        public void tomarSeleccionRT(int numeroRTSeleccionado)
        {
            gestor.tomarSeleccionRT(numeroRTSeleccionado);
        }
        private void tomarFechaFinIngresada()
        {
            fechaFinSeleccionada = Convert.ToDateTime(calendario.SelectionStart);
            gestor.tomarFechaFin(fechaFinSeleccionada);
        }
        private void tomarRazonMantenimiento()
        {
            gestor.tomarRazonMantenimiento(txtRazonMantenimiento.Text);
        }
        public void pedirSeleccionRT(List<int> numeros, List<string> tipos, List<string> modelos, List<string> marcas)
        {
            for (int i = 0; i < numeros.Count(); i++)
            {
                grillaRecursosTecnologicos.Rows.Add(numeros[i], tipos[i],
                    marcas[i], modelos[i]);
            }
        }
        public void pedirFechaFinMantenimiento()
        {
            calendario.Enabled = true;
        }
        public void pedirRazonMantenimiento()
        {
            txtRazonMantenimiento.Enabled = true;
        }
        public void mostrarTurnos(List<PersonalCientifico> cientificos, List<Turno> turnos)
        {
            for (int i = 0; i < turnos.Count(); i++)
            {
                grillaTurnosACancelar.Rows.Add(numeroRTSeleccionado, cientificos[i].obtenerNombreCompleto(), turnos[i].FechaHoraInicio);
                grillaTurnosACancelar.CurrentCell.Selected = false;
            }
        }
        public bool tomarConfirmacionIngresoMantenimiento()
        {
            var confirmacion = MessageBox.Show("¿Está seguro de que desea registrar ingreso en mantenimiento?\n" +
                    "Número de RT: " + numeroRTSeleccionado + "\nFecha prevista de fin de mantenimiento: " +
                    fechaFinSeleccionada.ToShortDateString() + "\nSe cancelarán " + grillaTurnosACancelar.Rows.Count +
                    " turnos y se informará a los científicos solicitantes.", "Confirmar ingreso en mantenimiento",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        public void verificarBotonConfirmacion()
        {
            if (numeroRTSeleccionado != 0 &&
                fechaFinSeleccionada != null &&
                txtRazonMantenimiento.Text != "")
            {
                pedirConfirmacionIngresoMantenimiento();
            }
        }
        public void pedirConfirmacionIngresoMantenimiento()
        {
            btnIngresarAMantenimiento.Enabled = true;
        }
        #endregion

        #region Eventos de la pantalla
        private void btnIngresarAMantenimiento_Click(object sender, EventArgs e)
        {
            if (numeroRTSeleccionado != 0 &&
                fechaFinSeleccionada != null &&
                txtRazonMantenimiento.Text != "")
            {
                if (tomarConfirmacionIngresoMantenimiento())
                {
                    tomarFechaFinIngresada();
                    tomarRazonMantenimiento();
                    gestor.generarIngresoAMantenimiento();
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Primero debe ingresar todos los datos solicitados.", "Atención!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grillaRecursosTecnologicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) // si se hizo click en la grilla
            {
                int indice = e.RowIndex;
                numeroRTSeleccionado = Convert.ToInt32(grillaRecursosTecnologicos.Rows[indice].Cells[0].Value.ToString());

                tomarSeleccionRT(numeroRTSeleccionado);
                pedirFechaFinMantenimiento();
                pedirRazonMantenimiento();
                verificarBotonConfirmacion();
                actualizarGrillaTurnos();
            }
        }

        private void grillaRecursosTecnologicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) // si se hizo click en la grilla
            {
                int indice = e.RowIndex;
                numeroRTSeleccionado = Convert.ToInt32(grillaRecursosTecnologicos.Rows[indice].Cells[0].Value.ToString());

                tomarSeleccionRT(numeroRTSeleccionado);
                pedirFechaFinMantenimiento();
                pedirRazonMantenimiento();
                verificarBotonConfirmacion();
                actualizarGrillaTurnos();
            }
        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            tomarFechaFinIngresada();
            verificarBotonConfirmacion();
            actualizarGrillaTurnos();
        }

        private void txtRazonMantenimiento_TextChanged(object sender, EventArgs e)
        {
            verificarBotonConfirmacion();
        }
        #endregion

        #region Métodos Extras

        public PantallaRegistrarMantenimiento()
        {
            InitializeComponent();
        }
        public void limpiarCampos()
        {
            txtRazonMantenimiento.Text = "";
            calendario.SelectionStart = DateTime.Today;
            grillaTurnosACancelar.Rows.Clear();
            eliminarFila();
        }
        public void actualizarGrillaTurnos()
        {
            grillaTurnosACancelar.Rows.Clear();
            if (calendario.SelectionStart != null && grillaRecursosTecnologicos.CurrentCell.Selected != false)
            {
                gestor.obtenerReservasVigentes();
            }
            else
            {
                MessageBox.Show("Primero debe ingresar todos los datos solicitados.", "Atención!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grillaRecursosTecnologicos_SelectionChanged(object sender, EventArgs e)
        {
            indiceFila = grillaRecursosTecnologicos.CurrentCell.RowIndex;
        }
        public void eliminarFila()
        {
            grillaRecursosTecnologicos.Rows.RemoveAt(indiceFila);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal ventana = new MenuPrincipal();
            ventana.Show();
            this.Close();
        }
    }
    #endregion
}
