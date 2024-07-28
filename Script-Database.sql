CREATE DATABASE BlocoDeNotas;

USE BlocoDeNotas;

--Trigrama = NTS
CREATE TABLE Notas(
	NTS_Id int,
	NTS_Titulo varchar(500) not null,
	NTS_Texto varchar(8000) not null,
	NTS_DataCriacao Date not null,
	NTS_DataUltimaAtualizacao Date not null,
	PRIMARY KEY(NTS_Id)
);
