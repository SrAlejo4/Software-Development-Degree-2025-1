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
    public partial class ChefBD : Form
    {
        public ChefBD()
        {
            InitializeComponent();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar() 
        {
            txCodigo.Clear();
            txNombre.Clear();
            txTelefono.Clear();
            txExperiencia.Clear();
            txCodigo.Focus();
        }

        private void habilitar() 
        {
            txNombre.Enabled = true;
            txTelefono.Enabled = true;
            txExperiencia.Enabled = true;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection objConector1 = DB.conectar("Restaurante");
                string instruccion = $"select * from chef where codigo = {Int32.Parse(txCodigo.Text)}";
                SqlCommand objComando = new SqlCommand(instruccion, objConector1);
                SqlDataReader objTabla = objComando.ExecuteReader();

                try
                {
                    if (objTabla.Read())
                    {
                        txNombre.Text = objTabla["nombre"].ToString();
                        txTelefono.Text = objTabla["telefono"].ToString();
                        txExperiencia.Text = objTabla["experiencia"].ToString();
                        btEliminar.Enabled = true;
                        btEditar.Enabled = true;
                    }
                    else 
                    {
                        MessageBox.Show("El chef no se encuentra registrado.");
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
        } // FIN btConsultar

        private void agregar() 
        {
            try
            {
                SqlConnection objConector2 = DB.conectar("Restaurante");
                //string nombre = txNombre.Text.Replace("'", "''");
                //string instruccion = $"insert into chef values({Convert.ToInt32(txCodigo.Text)}, '{nombre}', " +
                //$"{Convert.ToInt32(txTelefono.Text)}, {Convert.ToInt32(txExperiencia.Text)})";

                string instruccion = "insert into chef values (" +
                txCodigo.Text + ", '" + txNombre.Text + "' , " + txTelefono.Text + "," + txExperiencia.Text + ")";

                int n = DB.operar(instruccion, objConector2);
                if (n > 0)
                {
                    MessageBox.Show("Chef agregado con éxito.");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se agregó el chef.");
                }
                objConector2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión " + ex.Message);
            }
        }

        private void editar() 
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            // limpiar();
            habilitar();
            try
            {
                SqlConnection objConector3 = DB.conectar("Restaurante");
                string nombre = txNombre.Text.Replace("'", "''");
                string instruccion = $"update chef set nombre = '{nombre}', " +
                                $"telefono  = {Int32.Parse(txTelefono.Text)}, experiencia = {txExperiencia.Text} where codigo = {Int32.Parse(txCodigo.Text)}";

                int n = DB.operar(instruccion, objConector3);
                if (n > 0)
                {
                    MessageBox.Show("Información actualizada con éxito.");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la información.");
                }
                objConector3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión " + ex.Message);
            }


        } // FIN btAgregar

        private void btEditar_Click(object sender, EventArgs e)
        {
            habilitar();
            if (string.IsNullOrEmpty(txCodigo.Text) || string.IsNullOrEmpty(txNombre.Text) ||
                string.IsNullOrEmpty(txTelefono.Text) || string.IsNullOrEmpty(txExperiencia.Text))
            {
                MessageBox.Show("Llenar todos los campos.");
            }
            else
            {
                editar();
            }
        } // FIN btEditar
    }
}
