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
    public partial class FormAtualizarFuncionario : Form
    {
        public FormAtualizarFuncionario()
        {
            InitializeComponent();
        }
        ClassFuncionario funcionario = new ClassFuncionario();

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            if (mskBuscaCPF.MaskFull == false)
            {
                MessageBox.Show("Por favor, preencha o campo de busca antes de continuar");
            }
            else
            {
                funcionario.RetFuncionarioCPF(mskBuscaCPF.Text);
                if(funcionario.RetFuncionarioCPF(mskBuscaCPF.Text) == true)
                {
                    funcionario.MostrarFuncionarioCpf(mskBuscaCPF.Text);
                    txtNome.Text = funcionario.NomeFunc;
                    txtEmail.Text = funcionario.EmailFunc;
                    txtSenha.Text = funcionario.Senha;
                    mskCPF.Text = funcionario.Cpf;
                    mskTelefone.Text = funcionario.TelefoneFunc;
                    cboCargo.Text = funcionario.Cargo;
                }
                else
                {
                }
            }
        }

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            funcionario.NomeFunc = txtNome.Text;
            funcionario.TelefoneFunc = mskTelefone.Text;
            funcionario.EmailFunc = txtEmail.Text;
            funcionario.Senha = txtSenha.Text;
            funcionario.Cargo = cboCargo.SelectedItem.ToString();
            funcionario.EditarFuncionario(mskCPF.Text);
        }
    }
}
