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
    public partial class FormAddPedidoEmpresa : Form
    {
        public FormAddPedidoEmpresa()
        {
            InitializeComponent();
        }
        ClassEmpresa empresa = new ClassEmpresa();
        ClassNecessidadesEmpresa necessidades = new ClassNecessidadesEmpresa();

        private void FormAddPedidoEmpresa_Load(object sender, EventArgs e)
        {
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegistrarNecessidade_Click(object sender, EventArgs e)
        {
            necessidades.NomeEmpresaC = txtNome.Text;
            necessidades.DataRequerimento = dtpFimContrato.Value;
            necessidades.QtdContratoFaseEscolar = int.Parse(numericUpDownFaseEscolar.Text);
            necessidades.QtdContratoPraticaSequencial = int.Parse(numericUpDownPraticaSequencial.Text);
            necessidades.QtdContratoSequencial = int.Parse(numericUpDownSequenciais.Text);
            necessidades.QtdContratoConcomitante = int.Parse(numericUpDownConcomitantes.Text);
            necessidades.QtdContratoDual = int.Parse(numericUpDownDual.Text);
            necessidades.RegistrarNecessidade();
        }

        private void btnGerenciarNecessidade_Click(object sender, EventArgs e)
        {
            FormGerenciarPedidoEmpresa gerenciarPedido = new FormGerenciarPedidoEmpresa();
            gerenciarPedido.Show();
        }
    }
}
