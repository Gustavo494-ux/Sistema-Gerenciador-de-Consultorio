using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.SqlClient;

namespace AcessoDados
{
    public class ContatoAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool cadastrar(string idContato, string idUsuario, string email, string telefone1, string telefone2, string telefone3, string outro, string observacaoContato)
        {
			try
            {
                //Retira paranteses, pontos, virgulas, "-" e "_";
                telefone1 = telefone1.Replace("(", "").Replace(")", "").Replace(",", "").Replace(".", "").Replace("_", "").Replace("-", "").Trim();
                telefone2 = telefone2.Replace("(", "").Replace(")", "").Replace(",", "").Replace(".", "").Replace("_", "").Replace("-", "").Trim();
                telefone3 = telefone3.Replace("(", "").Replace(")", "").Replace(",", "").Replace(".", "").Replace("_", "").Replace("-", "").Trim();

                sql.Clear();
                sql.Append("INSERT INTO contato(idUsuario, email, telefone1, telefone2, telefone3, outro, observacaoContato, deletar)");
                sql.Append("VALUES(\'IDUSUARIO\',\'EMAIL\',\'TELEFONE1\',\'TELEFONE2\',\'TELEFONE2\',\'OUTRO\',\'OBSERVACAOCONTATO\',false)");

                sql = sql.Replace("IDUSUARIO", idUsuario.ToString()).Replace("EMAIL", email).Replace("TELEFONE1", telefone1).Replace("TELEFONE2", telefone2).Replace("TELEFONE3", telefone3);
                sql = sql.Replace("OUTRO", outro).Replace("OBSERVACAOCONTATO", observacaoContato);

                return acessoBanco.Executar(sql.ToString()); 
            }
			catch (Exception ex) 
			{
                MessageBox.Show("Ocorreu um erro ao tentar inserir os dados do contato. Error: " + ex.Message + " ,Caso o problema persista entre em contato com o suporte!", "Erro na Inserção",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public bool Atualizar(int idUsuario, string email, string telefone1, string telefone2, string telefone3, string outro, string observacaoContato)
        {
            try
            {
                sql.Clear();
                sql.Append("update contato SET email = \'EMAIL\', telefone1= \'TELEFONE1\', telefone2 = \'TELEFONE2\',telefone3 = \'TELEFONE3\', outro = \'OUTRO\', ");
                sql = sql.Append("observacaoContato = \'OBSERVACAOCONTATO\' WHERE idContato = \'IDUSUARIO\' ");

                sql = sql.Replace("IDUSUARIO", idUsuario.ToString()).Replace("EMAIL", email).Replace("TELEFONE1", telefone1).Replace("TELEFONE2", telefone2).Replace("TELEFONE3", telefone3);
                sql = sql.Replace("OUTRO", outro).Replace("OBSERVACAOCONTATO", observacaoContato);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma atualização de dados do Contato(Classe ContatoAcesso, Método Atualizar)", "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool idContato(int idUsuarioSistema, int idContato)
        {
            try
            {
                sql.Clear();
                sql.Append("update contato set deletar = true,idUsuarioDeletar = \'IDUSUARIODELETAR\' where idContato = \'CONTATO\'");

                sql = sql.Replace("CONTATO",idContato.ToString()).Replace("IDUSUARIODELETAR",idUsuarioSistema.ToString());

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o endereço(Classe ContatoAcesso, Método idContato)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public bool idUsuario(int idUsuarioSistema, int idUsuario)
        {
            try
            {
                sql.Clear();
                sql.Append("update contato set deletar = true, idUsuarioDeletar = \'IDUSUARIODELETAR\' where idUsuario = \'IDUSUARIO\'");

                sql = sql.Replace("IDUSUARIO", idUsuario.ToString()).Replace("IDUSUARIODELETAR", idUsuarioSistema.ToString());

                return acessoBanco.Executar(sql.ToString());
                        
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o endereço(Classe ContatoAcesso, Método idUsuario)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
    }
}
