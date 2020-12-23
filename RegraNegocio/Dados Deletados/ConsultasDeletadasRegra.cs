using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;
using System.Data;
using System.Windows.Forms;

namespace RegraNegocio
{
    public class ConsultasDeletadasRegra
    {
        DataTable tableVazia = new DataTable();
        ConsultasDeletadasAcesso consultas = new ConsultasDeletadasAcesso();
        public DataTable PesquisarTodasConsultas()
        {
            try
            {
                return consultas.PesquisarTodasConsultas();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ConsultasDeletadasRegra, Método PesquisarTodasConsultas) da Consulta, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarNomeConsultas(string nome)
        {
            try
            {
                return consultas.PesquisarNomeConsultas(nome);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ConsultasDeletadasRegra, Método PesquisarNomeConsultas) da Consulta, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarRgConsultas(string rg)
        {
            try
            {
                return consultas.PesquisarRgConsultas(rg);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ConsultasDeletadasRegra, Método PesquisarRgConsultas) da Consulta, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarCPFConsultas(string cpf)
        {
            try
            {
                return consultas.PesquisarCPFConsultas(cpf);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ConsultasDeletadasRegra, Método PesquisarCPFConsultas) da Consulta, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool DeletarTodasConsultas()
        {
            try
            {
                return consultas.DeletarTodasConsultas();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu algum erro ao deletar fisicamente a consulta!Classes ConsultasDeletadasRegra, Método DeletarTodasConsultas",
                     "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool DeletarIdConsulta(string idConsulta)
        {
            try
            {
                return consultas.DeletarIdConsulta(idConsulta);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu algum erro ao deletar fisicamente a consulta!Classes ConsultasDeletadasRegra, Método DeletarIdConsulta",
                        "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool RestaurarTodasConsultas()
        {
            try
            {
                return consultas.RestaurarTodasConsultas();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de restauração(Classe ConsultasDeletadasRegra, Método RestaurarTodasConsultas) da Consulta, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool RestaurarIdConsultas(string idConsulta)
        {
            try
            {
                return consultas.RestaurarIdConsultas(idConsulta);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de restauração(Classe ConsultasDeletadasRegra, Método RestaurarIdConsultas) da Consulta, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
