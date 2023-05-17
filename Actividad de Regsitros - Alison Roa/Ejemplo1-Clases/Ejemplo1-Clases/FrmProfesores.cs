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
    public partial class FrmProfesores : Form
    {
        public FrmProfesores()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            List<string> nombresCentrosSeleccionados = txtCentros.Text.Split(',').ToList();
            List<Centro> centrosSeleccionados = Datos.Centros.Where(c => nombresCentrosSeleccionados.Contains(c.Nombre)).ToList();

            if (centrosSeleccionados.Count > 0)
            {
                Profesor nuevoProfesor = new Profesor(txtINSS.Text, double.Parse(txtSalario.Text));
                nuevoProfesor.Centros.AddRange(centrosSeleccionados);

                nuevoProfesor.Nombre = txtNombre.Text;
                nuevoProfesor.Direccion = txtDireccion.Text;
                nuevoProfesor.Telf = txtTelf.Text;
                nuevoProfesor.Email = txtEmail.Text;

                Datos.Profesores.Add(nuevoProfesor);

                Close();
            }
            else
            {
                MessageBox.Show("Ninguno de los centros seleccionados existe en la lista de centros");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                Close();
        }
    }
}
