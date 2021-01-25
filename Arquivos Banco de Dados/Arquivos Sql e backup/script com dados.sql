drop table agendamento,  anamnese,acuidadeVisual,forometria, retinoscopia,lensometria, rxInicial,RxFinal,visaoCor,estereopsia,amsler,
antecedentesGerais,antecedentesOculares,biomicroscopia,ceratometria,motilidadeOcular,sintomasReferidos,oftalmoscopia,statusUsuario,statusAgendamento,
consulta,consulta,paciente,profissional,contato,endereco,usuario,nivelAcesso;


CREATE TABLE paciente (
idPaciente serial PRIMARY KEY,
idContato serial,
idEndereco serial,
idUsuario serial,
nomePaciente varchar(50),
nomeResponsavel varchar(50),
rg varchar(20),
cpf varchar(14),
ocupacao varchar(30),
idade varchar(3),
sexo varchar(1),
dataNascimento date,
dataCadastro date,
horaCadastro time,
observacaoPaciente varchar,
deletar boolean,
idUsuarioDeletar serial
);

CREATE TABLE contato (
idContato serial PRIMARY KEY,
idUsuario serial,
email varchar(50),
telefone1 varchar(11),
telefone2 varchar(11),
telefone3 varchar(11),
outro varchar(100),
observacaoContato varchar,
deletar boolean,
idUsuarioDeletar serial
);

CREATE TABLE statusUsuario (
idStatusUsuario serial PRIMARY KEY,
nomeStatus varchar(20),
descricaoStatusUsuario varchar,
deletar boolean
);

CREATE TABLE profissional (
idProfissional serial PRIMARY KEY,
idEndereco serial,
idContato serial,
idUsuario serial,
nomeProfissional varchar(50),
especialidade varchar(30),
rg varchar(20),
cpf varchar(14),
sexo varchar(1),
croo varchar(10),
dataNascimento date,
dataCadastro date,
horaCadastro time,
observacaoProfissional varchar,
deletar boolean,
idUsuarioDeletar serial,
FOREIGN KEY(idContato) REFERENCES contato (idContato)
);

CREATE TABLE endereco (
idEndereco serial PRIMARY KEY,
idUsuario serial,
estado varchar(30),
cidade varchar(30),
bairro varchar(30),
rua varchar(50),
numero varchar(5),
cep varchar(8),
pontoReferencia varchar,
observacaoEndereco varchar,
deletar boolean,
IdUsuarioDeletar serial
);

CREATE TABLE usuario (
idUsuario serial PRIMARY KEY,
idNivel serial,
idUsuarioCadastro serial,
nomeUsuario varchar(50),
loginUsuario varchar(20),
senhaUsuario varchar(128),
dataCadastro date,
horaCadastro time,
observacaoUsuario varchar,
statusUsuario varchar(15),
deletar boolean,
idUsuarioDeletar serial
);

CREATE TABLE statusAgendamento (
idStatusAgendamento  serial PRIMARY KEY,
nomeStatus varchar(50),
descricao varchar,
deletar boolean
);

CREATE TABLE nivelAcesso (
idNivelAcesso serial PRIMARY KEY,
nomeNivel varchar(20),
descricaoNivel varchar,
deletar boolean
);

CREATE TABLE agendamento  (
idAgendamento  serial PRIMARY KEY,
idPaciente serial,
idUsuario serial,
idStatusAgendamento  serial,
dataConsulta date,
horaChegada time,
observacaoAgendamento  varchar,
deletar boolean,
idUsuarioDeletar serial,
FOREIGN KEY(idPaciente) REFERENCES paciente (idPaciente),
FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario),
FOREIGN KEY(idStatusAgendamento ) REFERENCES statusAgendamento (idStatusAgendamento)
);

CREATE TABLE sintomasReferidos (
idSintomasReferidos serial PRIMARY KEY,
idConsulta serial,
visaoBorrada boolean,
cefaleia boolean,
lacrimejamento boolean,
olhoVermelho boolean,
visaoDupla boolean,
fotopsias_fosfenos boolean,
miodesopsias boolean,
dorCabeca boolean,
astenopia boolean,
dorOcular boolean,
ardencia boolean,
secrecoes boolean,
coceira boolean,
fotofobia boolean,
halos boolean,
estrabismo boolean,
outros varchar(100),
outrosConfirm boolean,
deletar boolean
);

