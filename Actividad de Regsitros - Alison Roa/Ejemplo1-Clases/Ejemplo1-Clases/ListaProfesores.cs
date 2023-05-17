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
    public partial class ListaProfesores : Form
    {
        public ListaProfesores()
        {
            InitializeComponent();
        }

        private void ListaProfesores_Load(object sender, EventArgs e)
        {
            // Este espacio fue creado para mostrar las columnas de forma lógica y ocultar la columna último Id

            var profesoresData = Datos.Profesores.Select(profesor => new
            {
                profesor.Id,
                profesor.Nombre,
                profesor.Direccion,
                profesor.Telf,
                profesor.Email,
                profesor.INSS,
                profesor.Salario,
                Centros = string.Join(", ", profesor.Centros.Select(centro => centro.Nombre))
            }).ToList();

            dataGridView1.DataSource = profesoresData;

            dataGridView1.Columns["Id"].DataPropertyName = "Id";
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";
            dataGridView1.Columns["Direccion"].DataPropertyName = "Direccion";
            dataGridView1.Columns["Telf"].DataPropertyName = "Telf";
            dataGridView1.Columns["Email"].DataPropertyName = "Email";
            dataGridView1.Columns["INSS"].DataPropertyName = "INSS";
            dataGridView1.Columns["Salario"].DataPropertyName = "Salario";
            dataGridView1.Columns["Centros"].DataPropertyName = "Centros";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                Close();
        }
    }
}
