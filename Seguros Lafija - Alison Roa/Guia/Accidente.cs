using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guia.Global;

namespace Guia
{
    public partial class Accidente : Form
    {
        public Accidente()
        {
            InitializeComponent();
        }

        private void Accidente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Global.Accidentes;
            txtRegistro.Text = Global.Accidentes.Count.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                var Encontrado = Accidentes.Where(c => c.Descripcion.Contains(txtBuscar.Text)).ToList();

                if (Encontrado.Count > 0)
                {
                    dataGridView1.DataSource = Encontrado;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún cliente con el nombre buscado.");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarAccidente Agregar = new AgregarAccidente();
            Agregar.ShowDialog();
            this.Close();
        }
    }
}
