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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void limpiar() 
        {
            txUsuario.Clear();
            txClave.Clear();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            SqlConnection objConector = DB.conectar("Empresa");
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
                                                    "where nombre = '" + txUsuario.Text + "'";

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
                            limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o clave incorrecto");
                        limpiar();
                    }
                }
            }
            objConector.Close();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // RECORDAR CLAVE
            RecuperarClave objRecuperarClave = new RecuperarClave();
            objRecuperarClave.Show();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
