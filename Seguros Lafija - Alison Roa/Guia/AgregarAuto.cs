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
    public partial class AgregarAuto : Form
    {
        public AgregarAuto()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            int ultimoId = Global.Autos.Any() ? Global.Autos.Max(obj => obj.Id) : 0; // Obtener el último ID o 0 si la lista está vacía
            int nuevoId = ultimoId + 1; // Generar el nuevo ID

            bool polizaInt = int.TryParse(txtNumPoliza.Text, out int poliza);
            bool existePoliza = Global.Polizas.Exists(u => u.NumPoliza == poliza);

            if (existePoliza && polizaInt)
            {
                var nuevoAuto = new Global.Auto(nuevoId, txtModelo.Text, txtMatricula.Text, txtMarca.Text, txtColor.Text, poliza);
                Global.Autos.Add(nuevoAuto);

                Close();
            }
            else
            {
                MessageBox.Show("El número de póliza que ingresó es incorrecto. Ingrese un número de póliza dentro del sistema");
            }
        }
    }
}
