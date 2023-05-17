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
    public partial class FrmSplash : Form
    {
        int tiempo = 0;
        public FrmSplash()
        {
            InitializeComponent();
        }
        private void FrmSplash_Load(object sender, EventArgs e)
        {
            // Tiempo del intervalo en milisegundos
            // timer1.Interval = 4000;
            timer1.Interval = 10;

            // Definimos el evento tick
            timer1.Tick += timer1_Tick;
            
            // Iniciamos el temporizador
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (tiempo < 4000) // no supere los 4 segs
            {
                tiempo += 40; // el tiempo va aumentando cada 40 milisegundo el timer
                progressBar1.Value += 1;
            }
            
            else
            {
                this.Close();
                timer1.Stop();
            }

            // Close();

        }
    }
}