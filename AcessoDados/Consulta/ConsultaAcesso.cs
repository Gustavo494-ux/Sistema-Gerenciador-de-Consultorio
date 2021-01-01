using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoDados
{
    public class ConsultaAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        DataTable tableVazia = new DataTable();
        public bool Cadastrar(string IDPACIENTE, string IDPROFISSIONAL, string IDUSUARIO, string ORIGEM, string HOBBIES, string ENCAMINHADOPOR, string AJUDAOPTICAPRESCRITA, string DATAULTIMOEXAME,
            string TRANSCRICAOLENTES, string OBSERVACAORECEITA, string STATUSCONSULTA,
            string OBSERVACAOCONSULTA)
        {
            try
            {
               string DATACONSULTA, HORACONSULTA;
                DATACONSULTA =  DateTime.Now.ToShortDateString();
                HORACONSULTA =  DateTime.Now.ToLongTimeString();

                //Comando sql responsavel por inserir os dados
                sql.Append("INSERT INTO consulta(idPaciente,idProfissional,idUsuario,origem,hobbies,encaminhadoPor,ajudaOpticaPrescrita,dataUltimoExame,transcricaoLentes, ");
                sql.Append("observacaoReceita,dataConsulta,horaConsulta,statusConsulta,observacaoConsulta,deletar)");

                sql.Append("VALUES(\'IDPACIENTE\',\'IDPROFISSIONAL\',\'IDUSUARIO\',\'ORIGEM\',\'HOBBIES\',\'ENCAMINHADOPOR\',\'AJUDAOPTICAPRESCRITA\',\'DATAULTIMOEXAME\',\'TRANSCRICAOLENTES\',\'OBSERVACAORECEITA\', ");
                sql.Append("\'DATACONSULTA\',\'HORACONSULTA\',\'STATUSCONSULTA\',\'OBSERVACAOCONSULTA\',false) ");

                //Relaciona cada valor com seu respectivo parametro.
                sql = sql.Replace("IDPACIENTE", IDPACIENTE).Replace("IDPROFISSIONAL", IDPROFISSIONAL).Replace("IDUSUARIO", IDUSUARIO).Replace("ORIGEM", ORIGEM);
                sql = sql.Replace("HOBBIES", HOBBIES).Replace("ENCAMINHADOPOR", ENCAMINHADOPOR).Replace("AJUDAOPTICAPRESCRITA", AJUDAOPTICAPRESCRITA);
                sql = sql.Replace("DATAULTIMOEXAME", DATAULTIMOEXAME).Replace("TRANSCRICAOLENTES", TRANSCRICAOLENTES).Replace("OBSERVACAORECEITA", OBSERVACAORECEITA);
                sql = sql.Replace("DATACONSULTA", DATACONSULTA).Replace("HORACONSULTA", HORACONSULTA).Replace("STATUSCONSULTA", STATUSCONSULTA).Replace("OBSERVACAOCONSULTA", OBSERVACAOCONSULTA);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar inserir os dados da consulta. Error: " + ex.Message + " ,Caso o problema persista entre em contato com o suporte!", "Erro na Inserção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool Atualizar(string IDCONSULTA, string ORIGEM, string HOBBIES, string ENCAMINHADOPOR, string AJUDAOPTICAPRESCRITA, string DATAULTIMOEXAME,
            string TRANSCRICAOLENTES, string OBSERVACAORECEITA, string STATUSCONSULTA,
            string OBSERVACAOCONSULTA)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE consulta SET origem = \'ORIGEM\',hobbies = \'HOBBIES\',encaminhadoPOr= \'ENCAMINHADOPOR\',ajudaOpticaPrescrita= \'AJUDAOPTICAPRESCRITA\', ");
                sql.Append("dataUltimoExame= \'DATAULTIMOEXAME\', transcricaoLentes = \'TRANSCRICAOLENTES\', observacaoReceita = \'OBSERVACAORECEITA\', ");
                sql.Append("statusConsulta=\'STATUSCONSULTA\',observacaoConsulta = \'OBSERVACAOCONSULTA\' WHERE idConsulta = \'IDCONSULTA\'");

                //Relaciona cada valor com seu respectivo parametro.
                sql = sql.Replace("ORIGEM", ORIGEM).Replace("HOBBIES", HOBBIES).Replace("ENCAMINHADOPOR", ENCAMINHADOPOR).Replace("AJUDAOPTICAPRESCRITA", AJUDAOPTICAPRESCRITA);
                sql = sql.Replace("DATAULTIMOEXAME", DATAULTIMOEXAME).Replace("TRANSCRICAOLENTES", TRANSCRICAOLENTES).Replace("OBSERVACAORECEITA", OBSERVACAORECEITA);
                sql = sql.Replace("STATUSCONSULTA", STATUSCONSULTA).Replace("OBSERVACAOCONSULTA", OBSERVACAOCONSULTA).Replace("IDCONSULTA", IDCONSULTA);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar uma consulta(Classe ConsultaAcesso, Método Atualizar)", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        //Funções para pesquisar os dados da consulta com diferentes filtros.
        public DataTable PesquisarUltimoId()
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT idConsulta from consulta ORDER BY idConsulta DESC LIMIT 1");
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelas chaves Estrangeiras da consulta(Classe ConsultaAcesso, Método PesquisarChavesEstrangeiras)",
                   "erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable TodasConsultas()
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT consulta.idConsulta, paciente.nomePaciente, profissional.nomeProfissional,consulta.idProfissional,consulta.idUsuario, ");
                sql.Append("usuario.loginUsuario,consulta.origem,consulta.hobbies,consulta.encaminhadoPor,/*consulta*/ consulta.ajudaOpticaPrescrita, ");
                sql.Append("consulta.dataUltimoExame,consulta.transcricaoLentes,consulta.observacaoReceita,consulta.dataConsulta, consulta.horaConsulta, ");
                sql.Append("consulta.statusConsulta, consulta.observacaoConsulta FROM consulta INNER JOIN paciente ON consulta.idPaciente = paciente.idPaciente ");
                sql.Append("INNER JOIN profissional on profissional.idProfissional = consulta.idProfissional INNER JOIN usuario on usuario.idUsuario = consulta.idUsuario ");
                sql.Append("WHERE consulta.deletar = false  order by idConsulta asc ");
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ConsultaAcesso, Método TodasConsultas) das Consultas, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoConsulta(string codigo)//Utilizado para Quando for editar a consulta.
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT consulta.idConsulta, paciente.nomePaciente, profissional.nomeProfissional,consulta.idProfissional,consulta.idUsuario, ");
                sql.Append("usuario.loginUsuario,consulta.origem,consulta.hobbies,consulta.encaminhadoPor,/*consulta*/ consulta.ajudaOpticaPrescrita, ");
                sql.Append("consulta.dataUltimoExame,consulta.transcricaoLentes,consulta.observacaoReceita,consulta.dataConsulta, consulta.horaConsulta, ");
                sql.Append("consulta.statusConsulta, consulta.observacaoConsulta FROM consulta INNER JOIN paciente ON consulta.idPaciente = paciente.idPaciente ");
                sql.Append("INNER JOIN profissional on profissional.idProfissional = consulta.idProfissional INNER JOIN usuario on usuario.idUsuario = consulta.idUsuario ");
                sql.Append("where consulta.idConsulta = codigo and consulta.deletar = false order by idConsulta asc");

                return acessoBanco.Pesquisar(sql.Replace("codigo", codigo).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ConsultaAcesso, Método CodigoConsulta) das Consultas, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoPaciente(string codPaciente)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT consulta.idConsulta, paciente.nomePaciente, profissional.nomeProfissional,consulta.idProfissional,consulta.idUsuario, ");
                sql.Append("usuario.loginUsuario,consulta.origem,consulta.hobbies,consulta.encaminhadoPor,/*consulta*/ consulta.ajudaOpticaPrescrita, ");
                sql.Append("consulta.dataUltimoExame,consulta.transcricaoLentes,consulta.observacaoReceita,consulta.dataConsulta, consulta.horaConsulta, ");
                sql.Append("consulta.statusConsulta, consulta.observacaoConsulta FROM consulta INNER JOIN paciente ON consulta.idPaciente = paciente.idPaciente ");
                sql.Append("INNER JOIN profissional on profissional.idProfissional = consulta.idProfissional INNER JOIN usuario on usuario.idUsuario = consulta.idUsuario ");
                sql.Append("where paciente.idPaciente = codPaciente and paciente.deletar = false and consulta.deletar = false order by idConsulta asc");

                return acessoBanco.Pesquisar(sql.Replace("codPaciente", codPaciente).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ConsultaAcesso, Método CodigoPaciente) das Consultas, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NomePaciente(string nomePaciente)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT consulta.idConsulta, paciente.nomePaciente, profissional.nomeProfissional,consulta.idProfissional,consulta.idUsuario, ");
                sql.Append("usuario.loginUsuario,consulta.origem,consulta.hobbies,consulta.encaminhadoPor,/*consulta*/ consulta.ajudaOpticaPrescrita, ");
                sql.Append("consulta.dataUltimoExame,consulta.transcricaoLentes,consulta.observacaoReceita,consulta.dataConsulta, consulta.horaConsulta, ");
                sql.Append("consulta.statusConsulta, consulta.observacaoConsulta FROM consulta INNER JOIN paciente ON consulta.idPaciente = paciente.idPaciente ");
                sql.Append("INNER JOIN profissional on profissional.idProfissional = consulta.idProfissional INNER JOIN usuario on usuario.idUsuario = consulta.idUsuario ");
                sql.Append("where paciente.nomePaciente like '%" + @nomePaciente + "%' and paciente.deletar = false and consulta.deletar = false order by idConsulta asc");
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ConsultaAcesso, Método NomePaciente) das Consultas, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable cpfPaciente(string cpf)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT consulta.idConsulta, paciente.nomePaciente, profissional.nomeProfissional,consulta.idProfissional,consulta.idUsuario, ");
                sql.Append("usuario.loginUsuario,consulta.origem,consulta.hobbies,consulta.encaminhadoPor,/*consulta*/ consulta.ajudaOpticaPrescrita, ");
                sql.Append("consulta.dataUltimoExame,consulta.transcricaoLentes,consulta.observacaoReceita,consulta.dataConsulta, consulta.horaConsulta, ");
                sql.Append("consulta.statusConsulta, consulta.observacaoConsulta FROM consulta INNER JOIN paciente ON consulta.idPaciente = paciente.idPaciente ");
                sql.Append("INNER JOIN profissional on profissional.idProfissional = consulta.idProfissional INNER JOIN usuario on usuario.idUsuario = consulta.idUsuario ");
                sql.Append(" where paciente.cpf like '%" + @cpf + "%' and paciente.deletar = false and consulta.deletar = false order by idConsulta asc");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ConsultaAcesso, Método cpfPaciente) das Consultas, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable rgPaciente(string rg)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT consulta.idConsulta, paciente.nomePaciente, profissional.nomeProfissional,consulta.idProfissional,consulta.idUsuario, ");
                sql.Append("usuario.loginUsuario,consulta.origem,consulta.hobbies,consulta.encaminhadoPor,/*consulta*/ consulta.ajudaOpticaPrescrita, ");
                sql.Append("consulta.dataUltimoExame,consulta.transcricaoLentes,consulta.observacaoReceita,consulta.dataConsulta, consulta.horaConsulta, ");
                sql.Append("consulta.statusConsulta, consulta.observacaoConsulta FROM consulta INNER JOIN paciente ON consulta.idPaciente = paciente.idPaciente ");
                sql.Append("INNER JOIN profissional on profissional.idProfissional = consulta.idProfissional INNER JOIN usuario on usuario.idUsuario = consulta.idUsuario ");
                sql.Append(" where paciente.rg like '%" + @rg + "%' and paciente.deletar = false and consulta.deletar = false order by idConsulta asc");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ConsultaAcesso, Método rgPaciente) das Consultas, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        //Funções para deletar lógicamente a consulta com diversos id diferentes..
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
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe ConsultaAcesso, Método DeletarConsultaIdPaciente)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe ConsultaAcesso, Método DeletarConsultaidConsulta)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe ConsultaAcesso, Método DeletarConsultaIdProfissional)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe ConsultaAcesso, Método DeletarConsultaIdUsuario)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }
    }
}
