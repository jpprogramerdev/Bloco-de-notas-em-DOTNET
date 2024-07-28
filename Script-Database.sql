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
