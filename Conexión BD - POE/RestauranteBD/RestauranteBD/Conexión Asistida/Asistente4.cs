﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteBD
{
    public partial class Asistente4 : Form
    {
        public Asistente4()
        {
            InitializeComponent();
        }

        private void Asistente4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet3.vistaRestaurante' table. You can move, or remove it, as needed.
            this.vistaRestauranteTableAdapter.Fill(this.restauranteDataSet3.vistaRestaurante);

        }
    }
}
