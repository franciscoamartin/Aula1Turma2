CREATE TABLE UsuarioXP 
(
	[Id]   INT         IDENTITY (1, 1) NOT NULL,
    [Nome]             NCHAR (100) NULL,
    [Login]            NCHAR (50)  NULL,
    [Senha]            NCHAR (50)  NULL,
    [Ativo]            BIT         DEFAULT ((1)) NOT NULL,
    [UsuarioCriacao]   INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)

)
GO
CREATE TABLE MarcasXP
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Codigo] INT NULL, 
    [Nome] NCHAR(20) NULL
)
GO
CREATE TABLE CarrosXP (
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [Modelo]           NCHAR (50) NULL,
    [MarcaCodigo]            INT NULL,
    [Placa]            NCHAR (7)  NULL,
    [Ano]              INT        NULL,
    [Ativo]            BIT        DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE TABLE LocacoesXP (
    [Id]               INT      IDENTITY (1, 1) NOT NULL,
    [UsuarioId]        INT      NULL,
    [CarroId]          INT      NULL,
    [Valor]            MONEY    NULL,
    [DataInicial]      DATETIME DEFAULT (getdate()) NULL,
    [DataDevolucao]    DATETIME DEFAULT (dateadd(day,(5),getdate())) NULL,
    [Ativo]            BIT      DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT      DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT      DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
insert into UsuarioXP (Nome,Login,Senha)values('Admin','Admin', 'Admin')
GO
insert into MarcasXP(Nome, Codigo)values('FORD', '5')
GO
select * from UsuarioXP
select * from MarcasXP





