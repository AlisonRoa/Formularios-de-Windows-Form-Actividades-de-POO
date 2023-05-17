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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentro Centro = new FrmCentro();
            Centro.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProfesores Profesor = new FrmProfesores();
            Profesor.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmAlumnos Alumno = new FrmAlumnos();
            Alumno.ShowDialog();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPersonal Personal = new FrmPersonal();
            Personal.ShowDialog();
        }

        private void listaDeCentrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCentros listC = new ListaCentros();
            listC.ShowDialog();
        }

        private void listaDeProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaProfesores listP = new ListaProfesores();
            listP.ShowDialog();
        }

        private void listaDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEstudiantes listE = new ListaEstudiantes();
            listE.ShowDialog();
        }

        private void listaDeTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPersonal listT = new ListaPersonal();
            listT.ShowDialog();
        }
    }
}
