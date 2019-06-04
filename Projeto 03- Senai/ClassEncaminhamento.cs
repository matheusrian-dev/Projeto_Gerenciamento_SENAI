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

        public void ExcluirEncaminhamento(int codEncaminhar)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("DELETE FROM Encaminhar WHERE codEncaminhar = '" + codEncaminhar + "'"));
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

        public DataTable MostrarEncaminhamentoRa(int ra)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Encaminhar WHERE raEncaminhar = " + ra + ""));
            
            if (dt.Rows.Count == 0)
            {
            }
            else
            {
                CodEncaminhar = int.Parse(dt.Rows[0]["codEncaminhar"].ToString());
                // Informações do Aluno
                NomeAluno = dt.Rows[0]["nomeAluno"].ToString();
                CpfEncaminhar = dt.Rows[0]["cpfEncaminhar"].ToString();
                RaEncaminhar = int.Parse(dt.Rows[0]["raEncaminhar"].ToString());
                RgEncaminhar = dt.Rows[0]["rgEncaminhar"].ToString();
                EmailEncaminhar = dt.Rows[0]["emailEncaminhar"].ToString();
                TelefoneEncaminhar = dt.Rows[0]["telefoneEncaminhar"].ToString();
                CodTurmaEncaminhar = dt.Rows[0]["codTurmaEncaminhar"].ToString();
                SexoEncaminhar = dt.Rows[0]["sexoEncaminhar"].ToString();
                // Informações do Contrato
                Periodo = dt.Rows[0]["periodo"].ToString();
                TipoContrato = dt.Rows[0]["tipoContrato"].ToString();
                InicioContrato = Convert.ToDateTime(dt.Rows[0]["inicioContrato"].ToString());
                FimContrato = Convert.ToDateTime(dt.Rows[0]["fimContrato"].ToString());
                // Informações da Empresa
                NomeFantasia = dt.Rows[0]["nomeFantasia"].ToString();
                TelefoneEmpresa2 = dt.Rows[0]["telefoneEmpresa2"].ToString();
                EmailEmpresa2 = dt.Rows[0]["emailEmpresa2"].ToString();
                EnderecoEmpresa = dt.Rows[0]["enderecoEmpresa"].ToString();
                RazaoSocial2 = dt.Rows[0]["razaoSocial2"].ToString();
                Responsavel2 = dt.Rows[0]["responsavel2"].ToString();
                Empresa_Cnpj = dt.Rows[0]["Empresa_cnpj"].ToString();
            }
            bd.Desconectar();
            return dt;
        }

        public bool RetornarEncaminhamentoRa(int ra)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Encaminhar WHERE raEncaminhar = " + ra + ""));
            bd.Desconectar();
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable MostrarEncaminhamentoCnpj(string cnpj)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Encaminhar WHERE Empresa_cnpj = " + cnpj + ""));
            bd.Desconectar();
            return dt;
        }

    }
}

