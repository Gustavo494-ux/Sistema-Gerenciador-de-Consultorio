using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data;

namespace AcessoDados
{
    public class localizarNivelAcesso
    {
        DataTable tableVazia = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public DataTable TodosNiveis()
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT * FROM nivelAcesso where deletar = false order by idNivelAcesso asc");
                return acessoBanco.Pesquisar(sql.ToString());
                
            }
			catch (Exception ex)
			{
                MessageBox.Show("Ocorreu um erro("+ex.Message+")ao pesquisar os niveis de acesso, Erro aconteceu na classe localizarNivelAcesso método TodosNiveis, Caso o problema persista entre em contato com suporte!",
                    "Erro de pesquisa",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
            return tableVazia;
        }
        public DataTable retornaridNivel(string nomeNivel)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT idNivelAcesso from nivelAcesso where nomeNivel = NAME and deletar = false");
                sql = sql.Replace("NAME", nomeNivel);
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro("+ex.Message+ ") ao retornar o idNivel do nivelAcesso(Classe LocalizarNivelAcesso, Método retornaridNivel)", "Erro ao pesquisar nivel",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
