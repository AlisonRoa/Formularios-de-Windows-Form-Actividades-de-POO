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
    public partial class Login : Form
    {
        int intentos = 3;

        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (intentos > 1)
            {
                bool existeUsuario = Global.Usuarios.Exists(u => u.User == txtUser.Text && u.Pass == txtPass.Text);

                if (existeUsuario)
                {
                    this.Hide();
                    FrmMainMenu Principal = new FrmMainMenu();
                    Principal.ShowDialog();
                    this.Close();
                }
                else
                {
                    intentos--;
                    MessageBox.Show($"Credenciales no validas \nRestan: {intentos} intentos","Avisos",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Lo sentimos se han acabado los intentos", "Confirmar", MessageBoxButtons.OK);
                Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                Close();
        }

    }
}
