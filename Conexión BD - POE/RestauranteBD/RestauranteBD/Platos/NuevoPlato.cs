using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestauranteBD
{
    public partial class NuevoPlato : Form
    {
        public NuevoPlato()
        {
            InitializeComponent();
        }

        private void NuevoPlato_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet.chef' table. You can move, or remove it, as needed.
            this.chefTableAdapter.Fill(this.restauranteDataSet.chef);
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection objConector = DB.conectar("Restaurante");
            int cod = Int32.Parse(comboBox1.SelectedValue.ToString());
            string instruccion = "insert into platos values (" +
                txCodigo.Text + ", '" + txNombre.Text + "' , " + txValor.Text + "," + cod + ")";

            int n = DB.operar(instruccion, objConector);
            if (n > 0)
            {
                MessageBox.Show("Plato agregado con éxito");
            }
            else 
            {
                MessageBox.Show("No se agregó el plato");
            }
            objConector.Close();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
