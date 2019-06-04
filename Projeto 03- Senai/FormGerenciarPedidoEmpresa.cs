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
    public partial class FormGerenciarPedidoEmpresa : Form
    {
        public FormGerenciarPedidoEmpresa()
        {
            InitializeComponent();
        }

        ClassNecessidadesEmpresa necessidades = new ClassNecessidadesEmpresa();

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnModificarNecessidade_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente alterar o registro de necessidades" +
                "\n" + "da empresa: " + txtNome.Text + "?", "Mensagem de Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                necessidades.NomeEmpresaC = txtNome.Text;
                necessidades.DataRequerimento = dtpDataRequerimento.Value;
                necessidades.QtdContratoConcomitante = int.Parse(numericUpDownConcomitantes.Text);
                necessidades.QtdContratoSequencial = int.Parse(numericUpDownSequenciais.Text);
                necessidades.QtdContratoDual = int.Parse(numericUpDownDual.Text);
                necessidades.QtdContratoPraticaSequencial = int.Parse(numericUpDownPraticaSequencial.Text);
                necessidades.QtdContratoFaseEscolar = int.Parse(numericUpDownFaseEscolar.Text);
                necessidades.Empresa_Cnpj = mskCNPJ.Text;
                necessidades.EditarNecessidade(int.Parse(txtCodNecessidade.Text));
            }
            else
            {
            }
        }

        private void btnExcluirNecessidade_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente excluir o registro de necessidades" +
                "\n" + "da empresa: " + txtNome.Text + "?", "Mensagem de Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                necessidades.ExcluirNecessidade(int.Parse(txtCodNecessidade.Text));
            }
            else
            {
            }
        }

        private void btnBuscarEmpresaCNPJ_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = necessidades.MostrarNecessidadesPorCNPJ(mskCNPJBusca.Text);
        }

        private void FormGerenciarPedidoEmpresa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = necessidades.MostrarNecessidade();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtCodNecessidade.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dtpDataRequerimento.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            numericUpDownFaseEscolar.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            numericUpDownPraticaSequencial.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            numericUpDownConcomitantes.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            numericUpDownSequenciais.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            numericUpDownDual.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            mskCNPJ.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }
    }
}
