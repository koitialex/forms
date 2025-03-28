using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace forms.model
{
    internal class database
    {
        public static void SalvarAluno(aluno aluno)
        {
            string stringDeConexao = "server= 127.0.0.1; Port=3306; User Id=root;database = ti113_windowsforms";
            MySqlConnection conexao = new MySqlConnection(stringDeConexao);
            conexao.Open();

            string query = "insert into Alunos ( Nome, Cpf, Telefone," +
                " DataNascimento, NomeMae, Email, IdEnderecoAluno)" +
                "values(@Nome,@Cpf,@Telefone,@DataNascimento,@NomeDaMae,@Email,@IdEnderecoAluno)";
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@NumeroMatricula", aluno.NumeroMatricula);
            cmd.Parameters.AddWithValue("@NomeMae", aluno.NomeMae);
            cmd.Parameters.AddWithValue("@Email", aluno.Email);
            cmd.Parameters.AddWithValue("@EnderecoAluno", aluno.EnderecoAluno);
            cmd.Parameters.AddWithValue("@Cpf", aluno.Cpf);
            cmd.Parameters.AddWithValue("@Telefone", aluno.Telefone);
            cmd.Parameters.AddWithValue("@DataNascimento", aluno.DataNascimento);

            cmd.ExecuteNonQuery();
            conexao.Close();

        }
        public static int SalvarEndereco(endereco endereco, out int idEndereco) //"out int idEndereco" serve para que endereco saia para o idenreco
        {
            string stringDeConexao = "server= 127.0.0.1; Port=3306; User Id=root;database = ti113_windowsforms";
            MySqlConnection conexao = new MySqlConnection(stringDeConexao);
            conexao.Open();

            string query = "insert into Alunos ( Logradouro, Numero, Cep," +
                "bairro, Complemento, Cidade, Estado,Pais)" +
                "values(@Logradouro,@Numero,@Cep,@bairro,@Complemento,@Cidade,@Estado,@Pais)";
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@Logradouro", endereco.Logradouro);
            cmd.Parameters.AddWithValue("@Numero", endereco.Numero);
            cmd.Parameters.AddWithValue("@Cep", endereco.Cep);
            cmd.Parameters.AddWithValue("@bairro", endereco.bairro);
            cmd.Parameters.AddWithValue("@Complemento", endereco.Complemento);
            cmd.Parameters.AddWithValue("@Cidade", endereco.Cidade);
            cmd.Parameters.AddWithValue("@Estado", endereco.Estado);
            cmd.Parameters.AddWithValue("@Pais", endereco.Pais);
            int quantidade = cmd.ExecuteNonQuery();
            idEndereco = Convert.ToInt32(cmd.LastInsertedId);
            conexao.Close();

            if (quantidade == 0)
                return false;
            else
                return true;
        }

    }
}
