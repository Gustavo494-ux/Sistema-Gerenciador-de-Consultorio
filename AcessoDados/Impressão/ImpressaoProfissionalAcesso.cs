using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;

namespace AcessoDados.Impressão
{
    public class ImpressaoProfissionalAcesso
    {
        DataTable tableVazia = new DataTable();
        Banco acessoBanco = new Banco();
        StringBuilder sql = new StringBuilder();
        public DataTable ImpressaoCompleta(int idProfissional)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT * FROM profissional INNER JOIN usuario ON usuario.idUsuario = profissional.idUsuario INNER JOIN contato ON contato.idContato = profissional.idContato ");
                sql.Append("INNER JOIN endereco ON endereco.idEndereco = profissional.idEndereco WHERE profissional.deletar = false AND usuario.deletar = false AND contato.deletar = false AND ");
                sql.Append("endereco.deletar = false  AND idProfissional = \'ID\'");

                sql =sql.Replace("ID",idProfissional.ToString());

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a impressão dos dados do profissional(Classe ImpressaoProfissionalAcesso,Método ImpressaoCompleta)", 
                    "Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
