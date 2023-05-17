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
    public partial class AgregarAccidente : Form
    {
        public AgregarAccidente()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            int ultimoId = Global.Accidentes.Any() ? Global.Accidentes.Max(obj => obj.Id) : 0; // Obtener el último ID o 0 si la lista está vacía
            int nuevoId = ultimoId + 1; // Generar el nuevo ID

            bool autoId = int.TryParse(txtAuto.Text, out int auto);
            bool existeAuto = Global.Accidentes.Exists(u => u.IdAuto == auto);

            if (existeAuto && autoId)
            {
                var nuevaAccidente = new Global.Accidente(nuevoId, txtTipo.Text, txtFecha.Text, txtDes.Text, auto);
                Global.Accidentes.Add(nuevaAccidente);

                Close();
            }
            else
            {
                MessageBox.Show("El Auto que ingresó es Incorrecto. Ingrese un Auto dentro del sistema");
            }
        }
    }
}
