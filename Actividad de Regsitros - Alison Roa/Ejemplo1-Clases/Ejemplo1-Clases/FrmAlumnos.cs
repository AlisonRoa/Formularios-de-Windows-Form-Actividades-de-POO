using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejemplo1_Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ejemplo1_Clases
{
    public partial class FrmAlumnos : Form
    {
        public FrmAlumnos()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            bool existeCentro = Datos.Centros.Exists(c => c.Nombre == txtCentro.Text);

            if (existeCentro)
            {
                Centro centro = Datos.Centros.FirstOrDefault(c => c.Nombre == txtCentro.Text);

                Alumno alumno = new Alumno(txtExp.Text, txtTitulacion.Text);

                alumno.Centro = centro; // Asignar solo el nombre del centro

                alumno.Nombre = txtNombre.Text;
                alumno.Direccion = txtDireccion.Text;
                alumno.Telf = txtTelf.Text;
                alumno.Email = txtEmail.Text;

                Datos.Alumnos.Add(alumno);

                Close();
            }
            else
            {
                MessageBox.Show("El centro ingresado no existe en la lista de centros");
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
