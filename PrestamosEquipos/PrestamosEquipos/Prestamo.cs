using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestamosEquipos
{
    public partial class PrestamoEquipos : Form
    {

        private Control[] formInicio;
        private Control[] computador;
        private Control[] tablet;
        Computadores objComputadores = new Computadores();
        public PrestamoEquipos()
        {
            InitializeComponent();

            //  Inicializamos el vector con los componentes del GroupBox del Inicio y de Prestamo.
            formInicio = new Control[] {cbTipoEstudiante, txCedula, txNombre, txApellido, txTelefono,
                                    txSemestre, txPromedio};
            computador = new Control[] {cbMarcaComputador, cbSO, cbProcesador, lbPrestamoComputador,
                                                        lbProcesador, lbMarcaComputador, lbSO, rbSemana, rbMes, rbTresMeses};
            tablet = new Control[] { cbMarcaTablet, cbAlmacenamiento, cbTamano, lbPrestamoTablet, 
                                                lbMarcaTablet, lbAlmacenamiento, lbTamano};
        }

        private void limpiarFormInicio() 
        {
            // Limpiamos los campos del formulario de inicio
            foreach (var elemento in formInicio)
            {
                elemento.Text = "";
            }
        }

        private void limpiarFormPrestamo() 
        {
            cbMarcaComputador.Text = ""; cbSO.Text = ""; cbProcesador.Text = "";
            cbMarcaTablet.Text = ""; cbAlmacenamiento.Text = ""; cbTamano.Text = "";
            rbMes.Checked = false; rbSemana.Checked = false; rbTresMeses.Checked = false;

            if (cbTipoEstudiante.Text == "Estudiante Ingeniería")
            {
                foreach (var elemento in computador)
                {
                    elemento.Enabled = false;
                }
            }

            if (cbTipoEstudiante.Text == "Estudiante Diseño")
            {
                foreach (var elemento in tablet)
                {
                    elemento.Enabled = false;
                }
            }
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            gbPrestamo.Visible = true;
            gbInicio.Enabled = false;
            lbNombreAppear.Text = txNombre.Text + " " + txApellido.Text;

            if (cbTipoEstudiante.Text == "Estudiante Ingeniería")
            {
                foreach (var elemento in computador)
                {
                    elemento.Enabled = true;
                }
            }

            if (cbTipoEstudiante.Text == "Estudiante Diseño")
            {
                foreach (var elemento in tablet)
                {
                    elemento.Enabled = true;
                }
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            limpiarFormPrestamo();
            gbPrestamo.Visible = false;
            limpiarFormInicio();
            gbInicio.Enabled = true;
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            foreach (var elemento in formInicio)
            {
                elemento.Text = "";
            }
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            if (cbTipoEstudiante.Text == "Estudiante Ingeniería") 
            {
                if (String.IsNullOrEmpty(cbMarcaComputador.Text) || String.IsNullOrEmpty(cbSO.Text) ||
                String.IsNullOrEmpty(cbProcesador.Text))
                {
                    MessageBox.Show("Debes elegir todas las opciones . . .");
                }
                else
                {
                    String tiempoPrestamo = "";
                    if (rbSemana.Checked) 
                    {
                        tiempoPrestamo = "1 Semana";
                    }
                    if (rbMes.Checked) 
                    {
                        tiempoPrestamo = "1 Mes";
                    }
                    if (rbTresMeses.Checked) 
                    {
                        tiempoPrestamo = "3 Meses";
                    }

                    objComputadores.agregarTxSalidaComputadores("\t" + txCedula.Text + "\t" + txNombre.Text + "\t" + txApellido.Text + "\t" +
                                              txTelefono.Text + "\t" + cbMarcaComputador.Text + "\t" + cbSO.Text + 
                                              "\t" + cbProcesador.Text + "\t" + tiempoPrestamo + "\r\n");

                    MessageBox.Show("ESTUDIANTE INGENIERÍA\r\n" + 
                                                "Préstamo Registrado con éxito");

                    limpiarFormPrestamo();
                    gbInicio.Enabled = true;
                    limpiarFormInicio();
                    gbPrestamo.Visible = false;
                }
            }

            if (cbTipoEstudiante.Text == "Estudiante Diseño") 
            {
                if (String.IsNullOrEmpty(cbMarcaTablet.Text) || String.IsNullOrEmpty(cbAlmacenamiento.Text) ||
                String.IsNullOrEmpty(cbTamano.Text))
                {
                    MessageBox.Show("Debes elegir todas las opciones . . .");
                }
                else
                {
                    MessageBox.Show("ESTUDIANTE INGENIERÍA\r\n" +
                                                "Préstamo Registrado con éxito");

                    limpiarFormPrestamo();
                    gbInicio.Enabled = true;
                    limpiarFormInicio();
                    gbPrestamo.Visible = false;
                }
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // OTRAS VENTANAS DE WINDOWS . . .

        private void btPreComputadores_Click(object sender, EventArgs e)
        {
            objComputadores.ShowDialog();
        }
    }
}
