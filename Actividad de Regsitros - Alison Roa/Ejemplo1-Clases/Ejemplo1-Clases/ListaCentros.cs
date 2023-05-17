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
    public partial class ListaCentros : Form
    {
        public ListaCentros()
        {
            InitializeComponent();
        }

        private void ListaCentros_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Datos.Centros;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                Close();
        }
    }
}