CREATE TABLE AntecedentesOculares (
idAntecedentesOculares serial PRIMARY KEY,
idConsulta serial,
traumaOcular boolean,
traumaOcularTratamento varchar(100),
corpoEstranho boolean,
corpoEstranhoTratamento varchar(100),
queimaduras boolean,
queimadurasTratamento varchar(100),
cirurgicos boolean,
cirurgicosTratamento varchar(100),
inflamacoes boolean,
inflamacoesTratamento varchar(100),
catarata boolean,
catarataTratamento varchar(100),
glaucoma boolean,
glaucomaTratamento varchar(100),
cegueira boolean,
cegueiraTratamento varchar(100),
descolamentoRetina boolean,
descolamentoRetinaTratamento varchar(100),
toxoplasmose boolean,
toxoplasmoseTratamento varchar(100),
estrabismo boolean,
estrabismoTratamento varchar(100),
alergicos boolean,
alergicosTratamento varchar(100),
pterigio boolean,
pterigioTratamento varchar(100),
defeitosRefracao boolean,
defeitosRefracaoTratamento varchar(100),
outro varchar(50),
outrosConfirm boolean,
outroTratamento varchar(100),
deletar boolean
);


CREATE TABLE anamnese (
idAnamnese serial PRIMARY KEY,
idConsulta serial,
motivoConsulta varchar(100),
tempoQueixa varchar(100),
observacaoAnamnese varchar,
deletar boolean
);

CREATE TABLE Lensometria (
idLensometria serial PRIMARY KEY,
idConsulta serial,
vlOdEsfera varchar(5),
vlOeEsfera varchar(5),
vpOdEsfera varchar(5),
vpOeEsfera varchar(5),
vlOdCilindro varchar(5),
vlOeCilindro varchar(5),
vpOdCilindro varchar(5),
vpOeCilindro varchar(5),
vlOdEixo varchar(5),
vlOeEixo varchar(5),
vpOdEixo varchar(5),
vpOeEixo varchar(5),
vlOdAdicao varchar(5),
vlOeAdicao varchar(5),
vpOdAdicao varchar(5),
vpOeAdicao varchar(5),
vlOdPrisma varchar(5),
vlOePrisma varchar(5),
vpOdPrisma varchar(5),
vpOePrisma varchar(5),
vlOdBase varchar(5),
vlOeBase varchar(5),
vpOdBase varchar(5),
vpOeBase varchar(5),
tipoLente varchar(50),
material varchar(50),
cor varchar(50),
estado varchar(50),
observacaoLensometria varchar,
deletar boolean
);

CREATE TABLE motilidadeOcular (
idMotilidadeOcular serial PRIMARY KEY,
idConsulta serial,
kappaOe varchar(100),
KappaOd varchar(100),
hirschberg varchar,
ducaoOe varchar(100),
ducaoOd varchar(100),
versaoOd varchar(200),
versaoOe varchar(200),
observacaoMotilidade varchar,
fotomotorOd varchar(100),
fotomotorOe varchar(100),
consensualOd varchar(100),
consensualOe varchar(100),
acomodativoOd varchar(100),
acomodativoOe varchar(100),
balanco varchar(200)
);

CREATE TABLE oftalmoscopia (
idOftalmoscopia serial PRIMARY KEY,
idConsulta serial,
distanciaBruckner varchar(100),
papilaOd varchar(100),
papilaOe varchar(100),
escavacaoOd varchar(100),
escavacaoOe varchar(100),
maculaOd varchar(100),
maculaOe varchar(100),
fixacaoOd varchar(100),
fixacaoOe varchar(100),
relacaoAVOd varchar(100),
relacaoAvOe varchar(100),
corOd varchar(100),
corOe varchar(100),
lenteOd varchar(100),
lenteOe varchar(100),
ObservacaoOftalmoscopia varchar,
deletar boolean
);

