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
    public partial class Computadores : Form
    {
        public Computadores()
        {
            InitializeComponent();
            txSalidaComputadores.Text = "\tCedula " + "\tNombre" + "\tApellido" + "\tTélefono " +
                                                        "\tMarca" + "\tSistema Operativo" + "\tProcesador" + "\tTiempo Préstamo\r\n";
        }

        public void agregarTxSalidaComputadores(string texto)
        {
            txSalidaComputadores.AppendText(texto);
        }
    }
}
