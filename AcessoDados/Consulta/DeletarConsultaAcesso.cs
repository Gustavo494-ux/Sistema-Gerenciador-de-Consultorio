using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace AcessoDados
{
    public class DeletarConsultaAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool DeletarConsultaIdPaciente(string IDUSUARIOSISTEMA, string IDPACIENTE)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE consulta SET deletar = true, idUsuarioDeletar = IDUSUARIOSISTEMA WHERE idPaciente = IDPACIENTE; ");

                sql = sql.Replace("IDPACIENTE", IDPACIENTE).Replace("IDUSUARIOSISTEMA", IDUSUARIOSISTEMA);

                return acessoBanco.Executar(sql.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe DeletaConsultaAcesso, Método DeletarConsultaIdPaciente)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public bool DeletarConsultaidConsulta(string IDUSUARIOSISTEMA, string IDCONSULTA)
        {
           
            try
            {
                sql.Clear();
                sql.Append("UPDATE consulta SET deletar = true, idUsuarioDeletar = IDUSUARIOSISTEMA WHERE idConsulta =  IDCONSULTA;");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("IDUSUARIOSISTEMA", IDUSUARIOSISTEMA);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe DeletaConsultaAcesso, Método DeletarConsultaidConsulta)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public bool DeletarConsultaIdProfissional(string IDUSUARIOSISTEMA, string IDPROFISSIONAL)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE consulta SET deletar = true,idUsuarioDeletar = IDUSUARIOSISTEMA WHERE idProfissional = IDPROFISSIONAL;");

                sql = sql.Replace("IDPROFISSIONAL", IDPROFISSIONAL).Replace("IDUSUARIOSISTEMA", IDUSUARIOSISTEMA);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe DeletaConsultaAcesso, Método DeletarConsultaIdProfissional)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            return false;
        }
        public bool DeletarConsultaIdUsuario(string IDUSUARIOSISTEMA, string IDUSUARIO)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE consulta SET deletar = true,idUsuarioDeletar = IDUSUARIOSISTEMA WHERE idUsuario = CODUSUARIOCADASTRO;");

                sql = sql.Replace("CODUSUARIOCADASTRO", IDUSUARIO).Replace("IDUSUARIOSISTEMA", IDUSUARIOSISTEMA);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe DeletaConsultaAcesso, Método DeletarConsultaIdUsuario)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }
    }
}