CREATE TABLE acuidadeVisual (
idAcuidadeVisual serial PRIMARY KEY,
idConsulta serial,
vlOdSg varchar(10),
vlOeSg varchar(10),
vlAoSg varchar(10),
vlPh varchar(10),
vlOdCc varchar(10),
vlOeCc varchar(10),
vlAoCc varchar(10),
vpOdSc varchar(10),
vpOeSc varchar(10),
vpAoSc varchar(10),
vpOdCc varchar(10),
vpOeCc varchar(10),
vpAoCc varchar(10),
tipoOptotipo varchar(100),
deletar boolean
);

CREATE TABLE antecedentesGerais (
idAntecedentesGerais serial PRIMARY KEY,
idConsulta serial,
vasculares varchar(3),
vascularTratamento varchar(100),
diabetes varchar(3),
diabetesTratamento varchar(100),
imunes varchar(3),
imunesTratamento varchar(100),
neurologicos varchar(3),
neurologicosTratamento varchar(100),
outros varchar(50),
outrosTratamento varchar(100),
outrosConfirm varchar(3),
observacaoAntecedentesGerais varchar,
deletar boolean
);

CREATE TABLE biomicroscopia (
idBiomicroscopia serial PRIMARY KEY,
idConsulta serial,
sobrancelhaOd varchar(100),
sobrancelhaOe varchar(100),
cilioOd varchar(100),
cilioOe varchar(100),
palpebraOd varchar(100),
palpebraOe varchar(100),
conjuntivaOd varchar(100),
conjuntivaOe varchar(100),
escleroticaOd varchar(100),
escleroticaOe varchar(100),
corneaOd varchar(100),
corneaOe varchar(100),
IrisOd varchar(100),
irisOe varchar(100),
cristalinoOd varchar(100),
cristalinoOe varchar(100),
camaraAnteriorod varchar(100),
camaraAnteriorOe varchar(100),
observacaoBiomicroscopia varchar
);

CREATE TABLE Ceratometria (
idCeratometria serial PRIMARY KEY,
idConsulta serial,
od varchar(100),
oe varchar(100),
tipoCeratometro varchar(200),
observacaoCeratometria varchar
);

CREATE TABLE consulta (
idConsulta serial PRIMARY KEY,
idPaciente serial,
idProfissional serial,
idUsuario serial,
origem varchar(100),
hobbies varchar,
encaminhadoPor varchar(100),
ajudaOpticaPrescrita varchar(100),
dataUltimoExame date,
transcricaoLentes varchar,
observacaoReceita varchar,
dataConsulta date,
horaConsulta time,
statusConsulta varchar(50),
observacaoConsulta varchar,
deletar boolean,
idUsuarioDeletar serial,
FOREIGN KEY(idPaciente) REFERENCES paciente (idPaciente),
FOREIGN KEY(idProfissional) REFERENCES profissional (idProfissional),
FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario)
);

CREATE TABLE retinoscopia (
idRetinoscopia serial PRIMARY KEY,
idConsulta serial,
estaticaOd varchar(100),
estaticaOe varchar(100),
dinamicaOd varchar(100),
dinamicaOe varchar(100),
subjetivoOd varchar(100),
subjetivoOe varchar(100),
afinamentoOd varchar(100),
afinamentoOe varchar(100),
adicaoNivelOd varchar(100),
adicaoNivelOe varchar(100),
FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta)
);

CREATE TABLE forometria (
idForometria serial PRIMARY KEY,
idConsulta serial,
testeUtilizado varchar(100),
correcao boolean,
vlOd varchar(100),
vlOe varchar(100),
quarentaCmOd varchar(100),
quarentaCmOe varchar(100),
vinteCmOd varchar(100),
vinteCmOe varchar(100),
ppcOr varchar(100),
ppcLuz varchar(100),
ppcFiltro varchar(100),
pfpVl varchar(100),
pfpVp varchar(100),
rfnVl varchar(100),
rfnVp varchar(100),
aaOd varchar(100),
aaOe varchar(100),
flexibilidadeOd varchar(100),
flexibilidadeOe varchar(100),
metodo varchar(100),
nivelVisual varchar(100),
dt varchar(100),
FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta)
);

CREATE TABLE visaoCor (
idVisaoCor serial PRIMARY KEY,
idConsulta serial,
teste varchar(100),
od varchar(100),
oe varchar(100),
interpretacao varchar,
FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta)
);

CREATE TABLE Amsler (
idAmsler serial PRIMARY KEY,
idConsulta serial,
od varchar(100),
oe varchar(100),
FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta)
);

