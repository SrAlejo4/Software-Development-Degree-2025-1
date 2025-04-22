using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Juego : Form
    {
        string nombre = "";
        public Juego()
        {
            InitializeComponent();
        }

        public Juego(string nombre) 
        {
            InitializeComponent();
            this.nombre = nombre;
            this.Text = "Programa Juego-" + nombre;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {       

        }

        private int numAzar = 0;
        private void btNuevo_Click(object sender, EventArgs e)
        {
            Random objR = new Random();
            numAzar = objR.Next(1, 11);
            btNuevo.Enabled = false;
            btJugar.Enabled = true;
            lbMensaje.Text = "";
            pbImagen.Visible = false;
            txNumero.Clear();
            txNumero.Focus();
        }

        private void btJugar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Int32.Parse(txNumero.Text);
                if (num == numAzar)
                {
                    lbMensaje.Text = "Felicitaciones, adivinaste el número";
                    pbImagen.Visible = true;
                    btJugar.Enabled = false;
                    btNuevo.Enabled = true;
                }
                else 
                {
                    lbMensaje.Text = "Sigue intentando . . .";
                    pbImagen.Visible = false;
                    txNumero.Clear();
                    txNumero.Focus();
                }

            }
            catch
            {
                lbMensaje.Text = "Error, valor no válido " + txNumero.Text;
            }

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Color objC;

        private void btJugar_Enter(object sender, EventArgs e)
        {
            objC = btJugar.BackColor;
            btJugar.BackColor = Color.LightCyan;
        }

        private void btJugar_Leave(object sender, EventArgs e)
        {
            btJugar.BackColor = objC;
        }
    }
}
