using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Npgsql;


namespace AcessoDados
{
    public class ConexaoAcessoPostegreSql
    {
       //  public static NpgsqlConnection connPostegreSql = new NpgsqlConnection("Server=localHost;Port=5432;User Id=postgres;Password=679-6951;Database=Sistema_Gerenciador_de_Consultorio");
       public static NpgsqlConnection connPostegreSql = new NpgsqlConnection("Server=ec2-18-214-140-149.compute-1.amazonaws.com;Port=5432;User Id=qoovgnxbjrryeu;Password=ffe380d14baa0b1f5c0241957254f8f3b7b6f7ff047106baee9b3348432c6f9e;Database=d84o5di64m9nm3");
        public static string stringConectPostegreSql = Convert.ToString(connPostegreSql);
        public static void Conectar()
        {
            try
            {
                if (connPostegreSql.State == System.Data.ConnectionState.Closed)
                {
                    connPostegreSql.Open();//Conexão está aberta 
                }
            }
            catch (Exception ex)
            {
                string a = Convert.ToString(ex);
                MessageBox.Show("Ocorreu um erro no método de conexão com o banco de dados, Tente novamente, Caso o problema persista entre em contato com o suporte!"
                    + "\n Erro:\n" + ex
                    , "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public static void Desconectar()
        {
            try
            {
                if (connPostegreSql.State == System.Data.ConnectionState.Open)
                {
                    connPostegreSql.Close();//Conexão está aberta 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de desconectar o banco de dados, Tente novamente, Caso o problema persista entre em contato com o suporte!",
                        "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //public static NpgsqlConnection conn = new NpgsqlConnection("Server=localHost;Port=5432;User Id=postgres;Password=679-6951;Database=Sistema_Gerenciador_de_Consultorio");
        ////public static NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=679-6951;Database=Sistema_Gerenciador_de_Consultorio");
        //public static string stringConect = Convert.ToString(conn);
        //public static void Conectar()
        //{
        //    try
        //    {
        //        if (conn.State == System.Data.ConnectionState.Closed)
        //        {
        //            conn.Open();//Conexão está aberta 
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string a = Convert.ToString(ex);
        //        MessageBox.Show("Ocorreu um erro no método de conexão com o banco de dados, Tente novamente, Caso o problema persista entre em contato com o suporte!"
        //            +"\n Erro:\n" + ex
        //            ,"Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //}
        //public static void Desconectar()
        //{
        //    try
        //    {
        //        if (conn.State == System.Data.ConnectionState.Open)
        //        {
        //            conn.Close();//Conexão está aberta 
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ocorreu um erro no método de desconectar o banco de dados, Tente novamente, Caso o problema persista entre em contato com o suporte!",
        //                "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
    }
}
