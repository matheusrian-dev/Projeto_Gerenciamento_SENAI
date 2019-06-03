using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_03__Senai
{
    public partial class FormEncaminharAluno : Form
    {
        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;
        public FormEncaminharAluno()
        {
            InitializeComponent();
        }

        DataSet result;

        ClassEmpresa empresa = new ClassEmpresa();

        private void FormEncaminharAluno_Load(object sender, EventArgs e)
        {
            //Inserção do PlaceHolder ao iniciar o Form
            txtFiltrarRA.Text = "Insira a RA do Aluno";
            txtFiltrarRA.ForeColor = Color.Gray;

            txtFiltrarTurma.Text = "Insira o código da Turma";
            txtFiltrarTurma.ForeColor = Color.Gray;

            txtFiltrarPorIdade.Text = "Insira a Idade do Aluno";
            txtFiltrarPorIdade.ForeColor = Color.Gray;

            txtFiltrarPorGenero.Text = "Insira o Gênero do Aluno";
            txtFiltrarPorGenero.ForeColor = Color.Gray;
            
            dataGridView2.DataSource = empresa.MostrarEmpresas();
        }

        private void btnBuscarArquivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog() { Filter = "Excel Work Book 97-2003|*.xls|Excel Workbook|* .xlsx", ValidateNames = true })
            {
                if (of.ShowDialog() == DialogResult.OK)
                {

                    FileStream fs = File.Open(of.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader;
                    if (of.FilterIndex == 1)
                    {
                        reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    }

                    else
                    {
                        reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                    }

                    result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true  // set to true to use excel first row as column in datagridview
                        }

                    });

                    comboBox1.Items.Clear();
                    foreach (DataTable dt in result.Tables)
                    {
                        comboBox1.Items.Add(dt.TableName);

                    }
                    reader.Close();


                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = result.Tables[comboBox1.SelectedIndex];
        }

        private void btnFiltrarRA_Click(object sender, EventArgs e)
        {
            //Validação para o caso do textbox estar em branco ou com um placeholder
            if (txtFiltrarRA.Text.Length < 1 || txtFiltrarRA.Text == "Insira a RA do Aluno")
            {
                MessageBox.Show("Insira um valor no campo de filtro de RA ao lado da opção 'Filtrar por RA'");
            }
            else
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    //Validação para o caso da tabela não tenha sido selecionada ainda
                    MessageBox.Show("Por favor, selecione uma tabela antes de filtrar!");
                }
                else
                {
                    //Código para filtrar o datagridview, para colocar mais filtros juntos só adicionar AND/OR e a condição, 
                    // como faria no banco de dados 
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("[RA ALUNO] LIKE '{0}%' OR [RA ALUNO] LIKE '% {0}%'", txtFiltrarRA.Text);
                }
            }
        }

        private void btnFiltrarDataMatricula_Click(object sender, EventArgs e)
        {
            //Validação para o caso do textbox estar em branco ou com um placeholder
            if (dtpFiltrarDataMatricula.Text.Length < 10)
            {
                MessageBox.Show("Insira um valor no campo de filtro da Data de Matrícula ao lado da opção 'Filtrar por Data de Matrícula'");
            }
            else
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    //Validação para o caso da tabela não tenha sido selecionada ainda
                    MessageBox.Show("Por favor, selecione uma tabela antes de filtrar!");
                }
                else
                {
                    //Código para filtrar o datagridview, para colocar mais filtros juntos só adicionar AND/OR e a condição, 
                    // como faria no banco de dados 
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format(CultureInfo.InvariantCulture.DateTimeFormat, "[DATA DE MATRICULA] >= '{0} 00:00:00' AND [DATA DE MATRICULA] <= '{0} 23:59:59'", dtpFiltrarDataMatricula.Value.ToString("dd/MM/yyyy"));
                }
            }
        }

        private void btnFiltrarTurma_Click(object sender, EventArgs e)
        {
            //Validação para o caso do textbox estar em branco ou com um placeholder
            if (txtFiltrarTurma.Text.Length < 1 || txtFiltrarTurma.Text == "Insira o código da Turma")
            {
                MessageBox.Show("Insira um valor no campo de filtro de Turma ao lado da opção 'Filtrar por Turma'");
            }
            else
            {
                //Validação para o caso da tabela não tenha sido selecionada ainda
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione uma tabela antes de filtrar!");
                }
                else
                {
                    //Código para filtrar o datagridview, para colocar mais filtros juntos só adicionar AND/OR e a condição, 
                    // como faria no banco de dados 
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("[CODIGO TURMA] LIKE '{0}%' OR [CODIGO TURMA] LIKE '% {0}%'", txtFiltrarTurma.Text);
                }
            }
        }

        private void btnFiltrarPorIdade_Click(object sender, EventArgs e)
        {
            //Validação para o caso do textbox estar em branco ou com um placeholder
            if (txtFiltrarPorIdade.Text.Length < 1 || txtFiltrarPorIdade.Text == "Insira a Idade do Aluno")
            {
                MessageBox.Show("Insira um valor no campo de filtro da idade do aluno ao lado da opção 'Filtrar Alunos por Idade'");
            }
            else
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    //Validação para o caso da tabela não tenha sido selecionada ainda
                    MessageBox.Show("Por favor, selecione uma tabela antes de filtrar!");
                }
                else
                {
                    //Código para filtrar o datagridview, para colocar mais filtros juntos só adicionar AND/OR e a condição, 
                    // como faria no banco de dados 
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("[IDADE DO ALUNO] = {0}", int.Parse(txtFiltrarPorIdade.Text));
                }
            }
        }

        private void btnFiltrarPorGenero_Click(object sender, EventArgs e)
        {
            //Validação para o caso do textbox estar em branco ou com um placeholder
            if (txtFiltrarPorGenero.Text.Length < 1 || txtFiltrarPorGenero.Text == "Insira o Gênero do Aluno")
            {
                MessageBox.Show("Insira um valor no campo de filtro do Gênero do aluno ao lado da opção 'Filtrar Alunos por Gênero'");
            }
            else
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    //Validação para o caso da tabela não tenha sido selecionada ainda
                    MessageBox.Show("Por favor, selecione uma tabela antes de filtrar!");
                }
                else
                {
                    //Código para filtrar o datagridview, para colocar mais filtros juntos só adicionar AND/OR e a condição, 
                    // como faria no banco de dados 
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("SEXO LIKE '{0}%' OR SEXO LIKE '% {0}%'", txtFiltrarPorGenero.Text);
                }
            }
        }

        private void btnUndoFilter_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
        }
        //Remoção do PlaceHolder
        private void txtFiltrarRA_Enter(object sender, EventArgs e)
        {
            if (txtFiltrarRA.Text == "Insira a RA do Aluno")
            {
                txtFiltrarRA.Text = "";
                txtFiltrarRA.ForeColor = Color.Black;
            }
        }
        //Inserção do PlaceHolder
        private void txtFiltrarRA_Leave(object sender, EventArgs e)
        {
            if (txtFiltrarRA.Text == "")
            {
                txtFiltrarRA.Text = "Insira a RA do Aluno";
                txtFiltrarRA.ForeColor = Color.Gray;
            }
        }
        //Remoção do PlaceHolder
        private void txtFiltrarTurma_Enter(object sender, EventArgs e)
        {
            if (txtFiltrarTurma.Text == "Insira o código da Turma")
            {
                txtFiltrarTurma.Text = "";
                txtFiltrarTurma.ForeColor = Color.Black;
            }
        }
        //Inserção do PlaceHolder
        private void txtFiltrarTurma_Leave(object sender, EventArgs e)
        {
            if (txtFiltrarTurma.Text == "")
            {
                txtFiltrarTurma.Text = "Insira o código da Turma";
                txtFiltrarTurma.ForeColor = Color.Gray;
            }
        }
        //Remoção do PlaceHolder
        private void txtFiltrarPorIdade_Enter(object sender, EventArgs e)
        {
            if (txtFiltrarPorIdade.Text == "Insira a Idade do Aluno")
            {
                txtFiltrarPorIdade.Text = "";
                txtFiltrarPorIdade.ForeColor = Color.Black;
            }
        }
        //Inserção do PlaceHolder
        private void txtFiltrarPorIdade_Leave(object sender, EventArgs e)
        {
            if (txtFiltrarPorIdade.Text == "")
            {
                txtFiltrarPorIdade.Text = "Insira a Idade do Aluno";
                txtFiltrarPorIdade.ForeColor = Color.Gray;
            }
        }
        //Remoção do PlaceHolder
        private void txtFiltrarPorGenero_Enter(object sender, EventArgs e)
        {
            if (txtFiltrarPorGenero.Text == "Insira o Gênero do Aluno")
            {
                txtFiltrarPorGenero.Text = "";
                txtFiltrarPorGenero.ForeColor = Color.Black;

            }
        }
        //Inserção do PlaceHolder
        private void txtFiltrarPorGenero_Leave(object sender, EventArgs e)
        {
            if (txtFiltrarPorGenero.Text == "")
            {
                txtFiltrarPorGenero.Text = "Insira o Gênero do Aluno";
                txtFiltrarPorGenero.ForeColor = Color.Gray;
            }
        }

        private void btnEncaminharAluno_Click(object sender, EventArgs e)
        {
            ClassEncaminhamento encaminhamento = new ClassEncaminhamento();
            //Informações Pessoais do Aluno
            encaminhamento.NomeAluno = txtNomeAluno.Text;
            encaminhamento.CpfEncaminhar = mskCPFAluno.Text;
            encaminhamento.RaEncaminhar = int.Parse(txtRAAluno.Text);
            encaminhamento.RgEncaminhar = mskRGAluno.Text;
            encaminhamento.EmailEncaminhar = txtEmailAluno.Text;
            encaminhamento.TelefoneEncaminhar = mskTelefoneAluno.Text;
            encaminhamento.CodTurmaEncaminhar = mskCodTurma.Text;
            encaminhamento.SexoEncaminhar = mskSexoAluno.Text;
            // Informações do Contrato
            string periodoCompleto = cboPeriodo1.Text + " de " + dtpPeriodo2.Text;
            encaminhamento.Periodo = periodoCompleto;
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
            encaminhamento.RegistrarEncaminhamento();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnBuscarCNPJ_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = empresa.MostrarEmpresasPorCnpj(mskBuscarPorCNPJ.Text);
        }

        private void btnReverterBuscas_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = empresa.MostrarEmpresas();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtNomeAluno.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            mskCPFAluno.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
            mskRGAluno.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            txtRAAluno.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtEmailAluno.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
            mskTelefoneAluno.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            mskCodTurma.Text = dataGridView1.SelectedRows[0].Cells[60].Value.ToString();
            mskSexoAluno.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtNomeFantasia.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            mskCNPJ.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            mskTelefoneEmpresa.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            txtEmailEmpresa.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            txtEnderecoEmpresa.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            txtRazaoSocial.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            txtResponsavel.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnMostrarNecessidade_Click(object sender, EventArgs e)
        {
            //Criar um Form para mostrar a Tabela com as necessidades registradas
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
