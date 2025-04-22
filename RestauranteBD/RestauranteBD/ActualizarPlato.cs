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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestauranteBD
{
    public partial class ActualizarPlato : Form
    {
        public ActualizarPlato()
        {
            InitializeComponent();
        }

        private void ActualizarPlato_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet.chef' table. You can move, or remove it, as needed.
            this.chefTableAdapter.Fill(this.restauranteDataSet.chef);

        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection objConector1 = DB.conectar("Restaurante");
                string instruccion = "select * from platos where id = " + txCodigo.Text;
                SqlCommand objComando = new SqlCommand(instruccion, objConector1);
                SqlDataReader objTabla = objComando.ExecuteReader();

                try
                {
                    if (objTabla.Read())
                    {
                        txNombre.Text = objTabla[1].ToString();
                        txValor.Text = objTabla["valor"].ToString();
                        cbCodChef.SelectedValue = objTabla[3].ToString();

                        txCodigo.Enabled = false;
                        txNombre.Enabled = true;
                        txValor.Enabled = true;
                        cbCodChef.Enabled = true;
                        btGuardar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El plato no se encuentra registrado.");
                        limpiar();
                    }
                    objConector1.Close();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error de operación " + er.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión " + ex.Message);
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection objConector2 = DB.conectar("Restaurante");
            int cod = Int32.Parse(cbCodChef.SelectedValue.ToString());
            string instruccion = $"update platos set nombre = '{txNombre.Text}', " +
                                            $"valor  = {Double.Parse(txValor.Text)}, codigo_chef = {cod} where id = {Int32.Parse(txCodigo.Text)}";

            int n = DB.operar(instruccion, objConector2);
            if (n > 0)
            {
                MessageBox.Show("Plato editado con éxito");
                limpiar();
            }
            else
            {
                MessageBox.Show("No se editó el plato");
                limpiar();
            }
            objConector2.Close();
        }

        public void limpiar() 
        {
            txNombre.Clear();
            txValor.Clear();
            txCodigo.Enabled = true;
            txCodigo.Clear();
            txCodigo.Focus();
        }

    }
}
