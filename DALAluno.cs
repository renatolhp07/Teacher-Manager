using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Teacher_Manager
{
    internal class DALAluno
    {
        private Conexao objConexao;
        public DALAluno(Conexao conexao)
        {
            objConexao = conexao;
        }

        public void Incluir(Aluno aluno)
        {
            //Abre uma conexão e executa os comandos SQL para incluir dados na tabela tbAluno
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "insert into tbAluno(nome_aluno, rg_aluno, cpf_aluno," +
                "email_aluno, endereco_aluno, responsavel_aluno, rg_responsavel, " +
                "cpf_responsavel, endereco_resp, tel_aluno) values (@nomeAluno, " +
                "@rgAluno, @cpfAluno, @email, @enderecoAluno, @respAluno, " +
                "@rgResp, @cpfResp, @enderecoResp, @telAluno); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nomeAluno", aluno.Nome);
            cmd.Parameters.AddWithValue("@rgAluno", aluno.RgAluno);
            cmd.Parameters.AddWithValue("@cpfAluno", aluno.CpfAluno);
            cmd.Parameters.AddWithValue("@email", aluno.Email);
            cmd.Parameters.AddWithValue("@enderecoAluno", aluno.EnderecoAluno);
            cmd.Parameters.AddWithValue("@respAluno", aluno.ResponsavelAluno);
            cmd.Parameters.AddWithValue("@rgResp", aluno.RgResponsavel);
            cmd.Parameters.AddWithValue("@cpfResp", aluno.CpfResponsavel);
            cmd.Parameters.AddWithValue("@enderecoResp", aluno.EnderecoResp);
            cmd.Parameters.AddWithValue("@telAluno", aluno.TelAluno);
            objConexao.Conectar();
            aluno.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
