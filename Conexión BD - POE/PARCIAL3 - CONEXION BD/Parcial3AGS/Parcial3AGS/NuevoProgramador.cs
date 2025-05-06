using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3AGS
{
    public partial class NuevoProgramador : Form
    {
        public NuevoProgramador()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txCedula.Clear();
            txNombre.Clear();
            txArea.Clear();
            txSalario.Clear();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection objConector1 = DB.conectar("Empresa");
                string instruccion = "insert into programadores values (" +
                txCedula.Text + ", '" + txNombre.Text + "' , '" + txArea.Text + "'," + txSalario.Text + ")";

                int n = DB.operar(instruccion, objConector1);
                if (n > 0)
                {
                    MessageBox.Show("Programador registrado con éxito.");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar programador.");
                }
                objConector1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión " + ex.Message);
            }
        }
    }
}
