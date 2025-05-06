using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3AGS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login objLogin = new Login();
            objLogin.Show();
        }

        private void registroProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoProgramador objNuevoProgramador = new NuevoProgramador();
            objNuevoProgramador.MdiParent = this;
            objNuevoProgramador.Show();
        }

        private void recodarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecuperarClave objRecuperarClave = new RecuperarClave();
            objRecuperarClave.MdiParent = this;
            objRecuperarClave.Show();
        }

        private void eliminarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarAplicacion objElimianarAplicacion = new EliminarAplicacion();
            objElimianarAplicacion.MdiParent = this;
            objElimianarAplicacion.Show();
        }
    }
}
