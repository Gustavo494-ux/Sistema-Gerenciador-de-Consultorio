
--select * from usuario;
--select * from nivelAcesso;


--Insere o Status de Usuario Ativo.
insert into statusUsuario(nomeStatus,descricaostatususuario,deletar) 
	VALUES('Ativo','Possue acesso ao sistema com suas devidas altorizações de segurança',false),
('Inativo','Não Possue acesso ao sistema',false);

--Insere os nivel de acesso Desenvolvedor,Profissional,Recepcionista,Administrador.
insert into nivelAcesso(nomeNivel,descricaoNivel,deletar) values 
('Desenvolvedor','Acesso total e inrrestrito',false),
('Profissional','Acesso que permite inserções, atualizações, pesquisas e deletar consultas e registros de paciente',false),
('Recepcionista','Acesso que permite inserções,atualizações, pesquisas(restritas ao que sua função necessita) e deletar consultas e registros de paciente',false),
('Administrador','Não tem acesso a funções exclusivas para desenvolvedor,informações sensiveis dos pacientes,funcionarios e profissionais',false);

--Insere os usuarios padrões.
insert into usuario(idNivel,idUsuarioCadastro,nomeUsuario,loginUsuario,senhaUsuario,dataCadastro,horaCadastro,observacaoUsuario,statusUsuario,
deletar) 
values ('1','1','GUSTAVO GAMA DOS SANTOS', 'GUSTAVO_DEV','0a47151a074e633ab7b6bed6aab724abbddcd3250f80a06bc612a233a907805101f2441b5b2926e54ce8ac8cfbc074bb7a56748830487df09591dbe167e800f6',
				'2020-01-23','12:52:38','daad','Ativo',false);


--Insert dos status Agendamento
insert into statusAgendamento(nomeStatus,descricao,deletar) values 
	('Marcada','Consulta marcada porém o paciente ainda tem de comparecer no dia da consulta para entrar na lista de atendimento',false),
	('Aguardando','Já compereceu ao consultorio e está aguardando ser chamado',false),
	('Em atendimento','Está sendo atendido no momento',false),
	('Atendimento Finalizado','atendimento já foi realizado',false),
	('Cancelada','O agendamento foi cancelado por algum motivo',false),
	('Alta Prioridade','Paciente que tem direito garantido por lei. Tipo gestantes,idosos, pessoas com crianças de colo dentre outras',false),
	('Revisão','Paciente já fez a consulta e foi requerido que o mesmo retornesse para uma revisão',false);






update acuidadeVisual set deletar = false;
update agendamento set deletar = false,idUsuarioDeletar = '0';
update anamnese set deletar = false;
update antecedentesGerais set deletar = false;
update antecedentesOculares set deletar = false;
update consulta set deletar = false,idUsuarioDeletar = '0';
update contato set deletar = false,idUsuarioDeletar = '0';
update endereco set deletar = false,idUsuarioDeletar = '0';
update nivelAcesso set deletar = false,idUsuarioDeletar = '0';
update oftalmoscopia set deletar = false;
update paciente set deletar = false,idUsuarioDeletar = '0';
update profissional set deletar = false,idUsuarioDeletar = '0';
update rxInicial set deletar = false;
update rxFinal set deletar = false;
update sintomasReferidos set deletar = false;
update statusAgendamento set deletar = false;
update usuario set deletar = false,idUsuarioDeletar = '0';	
update acuidadeVisual set deletar = false;
update agendamento set deletar = false,idUsuarioDeletar = '0';
update anamnese set deletar = false;
update antecedentesGerais set deletar = false;
update antecedentesOculares set deletar = false;
update consulta set deletar = false,idUsuarioDeletar = '0';
update contato set deletar = false,idUsuarioDeletar = '0';
update endereco set deletar = false,idUsuarioDeletar = '0';
update nivelAcesso set deletar = false,idUsuarioDeletar = '0';
update oftalmoscopia set deletar = false;
update paciente set deletar = false,idUsuarioDeletar = '0';
update profissional set deletar = false,idUsuarioDeletar = '0';
update rxInicial set deletar = false;
update rxFinal set deletar = false;
update sintomasReferidos set deletar = false;
update statusAgendamento set deletar = false;
update usuario set deletar = false,idUsuarioDeletar = '0';	