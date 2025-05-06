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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void hacerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnSaludo_Click(object sender, EventArgs e)
        {
            Saludo();
        }

        private void bhSaludo_Click(object sender, EventArgs e)
        {
            Saludo();
        }

        private void Saludo() 
        {
            Saludo objSaludo = new Saludo();
            objSaludo.MdiParent = this;
            objSaludo.Show();
        }

        private void mnJuego_Click(object sender, EventArgs e)
        {
            Juego objJuego = new Juego();
            objJuego.MdiParent = this;
            objJuego.Show();
        }

        private void mnCaja_Click(object sender, EventArgs e)
        {
            Caja objCaja = new Caja(); 
            objCaja.MdiParent = this;
            objCaja.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void programasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
