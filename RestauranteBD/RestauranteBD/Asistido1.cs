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
    public partial class Asistido1 : Form
    {
        public Asistido1()
        {
            InitializeComponent();
        }

        private void Asistido1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet1.platos' table. You can move, or remove it, as needed.
            this.platosTableAdapter.Fill(this.restauranteDataSet1.platos);

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.platosBindingSource.EndEdit();
            this.platosTableAdapter.Update(this.restauranteDataSet1);
        }
    }
}
