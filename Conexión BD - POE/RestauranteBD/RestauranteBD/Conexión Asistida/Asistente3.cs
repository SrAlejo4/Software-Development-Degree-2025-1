using System;
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
    public partial class Asistente3 : Form
    {
        public Asistente3()
        {
            InitializeComponent();
        }

        private void Asistente3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet2.platos' table. You can move, or remove it, as needed.
            this.platosTableAdapter.Fill(this.restauranteDataSet2.platos);
            // TODO: This line of code loads data into the 'restauranteDataSet2.chef' table. You can move, or remove it, as needed.
            this.chefTableAdapter.Fill(this.restauranteDataSet2.chef);

        }
    }
}
