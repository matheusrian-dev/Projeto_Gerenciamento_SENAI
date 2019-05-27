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
        public int CodEnturmar { get; set; }
        public string NomeAluno { get; set; }
        public string CpfEnturmar { get; set; }
        public int RaEnturmar { get; set; }
        public string RgEnturmar { get; set; }
        public string EmailEnturmar { get; set; }
        public string TelefoneEnturmar { get; set; }
        public string CodigoEnturmar { get; set; }
        public string SexoEnturmar { get; set; }
        public string Periodo { get; set; }
        public string TipoContrato { get; set; }
        public DateTime InicioContrato { get; set; }
        public DateTime FimContrato { get; set; }
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
                bd.ExecutarComandosSql(String.Format("INSERT INTO Enturmar(codEnturmar, nomeAluno, cpfEnturmar, raEnturmar, rgEnturmar, emailEnturmar, telefoneEnturmar, codigoEnturmar, sexoEnturmar, periodo," +
                    "tipoContrato, inicioContrato, fimContrato, nomeFantasia, telefoneEmpresa2, emailEmpresa2, enderecoEmpresa, razaoSocial2, responsavel2, Empresa_Cnpj )" +
                    "VALUES (" + CodEnturmar + ", '" + NomeAluno + "', '" + CpfEnturmar + "', " + RaEnturmar + ", '" + RgEnturmar + "', '" + EmailEnturmar + "', '" + TelefoneEnturmar + "', '" + CodigoEnturmar + "', '" + SexoEnturmar + "'" +
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

        public bool EditarEncaminhamento(int codEnturmar)
        {
            try
            {
                //Conectar no Banco
                bd.Conectar();
                string inicioContratoShow = InicioContrato.ToString("yyyy-MM-dd");
                string fimContratoShow = FimContrato.ToString("yyyy-MM-dd");

                //Executar o Insert
                bd.ExecutarComandosSql(String.Format("Update Enturmar SET " +
                    " nomeAluno = '" + NomeAluno + "', cpfEnturmar = '" + CpfEnturmar + "', raEnturmar = " + RaEnturmar + ", rgEnturmar = '" + RgEnturmar + "', emailEnturmar = '" + EmailEnturmar + "', telefoneEnturmar = '" + TelefoneEnturmar + "' " +
                    " codigoEnturmar = '" + CodigoEnturmar + "', sexoEnturmar = '" + SexoEnturmar + "', periodo = '" + Periodo + "', tipoContrato = '" + TipoContrato + "', inicioContrato = '" + inicioContratoShow + "' " +
                    " fimContrato = '" + fimContratoShow + "', nomeFantasia = '" + NomeFantasia + "', telefoneEmpresa2 = '" + TelefoneEmpresa2 + "', emailEmpresa2 = '" + EmailEmpresa2 + "', enderecoEmpresa = '" + EnderecoEmpresa + "' " +
                    " razaoSocial2 = '" + RazaoSocial2 + "', responsavel2 = '" + Responsavel2 + "',  Empresa_Cnpj = '" + Empresa_Cnpj + "'" +
                    " WHERE codEnturmar LIKE " + codEnturmar));

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
            bd.ExecutarComandosSql(String.Format("DELETE FROM Enturmar WHERE codEnturmar = '" + CodEnturmar + "'"));
            bd.Desconectar();
            MessageBox.Show("Encaminhamento Excluido com Sucesso!");

        }

        public DataTable MostrarEncaminhamento()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Encaminhamento"));
            bd.Desconectar();
            return dt;
        }

        public DataTable MostrarEncaminhamentoRa()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Encaminhamento WHERE raEnturmar = " + RaEnturmar + ""));
            bd.Desconectar();
            return dt;
        }

        public DataTable MostrarEncaminhamentoCnpj()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Encaminhamento WHERE Empresa_cnpj = " + Empresa_Cnpj + ""));
            bd.Desconectar();
            return dt;
        }
    }
}
