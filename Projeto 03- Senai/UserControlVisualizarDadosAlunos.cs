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
    public partial class UserControlVisualizarDadosAlunos : UserControl
    {
        public UserControlVisualizarDadosAlunos()
        {
            InitializeComponent();
        }

        private void btnBuscarRA_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscaRA_Enter(object sender, EventArgs e)
        {
            if (txtBuscaRA.Text == "Insira a RA do Aluno")
            {
                txtBuscaRA.Text = "";
                txtBuscaRA.ForeColor = Color.Black;
            }
        }

        private void txtBuscaRA_Leave(object sender, EventArgs e)
        {
            if (txtBuscaRA.Text == "")
            {
                txtBuscaRA.Text = "Insira a RA do Aluno";
                txtBuscaRA.ForeColor = Color.Gray;
            }
        }

        private void UserControlVisualizarDadosAlunos_Load(object sender, EventArgs e)
        {
            txtBuscaRA.Text = "Insira a RA do Aluno";
            txtBuscaRA.ForeColor = Color.Gray;

            txtBuscarTurma.Text = "Insira o código da Turma";
            txtBuscarTurma.ForeColor = Color.Gray;

            txtBuscarAlunosNaEmpresa.Text = "Insira o CNPJ da Empresa";
            txtBuscarAlunosNaEmpresa.ForeColor = Color.Gray;
        }

        private void txtBuscarTurma_Enter(object sender, EventArgs e)
        {
            if (txtBuscarTurma.Text == "Insira o código da Turma")
            {
                txtBuscarTurma.Text = "";
                txtBuscarTurma.ForeColor = Color.Black;
            }
        }

        private void txtBuscarTurma_Leave(object sender, EventArgs e)
        {
            if (txtBuscarTurma.Text == "")
            {
                txtBuscarTurma.Text = "Insira o código da Turma";
                txtBuscarTurma.ForeColor = Color.Gray;
            }
        }

        private void txtBuscarAlunosNaEmpresa_Enter(object sender, EventArgs e)
        {
            if (txtBuscarAlunosNaEmpresa.Text == "Insira o CNPJ da Empresa")
            {
                txtBuscarAlunosNaEmpresa.Text = "";
                txtBuscarAlunosNaEmpresa.ForeColor = Color.Black;
            }
        }

        private void txtBuscarAlunosNaEmpresa_Leave(object sender, EventArgs e)
        {

            if (txtBuscarAlunosNaEmpresa.Text == "")
            {
                txtBuscarAlunosNaEmpresa.Text = "Insira o CNPJ da Empresa";
                txtBuscarAlunosNaEmpresa.ForeColor = Color.Gray;
            }
        }


    }
}
