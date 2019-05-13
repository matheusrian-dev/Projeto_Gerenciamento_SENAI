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
    public partial class FrmMenuPrincipal : Form
    {
        bool isPanelDropDownMenuOpen = false;
        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            userControlGerarRelatorioEmpresa1.Visible = false;
            userControlGerenciarEmpresa1.Visible = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - MouPosX, MousePosition.Y - MouPosY);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblVisualizarDadosAlunos_Click(object sender, EventArgs e)
        {
            userControlVisualizarDadosAlunos1.Visible = true;
            userControlGerarRelatorioEmpresa1.Visible = false;
            userControlGerenciarEmpresa1.Visible = false;
        }

        private void lblGerenciarEmpresa_Click(object sender, EventArgs e)
        {
            userControlGerenciarEmpresa1.Visible = true;
            userControlVisualizarDadosAlunos1.Visible = false;
            userControlGerarRelatorioEmpresa1.Visible = false;
        }

        private void lblGerarRelatorioEmpresa_Click(object sender, EventArgs e)
        {
            userControlGerarRelatorioEmpresa1.Visible = true;
            userControlVisualizarDadosAlunos1.Visible = false;
            userControlGerenciarEmpresa1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isPanelDropDownMenuOpen)
            {
                panelMenu.Width -= 38;
                if (panelMenu.Width == 0)
                {
                    timer1.Stop();
                    isPanelDropDownMenuOpen = false;
                }
            }

            else if (!isPanelDropDownMenuOpen)
            {
                panelMenu.Width += 38;
                if (panelMenu.Width == 190)
                {
                    timer1.Stop();
                    isPanelDropDownMenuOpen = true;
                }
            }
        }
    }
}
