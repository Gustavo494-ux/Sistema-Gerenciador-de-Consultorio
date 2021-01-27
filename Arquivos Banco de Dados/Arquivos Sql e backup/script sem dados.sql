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
email varchar(100),
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

