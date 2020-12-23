using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoDados
{
    public class DeletarUsuarioAcesso
    {
        StringBuilder sql = new StringBuilder();

        Banco acessoBanco = new Banco();
        public bool DeletarUsuario(int idUsuarioSistema, int idUsuario)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE usuario SET deletar = true,idUsuarioDeletar = CODUSUARIOSISTEMA WHERE idUsuario = IDUSUARIOCADASTRO");
                sql = sql.Replace("IDUSUARIOCADASTRO", idUsuario.ToString()).Replace("CODUSUARIOSISTEMA", idUsuarioSistema.ToString());

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o usuario(Classe DeletarUsuarioAcesso, Método idUsuario)", "Erro de deleção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
    }
}
