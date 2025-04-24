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
using System.Windows.Forms.VisualStyles;

namespace Parcial3AGS
{
    public partial class EliminarAplicacion : Form
    {
        public EliminarAplicacion()
        {
            InitializeComponent();
        }

        private void limpiar() 
        {
            txTipo.Clear();
            txTiempoDias.Clear();
            txProgramador.Clear();
            txCodigo.Focus();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection objConector1 = DB.conectar("Empresa");
                string instruccion = "select * from aplicacion app inner join programadores pro " +
                                               "on app.programador = pro.cedula " +
                                               "where app.codigo = " + txCodigo.Text;
                SqlCommand objComando = new SqlCommand(instruccion, objConector1);
                SqlDataReader objTabla = objComando.ExecuteReader();

                try
                {
                    if (objTabla.Read())
                    {
                        txTipo.Text = objTabla["tipo"].ToString();
                        txTiempoDias.Text = objTabla["tiempo_dias"].ToString();
                        txProgramador.Text = objTabla["nombre"].ToString();
                        btEliminar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("La aplicación no se encuentra registrada.");
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

        private void btEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection objConector2 = DB.conectar("Empresa");
            string instruccion = "delete from aplicacion where codigo = " + txCodigo.Text;
            int n = DB.operar(instruccion, objConector2);
            if (n > 0)
            {
                MessageBox.Show("Aplicación ELIMINADA con éxito");
                limpiar();
            }
            else
            {
                MessageBox.Show("No se eliminó la aplicación");
            }
            objConector2.Close();
        }
    }
}
