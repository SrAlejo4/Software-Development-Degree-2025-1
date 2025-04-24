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
    public partial class RecuperarClave : Form
    {
        public RecuperarClave()
        {
            InitializeComponent();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            SqlConnection objConector1 = DB.conectar("Empresa");
            if (objConector1 == null)
            {
                MessageBox.Show("Error de conexión . . .");
            }
            else
            {
                if (string.IsNullOrEmpty(txUsuario.Text))
                {
                    MessageBox.Show("Debe ingresar un usuario . . .");
                }
                else
                {
                    string instruccion = "select * from usuarios " +
                                                    "where nombre = '" + txUsuario.Text + "'";

                    SqlDataReader objTabla = DB.consulta(instruccion, objConector1);

                    if (objTabla.Read())
                    {
                        showPregunta.Visible = true;
                        labelPregunta.Visible = true;
                        respuestaLabel.Visible = true;
                        txRespuesta.Visible = true;
                        btEnviar.Visible = true;
                        showPregunta.Text = objTabla["pregunta"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No existe usuario");
                    }
                }
            }
            objConector1.Close();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            SqlConnection objConector2 = DB.conectar("Empresa");
            if (objConector2 == null)
            {
                MessageBox.Show("Error de conexión . . .");
            }
            else
            {
                if (string.IsNullOrEmpty(txRespuesta.Text))
                {
                    MessageBox.Show("Debe ingresar una respuesta . . .");
                }
                else
                {
                    string instruccion = "select * from usuarios " +
                                                    "where nombre = '" + txUsuario.Text + "'";

                    SqlDataReader objTabla = DB.consulta(instruccion, objConector2);

                    if (objTabla.Read())
                    {
                        if (txRespuesta.Text == objTabla["respuesta"].ToString())
                        {
                            labelContrasena.Visible = true;
                            showContrasena.Visible = true;

                            showContrasena.Text = objTabla["clave"].ToString();
                        }
                        else 
                        {
                            MessageBox.Show("Respuesta incorrecta.");
                            txRespuesta.Clear();
                        }
                    }
                }
            }
            objConector2.Close();
        }
    }
}
