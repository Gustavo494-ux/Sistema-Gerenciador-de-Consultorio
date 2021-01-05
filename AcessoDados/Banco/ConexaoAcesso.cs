using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;



namespace AcessoDados
{
    public class ConexaoAcesso
    {
        //public static NpgsqlConnection conn = new NpgsqlConnection("Server=localHost;Port=5432;User Id=postgres;Password=679-Gust@v0-6951;Database=Sistema_Gerenciador_de_Consultorio");
        public static NpgsqlConnection conn = new NpgsqlConnection("Server=localHost;Port=5432;User Id=postgres;Password=679-6951;Database=Sistema_Gerenciador_de_Consultorio");
        public static string stringConect = Convert.ToString(conn);
        public static void Conectar()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();//Conexão está aberta 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de conexão com o banco de dados, Tente novamente, Caso o problema persista entre em contato com o suporte!"
                    +"\n Erro:\n" + ex
                    ,"Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void Desconectar()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();//Conexão está aberta 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de desconectar o banco de dados, Tente novamente, Caso o problema persista entre em contato com o suporte!",
                        "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
