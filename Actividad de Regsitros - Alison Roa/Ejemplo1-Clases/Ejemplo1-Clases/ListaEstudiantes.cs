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
    public partial class ListaEstudiantes : Form
    {
        public ListaEstudiantes()
        {
            InitializeComponent();
        }

        private void ListaEstudiantes_Load(object sender, EventArgs e)
        {
            // Este espacio fue creado para mostrar las columnas de forma lógica y ocultar la columna último Id

            var alumnosData = Datos.Alumnos.Select(alumno => new
            {
                alumno.Id,
                alumno.Nombre,
                alumno.Direccion,
                alumno.Telf,
                alumno.Email,
                alumno.Exp,
                alumno.Tiulacion,
                Centro = alumno.Centro.Nombre
            }).ToList();

            dataGridView1.DataSource = alumnosData;

            dataGridView1.Columns["Id"].DataPropertyName = "Id";
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";
            dataGridView1.Columns["Direccion"].DataPropertyName = "Direccion";
            dataGridView1.Columns["Telf"].DataPropertyName = "Telf";
            dataGridView1.Columns["Email"].DataPropertyName = "Email";
            dataGridView1.Columns["Exp"].DataPropertyName = "Exp";
            dataGridView1.Columns["Tiulacion"].DataPropertyName = "Tiulacion";
            dataGridView1.Columns["Centro"].DataPropertyName = "Centro";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                Close();
        }
    }
}
