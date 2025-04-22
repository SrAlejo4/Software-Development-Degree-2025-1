using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Importamos libreria SqlClient

namespace RestauranteBD
{
    public partial class Restaurante : Form
    {
        public Restaurante()
        {
            InitializeComponent();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            SqlConnection objConector = DB.conectar("Restaurante");
            if (objConector == null) // si no hubo conexión, si hubo un error 
            {
                MessageBox.Show("Error de conexión . . .");
            }
            else 
            {
                if (string.IsNullOrEmpty(txUsuario.Text) || string.IsNullOrEmpty(txClave.Text))
                {
                    MessageBox.Show("Debe ingresar todos los datos . . .");
                }
                else 
                {
                    string instruccion = "select * from usuarios " + 
                                                    "where usuario = '"+txUsuario.Text+"'";

                    SqlDataReader objTabla = DB.consulta(instruccion, objConector); // Se le envía la instrucción SQL
                                                                                    // y el conector con la BD
                    if (objTabla.Read())
                    {
                        if (txClave.Text == objTabla["clave"].ToString())
                        {
                            Menu objMenu = new Menu();
                            this.Hide();
                            objMenu.Show();
                        }
                        else 
                        {
                            MessageBox.Show("Usuario o clave incorrecto");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Usuario o clave incorrecto");
                    }
                }
            }
            objConector.Close();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
