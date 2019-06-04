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
    public partial class FormGerenciarEncaminhamento : Form
    {
        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;
        public FormGerenciarEncaminhamento()
        {
            InitializeComponent();
        }

        ClassEncaminhamento encaminhamento = new ClassEncaminhamento();

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }

        private void btnRemoverEncaminhamento_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente cancelar o encaminhamento do "+"\n"+" aluno: " + txtNomeAluno.Text + 
                "\n"+"para a empresa: " + txtNomeFantasia.Text + "?", "Mensagem de Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                encaminhamento.ExcluirEncaminhamento(int.Parse(txtCodEncaminhamento.Text));
            }
            else
            {
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtRABusca.Text.Length == 0)
            {
                MessageBox.Show("Por favor, insira o RA antes de efetuar a busca.");
            }
            else
            {
                if(encaminhamento.RetornarEncaminhamentoRa(int.Parse(txtRAAluno.Text)) == true)
                {
                    encaminhamento.MostrarEncaminhamentoRa(int.Parse(txtRAAluno.Text));
                    // Informações do Aluno
                    txtCodEncaminhamento.Text = Convert.ToString(encaminhamento.CodEncaminhar);
                    txtNomeAluno.Text = encaminhamento.NomeAluno;
                    mskCPFAluno.Text = encaminhamento.CpfEncaminhar;
                    txtRAAluno.Text = Convert.ToString(encaminhamento.RaEncaminhar);
                    mskRGAluno.Text = encaminhamento.RgEncaminhar;
                    txtEmailAluno.Text = encaminhamento.EmailEncaminhar;
                    mskTelefoneAluno.Text = encaminhamento.TelefoneEncaminhar;
                    mskCodTurma.Text = encaminhamento.CodTurmaEncaminhar;
                    mskSexoAluno.Text = encaminhamento.SexoEncaminhar;
                    //// Informações do Contrato
                    txtPeriodo.Text = encaminhamento.Periodo;
                    cboTipoContrato.Text = encaminhamento.TipoContrato;
                    dtpInicioContrato.Value = encaminhamento.InicioContrato;
                    dtpFimContrato.Value = encaminhamento.FimContrato;
                    //// Informações da Empresa
                    txtNomeFantasia.Text = encaminhamento.NomeFantasia; 
                    mskTelefoneEmpresa.Text = encaminhamento.TelefoneEmpresa2; 
                    txtEmailEmpresa.Text = encaminhamento.EmailEmpresa2;
                    txtEnderecoEmpresa.Text = encaminhamento.EnderecoEmpresa;
                    txtRazaoSocial.Text = encaminhamento.RazaoSocial2; 
                    txtResponsavel.Text = encaminhamento.Responsavel2; 
                    mskCNPJ.Text = encaminhamento.Empresa_Cnpj;
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado.");
                }
            }
        }

        private void btnEncaminharAluno_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente alterar o encaminhamento do " + "\n" + " aluno: " + txtNomeAluno.Text +
                "\n" + "para a empresa: " + txtNomeFantasia.Text + "?", "Mensagem de Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                // Informações do Aluno
                encaminhamento.NomeAluno = txtNomeAluno.Text;
                encaminhamento.CpfEncaminhar = mskCNPJ.Text;
                encaminhamento.RaEncaminhar = int.Parse(txtRAAluno.Text);
                encaminhamento.RgEncaminhar = mskRGAluno.Text;
                encaminhamento.EmailEncaminhar = txtEmailAluno.Text;
                encaminhamento.TelefoneEncaminhar = mskTelefoneAluno.Text;
                encaminhamento.CodTurmaEncaminhar = mskCodTurma.Text;
                encaminhamento.SexoEncaminhar = mskSexoAluno.Text;
                // Informações do Contrato
                encaminhamento.Periodo = txtPeriodo.Text;
                encaminhamento.TipoContrato = cboTipoContrato.Text;
                encaminhamento.InicioContrato = dtpInicioContrato.Value;
                encaminhamento.FimContrato = dtpFimContrato.Value;
                // Informações da Empresa
                encaminhamento.NomeFantasia = txtNomeFantasia.Text;
                encaminhamento.TelefoneEmpresa2 = mskTelefoneEmpresa.Text;
                encaminhamento.EmailEmpresa2 = txtEmailEmpresa.Text;
                encaminhamento.EnderecoEmpresa = txtEnderecoEmpresa.Text;
                encaminhamento.RazaoSocial2 = txtRazaoSocial.Text;
                encaminhamento.Responsavel2 = txtResponsavel.Text;
                encaminhamento.Empresa_Cnpj = mskCNPJ.Text;
                encaminhamento.EditarEncaminhamento(int.Parse(txtCodEncaminhamento.Text));
            }
            else
            {
            }
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
