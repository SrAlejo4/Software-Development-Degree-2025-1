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
using System.Windows.Forms.VisualStyles;

namespace RestauranteBD
{
    public partial class EliminarPlato : Form
    {
        SqlConnection objConector = DB.conectar("Restaurante");
        public EliminarPlato()
        {
            InitializeComponent();
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
                        txCodigoChef.Text = objTabla[3].ToString();
                        btEliminar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El plato no se encuentra registrado.");
                        txNombre.Clear();
                        txValor.Clear();
                        txCodigoChef.Clear();
                        txCodigo.Focus();
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
        } // Fin btConsultar

        private void btEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection objConector2 = DB.conectar("Restaurante");
            string instruccion = "delete from platos where id = " + txCodigo.Text;
            int n = DB.operar(instruccion, objConector2);
            if (n > 0) 
            {
                MessageBox.Show("Plato ELIMINADO con éxito");
                txNombre.Clear();
                txValor.Clear();
                txCodigoChef.Clear();
                txCodigo.Focus();
            }
            else
            {
                MessageBox.Show("No se eliminó el plato");
            }
            objConector2.Close();
        }// Fin btBorrar

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
