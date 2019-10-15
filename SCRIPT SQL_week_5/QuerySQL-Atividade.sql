CREATE DATABASE BaseDeDadosHbsis
GO
USE BaseDeDadosHbsis
GO
CREATE TABLE Carros(
	[Id] int IDENTITY (1,1) NOT NULL,
	[Modelo]           NCHAR (50) NULL,
    [CodigoMarca]      INT        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE TABLE Motos(
	[Id] int IDENTITY (1,1) NOT NULL,
	[Modelo]           NCHAR (50) NULL,
    [CodigoMarca]      INT        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE TABLE MarcasCarros (
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Nome]   NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE TABLE MarcasMotos (
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Nome]   NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
INSERT INTO Carros ([CodigoMarca], [Modelo]) VALUES (10,'Sportage'), (10,'Soul'), (10, 'Sorento'), (10,'Grand Carnival'),(10,'Optima'), (8, 'EcoSport')
GO
INSERT INTO MarcasCarros ([Codigo], [Nome]) VALUES (10, 'KIA'), (8, 'FORD')
GO
INSERT INTO Motos ([CodigoMarca], [Modelo]) VALUES (5,'Ninja'), (5,'Voyager'), (5, 'Z 300'), (5,'Z 750'),(5,'Z 900'),(6,'K 1200')
go
INSERT INTO MarcasMotos ([Codigo], [Nome]) VALUES (5, 'Kawasaki'),(6,'BMW' )
GO
select * from Carros
GO
select * from Motos
GO
select 
car.Id,
car.Modelo,
mar.Nome as 'Marca'
from Carros car inner join MarcasCarros mar on car.CodigoMarca = mar.Codigo where mar.Codigo = 10
GO
select 
mot.Id,
mot.Modelo,
marM.Nome as 'Marca'
from Motos mot inner join MarcasMotos marM on mot.CodigoMarca = marM.Codigo where marM.Codigo = 5


