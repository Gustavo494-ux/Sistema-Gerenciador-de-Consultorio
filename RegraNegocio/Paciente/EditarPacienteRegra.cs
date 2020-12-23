using AcessoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegraNegocio
{
    public class EditarPacienteRegra
    {
        DataTable tableVazia = new DataTable();
        DataTable dadosTabela = new DataTable();
        CadastrarPacienteRegra validar = new CadastrarPacienteRegra();
        public DataTable RetornarDados(string codigo)
        {
            try
            {
                if (Convert.ToInt32(codigo) > 0)
                {
                    EditarPacienteAcesso retornar = new EditarPacienteAcesso();
                    dadosTabela = retornar.RetornarDados(Convert.ToInt32(codigo));
                    if (dadosTabela.Rows.Count > 0) return dadosTabela;
                    else
                    {
                        MessageBox.Show("A Pesquisa foi realizada com sucesso,No entanto os registros não foram encontrados", "Pesquisa");
                    }
                }
                else
                {
                    MessageBox.Show("O Código Indentificador do paciente é inválido", "Código Inválido");
                    return tableVazia;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realzar uma pesquisa completa do paciente(Classe EditarPacienteRegra, Método RetornarDados)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

        public bool Atualizar(int codigo, string paciente, string responsavel, string rg, string cpf, string ocupacao, string idade, string sexo, string nascimento, string observacao)
        {
            try
            {
                if (codigo > 0)
                {
                    /*O que foi passado na de forma manual sempre vai passar pela validação, já que não são dados que podem ser manupulados pelo usuario uma vez no banco não podem ser alterados*/
                    if (validar.Validar("0","0","0","1",  paciente,  responsavel,  rg,  cpf,  ocupacao,  idade,  sexo,  nascimento,"","",  observacao) == true)
                    {
                        EditarPacienteAcesso update = new EditarPacienteAcesso();
                         return update.Atualizar(codigo, paciente, responsavel, rg, cpf.Replace(",", "").Replace(".", "").Replace("-", ""), ocupacao, idade, sexo, nascimento, observacao); 
                    }
                    else
                    {
                        MessageBox.Show("Alguns dados não são válidos, para efetuar a atualização insira dados válidos","Dados Inválidos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("O código indentificador do Paciente é inválido, o mesmo não pode ser inferior a 1", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma atualização de dados do paciente(Classe EditarPacienteRegra, Método Atualizar)", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
