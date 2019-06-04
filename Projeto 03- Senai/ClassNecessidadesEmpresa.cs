using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_03__Senai
{
    class ClassNecessidadesEmpresa
    {
        public int CodNecessidade { get; set; }
        public string NomeEmpresaC { get; set; }
        public DateTime DataRequerimento { get; set; }
        public int QtdContratoFaseEscolar { get; set; }
        public int QtdContratoPraticaSequencial { get; set; }
        public int QtdContratoConcomitante { get; set; }
        public int QtdContratoSequencial { get; set; }
        public int QtdContratoDual { get; set; }
        public string Empresa_Cnpj { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool RegistrarNecessidade()
        {
            try
            {
                //Conectar no Banco
                bd.Conectar();
                string dataRequerimentoShow = DataRequerimento.ToString("yyyy-MM-dd");

                //Executar o Insert
                bd.ExecutarComandosSql(String.Format("INSERT INTO NecessidadeEmpresa(nomeEmpresaC, dataRequerimento, qtdContratoFaseEscolar, qtdContratoPraticaSequecial, qtdContratoConcomitante," +
                    "qtdContratoSequecial, qtdContratoDual, Empresa_Cnpj )" +
                    "VALUES (" + NomeEmpresaC + "', '" + dataRequerimentoShow + "', " + QtdContratoFaseEscolar + ", " + QtdContratoPraticaSequencial + ", " + QtdContratoConcomitante + " " +
                    " " + QtdContratoSequencial + ", " + QtdContratoDual + ", '" + Empresa_Cnpj + "')"));

                //Desconectar
                bd.Desconectar();
                MessageBox.Show("Necessidade Registrada com Sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                     "Erro ao inserir a Necessidade");

            }
        }

        public bool EditarNecessidade(int codNecessidade)
        {
            try
            {
                //Conectar no Banco
                bd.Conectar();
                string dataRequerimentoShow = DataRequerimento.ToString("yyyy-MM-dd");


                //Executar o Insert
                bd.ExecutarComandosSql(String.Format("Update NecessidadeEmpresa SET " +
                    " nomeEmpresaC = '" + NomeEmpresaC + "', dataRequerimento = '" + DataRequerimento + "', qtdContratoFaseEscolar = " + QtdContratoFaseEscolar + ", qtdContratoPraticaSequencial = '" + QtdContratoPraticaSequencial + "', qtdContratoConcomitante = '" + QtdContratoConcomitante + "', qtdContratoSequencial = '" + QtdContratoSequencial + "' " +
                    " qtdContratoDual = '" + QtdContratoDual + "', Empresa_Cnpj = '" + Empresa_Cnpj + "'" +
                    " WHERE codNecessidade LIKE " + CodNecessidade));

                //Desconectar
                bd.Desconectar();
                MessageBox.Show("Cadastro do Encaminhamento Atualizado com Sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                     "Erro ao editar o Encaminhamento");

            }
        }
        // Executar Excluir
        public void ExcluirNecessidade(int codNecessidade)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("DELETE FROM NecessidadeEmpresa WHERE CodNecessidade = '" + codNecessidade + "'"));
            bd.Desconectar();
            MessageBox.Show("Necessidades de Empresa Excluido com Sucesso!");

        }

        //Executar Select 
        public DataTable MostrarNecessidade()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM NecessidadeEmpresa"));
            bd.Desconectar();
            return dt;
        }

        //Select por CNPJ
        public DataTable MostrarNecessidadesPorCNPJ(string cnpj)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM NecessidadeEmpresa WHERE Empresa_Cnpj = " + cnpj + ""));
            bd.Desconectar();
            return dt;
        }
    }
}

