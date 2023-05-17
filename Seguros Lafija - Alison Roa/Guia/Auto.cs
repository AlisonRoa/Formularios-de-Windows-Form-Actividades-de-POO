using System;
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
    public partial class Auto : Form
    {
        public Auto()
        {
            InitializeComponent();
        }

        private void Auto_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Global.Autos;
            txtRegistro.Text = Autos.Count.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                int numPoliza;
                if (int.TryParse(txtBuscar.Text, out numPoliza))
                {
                    var encontrado = Autos.Where(c => c.Id == numPoliza).ToList();

                    if (encontrado.Count > 0)
                    {
                        dataGridView1.DataSource = encontrado;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningun auto con el Id buscado.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un Id de Auto válido.");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarAuto Agregar = new AgregarAuto();
            Agregar.ShowDialog();
            this.Close();
        }
    }
}
