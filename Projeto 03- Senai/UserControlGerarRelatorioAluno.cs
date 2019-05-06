using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_03__Senai
{
    public partial class UserControlGerarRelatorioAluno : UserControl
    {
        public UserControlGerarRelatorioAluno()
        {
            InitializeComponent();
        }

        private void txtGerarRA_Enter(object sender, EventArgs e)
        {
            if (txtGerarRA.Text == "Insira a RA do Aluno")
            {
                txtGerarRA.Text = "";
                txtGerarRA.ForeColor = Color.Black;
            }
        }

        private void txtGerarRA_Leave(object sender, EventArgs e)
        {
            if (txtGerarRA.Text == "")
            {
                txtGerarRA.Text = "Insira a RA do Aluno";
                txtGerarRA.ForeColor = Color.Gray;
            }
        }

        private void txtGerarTurma_Enter(object sender, EventArgs e)
        {
            if (txtGerarTurma.Text == "Insira o código da Turma")
            {
                txtGerarTurma.Text = "";
                txtGerarTurma.ForeColor = Color.Black;
            }
        }

        private void txtGerarTurma_Leave(object sender, EventArgs e)
        {
            if (txtGerarTurma.Text == "")
            {
                txtGerarTurma.Text = "Insira o código da Turma";
                txtGerarTurma.ForeColor = Color.Gray;
            }
        }

        private void UserControlGerarRelatorioAluno_Load(object sender, EventArgs e)
        {
            txtGerarRA.Text = "Insira a RA do Aluno";
            txtGerarRA.ForeColor = Color.Gray;

            txtGerarTurma.Text = "Insira o código da Turma";
            txtGerarTurma.ForeColor = Color.Gray;
        }

        private void btnGerarTurma_Click(object sender, EventArgs e)
        {

        }

 
    }
}
