using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Projeto_03__Senai
{
    public partial class UserControlGerarRelatorioEmpresa : UserControl
    {
        public UserControlGerarRelatorioEmpresa()
        {
            InitializeComponent();
        }
        ClassEmpresa empresa = new ClassEmpresa();

        private void txtGerarPorCNPJ_Enter(object sender, EventArgs e)
        {

            if (mskGerarPorCNPJ.Text == "Insira o CNPJ da Empresa")
            {
                mskGerarPorCNPJ.Text = "";
                mskGerarPorCNPJ.ForeColor = Color.Black;
            }
        }

        private void txtGerarPorCNPJ_Leave(object sender, EventArgs e)
        {
            if (mskGerarPorCNPJ.Text == "")
            {
                mskGerarPorCNPJ.Text = "Insira o CNPJ da Empresa";
                mskGerarPorCNPJ.ForeColor = Color.Gray;
            }
        }

        private void UserControlGerarRelatorioEmpresa_Load(object sender, EventArgs e)
        {
            mskGerarPorCNPJ.Text = "Insira o CNPJ da Empresa";
            mskGerarPorCNPJ.ForeColor = Color.Gray;
        }

        private void btnGerarTodasEmpresas_Click(object sender, EventArgs e)
        {
            DataTable validTable = empresa.MostrarEmpresasPorCnpj(mskGerarPorCNPJ.Text);
            if (validTable.Rows.Count == 0)
            {
                MessageBox.Show("Não Há empresas cadastradas no sistema, por favor registre ao menos uma empresa antes de realizar uma busca");
            }
            else
            {
                ReportDataSource reportsource = new ReportDataSource();
                reportsource.Name = "DataSetEmpresa";
                reportsource.Value = empresa.MostrarEmpresas();
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportsource);
                reportViewer1.RefreshReport();
            }
        }

        private void btnGerarPorCNPJ_Click(object sender, EventArgs e)
        {
            DataTable validTable = empresa.MostrarEmpresasPorCnpj(mskGerarPorCNPJ.Text);
            if (validTable.Rows.Count == 0)
            {
                MessageBox.Show("CNPJ não encontrado no sistema, verifique se digitou corretamente.");
            }
            else
            {
                ReportDataSource reportsource = new ReportDataSource();
                reportsource.Name = "DataSetEmpresa";
                reportsource.Value = empresa.MostrarEmpresasPorCnpj(mskGerarPorCNPJ.Text);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportsource);
                reportViewer1.RefreshReport();
            }
            
        }
    }
}
