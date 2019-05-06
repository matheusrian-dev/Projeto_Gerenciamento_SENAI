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
    public partial class UserControlGerarRelatorioEmpresa : UserControl
    {
        public UserControlGerarRelatorioEmpresa()
        {
            InitializeComponent();
        }

        private void txtGerarPorCNPJ_Enter(object sender, EventArgs e)
        {

            if (txtGerarPorCNPJ.Text == "Insira o CNPJ da Empresa")
            {
                txtGerarPorCNPJ.Text = "";
                txtGerarPorCNPJ.ForeColor = Color.Black;
            }
        }

        private void txtGerarPorCNPJ_Leave(object sender, EventArgs e)
        {
            if (txtGerarPorCNPJ.Text == "")
            {
                txtGerarPorCNPJ.Text = "Insira o CNPJ da Empresa";
                txtGerarPorCNPJ.ForeColor = Color.Gray;
            }
        }

        private void UserControlGerarRelatorioEmpresa_Load(object sender, EventArgs e)
        {
            txtGerarPorCNPJ.Text = "Insira o CNPJ da Empresa";
            txtGerarPorCNPJ.ForeColor = Color.Gray;
        }
    }
}
