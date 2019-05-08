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

            mskCNPJ.Text = "Insira o CNPJ da Empresa";
            mskCNPJ.ForeColor = Color.Gray;

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

        private void mskCNPJ_Enter(object sender, EventArgs e)
        {
            if (mskCNPJ.Text == "Insira o CNPJ da Empresa")
            {
                mskCNPJ.Text = "";
                mskCNPJ.ForeColor = Color.Black;
            }
        }

        private void mskCNPJ_Leave(object sender, EventArgs e)
        {
            if (mskCNPJ.Text == "")
            {
                mskCNPJ.Text = "Insira o CNPJ da Empresa";
                mskCNPJ.ForeColor = Color.Gray;
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
    }
}