CREATE TABLE estereopsia (
idEstereopsia serial PRIMARY KEY,
idConsulta serial,
teste varchar(100),
resultado varchar(200),
FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta)
);

CREATE TABLE RxInicial (
idRxInicial serial PRIMARY KEY,
idConsulta serial,
esferaVlOd varchar(20),
esferaVlOe varchar(20),
esferaVpOd varchar(20),
esferaVpOe varchar(20),
cilindroVlOd varchar(20),
cilindroVlOe varchar(20),
cilindroVpOd varchar(20),
cilindroVpOe varchar(20),
eixoVlOd varchar(20),
eixoVlOe varchar(20),
eixoVpOd varchar(20),
eixoVpOe varchar(20),
avVlOd varchar(20),
avVlOe varchar(20),
avVpOd varchar(20),
avVpOe varchar(20),
adicao varchar(50),
dp varchar(50),
tipoMaterial varchar(50),
cor varchar(50),
uso varchar(50),
tipoLente varchar(50),
observacaoRxInicial varchar(100),
FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta)
);

CREATE TABLE rxFinal (
idRxFinal serial PRIMARY KEY,
idConsulta serial,
esferaVlOd varchar(20),
esferaVlOe varchar(20),
esferaVpOd varchar(20),
esferaVpOe varchar(20),
cilindroVlOd varchar(20),
cilindroVlOe varchar(20),
cilindroVpOd varchar(20),
cilindroVpOe varchar(20),
eixoVlOd varchar(20),
eixoVlOe varchar(20),
eixoVpOd varchar(20),
eixoVpOe varchar(20),
avVlOd varchar(20),
avVlOe varchar(20),
avVpOd varchar(20),
avVpOe varchar(20),
adicao varchar(50),
dp varchar(50),
tipoMaterial varchar(50),
cor varchar(50),
uso varchar(50),
tipoLente varchar(50),
observacaoRxFinal varchar(100),
FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta)
);

ALTER TABLE paciente ADD FOREIGN KEY(idContato) REFERENCES contato (idContato);
ALTER TABLE paciente ADD FOREIGN KEY(idEndereco) REFERENCES endereco (idEndereco);
ALTER TABLE paciente ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE contato ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE profissional ADD FOREIGN KEY(idEndereco) REFERENCES endereco (idEndereco);
ALTER TABLE profissional ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE endereco ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE usuario ADD FOREIGN KEY(idNivel) REFERENCES nivelAcesso (idNivelAcesso);
ALTER TABLE usuario ADD FOREIGN KEY(idUsuarioCadastro) REFERENCES usuario (idUsuario);
ALTER TABLE sintomasReferidos ADD FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta);
ALTER TABLE AntecedentesOculares ADD FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta);
ALTER TABLE anamnese ADD FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta);
ALTER TABLE Lensometria ADD FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta);
ALTER TABLE motilidadeOcular ADD FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta);
ALTER TABLE oftalmoscopia ADD FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta);
ALTER TABLE acuidadeVisual ADD FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta);
ALTER TABLE antecedentesGerais ADD FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta);
ALTER TABLE biomicroscopia ADD FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta);
ALTER TABLE Ceratometria ADD FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta);



--Insere o Status de Usuario Ativo.
insert into statusUsuario
	(nomeStatus,descricaostatususuario,deletar)
VALUES('Ativo', 'Possue acesso ao sistema com suas devidas altorizações de segurança', false),
	('Inativo', 'Não Possue acesso ao sistema', false);

--Insere os nivel de acesso Desenvolvedor,Profissional,Recepcionista,Administrador.
insert into nivelAcesso
	(nomeNivel,descricaoNivel,deletar)
values
	('Desenvolvedor', 'Acesso total e inrrestrito', false),
	('Profissional', 'Acesso que permite inserções, atualizações, pesquisas e deletar consultas e registros de paciente', false),
	('Recepcionista', 'Acesso que permite inserções,atualizações, pesquisas(restritas ao que sua função necessita) e deletar consultas e registros de paciente', false),
	('Administrador', 'Não tem acesso a funções exclusivas para desenvolvedor,informações sensiveis dos pacientes,funcionarios e profissionais', false);

