using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2AGS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnPizza_Click(object sender, EventArgs e)
        {
            Pizza objPizza = new Pizza();
            objPizza.ShowDialog();
        }

        private void mnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado objEmpleado = new Empleado();
            objEmpleado.ShowDialog();
        }
    }
}
