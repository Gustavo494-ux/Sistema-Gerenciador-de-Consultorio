using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows.Forms;

namespace RegraNegocio
{
    public class ContatoRegraNegocio
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
                MessageBox.Show("Erro no método de validação das informações de cadastro do contato(Classe Contato, método Cadastrar). Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!", "Erro na validação",
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

                if (email.Length > 50) return false;

                if (outro.Length > 100) return false;

                if (observacaoContato.GetType() != typeof(string)) return false; 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no método de validação das informações de cadastro do contato(Classe Contato, método autenticar). Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!", "Erro na validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
    }
}