--Insere os usuarios padrões.
insert into usuario
	(idNivel,idUsuarioCadastro,nomeUsuario,loginUsuario,senhaUsuario,dataCadastro,horaCadastro,observacaoUsuario,statusUsuario,
	deletar)
values
	('1', '1', 'GUSTAVO GAMA DOS SANTOS', 'GUSTAVO_DEV', '3c122f1d52a76f5b05d522f02e6c5d160360b22136dd2e3d3f3edbb60a924d0f3183ee05ec968d9614d4cbcd9a6a4c453eeb8dcc7c7ff8d5bb69871f2c412ffd',
		'2020-01-23', '12:52:38', 'daad', 'Ativo', false);


--Insert dos status Agendamento
insert into statusAgendamento
	(nomeStatus,descricao,deletar)
values
	('Marcada', 'Consulta marcada porém o paciente ainda tem de comparecer no dia da consulta para entrar na lista de atendimento', false),
	('Aguardando', 'Já compereceu ao consultorio e está aguardando ser chamado', false),
	('Em atendimento', 'Está sendo atendido no momento', false),
	('Atendimento Finalizado', 'atendimento já foi realizado', false),
	('Cancelada', 'O agendamento foi cancelado por algum motivo', false),
	('Alta Prioridade', 'Paciente que tem direito garantido por lei. Tipo gestantes,idosos, pessoas com crianças de colo dentre outras', false),
	('Revisão', 'Paciente já fez a consulta e foi requerido que o mesmo retornesse para uma revisão', false);



update acuidadeVisual set deletar = false;
update agendamento set deletar = false,idUsuarioDeletar = '0';
update anamnese set deletar = false;
update antecedentesGerais set deletar = false;
update antecedentesOculares set deletar = false;
update consulta set deletar = false,idUsuarioDeletar = '0';
update contato set deletar = false,idUsuarioDeletar = '0';
update endereco set deletar = false,idUsuarioDeletar = '0';
update nivelAcesso set deletar = false;--,idUsuarioDeletar = '0';
update oftalmoscopia set deletar = false;
update paciente set deletar = false,idUsuarioDeletar = '0';
update profissional set deletar = false,idUsuarioDeletar = '0';
update sintomasReferidos set deletar = false;
update statusAgendamento set deletar = false;
update usuario set deletar = false,idUsuarioDeletar = '0';

