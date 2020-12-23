using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using AcessoDados;

namespace RegraNegocio
{
	public class LocalizarStatusAgendamentoRegra
	{
		public DataTable TodosStatus()
		{
			DataTable tableVazia = new DataTable();
			DataTable dadosTabela = new DataTable();
			try
			{
				LocalizarStatusAgendamentoAcesso statusAgendamento = new LocalizarStatusAgendamentoAcesso();
				dadosTabela = statusAgendamento.TodosStatus();
				if (dadosTabela.Rows.Count > 0)
				{
					return dadosTabela;
				}
				else
				{
					return tableVazia;
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocorreu um erro(" + ex + ") ao realizar uma pesquisa dos Status de Agendamento(Classe LocalizarStatusAgendamentoRegra, Método TodosStatus)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return tableVazia;
		}
		public DataTable RetornarIdStatus(string status)
		{
			DataTable tableVazia = new DataTable();
			DataTable dadosTabela = new DataTable();
			try
			{
				LocalizarStatusAgendamentoAcesso statusAgendamento = new LocalizarStatusAgendamentoAcesso();
				dadosTabela = statusAgendamento.RetornarIdStatus(status);
				if (dadosTabela.Rows.Count > 0)return dadosTabela;return tableVazia;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocorreu um erro(" + ex + ") ao realizar uma pesquisa dos Status de Agendamento(Classe LocalizarStatusAgendamentoRegra, Método RetornarIdStatus)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return tableVazia;
		}
	}
}
	
