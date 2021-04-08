using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace AcessoDados
{
    public class LocalizarstatusUsuarioAcesso
    {
        DataTable dadosTabelaAcesso = new DataTable();
        DataTable tableVazia = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public DataTable TodosStatus()
        {
			try
			{
                sql.Clear();
                sql.Append("SELECT * from statusUsuario where deletar = false  order by idStatusUsuario asc");
                return acessoBanco.Pesquisar(sql.ToString());
			}
			catch (Exception ex)
			{
                MessageBox.Show("Ocorreu um erro("+ex.Message+") ao pesquisar os status de usuario(Classe LocalizarStatusUsuarioAcesso, Método TodosStatus)","Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
            return tableVazia;
        }
    }
}
