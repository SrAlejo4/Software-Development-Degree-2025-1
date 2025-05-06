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
    public partial class Procedimiento : Form
    {
        public Procedimiento()
        {
            InitializeComponent();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            SqlConnection objConector = DB.conectar("Restaurante");

            string conSQL = "conNombreChef"; 
            SqlCommand comando = new SqlCommand(conSQL, objConector); 
            comando.CommandType = CommandType.StoredProcedure; 
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar).SqlValue = txNombre.Text; 
            SqlDataReader tabla = comando.ExecuteReader();
            txResultado.Text = "";

            while (tabla.Read()) 
            {
                txResultado.AppendText("Nombre: " + tabla["nombre"].ToString() + "\r\n");
            }
        }
    }
}
