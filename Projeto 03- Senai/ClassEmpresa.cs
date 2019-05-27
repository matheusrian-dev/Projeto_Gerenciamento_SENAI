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
                DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Empresa WHERE cnpj = '" + Cnpj + "'"));
                if (dt.Rows.Count == 0)
                {
                    //Executar o Insert
                    bd.ExecutarComandosSql(String.Format("INSERT INTO Empresa(cnpj, nomeEmpresa, razaoSocial, endereco, telefoneEmpresa, emailEmpresa, responsavel)" +
                    " VALUES ('" + Cnpj + "', '" + NomeEmpresa + "', '" + RazaoSocial + "', '" + Endereco + "', '" + TelefoneEmpresa + "', '" + EmailEmpresa + "', '" + Responsavel + "')"));
                    MessageBox.Show("Empresa Cadastrada com Sucesso!");
                }
                else
                {
                    MessageBox.Show("O CNPJ inserido já está registrado no sistema");
                }

                //Desconectar
                bd.Desconectar();
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

        public bool RetEmpresaCNPJ(string cnpj)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Empresa WHERE cnpj = '" + cnpj + "'"));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("CNPJ não encontrado");
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable MostrarEmpresas()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Empresa"));
            bd.Desconectar();
            return dt;
        }

        public DataTable MostrarCNPJEmpresas()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT CNPJ FROM Empresa"));
            bd.Desconectar();
            return dt;
        }

        public DataTable MostrarEmpresasPorCnpj(string cnpj)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Empresa WHERE cnpj = '" + cnpj + "'"));
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Não há empresas cadastradas com o CNPJ informado, verifique se inseriu corretamente o valor.");
            }
            else
            {
                NomeEmpresa = dt.Rows[0]["nomeEmpresa"].ToString();
                RazaoSocial = dt.Rows[0]["razaoSocial"].ToString();
                Endereco = dt.Rows[0]["endereco"].ToString();
                TelefoneEmpresa = dt.Rows[0]["telefoneEmpresa"].ToString();
                EmailEmpresa = dt.Rows[0]["emailEmpresa"].ToString();
                Responsavel = dt.Rows[0]["responsavel"].ToString();
                Cnpj = dt.Rows[0]["cnpj"].ToString();
            }
            
            bd.Desconectar();
            return dt;
        }
    }
}
