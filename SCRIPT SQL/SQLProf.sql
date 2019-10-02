CREATE DATABASE BaseDadosHBSIS;
USE BaseDadosHBSIS

CREATE TABLE [dbo].[Veiculos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Descricao] NVARCHAR(30) NULL, 
    [MarcaCodigo] INT NULL
)
GO

CREATE TABLE [dbo].[Tipos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Codigo] INT NULL, 
    [Nome] NVARCHAR(20) NULL
)
GO

CREATE TABLE [dbo].[Marcas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Codigo] INT NULL, 
    [Nome] NVARCHAR(20) NULL, 
    [TipoCodigo] INT NULL, 
)

GO
INSERT INTO Tipos values (1, 'Carro'), (2, 'Moto') 
GO
INSERT INTO Marcas (Codigo, Nome, TipoCodigo) values (1, 'BMW', 1),(2, 'BMW', 2),(3, 'KIA', 1),(4, 'KAWASAKI', 2)
GO
INSERT INTO Veiculos (Descricao,MarcaCodigo) values ('M6',1),('C600',2),('R200',3), ('Sportage', 3), ('Z 900', 4), ('Z 900', 4)
GO

SELECT * FROM Tipos;
GO
SELECT * FROM Marcas;
GO
SELECT * FROM Veiculos;
GO
SELECT 
vei.Id,
vei.Descricao,
mar.Nome as 'Marca',
tip.Nome as 'Tipo'
FROM Veiculos vei 
inner join Marcas mar on vei.MarcaCodigo = mar.Codigo
inner join Tipos tip on mar.TipoCodigo = tip.Codigo
where mar.Codigo = 4
GO
SELECT 
vei.Id,
vei.Descricao,
mar.Nome as 'Marca',
tip.Nome as 'Tipo'
FROM Veiculos vei 
inner join Marcas mar on vei.MarcaCodigo = mar.Codigo
inner join Tipos tip on mar.TipoCodigo = tip.Codigo
where mar.Codigo = 3