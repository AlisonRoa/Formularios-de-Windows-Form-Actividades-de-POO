using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente Clientes = new Cliente();
            Clientes.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                Close();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Panel1.Location = new Point(Width / 4, Height / 4);
        }

        private void polizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Poliza Polizas = new Poliza();
            Polizas.ShowDialog();
        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auto Autos = new Auto();
            Autos.ShowDialog();
        }

        private void accidenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accidente Accidentes = new Accidente();
            Accidentes.ShowDialog();
        }
    }
}