--------------------------------------------------------------------------------------------------------------------------------------------------------------------
INSERT INTO contato(telefone1,idUsuario) VALUES (63987479647,1),
(19982809478,1),
(21996704173,1),
(63994676359,1),
(47994723308,1),
(47983845002,1),
(27982571720,1),
(81982753872,1),
(71988708724,1),
(31989410362,1),
(27986136402,1),
(65994243797,1),
(65998145241,1),
(19982037454,1),
(61996549537,1),
(93989576487,1),
(51997612464,1),
(96986547206,1),
(84982555389,1),
(71998454902,1),
(95997788886,1),
(88996962128,1),
(91992106374,1),
(85987973966,1),
(51984596698,1),
(21996464271,1),
(83993023813,1),
(92999793012,1),
(61995126540,1);
------------------------------------------------------------------------------------------------------------------------
INSERT INTO endereco(cidade,idUsuario) VALUES ('Gurupi',1),
('Campinas',1),
('Vitória da Conquista',1),
('Japeri',1),
('Palmas',1),
('Blumenau',1),
('Blumenau',1),
('Aracruz',1),
('Igarassu',1),
('Salvador',1),
('Ribeirão das Neves',1),
('Guarapari',1),
('Várzea Grande',1),
('Várzea Grande',1),
('Limeira',1),
('Valparaíso de Goiás',1),
('Altamira',1),
('Porto Alegre',1),
('Macapá',1),
('Natal',1),
('Salvador',1),
('Boa Vista',1),
('Crato',1),
('Belém',1),
('Maranguape',1),
('Porto Alegre',1),
('Teresópolis',1),
('João Pessoa',1),
('Manaus',1),
('Brasília',1);
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
INSERT INTO paciente(nomePaciente,idade,cpf,rg,dataNascimento,nomeResponsavel,idUsuario,idEndereco,idContato) VALUES
('Rodrigo Mário da Cruz','34','184.666.486-15','126158678','20/08/1986','Bento Tomás Tiago da Cruz',1,1,1),
('Maitê Lavínia Renata da Luz','70','226.606.343-00','290180144','13/08/1950','Iago Daniel da Luz',1,2,2),
('Clara Carla Sandra Moreira','67','875.860.553-35','306654684','21/09/1953','Nathan Noah Moreira',1,3,3),
('Cauã Thales Araújo','72','866.730.531-60','102879461','24/01/1948','Oliver Ricardo Araújo',1,4,4),
('Edson Fernando Murilo das Neves','35','325.120.203-04','226063604','17/02/1985','Carlos Eduardo Thales das Neves',1,5,5),
('Hugo Luan Pietro Duarte','73','223.890.250-30','324422921','01/01/1947','Paulo Edson Nathan Duarte',1,6,6),
('Heitor Miguel da Conceição','35','169.82.391-06','351871883','06/10/1985','Sebastião Diego da Conceição',1,7,7),
('Maria Stefany Cardoso','18','491.347.359-09','497418423','10/09/2002','Hugo Bento Juan Cardoso',1,8,8),
('Yuri Martin Viana','27','503.185.805-27','287755459','21/01/1993','Martin Heitor Viana',1,9,9),
('Allana Juliana Catarina Pinto','18','097.740.623-70','405846265','16/09/2002','Rodrigo Carlos Tomás Pinto',1,10,10),
('Rayssa Luciana Andreia da Luz','24','237.046.761-44','120495223','23/10/1996','Yuri Caleb Diego da Luz',1,11,11),
('José Bento Melo','79','393.803.175-14','277442114','21/10/1941','Ryan Calebe Luís Melo',1,12,12),
('Bento Matheus Davi Pereira','19','968.105.517-94','274918432','26/02/2001','Raul Calebe Pereira',1,13,13),
('Eliane Heloise Aparício','67','752.996.784-36','417198528','17/03/1953','Levi Otávio Marcelo Aparício',1,14,14),
('Vicente Sebastião Alexandre Assis','25','946.308.719-26','478664175','15/01/1995','Kaique Paulo Assis',1,15,15),
('Benedito Leandro Melo','55','087.362.911-61','290527673','06/06/1965','Edson Diego Melo',1,16,16),
('Liz Isabel Olivia Rocha','64','188.728.256-44','289502512','10/05/1956','Luís Rodrigo Felipe Rocha',1,17,17),
('Cláudio Renato Elias Duarte','50','841.418.895-80','339421253','11/01/1970','Geraldo Otávio Duarte',1,18,18),
('Augusto Lorenzo Iago de Paula','24','351.064.439-54','128388262','27/01/1996','Breno Augusto Leandro de Paula',1,19,19),
('Diogo Julio Anderson da Cunha','41','475.022.239-91','448061739','11/01/1979','Francisco Nelson da Cunha',1,20,20),
('Adriana Isabella Lorena Nascimento','55','291.757.136-59','276352944','19/09/1965','Kaique Antonio Yago Nascimento',1,21,21),
('Luan Anthony Novaes','28','957.407.535-46','435304549','17/01/1992','Arthur Manuel José Novaes',1,22,22),
('Gabrielly Alessandra Santos','57','237.016.903-67','178394981','17/03/1963','Vitor Gabriel Santos',1,23,23),
('Jaqueline Andrea Lopes','29','631.253.445-65','496175981','02/05/1991','Iago Eduardo Tiago Lopes',1,24,24),
('Sebastião Kevin Fábio Silveira','59','100.317.781-60','261389269','11/09/1961','Noah Caio Silveira',1,25,25),
('Adriana Bianca Lima','36','352.336.292-08','168208726','04/08/1984','João Raul Carlos Lima',1,26,26),
('Theo Henrique Jorge de Paula','59','018.084.075-47','261478667','07/01/1961','Yuri Ricardo de Paula',1,27,27),
('Benedito Diego Thomas da Costa','63','904.468.630-50','339676073','01/07/1957','Heitor Thiago Anderson da Costa',1,28,28),
('Alexandre André Galvão','46','351.384.298-84','345508828','19/02/1974','Manuel Joaquim Vicente Galvão',1,29,29);
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
INSERT INTO profissional(nomeProfissional,cpf,rg,dataNascimento,idUsuario,idEndereco,idContato) VALUES 
('Rodrigo Mário da Cruz','184.666.486-15','126158678','20/08/1986',1,1,1),
('Maitê Lavínia Renata da Luz','226.606.343-00','290180144','13/08/1950',1,2,2),
('Clara Carla Sandra Moreira','875.860.553-35','306654684','21/09/1953',1,3,3),
('Cauã Thales Araújo','866.730.531-60','102879461','24/01/1948',1,4,4),
('Edson Fernando Murilo das Neves','325.120.203-04','226063604','17/02/1985',1,5,5),
('Hugo Luan Pietro Duarte','223.890.250-30','324422921','01/01/1947',1,6,6),
('Heitor Miguel da Conceição','169.982.391-06','351871883','06/10/1985',1,7,7),
('Maria Stefany Cardoso','491.347.359-09','497418423','10/09/2002',1,8,8),
('Yuri Martin Viana','503.185.805-27','287755459','21/01/1993',1,9,9),
('Allana Juliana Catarina Pinto','097.740.623-70','405846265','16/09/2002',1,10,10),
('Rayssa Luciana Andreia da Luz','237.046.761-44','120495223','23/10/1996',1,11,11),
('José Bento Melo','393.803.175-14','277442114','21/10/1941',1,12,12),
('Bento Matheus Davi Pereira','968.105.517-94','274918432','26/02/2001',1,13,13),
('Eliane Heloise Aparício','752.996.784-36','417198528','17/03/1953',1,14,14),
('Vicente Sebastião Alexandre Assis','946.308.719-26','478664175','15/01/1995',1,15,15),
('Benedito Leandro Melo','087.362.911-61','290527673','06/06/1965',1,16,16),
('Liz Isabel Olivia Rocha','188.728.256-44','289502512','10/05/1956',1,17,17),
('Cláudio Renato Elias Duarte','841.418.895-80','339421253','11/01/1970',1,18,18),
('Augusto Lorenzo Iago de Paula','351.064.439-54','128388262','27/01/1996',1,19,19),
('Diogo Julio Anderson da Cunha','475.022.239-91','448061739','11/01/1979',1,20,20),
('Adriana Isabella Lorena Nascimento','291.757.136-59','276352944','19/09/1965',1,21,21),
('Luan Anthony Novaes','957.407.535-46','435304549','17/01/1992',1,22,22),
('Gabrielly Alessandra Santos','237.016.903-67','178394981','17/03/1963',1,23,23),
('Jaqueline Andrea Lopes','631.253.445-65','496175981','02/05/1991',1,24,24),
('Sebastião Kevin Fábio Silveira','100.317.781-60','261389269','11/09/1961',1,25,25),
('Theo Henrique Jorge de Paula','018.084.075-47','261478667','07/01/1961',1,26,26),
('Benedito Diego Thomas da Costa','904.468.630-50','339676073','01/07/1957',1,27,27),
('Alexandre André Galvão','351.384.298-84','345508828','19/02/1974',1,28,28),
('Rafael Arthur Barros','008.792.814-05','386262585','22/10/1994',1,29,29);
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

update acuidadeVisual set deletar = false;
update agendamento set deletar = false,idUsuarioDeletar = '0';
update anamnese set deletar = false;
update antecedentesGerais set deletar = false;
update antecedentesOculares set deletar = false;
update consulta set deletar = false,idUsuarioDeletar = '0';
update contato set deletar = false,idUsuarioDeletar = '0';
update endereco set deletar = false,idUsuarioDeletar = '0';
update nivelAcesso set deletar = false;--,idUsuarioDeletar = '0';
update oftalmoscopia set deletar = false;
update paciente set deletar = false,idUsuarioDeletar = '0';
update profissional set deletar = false,idUsuarioDeletar = '0';
update sintomasReferidos set deletar = false;
update statusAgendamento set deletar = false;
update usuario set deletar = false,idUsuarioDeletar = '0';	



update paciente set nomepaciente = upper(nomePaciente), nomeResponsavel = upper(nomeResponsavel);
update profissional set nomeProfissional = upper(nomeProfissional), especialidade = upper(especialidade);
update usuario set nomeUsuario = upper(nomeUsuario), loginUsuario =upper(loginUsuario);
