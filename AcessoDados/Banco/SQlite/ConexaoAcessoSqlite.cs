using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace AcessoDados
{
    public class ConexaoAcessoSQlite
    {
        //private static string stringConect = "Data Source=Databases/Sistema_Gerenciador_de_Consultorio.db";
        //C:\Databases\Sistema_Gerenciador_de_Consultorio
            private static string stringConect = "Data Source=Sistema_Gerenciador_de_Consultorio.db";

        SQLiteConnection conn = new SQLiteConnection(stringConect.ToString());
        public string GetStringConectSqlite()
        {
            try
            {
                return stringConect.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao retornar o caminho do banco SQLite do sistema(Classe ConexaoAcessoSQLite, Método conectSqlite)", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return string.Empty;
        }
     
    }
}

