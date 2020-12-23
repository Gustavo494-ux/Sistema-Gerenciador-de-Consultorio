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
    public class ProfissionaisDeletadosRegra
    {
        DataTable dadosTabela = new DataTable();
        DataTable tableVazia = new DataTable();

        ProfissionaisDeletadosAcesso profissional = new ProfissionaisDeletadosAcesso();

        public DataTable PesquisarTodosProfissionais()
        {
            try
            {
                return profissional.PesquisarTodosProfissionais();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar todos os profissionais deletados(Classe ProfissionaisDeletadosRegra, Método PesquisarTodosProfissionais)",
                    "Erro de Pesquisa",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia = new DataTable();
        }

        public DataTable PesquisarIdProfissionais(string idProfissional)
        {
            try
            {
                return profissional.PesquisarIdProfissional(idProfissional);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar todos os profissionais deletados(Classe ProfissionaisDeletadosRegra, Método PesquisarIdProfissionais)",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia = new DataTable();
        }

        public DataTable PesquisarNomeProfissionais(string nome)
        {
            try
            {
                return profissional.PesquisarNomeProfissional(nome);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar todos os profissionais deletados(Classe ProfissionaisDeletadosRegra, Método PesquisarNomeProfissionais)",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia = new DataTable();
        }

        public DataTable PesquisarCPFProfissionais(string cpf)
        {
            try
            {
                return profissional.PesquisarCPFProfissional(cpf);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar todos os profissionais deletados(Classe ProfissionaisDeletadosRegra, Método PesquisarCPFProfissionais)",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia = new DataTable();
        }

        public DataTable PesquisarCROOProfissionais(string croo)
        {
            try
            {
                return profissional.PesquisarCROOProfissional(croo);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar todos os profissionais deletados(Classe ProfissionaisDeletadosRegra, Método PesquisarCROOProfissionais)",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia = new DataTable();
        }

        public bool DeletarTodosProfissionais()
        {
            try
            {
                return profissional.DeletarTodosProfissional();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar todos os profissionais deletados(Classe ProfissionaisDeletadosRegra, Método DeletarTodosProfissionais)",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool DeletarIdProfissional(string idProfissional)
        {
            try
            {
                return profissional.DeletarIdProfissional(idProfissional);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar todos os profissionais deletados(Classe ProfissionaisDeletadosRegra, Método DeletarIdProfissional)",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool RestaurarTodosProfissionais()
        {
            try
            {
                return profissional.RestaurarTodosProfissional();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar todos os profissionais deletados(Classe ProfissionaisDeletadosRegra, Método RestaurarTodosProfissionais)",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        
        public bool RestaurarIdProfissional(string idProfissional)
        {
            try
            {
                return profissional.RestaurarIdProfissional(idProfissional);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar todos os profissionais deletados(Classe ProfissionaisDeletadosRegra, Método RestaurarIdProfissional)",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }


}
