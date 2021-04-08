using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Npgsql;

namespace AcessoDados
{
    public class ConsultasDeletadasAcesso
    {
        DataTable tableVazia = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco AcessoBanco = new Banco();
        public DataTable PesquisarTodasConsultas()
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT consulta.idConsulta as \"Código\", paciente.nomePaciente as \"Paciente\", paciente.CPF as \"CPF\",paciente.rg as \"RG\", ");
                sql.Append("usuario.LoginUsuario as \"Usuário\" FROM consulta  INNER JOIN paciente ON paciente.idPaciente = consulta.idPaciente INNER JOIN ");
                sql.Append("usuario ON usuario.idUsuario = consulta.idUsuarioDeletar ");
                sql.Append("WHERE consulta.deletar = true order by consulta.idConsulta asc ");
                return AcessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ConsultasDeletadasAcesso, Método PesquisarTodasConsultas) da Consulta, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarNomeConsultas(string nome)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT consulta.idConsulta as \"Código\", paciente.nomePaciente as \"Paciente\", paciente.CPF as \"CPF\",paciente.rg as \"RG\", ");
                sql.Append("usuario.LoginUsuario as \"Usuário\" FROM consulta  INNER JOIN paciente ON paciente.idPaciente = consulta.idPaciente INNER JOIN ");
                sql.Append("usuario ON usuario.idUsuario = consulta.idUsuarioDeletar ");
                sql.Append("WHERE consulta.deletar = true and paciente.nomePaciente like '%pacienteNome%' order by consulta.idConsulta asc ");
                return AcessoBanco.Pesquisar(sql.Replace("pacienteNome", nome).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ConsultasDeletadasAcesso, Método PesquisarNomeConsultas) da Consulta, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarRgConsultas(string rg)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT consulta.idConsulta as \"Código\", paciente.nomePaciente as \"Paciente\", paciente.CPF as \"CPF\",paciente.rg as \"RG\", ");
                sql.Append("usuario.LoginUsuario as \"Usuário\" FROM consulta  INNER JOIN paciente ON paciente.idPaciente = consulta.idPaciente INNER JOIN ");
                sql.Append("usuario ON usuario.idUsuario = consulta.idUsuarioDeletar ");
                sql.Append("WHERE consulta.deletar = true and paciente.rg like '%rgPaciente%' order by consulta.idConsulta asc ");
                return AcessoBanco.Pesquisar(sql.Replace("rgPaciente", rg).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ConsultasDeletadasAcesso, Método PesquisarRgConsultas) da Consulta, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarCPFConsultas(string cpf)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT consulta.idConsulta as \"Código\", paciente.nomePaciente as \"Paciente\", paciente.CPF as \"CPF\",paciente.rg as \"RG\", ");
                sql.Append("usuario.LoginUsuario as \"Usuário\" FROM consulta  INNER JOIN paciente ON paciente.idPaciente = consulta.idPaciente INNER JOIN ");
                sql.Append("usuario ON usuario.idUsuario = consulta.idUsuarioDeletar ");
                sql.Append("WHERE consulta.deletar = true and paciente.cpf like '%cpfPaciente%' order by consulta.idConsulta asc");
                return AcessoBanco.Pesquisar(sql.Replace("cpfPaciente", cpf).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ConsultasDeletadasAcesso, Método PesquisarCPFConsultas) da Consulta, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public string RetornarConsultasDeletadas()
        {//Método utilizado para retornar o idConsulta de todas as consultas que foram deletadas. Recomendavél utilizar somente para deletar todas as consultas.
            StringBuilder listaidConsulta = new StringBuilder();
            try
            {
                DataTable dadosTabela = new DataTable();
                dadosTabela.Rows.Clear();
                sql.Clear();
                sql.Append("SELECT idConsulta from consulta where deletar = true and idUsuarioDeletar > 0");

                dadosTabela = AcessoBanco.Pesquisar(sql.ToString());
                for (int i = 0; i < dadosTabela.Rows.Count; i++)
                {
                    var valor = Convert.ToString(dadosTabela.Rows[i]["idConsulta"].ToString());

                    listaidConsulta = listaidConsulta.Append(valor + "#");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu algum erro ao deletar fisicamente a consulta!Classes ConsultasDeletadasAcesso, Método RetornarConsultasDeletadas",
                     "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaidConsulta.ToString();
        }
        public bool DeletarTodasConsultas()
        {
            try
            {
                string[] listaIdConsulta = RetornarConsultasDeletadas().Split('#');
                foreach (var i in listaIdConsulta)
                {
                    if (i != "" && i != "0")
                    {
                        if (!DeletarIdConsulta(i)) return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu algum erro ao deletar fisicamente a consulta!Classes ConsultasDeletadasAcesso, Método DeletarTodasConsultas",
                     "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool DeletarIdConsulta(string idConsulta)
        {
            try
            {
                sql.Clear();
                sql.Append("delete from retinoscopia where idConsulta = codConsulta ; #");
                sql.Append("delete from acuidadeVisual where idConsulta = codConsulta ; # ");
                sql.Append("delete from anamnese where idConsulta = codConsulta; # ");
                sql.Append("delete from antecedentesGerais where idConsulta = codConsulta; #");
                sql.Append("delete from antecedentesOculares where idConsulta = codConsulta; #");
                sql.Append("delete from oftalmoscopia where idConsulta = codConsulta; #");
                sql.Append("delete from rxInicial where idConsulta = codConsulta; #");
                sql.Append("delete from RxFinal where idConsulta = codConsulta; #");
                sql.Append("delete from sintomasReferidos where idConsulta = codConsulta; #");
                sql.Append("delete from forometria where idConsulta = codConsulta ; #");
                sql.Append("delete from visaoCor where idConsulta = codConsulta ; #");
                sql.Append("delete from amsler where idConsulta = codConsulta ; #");
                sql.Append("delete from lensometria where idConsulta = codConsulta ; #");
                sql.Append("delete from estereopsia where idConsulta = codConsulta ; #");
                sql.Append("delete from motilidadeOcular where idConsulta = codConsulta ; #");
                sql.Append("delete from biomicroscopia where idConsulta = codConsulta ; #");
                sql.Append("delete from ceratometria where idConsulta = codConsulta ; #");
                sql.Append("delete from Consulta where idConsulta = codConsulta; ");

                sql = sql.Replace("codConsulta", idConsulta);
                return AcessoBanco.ExecutarLista(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu algum erro ao deletar fisicamente a consulta!Classes ConsultasDeletadasAcesso, Método DeletarIdConsulta",
                        "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool RestaurarTodasConsultas()
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE Consulta set deletar = false, idUsuarioDeletar = 0 where deletar = true");

                return AcessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de restauração(Classe ConsultasDeletadasAcesso, Método RestaurarTodasConsultas) da Consulta, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool RestaurarIdConsultas(string idConsulta)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE Consulta set deletar = false, idUsuarioDeletar = 0 where deletar = true and idConsulta = codConsulta ");
                return AcessoBanco.Executar(sql.Replace("codConsulta",idConsulta).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de restauração(Classe ConsultasDeletadasAcesso, Método RestaurarIdConsultas) da Consulta, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
    //public string RetornarConsultasDeletadas()
    //{//Método utilizado para retornar o idConsulta de todas as consultas que foram deletadas. Recomendavél utilizar somente para deletar todas as consultas.
    //    StringBuilder listaidConsulta = new StringBuilder();
    //    try
    //    {
    //        NpgsqlCommand comandoSql = new NpgsqlCommand();

    //        sql.Clear();
    //        ConexaoAcesso.Conectar();
    //        sql.Append("SELECT idConsulta from consulta where deletar = true and idUsuarioDeletar > 0");


    //        comandoSql.CommandText = sql.ToString();
    //        comandoSql.Connection = ConexaoAcesso.conn;
    //        var readerData = comandoSql.ExecuteReader();

    //        int i = 0;
    //        while (readerData.Read())
    //        {
    //            var valor = Convert.ToString(readerData["idConsulta"]);

    //            listaidConsulta = listaidConsulta.Append(valor + "#");
    //            i++;
    //        }
    //        ConexaoAcesso.Desconectar();
    //    }
    //    catch (Exception)
    //    {
    //        MessageBox.Show("Ocorreu algum erro ao deletar fisicamente a consulta!Classes ConsultasDeletadasAcesso, Método RetornarConsultasDeletadas",
    //             "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //    return listaidConsulta.ToString();
    //}
}
