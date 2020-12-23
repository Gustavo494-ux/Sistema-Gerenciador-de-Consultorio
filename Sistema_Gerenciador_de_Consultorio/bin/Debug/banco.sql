
CREATE TABLE endereco (
idEndereco int PRIMARY KEY,
idLogin int,
estado varchar(30),
cidade varchar(30),
bairro varchar(30),
rua varchar(50),
numero varchar(5),
cep varchar(8),
pontoReferencia varchar(200),
observacaoEndereco varchar
);

CREATE TABLE login (
idLogin int PRIMARY KEY,
idUsuario int,
dataInicio date,
horaInicio time,
dataFim date,
horaFim time
);

CREATE TABLE paciente (
idPaciente int PRIMARY KEY,
idContato int,
idEndereco int,
idLogin int,
nomePaciente varchar(50),
nomeResponsavel varchar(50),
rg varchar(20),
cpf varchar(11),
ocupacao varchar(30),
idade varchar(3),
sexo varchar(1),
dataNascimento date,
dataCadastro date,
horaCadastro time,
observacaoPaciente varchar
);

CREATE TABLE consulta (
idConsulta int PRIMARY KEY,
idPaciente int,
idProfissional int,
idLogin int,
cilindricoOE varchar(5),
cilindricoOD varchar(5),
dnpMmOE varchar(5),
dnpMmOD varchar(5),
esfericoOE varchar(5),
esfericoOD varchar(5),
eixoTaboOE varchar(5),
eixoTaboOD varchar(5),
adicaoOE varchar(5),
adicaoOD varchar(5),
suspeitaPatologia varchar(5),
dataConsulta date,
horaConsulta time,
statusConsulta varchar(15),
observacaoConsulta varchar
);

CREATE TABLE profissional (
idProfissional int PRIMARY KEY,
idEndereco int,
idContato int,
idLogin int,
nomeProfissional varchar(50),
especialidade varchar(30),
rg varchar(20),
cpf varchar(11),
sexo varchar(1),
croo varchar(10),
dataNascimento date,
dataCadastro date,
horaCadastro time,
observacaoProfissional varchar
);

CREATE TABLE nivelAcesso (
idNivelAcesso int PRIMARY KEY,
nomeNivel varchar(20),
descricaoNivel varchar(100)
);

CREATE TABLE movimento (
idMovimentacao int PRIMARY KEY,
idCaixa int,
idConsulta int,
idLogin int,
tipoMovimento varchar(15),
tipoPagamento varchar(20),
valor int,
data date,
hora time,
observacaoMovimento varchar
);

CREATE TABLE usuario (
idUsuario int PRIMARY KEY,
idLogin int,
idNivel int,
nomeUsuario varchar(50),
loginUsuario varchar(20),
senhaUsuario varchar(32),
dataCadastro date,
horaCadastro time,
observacaoPaciente varchar,
statusUsuario varchar(15)
);

CREATE TABLE caixa (
idCaixa int PRIMARY KEY,
idLogin int,
dinheiroInicial varchar(6),
dinheiroFinal varchar(6),
TotalEntradaDinheiro varchar(6),
cartao varchar(6),
totalSaida varchar(6),
data date,
hora time,
observacaoCaixa varchar,
statusCaixa varchar(15)
);

CREATE TABLE contato (
idContato int PRIMARY KEY,
idLogin int,
email varchar(50),
telefone1 varchar(11),
telefone2 varchar(11),
telefone3 varchar(11),
outro varchar(100),
observacaoContato varchar
);

