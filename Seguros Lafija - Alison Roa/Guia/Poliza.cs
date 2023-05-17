using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guia.Global;

namespace Guia
{
    public partial class Poliza : Form
    {
        public Poliza()
        {
            InitializeComponent();
        }

        private void Poliza_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Global.Polizas;
            txtRegistro.Text = Polizas.Count.ToString();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                int numPoliza;
                if (int.TryParse(txtBuscar.Text, out numPoliza))
                {
                    var encontrado = Polizas.Where(c => c.NumPoliza == numPoliza).ToList();

                    if (encontrado.Count > 0)
                    {
                        dataGridView1.DataSource = encontrado;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ninguna póliza con el número buscado.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número de póliza válido.");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarPoliza Agregar = new AgregarPoliza();
            Agregar.ShowDialog();
            this.Close();
        }
    }
}
