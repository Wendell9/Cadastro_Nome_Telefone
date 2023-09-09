using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Nome_Telefone
{
    public class Conexão
    {
        SqlConnection con = new SqlConnection();
        //Construtor
        //Método para se conectar com o BD
        //Método para se desconectar com o BD
        public Conexão()
        {
            con.ConnectionString = "Data Source=DESKTOP-UOHE1VE\\SQLSERVER2022;Initial Catalog=testDB;Integrated Security=True";
            //password se necessário
        }

        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed) 
            {
            con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
