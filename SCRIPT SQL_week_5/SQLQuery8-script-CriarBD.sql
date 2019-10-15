CREATE DATABASE BaseSistemaLocacao
GO
USE BaseSistemaLocacao
GO
CREATE TABLE Usuarios
(
	[Id]               INT         IDENTITY (1, 1) NOT NULL,
    [Nome]             NCHAR (100) NOT NULL,
    [Login]            NCHAR (50)  NOT NULL,
    [Senha]            NCHAR (50)  NOT NULL,
    [Ativo]            BIT         DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE TABLE Marcas
(
	[Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Nome]   NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE TABLE Carro 
(
    [Id]               INT         IDENTITY (1, 1) NOT NULL, 
    [Modelo]           NCHAR (100) NOT NULL,
    [MarcaCodigo]      INT         NULL,
    [Placa]            NCHAR (7)   NOT NULL,
    [Ano]              INT         NULL,
    [Ativo]            BIT         DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE TABLE Locacao (
    [Id]               INT      IDENTITY (1, 1) NOT NULL,
    [UsuarioId]        INT      NOT NULL,
    [CarroId]          INT      NOT NULL,
    [Valor]            MONEY    NULL,
    [DataInicio]       DATETIME DEFAULT (getdate()) NULL,
    [DataDevolucao]    DATETIME DEFAULT (dateadd(day,(5),getdate())) NULL,
    [Ativo]            BIT      DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT      DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT      DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
INSERT INTO Usuarios ([Nome],[Login],[Senha]) VALUES ('Administrador','admin','admin')
INSERT INTO Marcas ([Codigo], [Nome]) VALUES (1, 'Ford'), (2, 'Volkswagem'), (3, 'Chevrolet'), (4, 'Renault')