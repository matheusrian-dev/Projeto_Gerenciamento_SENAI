using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_03__Senai
{
    public partial class frmLogin : Form
    {
        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {
            // Código que permite visualizar e mascarar o campo da senha
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // Fechar aplicativo
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            // Minimizar a tela
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - MouPosX, MousePosition.Y - MouPosY);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
