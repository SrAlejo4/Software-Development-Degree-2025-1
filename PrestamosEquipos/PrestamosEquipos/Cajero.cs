using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestamosEquipos
{
    public partial class Cajero : Form
    {
        private Control[] imgBilletes;
        private Control[] lbBilletes;
        private int monto;
        public Cajero()
        {

            InitializeComponent();
            imgBilletes = new Control[] { lbDiez, pbDiez, lbCinco, pbCinco, lbDos, pbDos, lbMil, pbMil };
            lbBilletes = new Control[] { lbDiez, lbCinco, lbDos, lbMil };
        }

        private void cantidadBilletes(int monto) 
        {
            int[] valores = { 10000, 5000, 2000, 1000};
            int[] cantidad = new int[valores.Length];

            for (int i = 0; i < valores.Length; i++) 
            {
                cantidad[i] = monto / valores[i];
                monto = monto % valores[i];
            }

            for (int i = 0; i < valores.Length; i++) 
            {
                lbBilletes[i].Text = cantidad[i] + " X ";
            }
        }

        private int ajustar(int monto) 
        {
            int residuo = monto % 1000;
            if (residuo >= 500)
            {
                monto = monto + (1000 - residuo); // Suma lo que le falta para llegar a cifra de mil 
            }
            else 
            {
                monto = monto - residuo;
            }
            return monto;
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(txMonto.Text) <= 200000)
            {
                foreach (var elemento in imgBilletes) 
                {
                    elemento.Visible = true;
                }

                monto = Int32.Parse(txMonto.Text);
                monto = ajustar(monto);
                cantidadBilletes(monto);

            }
            else {
                txMonto.Text = "";
                MessageBox.Show("El monto máximo permitido\n" +
                                             " es de $200.000 " );
            }
        }

        // Método para solamente recibir caracteres númericos en el TextBox . . .
        private void txMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            foreach (var elemento in lbBilletes) 
            {
                elemento.Text = "";
            }

            foreach (var elemento in imgBilletes) 
            {
                elemento.Visible = false;
            }

            txMonto.Text = "";
        }
    }
}
