using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Caja : Form
    {

        private double totalCajero = 0;
        private double totalIVACajero = 0;
        private double totalDescuentoCajero = 0;
        private double totalFactura = 0;
        private double totalDescuento = 0;
        private double totalIVA = 0;
        public Caja()
        {
            InitializeComponent();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txUsuario.Text) || String.IsNullOrEmpty(txClave.Text))
            {
                MessageBox.Show("Debe ingresar toda la información . . .");
            }
            else 
            {
                if (txClave.Text.Equals("A1B2"))
                {
                    MessageBox.Show("Bienvenido " + txUsuario.Text);
                    gbFacturacion.Visible = true;
                    gbLogueo.Enabled = false;
                    totalCajero = 0;
                    totalIVACajero = 0;
                    totalDescuentoCajero = 0;
                }
                else 
                {
                    MessageBox.Show("Clave inválida, reintenta por favor . . .");    
                }
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {

        }

        private void btNueva_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txCliente.Text))
            {
                MessageBox.Show("Debe registrar un cliente");
            }
            else
            {
                gbFactura.Visible = true;
                gbCliente.Enabled = false;
                totalFactura = 0;
                totalDescuento = 0;
                totalIVA = 0;
                DateTime objFecha = dtFecha.Value;
                txSalida.Text = "\t\tFactura de venta\r\n" +
                                        "Cliente: " + txCliente.Text + "\tSucursal: " + ltSucursal.Text + 
                                        "\tFecha: " + objFecha.Day + "/" + objFecha.Month + "/" + objFecha.Year + "\r\n" +
                                        "Nombre\tValor\tCant\tDesc\tIVA\tSubTotal\r\n";
            }
        }

        private void ldProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ldProducto.Text) 
            {
                case "Pantalón":
                    txValor.Text = "100000";
                    break;
                case "Camisa":
                    txValor.Text = "50000";
                    break;
                case "Falda":
                    txValor.Text = "80000";
                    break;
                case "Blusa":
                    txValor.Text = "70000";
                    break;
                case "Medias":
                    txValor.Text = "5000";
                    break;
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            double subTotal = 0;
            double IVA = 0, desc = 0;

            subTotal = Double.Parse(txValor.Text) * Int32.Parse(nmCantidad.Value.ToString());
            if (rbCinco.Checked == true) 
            {
                desc = subTotal * 0.05;
            }
            if (rbDiez.Checked) 
            {
                desc = subTotal * 0.1;
            }

            if (cbIVA.Checked) 
            {
                IVA = (subTotal - desc) * 0.19;
            }

            subTotal = subTotal + IVA - desc;
            txSalida.AppendText(ldProducto.Text + "\t" + txValor.Text + "\t" + nmCantidad.Value.ToString() + 
                                             "\t" + desc + "\t" + IVA + "\t" + subTotal + "\r\n");

            totalFactura += subTotal;
            totalIVA += IVA;
            totalDescuento += desc; 
        }

        private void btFinFactura_Click(object sender, EventArgs e)
        {
            txSalida.AppendText("\r\nEl total a pagar es: " + totalFactura 
                                            + "\r\nSu ahorro es: " + totalDescuento
                                            + "\r\nEl impuesto total es: " + totalIVA);
            btAgregar.Enabled = false;
            txPago.Visible = true;
            btPagar.Visible = true;
        }

        private void btPagar_Click(object sender, EventArgs e)
        {
            if (Double.Parse(txPago.Text) >= totalFactura)
            {
                MessageBox.Show("Compra exitosa\n" +
                                                "El cambio es: " + (Double.Parse(txPago.Text) - totalFactura));
                totalCajero += totalFactura;
                totalIVACajero += totalIVA;
                totalDescuentoCajero += totalDescuento;
                txSalida.Clear();
                txPago.Clear();
                txPago.Visible = false;
                btPagar.Visible = false;
                btAgregar.Enabled = true;
                gbFactura.Visible = false;
                gbCliente.Enabled = true;
                txCliente.Clear();
            }
            else 
            {
                MessageBox.Show("Cantidad de dinero insuficiente . . .");
            }
        }

        private void btBalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tBalance del cajero" + 
                                           "\nTotal realizado: " + totalCajero +
                                           "\nTotal Descuento: " + totalDescuentoCajero + 
                                           "\nTotal IVA" + totalIVACajero);
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tBalance del cajero" +
                                           "\nTotal realizado: " + totalCajero +
                                           "\nTotal Descuento: " + totalDescuentoCajero +
                                           "\nTotal IVA: " + totalIVACajero);

            gbFacturacion.Visible = false;
            gbLogueo.Enabled = true;
            txUsuario.Clear();
            txClave.Clear();
        }
    }
}
