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
    public partial class FormEditarEmpresa : Form
    {
        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;
        public FormEditarEmpresa()
        {
            InitializeComponent();
        }
        ClassEmpresa empresa = new ClassEmpresa();

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ClassFuncionario funcionario = new ClassFuncionario();
            funcionario.CargoUsuario = "Coordenador";
            FrmMenuPrincipal menu = new FrmMenuPrincipal(funcionario.CargoUsuario);
            this.Close();
            menu.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //validação de dados obrigatórios
            if (txtNome.Text.Length < 1 || txtNome.Text == "Insira o nome da Empresa" || mskCNPJ.MaskFull == false || (mskTelefone.MaskFull == false && (txtEmail.Text.Length < 5 || txtEmail.Text == "Insira o email da Empresa")))
            {
                MessageBox.Show("Não é possível cadastrar a empresa por falta de informações importantes (Nome, CNPJ e uma das opções de contato).");
            }
            else
            {
                //validação de dados que podem ser inseridos em uma futura edição de dados
                if (txtEndereco.Text.Length < 1 || txtRazaoSocial.Text.Length < 1 || txtResponsavel.Text.Length < 1 || mskTelefone.MaskFull == false || txtEmail.Text.Length < 1 ||
                    txtEndereco.Text == "Insira o endereço da Empresa" || txtRazaoSocial.Text == "Insira a razão social da Empresa" || txtResponsavel.Text == "Insira o responsável pela Empresa" || txtEmail.Text == "Insira o email da Empresa")
                {
                    DialogResult confirmation1 = MessageBox.Show("Há informações não obrigatórias que não foram preenchidas, deseja continuar?", "Mensagem de Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (confirmation1.Equals(DialogResult.OK))
                    {
                        //confirmação pré-cadastro
                        DialogResult result = MessageBox.Show("Deseja realmente atualizar o cadastro da empresa: " + txtNome.Text + "?", "Mensagem de Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result.Equals(DialogResult.OK))
                        {
                            empresa.Cnpj = mskCNPJ.Text;
                            empresa.NomeEmpresa = txtNome.Text;
                            empresa.TelefoneEmpresa = mskTelefone.Text;
                            empresa.EmailEmpresa = txtEmail.Text;
                            empresa.Endereco = txtEndereco.Text;
                            empresa.RazaoSocial = txtRazaoSocial.Text;
                            empresa.Responsavel = txtResponsavel.Text;
                            empresa.EditarEmpresa(mskBuscarCNPJ.Text);
                        }
                        else
                        {
                        }
                    }
                    else
                    {
                    }
                }
                else
                {
                    //confirmação pré-cadastro
                    DialogResult result = MessageBox.Show("Deseja realmente cadastrar a empresa: " + txtNome.Text + "?", "Mensagem de Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        empresa.Cnpj = mskCNPJ.Text;
                        empresa.NomeEmpresa = txtNome.Text;
                        empresa.TelefoneEmpresa = mskTelefone.Text;
                        empresa.EmailEmpresa = txtEmail.Text;
                        empresa.Endereco = txtEndereco.Text;
                        empresa.RazaoSocial = txtRazaoSocial.Text;
                        empresa.Responsavel = txtResponsavel.Text;
                        empresa.EditarEmpresa(mskBuscarCNPJ.Text);
                    }
                    else
                    {
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (mskBuscarCNPJ.MaskFull == false)
            {
                MessageBox.Show("Por favor, preencha o campo de busca antes de continuar");
            }
            else
            {
                empresa.RetEmpresaCNPJ(mskBuscarCNPJ.Text);
                if(empresa.RetEmpresaCNPJ(mskBuscarCNPJ.Text) == true)
                {
                    empresa.MostrarEmpresasPorCnpj(mskBuscarCNPJ.Text);
                    mskCNPJ.Text = empresa.Cnpj;
                    txtNome.Text = empresa.NomeEmpresa;
                    mskTelefone.Text = empresa.TelefoneEmpresa;
                    txtEmail.Text = empresa.EmailEmpresa;
                    txtEndereco.Text = empresa.Endereco;
                    txtRazaoSocial.Text = empresa.RazaoSocial;
                    txtResponsavel.Text = empresa.Responsavel;
                }
                else
                {
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
