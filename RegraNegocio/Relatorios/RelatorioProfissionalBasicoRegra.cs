using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using AcessoDados;
using System.Data.SqlTypes;
using System.Security.AccessControl;

namespace RegraNegocio
{
    public class RelatorioProfissionalBasicoRegra
    {
        DataTable tableVazia = new DataTable();
        public DataTable TodosProfissionais()
        {
            try
            {
                RelatorioProfissionalBasicoAcesso pesquisar = new RelatorioProfissionalBasicoAcesso();
                return pesquisar.TodosProfissionais();
            }
            catch (Exception)
            {
      
                MessageBox.Show("Ocorreu um erro ao gerar o Relatório de cadastro simples de profissional(Classe RelatorioProfissionalBasicoRegra, Método TodosProfissionais)",
                        "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

        public DataTable DataNascimentoProfissional(DateTime dataInicial,DateTime dataFinal)
        {
            try
            {
                RelatorioProfissionalBasicoAcesso pesquisar = new RelatorioProfissionalBasicoAcesso();
                return pesquisar.DataNascimentoProfissional(dataInicial,dataFinal);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o Relatório de cadastro simples de profissional(Classe RelatorioProfissionalBasicoRegra, Método DataNascimentoProfissional)",
                      "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

        public DataTable DataCadastroProfissional(DateTime dataInicial,DateTime dataFinal)
        {
            try
            {
                RelatorioProfissionalBasicoAcesso pesquisar = new RelatorioProfissionalBasicoAcesso();
                return pesquisar.DataCadastroProfissional(dataInicial,dataFinal);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o Relatório de cadastro simples de profissional(Classe RelatorioProfissionalBasicoRegra, Método DataCadastroProfissional)",
                       "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;  
        }
    }
}
