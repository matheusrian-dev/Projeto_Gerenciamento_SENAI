using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_03__Senai
{
    class ClassEmpresa
    {
        public string Cnpj { get; set; }
        public string NomeEmpresa { get; set; }
        public string RazaoSocial { get; set; }
        public string Endereco { get; set; }
        public string TelefoneEmpresa { get; set; }
        public string EmailEmpresa { get; set; }
        public string Responsavel { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool CadastrarEmpresa()
        {
            try
            {
                //Conectar no Banco
                bd.Conectar();

                //Executar o Insert
                bd.ExecutarComandosSql(String.Format("INSERT INTO Empresa(cnpj, nomeEmpresa, razaoSocial, endereco, telefoneEmpresa, emailEmpresa, responsavel)" +
                    " VALUES ('" + Cnpj + "', '" + NomeEmpresa + "', '" + RazaoSocial + "', '" + Endereco + "', '" + TelefoneEmpresa + "', '" + EmailEmpresa + "', '" + Responsavel + "')"));

                //Desconectar
                bd.Desconectar();
                MessageBox.Show("Empresa Cadastrada com Sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                     "Erro ao inserir a Empresa.");

            }
        }

        public bool EditarEmpresa(string cnpj)
        {
            try
            {
                //Conectar no Banco
                bd.Conectar();

                //Executar o Insert
                bd.ExecutarComandosSql(String.Format("Update Empresa SET " +
                    " nomeEmpresa = '" + NomeEmpresa + "', razaoSocial = '" + RazaoSocial + "', endereco = '" + Endereco + "', telefoneEmpresa = '" + TelefoneEmpresa + "', emailEmpresa = '" + EmailEmpresa + "', responsavel = '" + Responsavel + "'" +
                    " WHERE cnpj LIKE '" + cnpj+"'"));

                //Desconectar
                bd.Desconectar();
                MessageBox.Show("Cadastro da Empresa Atualizado com Sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                     "Erro ao editar a Empresa.");

            }
        }

        public DataTable MostrarEmpresas()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Empresa"));
            bd.Desconectar();
            return dt;
        }

        public DataTable MostrarEmpresasCnpj(string cnpj)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Empresa WHERE cnpj = '" + cnpj + "'"));
            bd.Desconectar();
            return dt;
        }
    }
}
