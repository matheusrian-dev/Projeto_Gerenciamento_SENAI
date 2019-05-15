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
    public partial class FormCadastrarFuncionario : Form
    {
        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;
        public FormCadastrarFuncionario()
        {
            InitializeComponent();
        }
        ClassFuncionario funcionario = new ClassFuncionario();

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - MouPosX, MousePosition.Y - MouPosY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            funcionario.CargoUsuario = "Coordenador";
            FrmMenuPrincipal menu = new FrmMenuPrincipal(funcionario.CargoUsuario);
            this.Close();
            menu.Show();
        }

        private void btnIrParaEditarFuncionario_Click(object sender, EventArgs e)
        {
            FormAtualizarFuncionario atualizar = new FormAtualizarFuncionario();
            atualizar.Show();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length < 1 || txtNome.Text.Length < 1 || txtSenha.Text.Length < 1 || cboCargo.Text.Length < 1 || mskCPF.MaskFull == false || mskTelefone.MaskFull == false)
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de iniciar o processo de cadastramento.");
            }
            else
            {
                funcionario.Cpf = mskCPF.Text;
                funcionario.NomeFunc = txtNome.Text;
                funcionario.TelefoneFunc = mskTelefone.Text;
                funcionario.EmailFunc = txtEmail.Text;
                funcionario.Senha = txtSenha.Text;
                funcionario.Cargo = cboCargo.Text;
                funcionario.CadastrarFuncionario();
            }
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
