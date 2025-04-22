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
    public partial class Empleado : Form
    {
        private string nombre = "";
        private double salarioBasico = 0;
        private double deducciones = 0;
        private double cantidadProducida = 0;
        private double bonificacion = 0;
        private double totalSalario = 0;

        public Empleado()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            salarioBasico = Double.Parse(txSalario.Text);
            deducciones = salarioBasico * 0.083;

            if (Double.Parse(txCantidad.Text) > 100) 
            {
                bonificacion = salarioBasico * 0.15;
            }
            if (Double.Parse(txCantidad.Text) > 75 && Double.Parse(txCantidad.Text) < 100)
            {
                bonificacion = salarioBasico * 0.10;
            }
            if (Double.Parse(txCantidad.Text) > 50 && Double.Parse(txCantidad.Text) < 75)
            {
                bonificacion = salarioBasico * 0.05;
            }

            if (rbSindicato.Checked) 
            {
                deducciones += 20000;
            }

            totalSalario = (salarioBasico + bonificacion) - deducciones;

            if (bonificacion != 0) 
            {
                MessageBox.Show("El empleado tiene una bonificación " +
                                            "de $" + bonificacion);
            }

            MessageBox.Show("Nombre del empleado: " + txNombre.Text +
                                        "\nSalario básico del empleado: $" + salarioBasico + 
                                        "\nBonificación: $" + bonificacion + 
                                        "\nDeducciones: $" + deducciones + 
                                        "\nEl total a pagar es: $" + totalSalario);

        }
    }
}
