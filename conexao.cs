using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class conexao
    {
        SqlConnection con = new SqlConnection();

        //construtor
        public conexao()
        {
            con.ConnectionString = "Data Source=LAPTOP-JSJP7MEP;Initial Catalog=Trabalho-Final;Integrated Security=True";
        }
        //Metodo Conectar
        public SqlConnection conectar() 
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }
        //Metodo desconectar
        public void desconectar() 
        { 
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        } 

    }
}
