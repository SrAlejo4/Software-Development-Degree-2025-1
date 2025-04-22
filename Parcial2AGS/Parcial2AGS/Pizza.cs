using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2AGS
{
    public partial class Pizza : Form
    {
        private double costoFijo = 5000;
        private double costoVariable = 100;
        private double costoTotalPizza = 0;
        private double precioVentaPizza = 0;
        private double IVAPizza;

        private double contPequeña, contMediana, contGrande;
        private double totalInsumos = 0;
        private double totalVentas = 0;
        private double totalGanancias = 0;
        private double totalIVA = 0;

        public Pizza()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {

            double queso = 0; 
            double champinones = 0; 
            double tocineta = 0;
            double subTotal = 0;

            if (chbQueso.Checked) 
            {
                queso = 1000;
            }
            if (chbChampinones.Checked) 
            {
                champinones = 1500;
            }
            if (chbTocineta.Checked) 
            {
                tocineta = 2000;
            }

            if (cbTamano.Text == "Pequeña") 
            {
                costoTotalPizza = costoFijo + (costoVariable * 20) + queso + champinones + tocineta;
                contPequeña += 1;
            }

            if (cbTamano.Text == "Mediana") 
            {
                costoTotalPizza = costoFijo + (costoVariable * 25) + queso + champinones + tocineta;
                contMediana += 1;
            }

            if (cbTamano.Text == "Grande")
            {
                costoTotalPizza = costoFijo + (costoVariable * 30) + queso + champinones + tocineta;
                contGrande += 1;
            }
            
            precioVentaPizza = (costoTotalPizza * 1.5);
            subTotal = precioVentaPizza;
            IVAPizza = precioVentaPizza * 0.19;
            precioVentaPizza += IVAPizza;

            totalInsumos += costoTotalPizza;
            totalVentas += precioVentaPizza;
            totalIVA += IVAPizza;
            totalGanancias += (totalVentas - totalInsumos);

            MessageBox.Show("Pizza registrada con éxito" + 
                                         "\nSubtotal: " + subTotal + 
                                         "\nIVA: " + IVAPizza +
                                         "\nTotal a pagar: " + precioVentaPizza);
        }

        private void btFinDia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total de Pizzas Pequeñas vendidas: " + contPequeña +
                                        "\nTotal de Pizzas Medianas vendidas: " + contMediana +
                                        "\nTotal de Pizzas Grandes vendidas: " + contGrande +
                                        "\nTotal de ventas: " + totalVentas +
                                        "\nTotal de ganancias " + totalGanancias +
                                        "\nTotal IVA: " + totalIVA);
        }

    }
}
    
