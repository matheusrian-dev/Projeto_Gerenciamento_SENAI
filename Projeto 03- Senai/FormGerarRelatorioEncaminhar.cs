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
    public partial class FormGerarRelatorioEncaminhar : Form
    {
        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;
        public FormGerarRelatorioEncaminhar()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnGerarRelatorioCompleto_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrarRA_Click(object sender, EventArgs e)
        {
            //Validação para o caso do textbox estar em branco ou com um placeholder
            if (txtFiltrarRA.Text.Length < 1 || txtFiltrarRA.Text == "Insira a RA do Aluno")
            {
                MessageBox.Show("Insira um valor no campo de filtro de RA ao lado da opção 'Filtrar por RA'");
            }
            else
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    //Validação para o caso da tabela não tenha sido selecionada ainda
                    MessageBox.Show("Por favor, selecione uma tabela antes de filtrar!");
                }
                else
                {
                    //Código para filtrar o datagridview, para colocar mais filtros juntos só adicionar AND/OR e a condição, 
                    // como faria no banco de dados 
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("raEncaminhar = {0}", txtFiltrarRA.Text);
                }
            }
        }

        private void btnGerarRelatorioParcial_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrarTurma_Click(object sender, EventArgs e)
        {
            //Validação para o caso do textbox estar em branco ou com um placeholder
            if (txtFiltrarTurma.Text.Length < 1 || txtFiltrarTurma.Text == "Insira o código da Turma")
            {
                MessageBox.Show("Insira um valor no campo de filtro de Turma ao lado da opção 'Filtrar por Turma'");
            }
            else
            {
                //Validação para o caso da tabela não tenha sido selecionada ainda
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione uma tabela antes de filtrar!");
                }
                else
                {
                    //Código para filtrar o datagridview, para colocar mais filtros juntos só adicionar AND/OR e a condição, 
                    // como faria no banco de dados 
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("codTurmaEnturmar LIKE '{0}%' OR codTurmaEnturmar LIKE '% {0}%'", txtFiltrarTurma.Text);
                }
            }
        }

        private void btnFiltrarPorGenero_Click(object sender, EventArgs e)
        {
            //Validação para o caso do textbox estar em branco ou com um placeholder
            if (txtFiltrarPorGenero.Text.Length < 1 || txtFiltrarPorGenero.Text == "Insira o Gênero do Aluno")
            {
                MessageBox.Show("Insira um valor no campo de filtro do Gênero do aluno ao lado da opção 'Filtrar Alunos por Gênero'");
            }
            else
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    //Validação para o caso da tabela não tenha sido selecionada ainda
                    MessageBox.Show("Por favor, selecione uma tabela antes de filtrar!");
                }
                else
                {
                    //Código para filtrar o datagridview, para colocar mais filtros juntos só adicionar AND/OR e a condição, 
                    // como faria no banco de dados 
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("sexoEncaminhar LIKE '{0}%' OR sexoEncaminhar LIKE '% {0}%'", txtFiltrarPorGenero.Text);
                }
            }
        }

        private void btnFiltrarPorEmpresa_Click(object sender, EventArgs e)
        {
            //Validação para o caso do textbox estar em branco ou com um placeholder
            if (mskFiltrarCNPJ.MaskFull == false)
            {
                MessageBox.Show("Insira um valor no campo de filtro de CNPJ da Empresa da opção 'Filtrar Alunos por Empresa'");
            }
            else
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    //Validação para o caso da tabela não tenha sido selecionada ainda
                    MessageBox.Show("Por favor, selecione uma tabela antes de filtrar!");
                }
                else
                {
                    //Código para filtrar o datagridview, para colocar mais filtros juntos só adicionar AND/OR e a condição, 
                    // como faria no banco de dados 
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("Empresa_cnpj LIKE '{0}%' OR Empresa_cnpj LIKE '% {0}%'", mskFiltrarCNPJ.Text);
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }
    }
}
