using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoDados
{
    public class ProfissionalAcesso
    {
        int contato, endereco;

        DataTable tableVazia = new DataTable();
        DataTable dados = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool Cadastrar(string idProfissional, string idEndereco, string idContato, string idUsuario, string nomeProfissional, string especialidade, string rg, string cpf, 
            string sexo, string croo,string dataNascimento, string dataCadastro, string horaCadastro,string rodapeReceita, string observacaoProfissional)
        {
            try
            {
                RetornarUltimoIdContato();
                RetornarUltimoIdEndereco();

                string CPF = cpf.Replace("-", "").Replace(",", "").Replace(".","");

                sql.Clear();
                sql.Append("INSERT INTO profissional(idEndereco, idContato,idUsuario, nomeProfissional, especialidade, rg, cpf");
                sql.Append(",sexo, croo,dataNascimento, dataCadastro, horaCadastro,rodapeReceita, observacaoProfissional,deletar)");

                sql.Append("VALUES(\'IDENDERECO\',\'IDCONTATO\',\'IDUSUARIO\',\'NOMEPROFISSIONAL\',\'ESPECIALIDADE\',\'RG\',\'CPF\', ");
                sql.Append("\'SEXO\',\'CROO\',\'DATANASCIMENTO\',\'DATACADASTRO\',\'HORACADASTRO\',\'RODAPERECEITA\',\'OBSERVACAOPROFISSIONAL\',false)");

                sql = sql.Replace("IDENDERECO", idEndereco.ToString()).Replace("IDCONTATO", idContato).Replace("IDUSUARIO", idUsuario).Replace("NOMEPROFISSIONAL", nomeProfissional);
                sql = sql.Replace("ESPECIALIDADE", especialidade).Replace("RG", rg).Replace("CPF",CPF ).Replace("SEXO", sexo).Replace("CROO", croo).Replace("DATANASCIMENTO", dataNascimento);
                sql = sql.Replace("DATACADASTRO", dataCadastro).Replace("HORACADASTRO", horaCadastro).Replace("RODAPERECEITA", rodapeReceita).Replace("OBSERVACAOPROFISSIONAL", observacaoProfissional);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar inserir os dados do Profissional. Error: " + ex.Message + " ,Caso o problema persista entre em contato com o suporte!", "Erro na Inserção",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable RetornarDados(int idProfissional)
        {
            try
            {
                sql.Clear();

                sql.Append("SELECT profissional.idProfissional,profissional.idEndereco,profissional.idContato,profissional.nomeProfissional,profissional.especialidade,profissional.rg,profissional.cpf, ");
                sql.Append("profissional.sexo,profissional.croo, profissional.dataNascimento,profissional.rodapeReceita, profissional.observacaoProfissional, contato.email, contato.telefone1, contato.telefone2, ");
                sql.Append("contato.telefone3, contato.outro,contato.observacaoContato, endereco.estado, endereco.cidade, endereco.bairro, endereco.rua, endereco.numero, endereco.cep, endereco.pontoReferencia, endereco.observacaoEndereco ");
                sql.Append("FROM profissional INNER JOIN contato on contato.idContato = profissional.idContato INNER JOIN endereco on endereco.idEndereco = profissional.idEndereco ");
                sql.Append("WHERE profissional.idProfissional = \'IDPROFISSIONAL\' AND profissional.deletar = false order by idProfissional asc");

                sql = sql.Replace("IDPROFISSIONAL", idProfissional.ToString());

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar uma pesquisa completa do profissional(Classe ProfissionalAcesso, Método RetornarDados)", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool Atualizar(int idProfissional, string nomeProfissional, string especialidade, string rg, string cpf, string sexo, string croo, DateTime dataNascimento,string rodapeReceita,
            string observacaoProfissional)
        {
            try
            {
                sql.Clear();
                sql.Append("update profissional set nomeProfissional =\'NOMEPROFISSIONAL\',especialidade = \'ESPECIALIDADE\', rg = \'RG\', cpf = \'CPF\', sexo = \'SEXO\', croo = \'CROO\'  , ");
                sql.Append("dataNascimento = \'DATANASCIMENTO\',rodapeReceita =\'RODAPERECEITA\', observacaoProfissional = \'OBSERVACAOPROFISSIONAL\' where idProfissional = @idProfissional");

                sql = sql.Replace("NOMEPROFISSIONAL", nomeProfissional).Replace("ESPECIALIDADE", especialidade).Replace("RG", rg).Replace("CPF", cpf).Replace("SEXO", sexo);
                sql = sql.Replace("CROO", croo).Replace("DATANASCIMENTO", dataNascimento.ToString()).Replace("RODAPERECEITA", rodapeReceita).Replace("OBSERVACAOPROFISSIONAL", observacaoProfissional);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os dados do Profissional(Classe ProfissionalAcesso, Método atualizar)", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable TodosProfissionais()
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT * FROM profissional where deletar = false order by idProfissional asc");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ProfissionalAcesso, Método TodosProfissionais) do profissional, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoProfissional(int codigo)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT * FROM profissional WHERE idProfissional = codProfissional and deletar = false order by idProfissional asc");

                sql = sql.Replace("codProfissional", codigo.ToString());

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ProfissionalAcesso, Método CodigoProfissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NomeProfissional(string nome)
        {
            try
            {
                sql.Clear();
                sql.Append("select * from profissional where nomeprofissional LIKE '%" + @nome + "%' and deletar = false order by idProfissional asc");
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ProfissionalAcesso, Método NomeProfissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CPFProfissional(string cpf)
        {

            try
            {
                sql.Clear();
                sql.Append("select * from profissional where cpf LIKE '%" + cpf + "%' and deletar = false order by idProfissional asc");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ProfissionalAcesso, Método CpfProfissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable RgProfissional(string rg)
        {

            try
            {
                sql.Clear();
                sql.Append("select * from profissional where rg LIKE '" + @rg + "%' and deletar = false order by idProfissional asc");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ProfissionalAcesso, Método RgProfissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CrooProfissional(string croo)
        {

            try
            {
                sql.Clear();
                sql.Append("select * from profissional where croo LIKE '" + @croo + "%' and deletar=false order by idProfissional asc");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ProfissionalAcesso, Método CrooProfissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable EspecialidadeProfissional(string especialidade)
        {
            try
            {
                sql.Clear();
                sql.Append("select * from profissional where especialidade LIKE '%" + especialidade + "%' and deletar = false order by idProfissional asc");
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ProfissionalAcesso, Método Profissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

        //Os métodos abaixo retornam respéctivamente o ultimo idEndereco e idContato cadastrados no sistema para serem usados para cadastrar o profissional.
        int RetornarUltimoIdEndereco()
        {
            try
            {
                sql.Clear();
                sql.Append("select idEndereco from endereco order by idEndereco desc limit 1");

                dados = acessoBanco.Pesquisar(sql.ToString());
                return endereco = Convert.ToInt32(dados.Rows[0]["idEndereco"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar retornar o código indentificador do endereço. Error: " + ex.Message + " ,Caso o problema persista entre em contato com o suporte!", "Erro na Inserção",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }
        int RetornarUltimoIdContato()
        {
            try
            {
                sql.Clear();
                sql.Append("select idContato from contato order by idContato desc limit 1");

                dados = acessoBanco.Pesquisar(sql.ToString());
                return contato = Convert.ToInt32(dados.Rows[0]["idContato"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar retornar o código indentificador do endereço. Error: " + ex.Message + " ,Caso o problema persista entre em contato com o suporte!", "Erro na Inserção",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }
        //Função para deletar o profissional
        public bool idProfissional(int idUsuarioSistema, int idProfissional)
        {
            try
            {
                sql.Clear();
                sql.Append("update profissional set deletar = true,idUsuarioDeletar = \'codUsuarioSistema\' where idProfissional = \'codProfissional\'");
                sql = sql.Replace("codProfissional", idProfissional.ToString()).Replace("codUsuarioSistema", idUsuarioSistema.ToString());
                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe DeletaConsultaAcesso, Método idProfissional)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public bool idUsuario(int idUsuarioSistema, int idUsuario)
        {
            try
            {
                sql.Clear();
                sql.Append("update profissional set deletar = true,idUsuarioDeletar = \'codUsuarioDeletar\' where idUsuario = \'IDUSUARIO\'");
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
