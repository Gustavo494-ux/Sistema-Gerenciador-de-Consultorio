using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    public class ContatoRegra
    {
        //Se a verificação retornar um valor true este metodo direciona os dados para a classe responsável por manda-los para o banco
        public bool cadastrar(string idContato, string idUsuario, string email, string telefone1, string telefone2, string telefone3, string outro, string observacaoContato)
        {
            try
            {
                if (Verificar(idContato, idUsuario, email, telefone1, telefone2, telefone3, outro, observacaoContato) == true)//Se a verificação der true as informações são inseridas
                {
                    AcessoDados.ContatoAcesso novoContato = new AcessoDados.ContatoAcesso();
                    return novoContato.cadastrar(idContato, idUsuario, email, telefone1, telefone2, telefone3, outro, observacaoContato);
                }
                else
                {
                    MessageBox.Show("Algumas informações do contato são inválidas,Tente novamente com informações diferentes, Caso o problema persista entre em contato com o suporte!",
                        "Informações inválidas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no método de validação das informações de cadastro do contato(Classe ContatoRegra, método Cadastrar). Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!", "Erro na validação",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }
        //Método responsável por fazer as verificações de dos campos vitais.
        public bool Verificar(string idContato, string idUsuario, string email, string telefone1, string telefone2, string telefone3, string outro, string observacaoContato)
        {
            try
            {

                if (idContato != "0") return false;

                if (Convert.ToInt32(idUsuario) <1) return false;

                if (email.Length > 100) return false;

                if (outro.Length > 100) return false;

                if (observacaoContato.GetType() != typeof(string)) return false; 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no método de validação das informações de cadastro do contato(Classe ContatoRegra, método autenticar). Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!", "Erro na validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        public bool Atualizar(int codigo, string email, string telefone1, string telefone2, string telefone3, string outro, string observacao)
        {
            try
            {

                ContatoAcesso contato = new ContatoAcesso();
                if (codigo > 0)
                {
                    if (Verificar("0", "1", email, telefone1, telefone2, telefone3, outro, observacao) == true)
                    {
                        return contato.Atualizar(codigo, email, telefone1.Replace("(", "").Replace(")", "").Replace(".", "").Replace("-", ""), telefone2.Replace("(", "").Replace(")", "").Replace(".", "").Replace("-", ""),
                            telefone3.Replace("(", "").Replace(")", "").Replace(".", "").Replace("-", ""), outro, observacao);
                    }
                }
                else
                {
                    MessageBox.Show("O código indentificador do Contato é inválido, o mesmo não pode ser inferior a 1", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma atualização de dados do Contato(classe ContatoRegra, Método Atualizar)", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
