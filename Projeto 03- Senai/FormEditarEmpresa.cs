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
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            this.Close();
            menu.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //validação de dados obrigatórios
            if (txtNomeEmpresa.Text.Length < 1 || txtNomeEmpresa.Text == "Insira o nome da Empresa" || mskCNPJ.MaskFull == false || (mskTelefoneEmpresa.MaskFull == false && (txtEmailEmpresa.Text.Length < 5 || txtEmailEmpresa.Text == "Insira o email da Empresa")))
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
                        DialogResult result = MessageBox.Show("Deseja realmente atualizar o cadastro da empresa: " + txtNomeEmpresa.Text + "?", "Mensagem de Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }
    }
}
