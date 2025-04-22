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
    public partial class Saludo : Form
    {
        public Saludo()
        {
            InitializeComponent();
        }

        private void Saludo_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al programa Saludo . . .");
        }

        string nombre = "";
        private void btnSaludar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            lblMensaje.Text = nombre + ", bienvenido a la programación POE";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            lblMensaje.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btJuego_Click(object sender, EventArgs e)
        {
            Juego objJuego = new Juego(nombre);
            objJuego.Show();
        }
    }
}
