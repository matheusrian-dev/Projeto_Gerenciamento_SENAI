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
    }
}
