using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WebApplication1
{
    public class CadastroPaciente
    {
        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public CadastroPaciente() 
        {
            cmd.CommandText = "";

            //cmd.Parameters.AddWithValue("",);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Cadastrado com Sucesso!!";
            }
            catch (SqlException e) 
            {
                this.mensagem = "Erro ao tentar se conectar com o Banco de Dados!!";
            }
        }
    }
}
