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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Global.Clientes;
            txtRegistro.Text = Clientes.Count.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                var Encontrado = Clientes.Where(c => c.Nombre.Contains(txtBuscar.Text)).ToList();

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
            AgregarClte Agregar = new AgregarClte();
            Agregar.ShowDialog();
            this.Close();
        }
    }
}
