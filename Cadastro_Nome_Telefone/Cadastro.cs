using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Nome_Telefone
{
    public class Cadastro
    {
        Conexão conexão=new Conexão();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        public Cadastro(string Nome,string Telefone)
        {
            //Comando SQL -- insert, update,delete --Necessário SQLCommand

            cmd.CommandText = "insert into usuario (nome,telefone) values (@Nome,@Telefone)";
            //Parâmetros
            cmd.Parameters.AddWithValue("@Nome",Nome);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);
            //Conectar com banco de dados
            try
            {
                cmd.Connection = conexão.Conectar();
                //recebe o endereço do banco de dados que quer executar
                cmd.ExecuteNonQuery();
                //Executa o comando adicionado no command text
                conexão.Desconectar();
                //desconecta o BD
                this.mensagem = "Cadastrado com Sucesso!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de Dados";
            }
            //executar comando 
            //desconectar
            //mostrar mensagem de erro ou de sucesso
        }

    }
}
