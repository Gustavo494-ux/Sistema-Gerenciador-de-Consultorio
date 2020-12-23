using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace AcessoDados
{
   public  class DeletarPacienteAcesso
   {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool exclusaoLogicaIdPaciente(string idUsuarioSistema,string idPaciente)
        {
            try
            {
                sql.Clear();
                sql.Append("update paciente set deletar = true, idUsuarioDeletar = idUsuarioSistema where idPaciente = codPaciente");
                sql = sql.Replace("codPaciente", idPaciente).Replace("idUsuarioSistema", idUsuarioSistema);
                return acessoBanco.Executar(sql.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o paciente(Classe DeletarPacienteAcesso, Método idPaciente)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public bool exclusaoLogicaIdUsuario(string idUsuarioSistema,string idUsuarioCadastro)
        {
            try
            {
                sql.Clear();
                sql.Append("update paciente set deletar = true,idUsuarioDeletar = idUsuarioSistema where idUsuario = idUsuarioCadastro");

                sql = sql.Replace("idUsuarioCadastro", idUsuarioCadastro).Replace("idUsuarioSistema", idUsuarioSistema);
                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o paciente(Classe DeletarPacienteAcesso, Método idUsuario)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }


     

   }
}
