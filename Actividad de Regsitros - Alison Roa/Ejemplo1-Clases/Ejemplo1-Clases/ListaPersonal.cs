using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class ListaPersonal : Form
    {
        public ListaPersonal()
        {
            InitializeComponent();
        }

        private void ListaPersonal_Load(object sender, EventArgs e)
        {            
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Datos.Personanles;

            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns["Id"].DataPropertyName = "Id";

            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";

            dataGridView1.Columns.Add("Direccion", "Dirección");
            dataGridView1.Columns["Direccion"].DataPropertyName = "Direccion";

            dataGridView1.Columns.Add("Telf", "Teléfono");
            dataGridView1.Columns["Telf"].DataPropertyName = "Telf";

            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns["Email"].DataPropertyName = "Email";

            dataGridView1.Columns.Add("Unidad", "Unidad");
            dataGridView1.Columns["Unidad"].DataPropertyName = "Unidad";

            dataGridView1.Columns.Add("Categoria", "Categoria");
            dataGridView1.Columns["Categoria"].DataPropertyName = "Categoria";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                Close();
        }
    }
}
