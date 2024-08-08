CREATE DATABASE BlocoDeNotas;

USE BlocoDeNotas;

DROP TABLE NOTAS;

--Trigrama = NTS
CREATE TABLE Notas(
	NTS_Id int IDENTITY (1,1),
	NTS_Titulo varchar(500) not null,
	NTS_Texto varchar(8000) not null,
	NTS_DataCriacao Date not null,
	NTS_DataUltimaAtualizacao Date not null,
	CONSTRAINT PK_NTS PRIMARY KEY(NTS_Id)
);

--Trigrama = USU
CREATE TABLE Usuarios(
	USU_Id int IDENTITY (1,1),
	USU_Nome varchar(500) not null,
	USU_Dtnascimento DATE not null,
	USU_email varchar(500) not null,
	USU_Senha varchar(500) not null,
	CONSTRAINT PK_USU PRIMARY KEY (USU_Id)
);