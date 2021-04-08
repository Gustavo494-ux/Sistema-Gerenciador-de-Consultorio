using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace AcessoDados
{
    public class ImprimirUsuarioAcesso
    {
        DataTable tableVazia = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public DataTable impressaoCompleta(int idUsuario)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT * FROM usuario INNER JOIN nivelAcesso ON nivelAcesso.idNivelAcesso = usuario.idNivel WHERE usuario.deletar= false AND idUsuario = \'ID\' ");

                sql =sql.Replace("\'ID\'",idUsuario.ToString());
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a impressão dos dados do usuario(Classe ImprimirUsuarioAcesso,Método impressaoCompleta)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
