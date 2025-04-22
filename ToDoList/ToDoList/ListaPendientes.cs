using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class ListaPendientes : Form
    {
        public ListaPendientes()
        {
            InitializeComponent();
        }

        DataTable toDoList = new DataTable();
        bool editando = false;
        private void ListaPendientes_Load(object sender, EventArgs e)
        {
            toDoList.Columns.Add("Título");
            toDoList.Columns.Add("Descripción");

            // Apuntamos el DataGriedView al DataTable o DataResource
            dgvToDoList.DataSource = toDoList;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            editando = true;
            // Traemos los datos del DataGriedViewer a los TextBox Título y Descripción
            txTitulo.Text = toDoList.Rows[dgvToDoList.CurrentCell.RowIndex].ItemArray[0].ToString();
            txDescripcion.Text = toDoList.Rows[dgvToDoList.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                toDoList.Rows[dgvToDoList.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Algo salió mal . . .");
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (editando)
            {
                toDoList.Rows[dgvToDoList.CurrentCell.RowIndex]["Título"] = txTitulo.Text;
                toDoList.Rows[dgvToDoList.CurrentCell.RowIndex]["Descripción"] = txDescripcion.Text;
            }
            else 
            {
                toDoList.Rows.Add(txTitulo.Text, txDescripcion.Text);
            }

            // Limpiamos los TextBox . . .
            txTitulo.Clear();
            txDescripcion.Clear();
            editando = false;

        }
        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txTitulo.Text = "";
            txDescripcion.Text = "";
        }
    }
}
