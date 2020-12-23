--DROP table caixa, consulta, contato,endereco, movimento,nivelAcesso, paciente, profissional, usuario,statusUsuario;
-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.



CREATE TABLE caixa (
idCaixa serial PRIMARY KEY not null,
idUsuario int,
dinheiroInicial varchar(6),
dinheiroFinal varchar(6),
TotalEntradaDinheiro varchar(6),
cartao varchar(6),
totalSaida varchar(6),
data date,
hora time,
observacaoCaixa varchar(15000),
statusCaixa varchar(15),
deletar boolean
);

CREATE TABLE contato (
idContato serial PRIMARY KEY not null,
idUsuario int,
email varchar(50),
telefone1 varchar(11),
telefone2 varchar(11),
telefone3 varchar(11),
outro varchar(100),
observacaoContato varchar(15000),
deletar boolean
);

CREATE TABLE nivelAcesso (
idNivelAcesso serial PRIMARY KEY not null,
nomeNivel varchar(20),
descricaoNivel varchar(15000),
deletar boolean
);

CREATE TABLE movimento (
idMovimentacao serial PRIMARY KEY not null,
idCaixa int,
idConsulta int,
idUsuario int,
tipoMovimento varchar(15),
tipoPagamento varchar(20),
valor int,
data date,
hora time,
observacaoMovimento varchar(15000),
deletar boolean,
FOREIGN KEY(idCaixa) REFERENCES caixa (idCaixa)
);

CREATE TABLE consulta (
idConsulta serial PRIMARY KEY not null,
idPaciente int,
idProfissional int,
idUsuario int,
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
suspeitaPatologia varchar(15000),
dataConsulta date,
horaConsulta time,
statusConsulta varchar(15),
observacaoConsulta varchar(15000),
deletar boolean
);

CREATE TABLE paciente (
idPaciente serial PRIMARY KEY not null,
idContato int,
idEndereco int,
idUsuario int,
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
observacaoPaciente varchar(15000),
deletar boolean,
FOREIGN KEY(idContato) REFERENCES contato (idContato)
);

CREATE TABLE usuario (
idUsuario serial PRIMARY KEY not null,
idNivel int,
idUsuarioCadastro int,
nomeUsuario varchar(50),
loginUsuario varchar(20),
senhaUsuario varchar(128),
dataCadastro date,
horaCadastro time,
observacaoUsuario varchar(15000),
statusUsuario varchar(15),
deletar boolean,
FOREIGN KEY(idNivel) REFERENCES nivelAcesso (idNivelAcesso)
);

CREATE TABLE endereco (
idEndereco serial PRIMARY KEY not null,
idUsuario int,
estado varchar(30),
cidade varchar(30),
bairro varchar(30),
rua varchar(50),
numero varchar(5),
cep varchar(8),
pontoReferencia varchar(200),
observacaoEndereco varchar(15000),
deletar boolean,
FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario)
);

CREATE TABLE profissional (
idProfissional serial PRIMARY KEY not null,
idEndereco int,
idContato int,
idUsuario int,
nomeProfissional varchar(50),
especialidade varchar(30),
rg varchar(20),
cpf varchar(11),
sexo varchar(1),
croo varchar(10),
dataNascimento date,
dataCadastro date,
horaCadastro time,
observacaoProfissional varchar(15000),
deletar boolean,
FOREIGN KEY(idEndereco) REFERENCES endereco (idEndereco),
FOREIGN KEY(idContato) REFERENCES contato (idContato),
FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario)
);

CREATE TABLE statusUsuario(
idStatusUsuario serial PRIMARY KEY not null,
nomestatus varchar(20),
descricaostatususuario varchar(15000),
deletar boolean
);

ALTER TABLE caixa ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE contato ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE movimento ADD FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta);
ALTER TABLE movimento ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE consulta ADD FOREIGN KEY(idPaciente) REFERENCES paciente (idPaciente);
ALTER TABLE consulta ADD FOREIGN KEY(idProfissional) REFERENCES profissional (idProfissional);
ALTER TABLE consulta ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE paciente ADD FOREIGN KEY(idEndereco) REFERENCES endereco (idEndereco);
ALTER TABLE paciente ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
