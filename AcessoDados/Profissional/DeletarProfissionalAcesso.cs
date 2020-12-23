using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoDados
{
    public class DeletarProfissionalAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool idProfissional(int idUsuarioSistema,int idProfissional)
        {
            try
            {
                sql.Clear();
                sql.Append("update profissional set deletar = true,idUsuarioDeletar = codUsuarioSistema where idProfissional = codProfissional");
                sql = sql.Replace("codProfissional", idProfissional.ToString()).Replace("codUsuarioSistema", idUsuarioSistema.ToString());
                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe DeletaConsultaAcesso, Método idProfissional)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public bool idUsuario(int idUsuarioSistema,int idUsuario)
        {
            try
            {
                sql.Clear();
                sql.Append("update profissional set deletar = true,idUsuarioDeletar = codUsuarioDeletar where idUsuario = IDUSUARIO");
                sql = sql.Replace("IDUSUARIO", idUsuario.ToString()).Replace("codUsuarioDeletar", idUsuarioSistema.ToString());

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe DeletaConsultaAcesso, Método idUsuario)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
    }
}
