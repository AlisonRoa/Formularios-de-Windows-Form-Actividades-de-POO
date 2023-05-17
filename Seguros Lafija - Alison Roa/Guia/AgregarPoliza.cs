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
    public partial class AgregarPoliza : Form
    {
        public AgregarPoliza()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            int ultimoId = Global.Polizas.Any() ? Global.Polizas.Max(obj => obj.NumPoliza) : 0; // Obtener el último ID o 0 si la lista está vacía
            int nuevoId = ultimoId + 1; // Generar el nuevo ID

            bool clienteId = int.TryParse(txtCliente.Text, out int cliente);
            bool existeClte = Global.Polizas.Exists(u => u.IdCliente == cliente);

            if (existeClte && clienteId)
            {
                var nuevaPoliza = new Global.Poliza(nuevoId, double.Parse(txtCantPagar.Text) , txtCobertura.Text, cliente);
                Global.Polizas.Add(nuevaPoliza);

                Close();
            }
            else
            {
                MessageBox.Show("El Cliente que ingresó es Incorrecto. Ingrese un Cliente dentro del sistema");
            }          
        }
    }
}
