using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteBD
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void consultarPorCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conCodigo objPlato = new conCodigo();
            objPlato.MdiParent = this;
            objPlato.Show();
        }

        private void nuevoPlatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoPlato objNuevoPlato = new NuevoPlato();
            objNuevoPlato.MdiParent = this;
            objNuevoPlato.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Restaurante login = new Restaurante();
            login.Show();
        }
    }
}
