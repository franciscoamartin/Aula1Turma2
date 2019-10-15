CREATE TABLE [dbo].[Pedidos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Numero] NVARCHAR(10) NOT NULL, 
    [ClienteId] INT NOT NULL, 
    [Valor] MONEY NULL DEFAULT 0,		
    [Ativo] BIT NULL DEFAULT 1,
	[UsuarioCriacao] INT NULL DEFAULT 0, 
    [UsuarioAlteracao] INT NULL DEFAULT 0, 
    [DataCriacao] DATETIME NULL DEFAULT GETDATE(), 
    [DataAlteracao] DATETIME NULL DEFAULT GETDATE(), 
    CONSTRAINT [FK_Pedidos_To_Clientes] 
	FOREIGN KEY ([ClienteId]) REFERENCES [Clientes]([Id])
)
