using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;

namespace Projeto_03__Senai
{
    public partial class UserControlVisualizarDadosAlunos : UserControl
    {
        public UserControlVisualizarDadosAlunos()
        {
            InitializeComponent();
        }

        DataSet result;

        private void btnBuscarRA_Click(object sender, EventArgs e)
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

        private void txtBuscaRA_Enter(object sender, EventArgs e)
        {
            if (txtFiltrarRA.Text == "Insira a RA do Aluno")
            {
                txtFiltrarRA.Text = "";
                txtFiltrarRA.ForeColor = Color.Black;
            }
        }

        private void txtBuscaRA_Leave(object sender, EventArgs e)
        {
            if (txtFiltrarRA.Text == "")
            {
                txtFiltrarRA.Text = "Insira a RA do Aluno";
                txtFiltrarRA.ForeColor = Color.Gray;
            }
        }

        private void UserControlVisualizarDadosAlunos_Load(object sender, EventArgs e)
        {
            txtFiltrarRA.Text = "Insira a RA do Aluno";
            txtFiltrarRA.ForeColor = Color.Gray;

            txtFiltrarTurma.Text = "Insira o código da Turma";
            txtFiltrarTurma.ForeColor = Color.Gray;
        }

        private void txtBuscarTurma_Enter(object sender, EventArgs e)
        {
            if (txtFiltrarTurma.Text == "Insira o código da Turma")
            {
                txtFiltrarTurma.Text = "";
                txtFiltrarTurma.ForeColor = Color.Black;
            }
        }

        private void txtBuscarTurma_Leave(object sender, EventArgs e)
        {
            if (txtFiltrarTurma.Text == "")
            {
                txtFiltrarTurma.Text = "Insira o código da Turma";
                txtFiltrarTurma.ForeColor = Color.Gray;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = result.Tables[comboBox1.SelectedIndex];
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

        private void btnIrParaBuscaAvancada_Click(object sender, EventArgs e)
        {
            FormBuscaAvancada buscaA = new FormBuscaAvancada();
            buscaA.Show();
        }
    }
}
