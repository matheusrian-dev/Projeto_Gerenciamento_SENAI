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
    public partial class UserControlGerenciarEmpresa : UserControl
    {
        public UserControlGerenciarEmpresa()
        {
            InitializeComponent();
        }
        ClassEmpresa empresa = new ClassEmpresa();

        private void UserControlGerenciarEmpresa_Load(object sender, EventArgs e)
        {
            txtNome.Text = "Insira o nome da Empresa";
            txtNome.ForeColor = Color.Gray;

            txtEmail.Text = "Insira o email da Empresa";
            txtEmail.ForeColor = Color.Gray;

            txtEndereco.Text = "Insira o endereço da Empresa";
            txtEndereco.ForeColor = Color.Gray;

            txtRazaoSocial.Text = "Insira a razão social da Empresa";
            txtRazaoSocial.ForeColor = Color.Gray;

            txtResponsavel.Text = "Insira o responsável pela Empresa";
            txtResponsavel.ForeColor = Color.Gray;
        }

        private void txtNomeEmpresa_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Insira o nome da Empresa")
            {
                txtNome.Text = "";
                txtNome.ForeColor = Color.Black;
            }
        }

        private void txtNomeEmpresa_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Insira o nome da Empresa";
                txtNome.ForeColor = Color.Gray;
            }
        }

        private void txtEmailEmpresa_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Insira o email da Empresa")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmailEmpresa_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Insira o email da Empresa";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtEnderecoEmpresa_Enter(object sender, EventArgs e)
        {
            if (txtEndereco.Text == "Insira o endereço da Empresa")
            {
                txtEndereco.Text = "";
                txtEndereco.ForeColor = Color.Black;
            }
        }

        private void txtEnderecoEmpresa_Leave(object sender, EventArgs e)
        {
            if (txtEndereco.Text == "")
            {
                txtEndereco.Text = "Insira o endereço da Empresa";
                txtEndereco.ForeColor = Color.Gray;
            }
        }

        private void txtRazaoSocial_Enter(object sender, EventArgs e)
        {
            if (txtRazaoSocial.Text == "Insira a razão social da Empresa")
            {
                txtRazaoSocial.Text = "";
                txtRazaoSocial.ForeColor = Color.Black;
            }
        }

        private void txtRazaoSocial_Leave(object sender, EventArgs e)
        {
            if (txtRazaoSocial.Text == "")
            {
                txtRazaoSocial.Text = "Insira a razão social da Empresa";
                txtRazaoSocial.ForeColor = Color.Gray;
            }
        }

        private void txtResponsavelEmpresa_Enter(object sender, EventArgs e)
        {
            if (txtResponsavel.Text == "Insira o responsável pela Empresa")
            {
                txtResponsavel.Text = "";
                txtResponsavel.ForeColor = Color.Black;
            }
        }

        private void txtResponsavelEmpresa_Leave(object sender, EventArgs e)
        {
            if (txtResponsavel.Text == "")
            {
                txtResponsavel.Text = "Insira o responsável pela Empresa";
                txtResponsavel.ForeColor = Color.Gray;
            }
        }

        private void btnShowEditar_Click(object sender, EventArgs e)
        {
            FormEditarEmpresa editar = new FormEditarEmpresa();
            this.Hide();
            editar.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //validação de dados obrigatórios
            if(txtNome.Text.Length < 1 || txtNome.Text == "Insira o nome da Empresa" || mskCNPJ.MaskFull == false || (mskTelefone.MaskFull == false && (txtEmail.Text.Length < 5 || txtEmail.Text == "Insira o email da Empresa")))
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
                            empresa.CadastrarEmpresa();
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
                        empresa.CadastrarEmpresa();
                    }
                    else
                    {
                    }
                }
            }
            
        }

        private void btnNecessidadeEmpresa_Click(object sender, EventArgs e)
        {
            FormAddPedidoEmpresa necessidade = new FormAddPedidoEmpresa();
            necessidade.Show();
        }
    }
}
