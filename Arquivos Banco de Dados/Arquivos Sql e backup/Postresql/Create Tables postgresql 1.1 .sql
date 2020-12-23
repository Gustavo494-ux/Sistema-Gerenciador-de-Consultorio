DROP table caixa, consulta, contato,endereco, movimento,nivelAcesso, paciente, profissional, usuario,statusUsuario;
-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.




CREATE TABLE nivelAcesso (
idNivelAcesso serial PRIMARY KEY,
nomeNivel varchar(20),
descricaoNivel varchar,
deletar boolean
);

CREATE TABLE statusUsuario (
idStatusUsuario serial PRIMARY KEY,
nomeStatus varchar(20),
descricaoStatusUsuario varchar,
deletar boolean
);

CREATE TABLE movimento (
idMovimentacao serial PRIMARY KEY,
idCaixa int,
idConsulta int,
data date,
idUsuario int,
deletar varchar(5),
tipoPagamento varchar(20),
observacaoMovimento varchar,
valor float,
hora time,
tipoMovimento boolean
);

CREATE TABLE caixa (
idCaixa serial PRIMARY KEY,
idUsuario int,
dinheiroInicial float,
dinheiroFinal float,
TotalEntradaDinheiro float,
cartao float,
totalSaida float,
data date,
hora time,
observacaoCaixa varchar,
statusCaixa varchar(15),
deletar boolean
);

CREATE TABLE consulta (
idConsulta serial PRIMARY KEY,
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
suspeitaPatologia varchar,
DataConsulta date,
horaConsulta time,
statusConsulta varchar(15),
observacaoConsulta varchar,
deletar boolean
);

CREATE TABLE paciente (
idPaciente serial PRIMARY KEY,
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
observacaoPaciente varchar,
deletar boolean
);

CREATE TABLE usuario (
idUsuario serial PRIMARY KEY,
idNivel int,
idUsuarioCadastro int,
nomeUsuario varchar(50),
loginUsuario varchar(20),
senhaUsuario varchar(128),
dataCadastro date,
horaCadastro time,
observacaoUsuario varchar,
statusUsuario varchar(15),
deletar boolean,
FOREIGN KEY(idNivel) REFERENCES nivelAcesso (idNivelAcesso)
);

CREATE TABLE profissional (
idProfissional serial PRIMARY KEY,
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
observacaoProfissional varchar,
deletar boolean,
FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario)
);

CREATE TABLE endereco (
idEndereco serial PRIMARY KEY,
idUsuario int,
estado varchar(30),
cidade varchar(30),
bairro varchar(30),
rua varchar(50),
numero varchar(5),
cep varchar(8),
pontoReferencia varchar,
observacaoEndereco varchar,
deletar boolean,
FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario)
);

CREATE TABLE contato (
idContato serial PRIMARY KEY,
idUsuario int,
email varchar(50),
telefone1 varchar(11),
telefone2 varchar(11),
telefone3 varchar(11),
outro varchar(100),
observacaoContato varchar,
deletar boolean,
FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario)
);

ALTER TABLE movimento ADD FOREIGN KEY(idCaixa) REFERENCES caixa (idCaixa);
ALTER TABLE movimento ADD FOREIGN KEY(idConsulta) REFERENCES consulta (idConsulta);
ALTER TABLE caixa ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE consulta ADD FOREIGN KEY(idPaciente) REFERENCES paciente (idPaciente);
ALTER TABLE consulta ADD FOREIGN KEY(idProfissional) REFERENCES profissional (idProfissional);
ALTER TABLE consulta ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE paciente ADD FOREIGN KEY(idContato) REFERENCES contato (idContato);
ALTER TABLE paciente ADD FOREIGN KEY(idEndereco) REFERENCES endereco (idEndereco);
ALTER TABLE paciente ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE usuario ADD FOREIGN KEY(idUsuarioCadastro) REFERENCES usuario (idUsuario);
ALTER TABLE profissional ADD FOREIGN KEY(idEndereco) REFERENCES endereco (idEndereco);
ALTER TABLE profissional ADD FOREIGN KEY(idContato) REFERENCES contato (idContato)