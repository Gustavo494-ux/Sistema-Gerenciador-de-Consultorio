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
    public class EnderecoAcesso
    {
        DataTable tableVazia = new DataTable();
        DataTable dadosTabela = new DataTable();

        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool Cadastrar(string idUsuario, string estado, string cidade, string bairro, string rua, string numero, string cep, string pontoReferencia, 
            string observacaoEndereco)
        {

            try
            {
                string CEP = cep.Replace("_", "").Replace(",", "").Replace(".", "").Replace("-", "").Trim();
                int usuario = Convert.ToInt32(idUsuario);

                //Comando sql responsavel por inserir os dados
                sql.Clear();
                sql.Append("INSERT INTO endereco(idUsuario, estado, cidade, bairro, rua, numero, cep, pontoReferencia, observacaoEndereco,deletar)");
                sql.Append("VALUES(\'IDUSUARIO\',\'ESTADO\',\'CIDADE\',\'BAIRRO\',\'RUA\',\'NUMERO\',\'CEP\',\'PONTOREFERENCIA\',\'OBSERVACAOENDERECO\',false)");

                //Relaciona cada valor com seu respectivo parametro.
                sql = sql.Replace("IDUSUARIO", usuario.ToString()).Replace("ESTADO", estado).Replace("CIDADE", cidade).Replace("BAIRRO", bairro).Replace("RUA", rua).Replace("NUMERO", numero);
                sql = sql.Replace("CEP", CEP).Replace("PONTOREFERENCIA", pontoReferencia).Replace("OBSERVACAOENDERECO", observacaoEndereco);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Ocorreu um erro ao tentar inserir os dados do Endereço. Error: " + ex.Message + " ,Caso o problema persista entre em contato com o suporte!", "Erro na Inserção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool Atualizar(int codigo, string estado, string cidade, string bairro, string rua, string numero, string cep, string referencia, string observacao)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE endereco SET estado = \'ESTADO\',cidade = \'CIDADE\', bairro = \'BAIRRO\',rua = \'RUA\',numero = \'NUMERO\',cep = \'CEP\',pontoReferencia = \'REFERENCIA\', ");
                sql = sql.Append("observacaoEndereco = \'OBSERVACAO\' WHERE idEndereco = \'CODIGO\' ");

                sql = sql.Replace("CODIGO", codigo.ToString()).Replace("ESTADO", estado).Replace("CIDADE", cidade).Replace("BAIRRO", bairro).Replace("RUA", rua).Replace("NUMERO", numero);
                sql = sql.Replace("CEP", cep).Replace("REFERENCIA", referencia).Replace("OBSERVACAO", observacao);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma atualização de dados do endereço(Classe EnderecoAcesso, Método Atualizar)", "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool idEndereco(int idUsuarioSistema, int idEndereco)
        {
            try
            {
                sql.Clear();
                sql.Append("update endereco set deletar = true,idUsuarioDeletar = \'IDUSUARIODELETAR\' where idEndereco = \'IDENDERECO\'");

               sql = sql.Replace("IDENDERECO", idEndereco.ToString()).Replace("IDUSUARIODELETAR", idUsuarioSistema.ToString());

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o endereço(Classe EnderecoAcesso, Método idEndereco)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public bool idUsuario(int idUsuarioSistema, int idUsuario)
        {
            try
            {
                sql.Clear();
                sql.Append("update endereco set deletar = true,idUsuarioDeletar = \'IDUSUARIODELETAR\' where idUsuario = \'IDUSUARIO\'");
                sql = sql.Replace("IDUSUARIO", idUsuario.ToString()).Replace("IDUSUARIODELETAR", idUsuarioSistema.ToString());

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o endereço(Classe EnderecoAcesso, Método idUsuario)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
    }
}
