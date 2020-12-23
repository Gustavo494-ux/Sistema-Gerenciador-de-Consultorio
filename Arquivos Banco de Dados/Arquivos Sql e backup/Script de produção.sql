DROP table consulta, contato,endereco,nivelAcesso, paciente, profissional, usuario,statusUsuario,agendamento,statusAgendamento,rxFinal,rxInicial,oftalmoscopia,
anamnese,sintomasReferidos,antecedentesGerais,antecedentesOculares,acuidadeVisual;

-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.



CREATE TABLE acuidadeVisual
(
    idAcuidadeVisual serial PRIMARY KEY,
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

CREATE TABLE rxInicial
(
    idRxInicial serial PRIMARY KEY,
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
    observacaoRxInicial varchar,
    deletar boolean
);

CREATE TABLE oftalmoscopia
(
    idOftalmoscopia serial PRIMARY KEY,
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

CREATE TABLE sintomasReferidos
(
    idSintomasReferidos serial PRIMARY KEY,
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
    deletar boolean
);

CREATE TABLE antecedentesGerais
(
    idAntecedentesGerais serial PRIMARY KEY,
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
    observacaoAntecedentesGerais varchar,
    deletar boolean
);

CREATE TABLE rxFinal
(
    idRxFinal serial PRIMARY KEY,
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
    observacaoRxFinal varchar,
    deletar boolean
);

CREATE TABLE AntecedentesOculares
(
    idAntecedentesOculares serial PRIMARY KEY,
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
    outroTratamento varchar(100),
    deletar boolean
);

CREATE TABLE paciente
(
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

CREATE TABLE consulta
(
    idConsulta serial PRIMARY KEY,
    idPaciente serial,
    idProfissional serial,
    idUsuario serial,
    idAnamnese serial,
    idSintomasReferidos serial,
    idAntecedentesGerais serial,
    idAntecedentesOculares serial,
    idRxInicial serial,
    idRxFinal serial,
    idAcuidadeVisual serial,
    idOftalmoscopia serial,
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
    FOREIGN KEY(idSintomasReferidos) REFERENCES sintomasReferidos (idSintomasReferidos),
    FOREIGN KEY(idAntecedentesGerais) REFERENCES antecedentesGerais (idAntecedentesGerais),
    FOREIGN KEY(idAntecedentesOculares) REFERENCES AntecedentesOculares (idAntecedentesOculares),
    FOREIGN KEY(idRxInicial) REFERENCES rxInicial (idRxInicial),
    FOREIGN KEY(idRxFinal) REFERENCES rxFinal (idRxFinal),
    FOREIGN KEY(idAcuidadeVisual) REFERENCES acuidadeVisual (idAcuidadeVisual),
    FOREIGN KEY(idOftalmoscopia) REFERENCES oftalmoscopia (idOftalmoscopia)
);

CREATE TABLE anamnese
(
    idAnamnese serial PRIMARY KEY,
    motivoConsulta varchar(100),
    tempoQueixa varchar(100),
    observacaoAnamnese varchar,
    deletar boolean
);

CREATE TABLE contato
(
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

CREATE TABLE statusUsuario
(
    idStatusUsuario serial PRIMARY KEY,
    nomeStatus varchar(20),
    descricaoStatusUsuario varchar,
    deletar boolean
);

CREATE TABLE profissional
(
    idProfissional serial PRIMARY KEY,
    idEndereco serial,
    idContato serial,
    idUsuario serial,
    nomeProfissional varchar(50),
    especialidade varchar(30),
    rg varchar(20),
    cpf varchar(14),
    sexo varchar(1),
    croo varchar(30),
    dataNascimento date,
    dataCadastro date,
    horaCadastro time,
    observacaoProfissional varchar,
    deletar boolean,
    idUsuarioDeletar serial,
    FOREIGN KEY(idContato) REFERENCES contato (idContato)
);

CREATE TABLE endereco
(
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

CREATE TABLE agendamento
(
    idAgendamento serial PRIMARY KEY,
    idPaciente serial,
    idUsuario serial,
    idStatusAgendamento serial,
    dataConsulta date,
    horaChegada time,
    observacaoAgendamento varchar,
    deletar boolean,
    idUsuarioDeletar serial,
    FOREIGN KEY(idPaciente) REFERENCES paciente (idPaciente)
);

CREATE TABLE usuario
(
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

CREATE TABLE statusAgendamento
(
    idStatusAgendamento serial PRIMARY KEY,
    nomeStatus varchar(50),
    descricao varchar,
    deletar boolean
);

CREATE TABLE nivelAcesso
(
    idNivelAcesso serial PRIMARY KEY,
    nomeNivel varchar(20),
    descricaoNivel varchar,
    deletar boolean
);

ALTER TABLE paciente ADD FOREIGN KEY(idContato) REFERENCES contato (idContato);
ALTER TABLE paciente ADD FOREIGN KEY(idEndereco) REFERENCES endereco (idEndereco);
ALTER TABLE paciente ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE consulta ADD FOREIGN KEY(idProfissional) REFERENCES profissional (idProfissional);
ALTER TABLE consulta ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE consulta ADD FOREIGN KEY(idAnamnese) REFERENCES anamnese (idAnamnese);
ALTER TABLE contato ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE profissional ADD FOREIGN KEY(idEndereco) REFERENCES endereco (idEndereco);
ALTER TABLE profissional ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE endereco ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE agendamento  ADD FOREIGN KEY(idUsuario) REFERENCES usuario (idUsuario);
ALTER TABLE agendamento  ADD FOREIGN KEY(idStatusAgendamento ) REFERENCES statusAgendamento (idStatusAgendamento);
ALTER TABLE usuario ADD FOREIGN KEY(idNivel) REFERENCES nivelAcesso (idNivelAcesso);
ALTER TABLE usuario ADD FOREIGN KEY(idUsuarioCadastro) REFERENCES usuario (idUsuario);





------------------------------------------------------------------------------------------------------------------------------------------------------------
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


update paciente set nomepaciente = upper(nomePaciente), nomeResponsavel = upper(nomeResponsavel);
update profissional set nomeProfissional = upper(nomeProfissional), especialidade = upper(especialidade);
update usuario set nomeUsuario = upper(nomeUsuario), loginUsuario =upper(loginUsuario);

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
update rxInicial set deletar = false;
update rxFinal set deletar = false;
update sintomasReferidos set deletar = false;
update statusAgendamento set deletar = false;
update usuario set deletar = false,idUsuarioDeletar = '0';