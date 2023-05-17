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
    public partial class FrmCentro : Form
    {
        public FrmCentro()
        {
            InitializeComponent();
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Centro centro = new Centro(txtNombre.Text, txtDireccion.Text, txtTelf.Text, txtEmail.Text);
            Datos.Centros.Add(centro);

            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                Close();
        }
    }
}
