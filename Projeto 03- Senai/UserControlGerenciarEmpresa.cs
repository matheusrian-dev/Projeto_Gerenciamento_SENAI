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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UserControlGerenciarEmpresa_Load(object sender, EventArgs e)
        {
            txtNomeEmpresa.Text = "Insira o nome da Empresa";
            txtNomeEmpresa.ForeColor = Color.Gray;

            txtEmailEmpresa.Text = "Insira o email da Empresa";
            txtEmailEmpresa.ForeColor = Color.Gray;

            txtEnderecoEmpresa.Text = "Insira o endereço da Empresa";
            txtEnderecoEmpresa.ForeColor = Color.Gray;

            txtRazaoSocial.Text = "Insira a razão social da Empresa";
            txtRazaoSocial.ForeColor = Color.Gray;

            txtResponsavelEmpresa.Text = "Insira o responsável pela Empresa";
            txtResponsavelEmpresa.ForeColor = Color.Gray;
        }

        private void txtNomeEmpresa_Enter(object sender, EventArgs e)
        {
            if (txtNomeEmpresa.Text == "Insira o nome da Empresa")
            {
                txtNomeEmpresa.Text = "";
                txtNomeEmpresa.ForeColor = Color.Black;
            }
        }

        private void txtNomeEmpresa_Leave(object sender, EventArgs e)
        {
            if (txtNomeEmpresa.Text == "")
            {
                txtNomeEmpresa.Text = "Insira o nome da Empresa";
                txtNomeEmpresa.ForeColor = Color.Gray;
            }
        }

        private void txtEmailEmpresa_Enter(object sender, EventArgs e)
        {
            if (txtEmailEmpresa.Text == "Insira o email da Empresa")
            {
                txtEmailEmpresa.Text = "";
                txtEmailEmpresa.ForeColor = Color.Black;
            }
        }

        private void txtEmailEmpresa_Leave(object sender, EventArgs e)
        {
            if (txtEmailEmpresa.Text == "")
            {
                txtEmailEmpresa.Text = "Insira o email da Empresa";
                txtEmailEmpresa.ForeColor = Color.Gray;
            }
        }

        private void txtEnderecoEmpresa_Enter(object sender, EventArgs e)
        {
            if (txtEnderecoEmpresa.Text == "Insira o endereço da Empresa")
            {
                txtEnderecoEmpresa.Text = "";
                txtEnderecoEmpresa.ForeColor = Color.Black;
            }
        }

        private void txtEnderecoEmpresa_Leave(object sender, EventArgs e)
        {
            if (txtEnderecoEmpresa.Text == "")
            {
                txtEnderecoEmpresa.Text = "Insira o endereço da Empresa";
                txtEnderecoEmpresa.ForeColor = Color.Gray;
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
            if (txtResponsavelEmpresa.Text == "Insira o responsável pela Empresa")
            {
                txtResponsavelEmpresa.Text = "";
                txtResponsavelEmpresa.ForeColor = Color.Black;
            }
        }

        private void txtResponsavelEmpresa_Leave(object sender, EventArgs e)
        {
            if (txtResponsavelEmpresa.Text == "")
            {
                txtResponsavelEmpresa.Text = "Insira o responsável pela Empresa";
                txtResponsavelEmpresa.ForeColor = Color.Gray;
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
            if(txtNomeEmpresa.Text.Length < 1 || txtNomeEmpresa.Text == "Insira o nome da Empresa" || mskCNPJ.MaskFull == false || (mskTelefoneEmpresa.MaskFull == false && (txtEmailEmpresa.Text.Length < 5 || txtEmailEmpresa.Text == "Insira o email da Empresa")))
            {
                MessageBox.Show("Não é possível cadastrar a empresa por falta de informações importantes (Nome, CNPJ e uma das opções de contato).");
            }
            else
            {
                //validação de dados que podem ser inseridos em uma futura edição de dados
                if (txtEnderecoEmpresa.Text.Length < 1 || txtRazaoSocial.Text.Length < 1 || txtResponsavelEmpresa.Text.Length < 1 || mskTelefoneEmpresa.MaskFull == false || txtEmailEmpresa.Text.Length < 1 ||
                    txtEnderecoEmpresa.Text == "Insira o endereço da Empresa" || txtRazaoSocial.Text == "Insira a razão social da Empresa" || txtResponsavelEmpresa.Text == "Insira o responsável pela Empresa" || txtEmailEmpresa.Text == "Insira o email da Empresa")
                {
                    DialogResult confirmation1 = MessageBox.Show("Há informações não obrigatórias que não foram preenchidas, deseja continuar?", "Mensagem de Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (confirmation1.Equals(DialogResult.OK))
                    {
                        //confirmação pré-cadastro
                        DialogResult result = MessageBox.Show("Deseja realmente cadastrar a empresa: " + txtNomeEmpresa.Text + "?", "Mensagem de Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result.Equals(DialogResult.OK))
                        {
                            //Do something
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
                    DialogResult result = MessageBox.Show("Deseja realmente cadastrar a empresa: " + txtNomeEmpresa.Text + "?", "Mensagem de Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        //Do something
                    }
                    else
                    {
                    }
                }
            }
            
        }
    }
}
