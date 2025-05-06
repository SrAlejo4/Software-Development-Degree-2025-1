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
    public partial class Asistente2 : Form
    {
        public Asistente2()
        {
            InitializeComponent();
        }

        private void platosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.platosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restauranteDataSet2);

        }

        private void Asistente2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restauranteDataSet2.ingredientes' table. You can move, or remove it, as needed.
            this.ingredientesTableAdapter.Fill(this.restauranteDataSet2.ingredientes);
            // TODO: This line of code loads data into the 'restauranteDataSet2.platos' table. You can move, or remove it, as needed.
            this.platosTableAdapter.Fill(this.restauranteDataSet2.platos);

        }
    }
}
