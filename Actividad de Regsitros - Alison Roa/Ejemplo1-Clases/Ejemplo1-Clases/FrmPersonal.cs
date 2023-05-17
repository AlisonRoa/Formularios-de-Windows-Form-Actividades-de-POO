using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ejemplo1_Clases
{
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            var nuevoPersonal = new Personal(txtUnidad.Text, txtCategoria.Text);

            nuevoPersonal.Nombre = txtNombre.Text;
            nuevoPersonal.Direccion = txtDireccion.Text;
            nuevoPersonal.Telf = txtTelf.Text;
            nuevoPersonal.Email = txtEmail.Text;

            Datos.Personanles.Add(nuevoPersonal);
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
