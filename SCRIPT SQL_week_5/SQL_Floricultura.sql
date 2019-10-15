--1 - Criar uma base de dados chamada FloriculturaDB

CREATE DATABASE FloriculturaDB;
USE FloriculturaDB;

--		1.1.1 - Flores - 1.1.1.1 - Id,Nome,Quantidade
CREATE TABLE [dbo].[Flores] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Nome]       NVARCHAR (20) NULL,
    [Quantidade] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

--1.2 - Devemos inserir ao menos 5 flores dentro de nossa tabelas
INSERT INTO Flores (Nome, Quantidade) values ('Rosa', 4), ('Violeta', 3), ('Petunia', 2), ('Margarida', 7), ('Cravo', 2);

--	1.3 - Devemos ter uma seleção ordenada das flores, da que contem a maior quantidade para a menor
SELECT * FROM Flores order by Quantidade DESC

--	1.3 - Devemos retornar uma seleção com a quantidade total de flores que temos em nossa tabela
SELECT COUNT(Quantidade) AS 'Total de Flores' FROM Flores 