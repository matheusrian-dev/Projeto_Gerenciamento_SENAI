using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_03__Senai
{
    class ClassEncaminhamento
    {
        // Informações do Aluno
        public int CodEncaminhar { get; set; }
        public string NomeAluno { get; set; }
        public string CpfEncaminhar { get; set; }
        public int RaEncaminhar { get; set; }
        public string RgEncaminhar { get; set; }
        public string EmailEncaminhar { get; set; }
        public string TelefoneEncaminhar { get; set; }
        public string CodTurmaEncaminhar { get; set; }
        public string SexoEncaminhar { get; set; }
        // Informações do Contrato
        public string Periodo { get; set; }
        public string TipoContrato { get; set; }
        public DateTime InicioContrato { get; set; }
        public DateTime FimContrato { get; set; }
        // Informações da Empresa
        public string NomeFantasia { get; set; }
        public string TelefoneEmpresa2 { get; set; }
        public string EmailEmpresa2 { get; set; }
        public string EnderecoEmpresa { get; set; }
        public string RazaoSocial2 { get; set; }
        public string Responsavel2 { get; set; }
        public string Empresa_Cnpj { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool RegistrarEncaminhamento()
        {
            try
            {
                //Conectar no Banco
                bd.Conectar();
                string inicioContratoShow = InicioContrato.ToString("yyyy-MM-dd");
                string fimContratoShow = FimContrato.ToString("yyyy-MM-dd");

                //Executar o Insert
                bd.ExecutarComandosSql(String.Format("INSERT INTO Encaminhar(codEncaminhar, nomeAluno, cpfEncaminhar, raEncaminhar, rgEncaminhar, emailEncaminhar, telefoneEncaminhar, codTurmaEncaminhar, sexoEncaminhar, periodo," +
                    "tipoContrato, inicioContrato, fimContrato, nomeFantasia, telefoneEmpresa2, emailEmpresa2, enderecoEmpresa, razaoSocial2, responsavel2, Empresa_Cnpj )" +
                    "VALUES (" + CodEncaminhar + ", '" + NomeAluno + "', '" + CpfEncaminhar + "', " + RaEncaminhar + ", '" + RgEncaminhar + "', '" + EmailEncaminhar + "', '" + TelefoneEncaminhar + "', '" + CodTurmaEncaminhar + "', '" + SexoEncaminhar + "'" +
                    " '" + Periodo + "', '" + TipoContrato + "', '" + inicioContratoShow + "', '" + fimContratoShow + "', '" + NomeFantasia + "', '" + TelefoneEmpresa2 + "' " +
                    " '" + EmailEmpresa2 + "', '" + EnderecoEmpresa + "', '" + RazaoSocial2 + "', '" + Responsavel2 + "', '" + Empresa_Cnpj + "')"));

                //Desconectar
                bd.Desconectar();
                MessageBox.Show("Encaminhamento Registrado com Sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                     "Erro ao inserir o Encaminhamento");

            }
        }

        public bool EditarEncaminhamento(int codEncaminhar)
        {
            try
            {
                //Conectar no Banco
                bd.Conectar();
                string inicioContratoShow = InicioContrato.ToString("yyyy-MM-dd");
                string fimContratoShow = FimContrato.ToString("yyyy-MM-dd");

                //Executar o Insert
                bd.ExecutarComandosSql(String.Format("Update Enturmar SET " +
                    " nomeAluno = '" + NomeAluno + "', cpfEncaminhar = '" + CpfEncaminhar + "', raEncaminhar = " + RaEncaminhar + ", rgEncaminhar = '" + RgEncaminhar + "', emailEncaminhar = '" + EmailEncaminhar + "', telefoneEncaminhar = '" + TelefoneEncaminhar + "' " +
                    " codTurmaEncaminhar = '" + CodTurmaEncaminhar + "', sexoEnturmar = '" + SexoEncaminhar + "', periodo = '" + Periodo + "', tipoContrato = '" + TipoContrato + "', inicioContrato = '" + inicioContratoShow + "' " +
                    " fimContrato = '" + fimContratoShow + "', nomeFantasia = '" + NomeFantasia + "', telefoneEmpresa2 = '" + TelefoneEmpresa2 + "', emailEmpresa2 = '" + EmailEmpresa2 + "', enderecoEmpresa = '" + EnderecoEmpresa + "' " +
                    " razaoSocial2 = '" + RazaoSocial2 + "', responsavel2 = '" + Responsavel2 + "',  Empresa_Cnpj = '" + Empresa_Cnpj + "'" +
                    " WHERE codEnturmar LIKE " + codEncaminhar));

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

        public void ExcluirEncaminhamento()
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("DELETE FROM Encaminhar WHERE codEncaminhar = '" + CodEncaminhar + "'"));
            bd.Desconectar();
            MessageBox.Show("Encaminhamento Excluido com Sucesso!");

        }

        public DataTable MostrarEncaminhamento()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Encaminhar"));
            bd.Desconectar();
            return dt;
        }

        public DataTable MostrarEncaminhamentoRa()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Encaminhar WHERE raEncaminhar = " + RaEncaminhar + ""));
            bd.Desconectar();
            return dt;
        }

        public DataTable MostrarEncaminhamentoCnpj()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Encaminhar WHERE Empresa_cnpj = " + Empresa_Cnpj + ""));
            bd.Desconectar();
            return dt;
        }

    }
}

