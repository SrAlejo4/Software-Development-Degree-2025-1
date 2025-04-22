using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // IMPORTAMOS LIBRERIA QUE PERMITE ACCEDER A BD EN SQL


namespace RestauranteBD
{
    public partial class conCodigo : Form
    {
        public conCodigo()
        {
            InitializeComponent();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        { 
            SqlConnection objConector = new SqlConnection("" +
            "Data Source=DESKTOP-VICUISF\\SQLEXPRESS;Initial Catalog = Restaurante;" +
            "Integrated Security=SSPI;");

            try
            {
                objConector.Open();
                string sql = "Select * from platos where id = " + txCodigo.Text;
                SqlCommand objComando = new SqlCommand(sql, objConector); // Parametros (string de la consulta, objeto base de datos)
                SqlDataReader objTabla = objComando.ExecuteReader();
                try
                {
                    if (objTabla.Read())
                    {
                        txNombre.Text = objTabla[1].ToString();
                        txValor.Text = objTabla["valor"].ToString();
                        txCodigoChef.Text = objTabla[3].ToString();
                    }
                    else
                    {
                        MessageBox.Show("El plato no se encuentra registrado.");
                        txNombre.Clear();
                        txValor.Clear();
                        txCodigoChef.Clear();
                        txCodigo.Focus();
                    }
                    objConector.Close();
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

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txCodigo.Clear();
            txNombre.Clear();
            txValor.Clear();
            txCodigoChef.Clear();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void conCodigo_Load(object sender, EventArgs e)
        {

        }
    }
}
