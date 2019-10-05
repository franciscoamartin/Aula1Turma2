CREATE TABLE [dbo].[Produtos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Nome] NVARCHAR(20) NULL, 
    [Valor] MONEY NULL,
	[Ativo]            BIT         DEFAULT ((1)) NOT NULL,
    [UsuarioCriacao]   INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL, 

)
