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
    public partial class AgregarClte : Form
    {
        public AgregarClte()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            int nuevoId = Global.Clientes.Count + 1; // Generar un nuevo Id basado en la cantidad actual de clientes

            var nuevoCliente = new Global.Cliente(nuevoId, txtNombre.Text, txtApellido.Text, txtNumTelf.Text);
            Global.Clientes.Add(nuevoCliente);

            Close();
        }
    }
}
