using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace Projeto_03__Senai
{
    public partial class FormBuscaAvancada : Form
    {
        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;
        public FormBuscaAvancada()
        {
            InitializeComponent();
        }

        DataSet result;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    string.Format("sexo LIKE '{0}%' OR sexo LIKE '% {0}%'", txtFiltrarRA.Text);
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
                    string.Format("sexo LIKE '{0}%' OR sexo LIKE '% {0}%'", dtpFiltrarDataMatricula.Text);
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
                    string.Format("sexo LIKE '{0}%' OR sexo LIKE '% {0}%'", txtFiltrarTurma.Text);
                }
            }
        }

        private void btnFiltrarAlunosEmpresa_Click(object sender, EventArgs e)
        {
            //Validação para o caso do textbox estar em branco ou com um placeholder
            if (mskFiltrarAlunosNaEmpresa.MaskFull == false)
            {
                MessageBox.Show("Insira um valor no campo de filtro de Alunos da Empresa ao lado da opção 'Filtrar Alunos na Empresa'");
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
                    string.Format("sexo LIKE '{0}%' OR sexo LIKE '% {0}%'", mskFiltrarAlunosNaEmpresa.Text);
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
                    string.Format("sexo LIKE '{0}%' OR sexo LIKE '% {0}%'", txtFiltrarPorIdade.Text);
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
                    string.Format("sexo LIKE '{0}%' OR sexo LIKE '% {0}%'", txtFiltrarPorGenero.Text);
                }
            }
        }

        private void FormBuscaAvancada_Load(object sender, EventArgs e)
        {
            txtFiltrarRA.Text = "Insira a RA do Aluno";
            txtFiltrarRA.ForeColor = Color.Gray;

            txtFiltrarTurma.Text = "Insira o código da Turma";
            txtFiltrarTurma.ForeColor = Color.Gray;

            txtFiltrarPorIdade.Text = "Insira a Idade do Aluno";
            txtFiltrarPorIdade.ForeColor = Color.Gray;

            txtFiltrarPorGenero.Text = "Insira o Gênero do Aluno";
            txtFiltrarPorGenero.ForeColor = Color.Gray;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = result.Tables[comboBox1.SelectedIndex];
        }

        private void txtFiltrarRA_Enter(object sender, EventArgs e)
        {
            if (txtFiltrarRA.Text == "Insira a RA do Aluno")
            {
                txtFiltrarRA.Text = "";
                txtFiltrarRA.ForeColor = Color.Black;
            }
        }

        private void txtFiltrarRA_Leave(object sender, EventArgs e)
        {
            if (txtFiltrarRA.Text == "")
            {
                txtFiltrarRA.Text = "Insira a RA do Aluno";
                txtFiltrarRA.ForeColor = Color.Gray;
            }
        }

        private void txtFiltrarTurma_Enter(object sender, EventArgs e)
        {
            if (txtFiltrarTurma.Text == "Insira o código da Turma")
            {
                txtFiltrarTurma.Text = "";
                txtFiltrarTurma.ForeColor = Color.Black;
            }
        }

        private void txtFiltrarTurma_Leave(object sender, EventArgs e)
        {
            if (txtFiltrarTurma.Text == "")
            {
                txtFiltrarTurma.Text = "Insira o código da Turma";
                txtFiltrarTurma.ForeColor = Color.Gray;
            }
        }

        private void txtFiltrarPorIdade_Leave(object sender, EventArgs e)
        {
            if (txtFiltrarPorIdade.Text == "")
            {
                txtFiltrarPorIdade.Text = "Insira a Idade do Aluno";
                txtFiltrarPorIdade.ForeColor = Color.Gray;
            }
        }

        private void txtFiltrarPorIdade_Enter(object sender, EventArgs e)
        {
            if (txtFiltrarPorIdade.Text == "Insira a Idade do Aluno")
            {
                txtFiltrarPorIdade.Text = "";
                txtFiltrarPorIdade.ForeColor = Color.Black;
            }
        }

        private void txtFiltrarPorGenero_Leave(object sender, EventArgs e)
        {
            if (txtFiltrarPorGenero.Text == "")
            {
                txtFiltrarPorGenero.Text = "Insira o Gênero do Aluno";
                txtFiltrarPorGenero.ForeColor = Color.Gray;
            }
        }

        private void txtFiltrarPorGenero_Enter(object sender, EventArgs e)
        {
            if (txtFiltrarPorGenero.Text == "Insira o Gênero do Aluno")
            {
                txtFiltrarPorGenero.Text = "";
                txtFiltrarPorGenero.ForeColor = Color.Black;
            }
        }

        ReportDataSource rs = new ReportDataSource();
        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            List<ClassAluno> lst = new List<ClassAluno>();
            lst.Clear();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                
                ClassAluno aluno = new ClassAluno
                {
                    Nome = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    Idade = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()),
                    Sexo = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    Telefone = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                };
                lst.Add(aluno);
            }

            rs.Name = "DataSet1";
            rs.Value = lst;
            FormRelatorioAluno relatorio = new FormRelatorioAluno();
            relatorio.reportViewer1.LocalReport.DataSources.Clear();
            relatorio.reportViewer1.LocalReport.DataSources.Add(rs);
            relatorio.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto 03- Senai.Report1.rdlc";
            relatorio.ShowDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }
    }
}
