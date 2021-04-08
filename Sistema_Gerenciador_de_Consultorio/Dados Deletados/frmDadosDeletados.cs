using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegraNegocio;

namespace Sistema_Gerenciador_de_Consultorio
{
    public partial class frmDadosDeletados : Form
    {
        string idUsuario, idNivel, loginUsuario, nomeNivel;
        public frmDadosDeletados(string idUsuario, string idNivel, string loginUsuario, string nomeNivel)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.idNivel = idNivel;
            this.loginUsuario = loginUsuario;
            this.nomeNivel = nomeNivel;
        }
        private void frmDadosDeletados_Load(object sender, EventArgs e)
        {

            CarregarTodosPacientes();
            carregarTodosProfissionais();
            CarregarTodasConsultas();
            CarregarTodosUsuarios();

            carregarNivelAcesso();
            carregarStatusUsuario();

            zerarDataGrid();
        }
        private void btnvoltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //Zerar dataGridView´s
        void zerarDataGrid()
        {
            for (int i = 0; i < dtgPaciente.Rows.Count; i++)
            {
                dtgPaciente.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                i++;
            }

            for (int i = 0; i < dtgProfissional.Rows.Count; i++)
            {
                dtgProfissional.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                i++;
            }

            for (int i = 0; i < dtgConsulta.Rows.Count; i++)
            {
                dtgConsulta.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                i++;
            }

            for (int i = 0; i < dtgUsuario.Rows.Count; i++)
            {
                dtgUsuario.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                i++;
            }
        }
        //Escolher dados
        void PesquisarPaciente()
        {
            PacienteDeletadoRegra pesquisar = new PacienteDeletadoRegra();
            if (rbTodosPacientes.Checked == true)PreencherDtgPaciente(pesquisar.PesquisarTodosPacientes());
            if (rbIdPaciente.Checked == true)PreencherDtgPaciente(pesquisar.PesquisarCodigoPaciente(Convert.ToInt32(nudPesquisarPaciente.Text)));
            if (rbNomePaciente.Checked == true)PreencherDtgPaciente(pesquisar.PesquisarNomePaciente(txtPesquisarPaciente.Text));
            if (rbCpfPaciente.Checked == true)PreencherDtgPaciente(pesquisar.PesquisarCpfPaciente(nudPesquisarPaciente.Text));
            if (rbRgPaciente.Checked == true)PreencherDtgPaciente(pesquisar.PesquisarRgPaciente(nudPesquisarPaciente.Text));
        }
        void PesquisarProfissional()
        {
            ProfissionaisDeletadosRegra pesquisar = new ProfissionaisDeletadosRegra();
            if (rbTodosProfissionais.Checked == true)PreencherDtgProfissional(pesquisar.PesquisarTodosProfissionais());
            if (rbIdProfissional.Checked == true)PreencherDtgProfissional(pesquisar.PesquisarIdProfissionais(nudPesquisarProfissional.Text));
            if (rbNomeProfissional.Checked == true)PreencherDtgProfissional(pesquisar.PesquisarNomeProfissionais(txtPesquisarProfissional.Text));
            if (rbCPFProfissional.Checked == true)PreencherDtgProfissional(pesquisar.PesquisarCPFProfissionais(nudPesquisarProfissional.Text));
            if (rbCROOProfissional.Checked == true)PreencherDtgProfissional(pesquisar.PesquisarCROOProfissionais(nudPesquisarProfissional.Text));
        }
        void PesquisarConsulta()
        {
            ConsultasDeletadasRegra consulta = new ConsultasDeletadasRegra();
            
            if (rbTodasConsultas.Checked == true) PreencherDtgConsulta(consulta.PesquisarTodasConsultas());
            if (rbNomePacienteConsulta.Checked == true) PreencherDtgConsulta(consulta.PesquisarNomeConsultas(txtPesquisarConsulta.Text));
            if (rbRGConsulta.Checked == true)PreencherDtgConsulta(consulta.PesquisarRgConsultas(nudConsulta.Text));
            if (rbcpfConsulta.Checked == true) PreencherDtgConsulta(consulta.PesquisarCPFConsultas(nudConsulta.Text));
        }
        void PesquisarUsuario()
        {
            UsuariosDeletadosRegra usuario = new UsuariosDeletadosRegra();
            if (rbTodosUsuario.Checked == true) PreencherDtgUsuario(usuario.PesquisarTodosUsuarios());
            if (rbNomeUsuario.Checked == true) PreencherDtgUsuario(usuario.PesquisarNomeUsuario(txtPesquisarUsuario.Text));
            if (rbRgUsuario.Checked == true) PreencherDtgUsuario(usuario.PesquisarRgUsuario(nudUsuario.Value.ToString()));
            if (rbCPFUsuario.Checked == true) PreencherDtgUsuario(usuario.PesquisarCPFUsuario(nudUsuario.Value.ToString()));
            if (rbStatusUsuario.Checked == true) PreencherDtgUsuario(usuario.PesquisarStatusUsuario(cbStatusUsuarioUsuario.Text));
            if (rbNivelAcessoUsuario.Checked == true) PreencherDtgUsuario(usuario.PesquisarNivelAcessoUsuario(Convert.ToString(cbNivelAcessoUsuario.SelectedIndex+1)));
        }
        //Deletar Todos
        private void deletarTodosPacientesMsMenuSuperior_Click(object sender, EventArgs e)
        {
            PacienteDeletadoRegra deletarTodos = new PacienteDeletadoRegra();
            if (MessageBox.Show("Deseja realmente deletar permanentemente todos os pacientes que foram deletados?Está ação é não pode ser revertida de maneira nenhuma!!!",
                "Deletar Permanentemente", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                if (deletarTodos.DeletarTodosPacientes() == true)
                {
                    MessageBox.Show("Dados deletados permanentemente com sucesso!", "Dados deletados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTodosPacientes();
                }
                else
                {
                    MessageBox.Show("Não foi possivel deletar os dados,talvez seu código identificador esteja errado!Deseja retornar a tela anterior?", "Dados Não Deletados",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTodosPacientes();
                }
            }
        }
        private void deletarTodosProfissionaisMsMenuSuperior_Click(object sender, EventArgs e)
        {
            ProfissionaisDeletadosRegra profissional = new ProfissionaisDeletadosRegra();
            if (MessageBox.Show("Deseja realmente deletar permanentemente todos os profissionais que foram deletados?Está ação é não pode ser revertida de maneira nenhuma!!!",
               "Deletar Permanentemente", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                if (profissional.DeletarTodosProfissionais() == true)
                {
                    MessageBox.Show("Dados deletados permanentemente com sucesso!Deseja retornar a tela anterior?", "Dados Deletados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    carregarTodosProfissionais();
                }
                else
                {
                    MessageBox.Show("Não foi possivel deletar os dados,talvez seu código identificador esteja errado!Deseja retornar a tela anterior?", "Dados Não Deletados",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    carregarTodosProfissionais();
                }
            }
        }
        private void deletarTodasConsultasMsMenuSuperior_Click(object sender, EventArgs e)
        {

            ConsultasDeletadasRegra consulta = new ConsultasDeletadasRegra();
            if (MessageBox.Show("Deseja realmente deletar permanentemente todas as consultas que foram deletadas?Está ação é não pode ser revertida de maneira nenhuma!!!",
               "Deletar Permanentemente", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                if (consulta.DeletarTodasConsultas() == true)
                {
                    MessageBox.Show("Dados deletados permanentemente com sucesso!", "Dados Deletados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTodasConsultas();
                }
                else
                {
                    MessageBox.Show("Não foi possivel deletar os dados,talvez seu código identificador esteja errado!Deseja retornar a tela anterior?", "Dados Não Deletados",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTodasConsultas();
                }
            }
        }
        private void deletarTodosUsuariosMsMenuSuperior_Click(object sender, EventArgs e)
        {

            UsuariosDeletadosRegra usuario = new UsuariosDeletadosRegra();
            if (MessageBox.Show("Deseja realmente deletar permanentemente todos os usuários que foram deletados?Está ação é não pode ser revertida de maneira nenhuma!!!",
               "Deletar Permanentemente", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                if (usuario.DeletarTodosUsuario() == true)
                {
                    MessageBox.Show("Dados deletados permanentemente com sucesso!", "Dados Deletados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTodosUsuarios();
                }
                else
                {
                    MessageBox.Show("Não foi possivel deletar os dados,talvez seu código identificador esteja errado!Deseja retornar a tela anterior?", "Dados Não Deletados",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTodosUsuarios();
                }
            }
        }
        //Restaurar Todos
        private void restaurarTodosPacientesMsMenuSuperior_Click(object sender, EventArgs e)
        {
            PacienteDeletadoRegra deletarTodos = new PacienteDeletadoRegra();

            if (MessageBox.Show("Deseja restaurar todos os pacientes deletados?",
               "Restaurar Pacientes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (deletarTodos.RecuperarTodosPacientes() == true)
                {
                    MessageBox.Show("Dados restaurados com sucesso!", "Dados Restaurados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTodosPacientes();
                }
                else
                {
                    MessageBox.Show("Não foi possivel restaurar os dados,talvez seu código identificador esteja errado!", "Dados Não Restaurados",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTodosPacientes();
                }
            }
        }
        private void restaurarTodosProfissionaisMsMenuSuperior_Click(object sender, EventArgs e)
        {
            ProfissionaisDeletadosRegra profissionais = new ProfissionaisDeletadosRegra();

            if (MessageBox.Show("Deseja restaurar todos os profissionais deletados?",
               "Restaurar Profissionais", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (profissionais.RestaurarTodosProfissionais() == true)
                {
                    MessageBox.Show("Dados restaurados com sucesso!", "Dados Restaurados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    carregarTodosProfissionais();
                }
                else
                {
                    MessageBox.Show("Não foi possivel restaurar os dados,talvez seu código identificador esteja errado!", "Dados Não Restaurados",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    carregarTodosProfissionais();
                }
            }
        }
        private void restaurarTodasConsultasMsMenuSuperior_Click(object sender, EventArgs e)
        {
            ConsultasDeletadasRegra consulta = new ConsultasDeletadasRegra();

            if (MessageBox.Show("Deseja restaurar todas as consultas deletadas?",
               "Restaurar consultas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (consulta.RestaurarTodasConsultas() == true)
                {
                    MessageBox.Show("Dados restaurados com sucesso!", "Dados Restaurados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTodasConsultas();
                }
                else
                {
                    MessageBox.Show("Não foi possivel restaurar os dados,talvez seu código identificador esteja errado!", "Dados Não Restaurados",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTodasConsultas();
                }
            }
        }
        private void restaurarTodosUsuariosMsMenuSuperior_Click(object sender, EventArgs e)
        {
            UsuariosDeletadosRegra usuarios= new UsuariosDeletadosRegra();

            if (MessageBox.Show("Deseja restaurar todos os usuários deletados?",
               "Restaurar Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (usuarios.RestaurarTodosUsuario() == true)
                {
                    MessageBox.Show("Dados restaurados com sucesso!", "Dados Restaurados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTodosUsuarios();
                }
                else
                {
                    MessageBox.Show("Não foi possivel restaurar os dados,talvez seu código identificador esteja errado!", "Dados Não Restaurados",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTodosUsuarios();
                }
            }
        }
        //btnPesquisar
        private void btnPesquisarPaciente_Click(object sender, EventArgs e)
        {
            PesquisarPaciente();

        }
        private void btnPesquisarProfissional_Click(object sender, EventArgs e)
        {
            PesquisarProfissional();
        }
        private void btnPesquisarConsulta_Click(object sender, EventArgs e)
        {
            PesquisarConsulta();

        }
        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            PesquisarUsuario();
        }
        //Filtros de pesquisa
        private void filtrosPaciente(object sender, EventArgs e)
        {
            txtPesquisarPaciente.Clear();
            nudPesquisarPaciente.Text = "0";
            txtPesquisarPaciente.Visible = false;
            nudPesquisarPaciente.Visible = false;

            if (rbTodosPacientes.Checked == true)txtPesquisarPaciente.Visible = true;
            if (rbIdPaciente.Checked == true)nudPesquisarPaciente.Visible = true;
            if (rbNomePaciente.Checked == true)txtPesquisarPaciente.Visible = true;
            if (rbCpfPaciente.Checked == true)nudPesquisarPaciente.Visible = true;
            if (rbRgPaciente.Checked == true)nudPesquisarPaciente.Visible = true;

        }
        private void filtrosProfissional(object sender, EventArgs e)
        {

            txtPesquisarProfissional.Clear();
            nudPesquisarProfissional.Text = "0";

            txtPesquisarProfissional.Visible = false;
            nudPesquisarProfissional.Visible = false;

            if (rbTodosProfissionais.Checked == true)txtPesquisarProfissional.Visible = true;
            if (rbIdProfissional.Checked == true)nudPesquisarProfissional.Visible = true;
            if (rbNomeProfissional.Checked == true)txtPesquisarProfissional.Visible = true;
            if (rbCPFProfissional.Checked == true)nudPesquisarProfissional.Visible = true;
            if (rbCROOProfissional.Checked == true) nudPesquisarProfissional.Visible = true;
        }
        private void FiltrosConsulta(object sender, EventArgs e)
        {
            txtPesquisarConsulta.Visible = false;
            txtPesquisarConsulta.Clear();
            nudConsulta.Visible = false;
            nudConsulta.Value =  0;

            if (rbTodasConsultas.Checked == true) txtPesquisarConsulta.Visible = true;
            if (rbNomePacienteConsulta.Checked == true) txtPesquisarConsulta.Visible = true;
            if (rbRGConsulta.Checked == true) nudConsulta.Visible = true;
            if (rbcpfConsulta.Visible == true) nudConsulta.Visible = true;
        }
        private void FiltrosUsuario(object sender, EventArgs e)
        {
            txtPesquisarUsuario.Visible = false;
            txtPesquisarUsuario.Clear();
            nudUsuario.Value = 0;
            nudUsuario.Visible = false;
            cbNivelAcessoUsuario.Visible = false;
           
            cbStatusUsuarioUsuario.Visible = false;

            if (rbTodosUsuario.Checked == true || rbNomeUsuario.Checked == true) txtPesquisarUsuario.Visible = true;
            if (rbCPFUsuario.Checked == true || rbRgUsuario.Checked == true) nudUsuario.Visible = true;
            if (rbStatusUsuario.Checked == true) cbStatusUsuarioUsuario.Visible = true;
            if (rbNivelAcessoUsuario.Checked == true) cbNivelAcessoUsuario.Visible = true;
            carregarNivelAcesso();
            carregarStatusUsuario();
        }
        //rbTodos
        private void rbTodosPacientes_CheckedChanged(object sender, EventArgs e)
        {
            CarregarTodosPacientes();
        }
        private void rbTodosProfissionais_CheckedChanged(object sender, EventArgs e)
        {
            carregarTodosProfissionais();
        }
        private void rbTodasConsultas_CheckedChanged(object sender, EventArgs e)
        {
            CarregarTodasConsultas();
        }
        private void rbTodosUsuario_CheckedChanged(object sender, EventArgs e)
        {
            CarregarTodosUsuarios();
        }
        //DTG
        private void dtgPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idPacienteSelecionado = dtgPaciente.Rows[e.RowIndex].Cells["Código"].Value.ToString();

            PacienteDeletadoRegra paciente = new PacienteDeletadoRegra();
            // criar algoritimos para restauração e exclusão fisica dos dados
            if (dtgPaciente.Columns[e.ColumnIndex].Name == "btnRestaurarPaciente")
            {
                if (MessageBox.Show("Tem certeza de que deseja restaurar esse registro?","Restaurar Dados?",MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (paciente.RecuperarIdPaciente(Convert.ToInt32(idPacienteSelecionado)) == true)//código para restaurar
                    {
                       MessageBox.Show("Dados Restaurados com sucesso!",
                            "Dados Restaurados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarTodosPacientes();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel restaurar os dados,talvez seu código identificador esteja errado!", "Dados Não Restaurados",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarTodosPacientes();
                    }
                }
            }
            if (dtgPaciente.Columns[e.ColumnIndex].Name == "btnDeletarPaciente")
            {
                if (MessageBox.Show("Tem certeza de que deseja deletar o registro permanentemente?Os dados serão permanente deletados", "Deletar dados fisicamente?",MessageBoxButtons.YesNo,MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    //código para deletar 
                    if (paciente.DeletarIdPaciente(idPacienteSelecionado) ==true)//trocar o true pelo código de deletar
                    {
                        MessageBox.Show("Dados deletados de forma permanente com sucesso!", 
                            "Dados Deletados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarTodosPacientes();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel deletar os dados,talvez seu código identificador esteja errado!", "Dados Não Deletados",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarTodosPacientes();
                    }
                }
            }
        }
        private void dtgProfissional_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idProfissionalSelecionado;
            ProfissionaisDeletadosRegra profissionais = new ProfissionaisDeletadosRegra();

            if (dtgProfissional.Columns[e.ColumnIndex].Name == "btnRestaurarProfissional")
            {
                idProfissionalSelecionado = dtgProfissional.Rows[e.RowIndex].Cells["Código"].Value.ToString();
                if (MessageBox.Show("Tem certeza de que deseja restaurar esse registro?", "Restaurar Dados?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (profissionais.RestaurarIdProfissional(idProfissionalSelecionado) == true)//código para restaurar
                    {
                        MessageBox.Show("Dados Restaurados com sucesso!Deseja retornar a tela anterior?",
                            "Dados Restaurados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        carregarTodosProfissionais();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel restaurar os dados,talvez seu código identificador esteja errado!Deseja retornar a tela anterior?", "Dados Não Restaurados",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                        carregarTodosProfissionais();
                    }
                }
            }
            if(dtgProfissional.Columns[e.ColumnIndex].Name == "btnDeletarProfissional")
            {
                idProfissionalSelecionado = dtgProfissional.Rows[e.RowIndex].Cells["Código"].Value.ToString();
                if (MessageBox.Show("Tem certeza de que deseja deletar o registro permanentemente?Os dados serão permanente deletados", "Deletar dados fisicamente?", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    //código para deletar 
                    if (profissionais.DeletarIdProfissional(idProfissionalSelecionado) == true)//trocar o true pelo código de deletar
                    {
                        MessageBox.Show("Dados deletados de forma permanente com sucesso!Deseja retornar a tela anterior?",
                            "Dados Deletados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        carregarTodosProfissionais();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel deletar os dados,talvez seu código identificador esteja errado!Deseja retornar a tela anterior?", "Dados Não Deletados",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                        carregarTodosProfissionais();
                    }
                }
            }
        }
        private void dtgConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idConsultaSelecionada = dtgConsulta.Rows[e.RowIndex].Cells["Código"].Value.ToString();
            ConsultasDeletadasRegra consulta = new ConsultasDeletadasRegra();

            if (dtgConsulta.Columns[e.ColumnIndex].Name == "btnRestaurarConsulta")
            {
                if (MessageBox.Show("Tem certeza de que deseja restaurar esse registro?", "Restaurar Dados?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (consulta.RestaurarIdConsultas(idConsultaSelecionada) == true)//código para restaurar
                    {
                        MessageBox.Show("Dados Restaurados com sucesso!","Dados Restaurados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarTodasConsultas();
                    }
                    else
                    {
                       MessageBox.Show("Não foi possivel restaurar os dados,talvez seu código identificador esteja errado!", "Dados Não Restaurados",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            if (dtgConsulta.Columns[e.ColumnIndex].Name == "btnDeletarConsulta")
            {
                if (MessageBox.Show("Tem certeza de que deseja deletar o registro permanentemente?\nOs dados serão permanente deletados", "Deletar dados fisicamente?", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    //código para deletar 
                    if (consulta.DeletarIdConsulta(idConsultaSelecionada) == true)//trocar o true pelo código de deletar
                    {
                        MessageBox.Show("Dados deletados de forma permanente com sucesso!",
                            "Dados Deletados!", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                        CarregarTodasConsultas();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel deletar os dados,talvez seu código identificador esteja errado!?", "Dados Não Deletados",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void dtgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idUsuarioSelecionado = dtgUsuario.Rows[e.RowIndex].Cells["Código"].Value.ToString();
            UsuariosDeletadosRegra usuario = new UsuariosDeletadosRegra();

            if (dtgUsuario.Columns[e.ColumnIndex].Name == "btnRestaurarUsuario")
            {
                if (MessageBox.Show("Tem certeza de que deseja restaurar esse registro?", "Restaurar Dados?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (usuario.RestaurarIdUsuario(idUsuarioSelecionado) == true)//código para restaurar
                    {
                        MessageBox.Show("Dados Restaurados com sucesso!", "Dados Restaurados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarTodosUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel restaurar os dados,talvez seu código identificador esteja errado!", "Dados Não Restaurados",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            if (dtgUsuario.Columns[e.ColumnIndex].Name == "btnDeletarUsuario")
            {
                if (MessageBox.Show("Tem certeza de que deseja deletar o registro permanentemente?\nOs dados serão permanente deletados", "Deletar dados fisicamente?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    //código para deletar 
                    if (usuario.DeletarIdUsuario(idUsuarioSelecionado) == true)//trocar o true pelo código de deletar
                    {
                        MessageBox.Show("Dados deletados de forma permanente com sucesso!",
                            "Dados Deletados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarTodosUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel deletar os dados,talvez seu código identificador esteja errado!?", "Dados Não Deletados",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        //Carregar Todos
        void CarregarTodosPacientes()
        {
            PacienteDeletadoRegra pesquisar = new PacienteDeletadoRegra();
            PreencherDtgPaciente(pesquisar.PesquisarTodosPacientes());
        }
        void carregarTodosProfissionais()
        {
            ProfissionaisDeletadosRegra pesquisar = new ProfissionaisDeletadosRegra();
            PreencherDtgProfissional(pesquisar.PesquisarTodosProfissionais());
        }
        void CarregarTodasConsultas()
        {
            ConsultasDeletadasRegra consulta = new ConsultasDeletadasRegra();
            PreencherDtgConsulta(consulta.PesquisarTodasConsultas());
        }
        void CarregarTodosUsuarios()
        {
            UsuariosDeletadosRegra usuario = new UsuariosDeletadosRegra();
            PreencherDtgUsuario(usuario.PesquisarTodosUsuarios());
        }
        //Carregar comboBox
        void carregarStatusUsuario()
        {
            cbNivelAcessoUsuario.Text = "Selecione um nível de acesso";
            LocalizarStatusUsuarioRegra status = new LocalizarStatusUsuarioRegra();
            cbStatusUsuarioUsuario.DataSource = status.TodosStatus();
            cbStatusUsuarioUsuario.DisplayMember = "nomeStatus";
            cbStatusUsuarioUsuario.ValueMember = "idStatusUsuario";
            cbStatusUsuarioUsuario.Text = "Selecione um Status";
        }
        void carregarNivelAcesso()
        {
            cbNivelAcessoUsuario.Text = "Selecione um nível de acesso";
            LocalizarNivelRegra nivel = new LocalizarNivelRegra();
            cbNivelAcessoUsuario.DataSource = nivel.TodosNiveis();
            cbNivelAcessoUsuario.DisplayMember = "nomeNivel";
            cbNivelAcessoUsuario.ValueMember = "idNivelAcesso";
           
        }
        //zebrar Dtg
        
        //Preencher DTG
        void PreencherDtgPaciente(DataTable dados)
        {
            try
            {
                if (dados.Rows.Count > 0)
                {
                    dtgPaciente.DataSource = dados;

                    //Código
                    
                    dtgPaciente.Columns["Código"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Linhas      

                    //Nome
                    dtgPaciente.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Preenche o restante do espaço.

                    //CPF
                    dtgPaciente.Columns["CPF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    //Data Nasc
                    dtgPaciente.Columns["Data Nasc."].Width = 110;//largura total da coluna.
                    dtgPaciente.Columns["Data Nasc."].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Linhas 
                    dtgPaciente.Columns["Data Nasc."].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    //Usuário
                    dtgPaciente.Columns["Usuário"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    //Restaurar
                    dtgPaciente.Columns["btnRestaurarPaciente"].Width = 80;//largura total da coluna.
                    dtgPaciente.Columns["btnRestaurarPaciente"].DisplayIndex = dtgPaciente.Columns.Count - 1;//Posição dentro do dtg
                    dtgPaciente.Columns["btnRestaurarPaciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    //Deletar
                    dtgPaciente.Columns["btnDeletarPaciente"].Width = 65;//largura total da coluna.
                    dtgPaciente.Columns["btnDeletarPaciente"].DisplayIndex = dtgPaciente.Columns.Count - 1;//Posição dentro do dtg.
                    dtgPaciente.Columns["btnDeletarPaciente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dtgPaciente.AutoResizeColumns();
                    dtgPaciente.Columns["Código"].Width = 70;//Largura da coluna
                }
                else
                {
                    if (dtgPaciente.Rows.Count > 0)
                    {
                        MessageBox.Show("Registros de pacientes não encontrado!", "Registros não Encontrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgPaciente.Rows.Clear();
                    }
                }
                
                zerarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método PreencherDtg do frmLocalizarPaciente", "Erro");
            }

        }
        void PreencherDtgProfissional(DataTable dados)
        {
            try
            {
                if (dados.Rows.Count > 0)
                {
                    dtgProfissional.DataSource = dados;
                    //Código
                    dtgProfissional.Columns["Código"].Width = 70;//Largura da coluna
                    dtgProfissional.Columns["Código"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Linhas      

                    //Nome
                    dtgProfissional.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Preenche o restante do espaço.

                    //CPF
                    dtgProfissional.Columns["CPF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    //CROO
                    dtgProfissional.Columns["CROO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    //Data Nasc
                    dtgProfissional.Columns["Data Nasc."].Width = 110;//largura total da coluna.
                    dtgProfissional.Columns["Data Nasc."].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Linhas 
                    dtgProfissional.Columns["Data Nasc."].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    //Usuário
                    dtgProfissional.Columns["Usuário"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    //Restaurar
                    dtgProfissional.Columns["btnRestaurarProfissional"].Width = 80;//largura total da coluna.
                    dtgProfissional.Columns["btnRestaurarProfissional"].DisplayIndex = dtgProfissional.Columns.Count - 1;//Posição dentro do dtg
                    dtgProfissional.Columns["btnRestaurarProfissional"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    //Deletar
                    dtgProfissional.Columns["btnDeletarProfissional"].Width = 65;//largura total da coluna.
                    dtgProfissional.Columns["btnDeletarProfissional"].DisplayIndex = dtgProfissional.Columns.Count - 1;//Posição dentro do dtg.
                    dtgProfissional.Columns["btnDeletarProfissional"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                else
                {
                    if (dtgProfissional.Rows.Count > 0)
                    {
                        MessageBox.Show("Os Registros de profissionais não foram encontrados!",
                                      "Registros não Encontrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgProfissional.Rows.Clear();
                    }
                }
                dtgProfissional.AutoResizeColumns();//Ajusta a largura da coluna automaticamente
                zerarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao preencher o dtgProfissional" + ex, "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void PreencherDtgConsulta(DataTable dados)
        {
            try
            {
                if (dados.Rows.Count > 0)
                {
                    dtgConsulta.DataSource = dados;
                    //Código
                    dtgConsulta.Columns["Código"].Width = 70;//Largura da coluna
                    dtgConsulta.Columns["Código"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Linhas      

                    //Nome
                    dtgConsulta.Columns["Paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Preenche o restante do espaço.

                    //CPF
                    dtgConsulta.Columns["CPF"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    //RG
                    dtgConsulta.Columns["RG"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    //Usuário
                    dtgConsulta.Columns["Usuário"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    //Restaurar
                    dtgConsulta.Columns["btnRestaurarConsulta"].Width = 80;//largura total da coluna.
                    dtgConsulta.Columns["btnRestaurarConsulta"].DisplayIndex = dtgConsulta.Columns.Count - 1;//Posição dentro do dtg
                    dtgConsulta.Columns["btnRestaurarConsulta"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    //Deletar
                    dtgConsulta.Columns["btnDeletarConsulta"].Width = 65;//largura total da coluna.
                    dtgConsulta.Columns["btnDeletarConsulta"].DisplayIndex = dtgConsulta.Columns.Count - 1;//Posição dentro do dtg.
                    dtgConsulta.Columns["btnDeletarConsulta"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                else
                {
                    if (dtgConsulta.Rows.Count > 0)
                    {
                        MessageBox.Show("Os Registros só de Consultas não foram encontrados!",
                                       "Registros não Encontrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               dtgConsulta.AutoResizeColumns();//Ajusta a largura da coluna automaticamente.
                zerarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao preencher o dtgConsulta" + ex, "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void PreencherDtgUsuario (DataTable dados)
        {
            try
            {
                if (dados.Rows.Count > 0)
                {
                    dtgUsuario.DataSource = dados;
                    //Código
                    dtgUsuario.Columns["Código"].Width = 70;//Largura da coluna
                    dtgUsuario.Columns["Código"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Linhas      

                    //Nome
                    dtgUsuario.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Preenche o restante do espaço.

                    //Login
                    dtgUsuario.Columns["Login"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    //Nível de Acesso 
                    dtgUsuario.Columns["Nível de Acesso"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtgUsuario.Columns["Nível de Acesso"].HeaderText = "N. de Acesso";

                    //Status
                    dtgUsuario.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    //Usuário
                    dtgUsuario.Columns["Usuário"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    //Restaurar
                    dtgUsuario.Columns["btnRestaurarUsuario"].Width = 80;//largura total da coluna.
                    dtgUsuario.Columns["btnRestaurarUsuario"].DisplayIndex = dtgUsuario.Columns.Count -1 ;//Posição dentro do dtg
                    dtgUsuario.Columns["btnRestaurarUsuario"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    //Deletar
                    dtgUsuario.Columns["btnDeletarUsuario"].Width = 65;//largura total da coluna.
                    dtgUsuario.Columns["btnDeletarUsuario"].DisplayIndex = dtgUsuario.Columns.Count -1;//Posição dentro do dtg.
                    dtgUsuario.Columns["btnDeletarUsuario"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                else
                {
                    if (dtgUsuario.Rows.Count > 0)
                    {
                        MessageBox.Show("Os Registros de Consultas não foram encontrados!",
                                      "Registros não Encontrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgUsuario.Rows.Clear();
                    }
                }
                dtgConsulta.AutoResizeColumns();//Ajusta a largura da coluna automaticamente.
                zerarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao preencher o dtgUsuario" + ex, "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Repetidor
        private void repetidor_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < dtgPaciente.Rows.Count; i++)
            {
                dtgPaciente.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                i++;
            }
            for (int i = 0; i < dtgProfissional.Rows.Count; i++)
            {
                dtgProfissional.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                i++;
            }
            for (int i = 0; i < dtgConsulta.Rows.Count; i++)
            {
                dtgConsulta.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                i++;
            }
            for (int i = 0; i < dtgUsuario.Rows.Count; i++)
            {
                dtgUsuario.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                i++;
            }
        }

    }
}
