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
    public class PacienteAcesso
    {
        int contato;
        int endereco;

        DataTable tableVazia = new DataTable();
        DataTable dados = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool Cadastrar(string idPaciente, string idContato, string idEndereco ,string idUsuario, string nomePaciente, string nomeResponsavel, string rg, string cpf, string ocupacao, string idade,
            string sexo, string dataNascimento, string dataCadastro, string horaCadastro, string observacaoPaciente)
        {
            try
            {
                RetornarUltimoIdContato();
                RetornarUltimoIdEndereco();
                string CPF = cpf.Replace("-", "").Replace(",", "").Replace(".", "");
               
                DateTime cadastro = Convert.ToDateTime(DateTime.Now.ToShortDateString()),HoraCadastro = Convert.ToDateTime(DateTime.Now.ToLongTimeString());

                sql.Clear();

                sql.Append("INSERT INTO paciente(idContato,idEndereco,idUsuario,nomePaciente,nomeResponsavel,rg,cpf, ");
                sql.Append("ocupacao,idade,sexo,dataNascimento,dataCadastro,horaCadastro,observacaoPaciente,deletar,idUsuarioDeletar)");
                
                sql.Append("VALUES(\'IDCONTATO\',\'IDENDERECO\',\'IDUSUARIO\',\'NOMEPACIENTE\',\'NOMERESPONSAVEL\',RG\',\'CPF\', ");
                sql.Append("\'OCUPACAO\',\'IDADE\',\'SEXO\',\'DATANASCIMENTO\',\'DATACADASTRO\',\'HORACADASTRO\',\'OBSERVACAOPACIENTE\',false,0)");

                sql = sql.Replace("IDCONTATO", contato.ToString()).Replace("IDENDERECO", endereco.ToString()).Replace("IDUSUARIO", idUsuario).Replace("NOMEPACIENTE", nomePaciente.ToUpper());
                sql = sql.Replace("NOMERESPONSAVEL", nomeResponsavel.ToUpper()).Replace("RG", rg).Replace("CPF", CPF).Replace("OCUPACAO", ocupacao).Replace("IDADE", idade).Replace("SEXO", sexo);
                sql = sql.Replace("DATANASCIMENTO", dataNascimento).Replace("DATACADASTRO", cadastro.ToString()).Replace("HORACADASTRO", HoraCadastro.ToString());
                sql = sql.Replace("OBSERVACAOPACIENTE", observacaoPaciente);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar inserir os dados do Paciente. Error: " + ex.Message + " ,Caso o problema persista entre em contato com o suporte!", "Erro na Inserção",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public DataTable RetornarDadosConsulta(int idConsulta)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT * FROM paciente INNER JOIN endereco on endereco.idEndereco = ");
                sql.Append("paciente.idEndereco INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario INNER JOIN contato on contato.idContato = paciente.idContato ");
                sql.Append("INNER JOIN consulta on consulta.idpaciente = paciente.idpaciente and consulta.idConsulta = \'CODIGO\' and paciente.deletar = false");
                sql = sql.Replace("CODIGO", idConsulta.ToString());

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa completa do paciente(Classe PacienteAcesso, Método RetornarDadosConsulta)", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool Atualizar(int codigo, string nomePaciente, string nomeResponsavel, string rg, string CPF, string ocupacao, string idade, string sexo, string dataNascimento, string observacaoPaciente)
        {
            try
            {
                
                DateTime nascimento = Convert.ToDateTime(dataNascimento);

                sql.Clear();
                sql.Append("UPDATE paciente SET nomePaciente = @paciente, nomeResponsavel = @responsavel,rg = @rg, cpf= @cpf,ocupacao = @ocupacao, idade = @idade,");
                sql.Append("sexo = @sexo,datanascimento = @nascimento, observacaoPaciente = @observacao WHERE  idPaciente = @codigo");

                sql = sql.Replace("IDCONTATO", contato.ToString()).Replace("IDENDERECO", endereco.ToString()).Replace("NOMEPACIENTE", nomePaciente.ToUpper());
                sql = sql.Replace("NOMERESPONSAVEL", nomeResponsavel.ToUpper()).Replace("RG", rg).Replace("CPF", CPF).Replace("OCUPACAO", ocupacao).Replace("IDADE", idade).Replace("SEXO", sexo);
                sql = sql.Replace("DATANASCIMENTO", dataNascimento).Replace("OBSERVACAOPACIENTE", observacaoPaciente);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma atualização de dados do paciente(Classe PacienteAcesso, Método Atualizar)", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable TodosPacientes()
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT paciente.idPaciente,paciente.idContato,paciente.idEndereco,paciente.idUsuario,paciente.nomePaciente,paciente.nomeResponsavel,paciente.rg,paciente.cpf, ");
                sql.Append("paciente.ocupacao, paciente.idade, paciente.sexo, paciente.dataNascimento, paciente.dataCadastro, paciente.horaCadastro, paciente.observacaoPaciente, ");
                sql.Append("usuario.loginUsuario FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("where paciente.deletar = false  order by idPaciente asc ");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe PacienteAcesso, Método TodosPacientes) do Paciente, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoPaciente(int codigo)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT * FROM paciente INNER JOIN endereco on endereco.idEndereco = ");
                sql.Append("paciente.idEndereco INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario INNER JOIN contato on contato.idContato = paciente.idContato ");
                sql.Append("and paciente.idPaciente = \'CODIGO\' and paciente.deletar = false  order by idPaciente asc");

                sql.Replace("\'CODIGO\'", codigo.ToString());

                return acessoBanco.Pesquisar(sql.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe PacienteAcesso, Método CodigoPaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NomePaciente(string Nome)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT paciente.idPaciente,paciente.idContato,paciente.idEndereco,paciente.idUsuario,paciente.nomePaciente,paciente.nomeResponsavel, ");
                sql.Append("paciente.rg,paciente.cpf,paciente.ocupacao, paciente.idade, paciente.sexo, paciente.dataNascimento,paciente.dataCadastro,paciente.horaCadastro, ");
                sql.Append("paciente.observacaoPaciente, usuario.loginUsuario FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("WHERE paciente.nomePaciente LIKE '%" + @Nome + "%' and  paciente.deletar = false order by idPaciente asc");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe PacienteAcesso, Método NomePaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CpfPaciente(string cpf)
        {
            try
            {
                sql.Clear();
                sql.Append("select idPaciente,idContato,idEndereco,paciente.idUsuario, nomePaciente, nomeResponsavel, rg,cpf,ocupacao,idade,sexo,dataNascimento,");
                sql.Append("paciente.dataCadastro,paciente.horaCadastro,observacaoPaciente,usuario.loginUsuario FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("where cpf LIKE '" + cpf + "%' and paciente.deletar = false order by idPaciente asc");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe PacienteAcesso, Método CpfPaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable RgPaciente(string rg)
        {
            try
            {
                sql.Clear();
                sql.Append("select idPaciente,idContato,idEndereco,paciente.idUsuario, nomePaciente, nomeResponsavel, rg,cpf,ocupacao,idade,sexo,dataNascimento,");
                sql.Append("paciente.dataCadastro,paciente.horaCadastro,observacaoPaciente,usuario.loginUsuario FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("where rg LIKE '" + rg + "%' and paciente.deletar = false order by idPaciente asc");


                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe PacienteAcesso, Método RgPaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public int UltimoPaciente()
        {
            try
            {
                int idPaciente = 0;
                sql.Clear(); 
                sql.Append("select idPaciente from paciente order by idPaciente desc limit 1");

                dados = acessoBanco.Pesquisar(sql.ToString());

                return idPaciente = Convert.ToInt32(dados.Rows[0]["idPaciente"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe PacienteAcesso, Método UltimoPaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }
        public bool exclusaoLogicaIdPaciente(string idUsuarioSistema, string idPaciente)
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
                MessageBox.Show("Ocorreu um erro ao deletar o paciente(Classe PacienteAcesso, Método idPaciente)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public bool exclusaoLogicaIdUsuario(string idUsuarioSistema, string idUsuarioCadastro)
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
        //Os métodos abaixo retornam respéctivamente o ultimo idEndereco e idContato cadastrados no sistema para serem usados para cadastrar o paciente.
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
    }
}
