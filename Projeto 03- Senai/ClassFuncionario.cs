using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_03__Senai
{
    class ClassFuncionario
    {
        public string Cpf { get; set; }
        public string NomeFunc { get; set; }
        public string Cargo { get; set; }
        public string Senha { get; set; }
        public string TelefoneFunc { get; set; }
        public string EmailFunc { get; set; }
        public string CargoUsuario { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();

        public bool CadastrarFuncionario()
        {
            try
            {
                //Conectar no Banco
                bd.Conectar();
                DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE cpf = '" + Cpf + "'"));
                if (dt.Rows.Count == 0)
                {
                    //Executar o Insert
                    bd.ExecutarComandosSql(String.Format("INSERT INTO Funcionario(cpf, nomeFunc, cargo, senha, telefoneFunc, emailFunc)" +
                        " VALUES ('" + Cpf + "', '" + NomeFunc + "', '" + Cargo + "', '" + Senha + "', '" + TelefoneFunc + "', '" + EmailFunc + "')"));
                    MessageBox.Show("Funcionário Cadastrado com Sucesso!");
                }
                else
                {
                    MessageBox.Show("CPF inserido já registrado no sistema");
                }
                //Desconectar
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                     "Erro ao inserir o Funcionário.");

            }
        }


        public bool EditarFuncionario(string cpf)
        {
            try
            {
                //Conectar no Banco
                bd.Conectar();

                //Executar o Insert
                bd.ExecutarComandosSql(String.Format("Update Funcionario SET " +
                    " nomeFunc = '" + NomeFunc + "', cargo = '" + Cargo + "', senha = '" + Senha + "', telefoneFunc = '" + TelefoneFunc + "', emailFunc = '" + EmailFunc + "'" +
                    " WHERE cpf LIKE '" + cpf +"'"));

                //Desconectar
                bd.Desconectar();
                MessageBox.Show("Cadastro do Funcionário Atualizado com Sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message +
                     "Erro ao editar o Funcionário.");

            }
        }

        public DataTable MostrarFuncionario()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario"));
            bd.Desconectar();
            return dt;
        }

        public DataTable MostrarFuncionarioCpf(string cpf)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE cpf = '" + cpf + "'"));
            string cpfEdit = dt.Rows[0]["cpf"].ToString();
            string nome = dt.Rows[0]["nomeFunc"].ToString();
            string cargo = dt.Rows[0]["cargo"].ToString();
            string telefone = dt.Rows[0]["telefoneFunc"].ToString();
            string email = dt.Rows[0]["emailFunc"].ToString();
            string senha = dt.Rows[0]["senha"].ToString();
            NomeFunc = nome;
            Cargo = cargo;
            TelefoneFunc = telefone;
            EmailFunc = email;
            Senha = senha;
            Cpf = cpfEdit;
            bd.Desconectar();
            return dt;
        }

        public bool RetFuncionarioCPF(string cpf)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE cpf = '" + cpf + "'"));
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("CPF não encontrado");
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable RetFuncionario(string email, string senha)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE emailFunc LIKE '%{0}%' AND senha LIKE '%{1}%'", email, senha));
            bd.Desconectar();
            return dt;
        }

        public bool RealizarLogin()
        {
            DataTable dt = RetFuncionario(EmailFunc, Senha);

            if (dt.Rows.Count > 0)
            {
                string nome = dt.Rows[0]["nomeFunc"].ToString();
                string cargo = dt.Rows[0]["cargo"].ToString();
                NomeFunc = nome;
                CargoUsuario = cargo;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
