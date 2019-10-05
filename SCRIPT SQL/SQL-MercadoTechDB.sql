--2 - Criar uma base de dados chamada MercadoTechDB

CREATE DATABASE MercadoTechDB;
USE MercadoTechDB;

--		2.1.1 - Funcionario -	2.1.1.1 - Id,Nome e informações de controle
CREATE TABLE [dbo].[Funcionario] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [Nome]             NVARCHAR (20) NULL,
    [Ativo]            BIT           DEFAULT ((1)) NOT NULL,
    [UsuarioCriacao]   INT           DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT           DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME      DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME      DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


--		2.1.1 - Produtos  - 2.1.1.1 - Id,Nome,Valor e informações de controle
CREATE TABLE [dbo].[Produtos] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [Nome]             NVARCHAR (20) NULL,
    [Valor]            MONEY         NULL,
    [Ativo]            BIT           DEFAULT ((1)) NOT NULL,
    [UsuarioCriacao]   INT           DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT           DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME      DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME      DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


-- 2.1.2 - Pedidos - 2.1.2.1 - Id,FuncionarioId,ProdutoId,Quantidade, e informações de controle
CREATE TABLE [dbo].[Pedidos] (
    [Id]               INT      IDENTITY (1, 1) NOT NULL,
    [FuncionarioId]    INT      NULL,
    [ProdutoId]        INT      NULL,
    [Quantidade]       INT      NULL,
    [Ativo]            BIT      DEFAULT ((1)) NOT NULL,
    [UsuarioCriacao]   INT      DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT      DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- 2.2  - Agora devemos inserir 2 funcionarios diferentes
Insert into Funcionario (Nome) values ('Maria'), ('Jose'); 

--	2.3  - Agora devemos cadastrar 5 produtos ambev com seus respectivos valores
Insert into Produtos (Nome, Valor) values ('Brahma',2,5),('Corona', 4), ('Pepsi',2,5), ('Guarana', 2,75 ), ('Skol', 4);

--2.4  - Vamos realizar a felicidade dos funcionarios e realizar 3 pedidos, sendo 2 para o primeiro funcionario e 1 para o segundo
Insert into Pedidos (FuncionarioId, ProdutoId, Quantidade) values (1,2,1), (1,3,2), (2,1,1)


--	2.5  - Vamos Listar em uma seleção de nossos funcionarios por ordem alfabetica
select fun.Nome as 'Funcionário' , pro.Nome as 'Marca'  from Pedidos ped 
inner join Funcionario fun on ped.FuncionarioId = fun.Id 
inner join Produtos pro on ped.ProdutoId = pro.Id
order by fun.Nome ASC

--	2.6  - Vamos listar em uma seleção de nossos produtos do mais caro para o mais barato
select prod.Nome, prod.Valor from Pedidos ped inner join Produtos prod on ped.ProdutoId = prod.Id order by prod.Valor DESC

--	2.6  - Vamos listar em uma seleção de nossos produtos do mais caro para o mais barato
select * from Produtos order by Valor DESC

--	2.7  - Vamos listar em uma seleção de nossos pedidos por funcionario trazendo o nome do funcionario
select fun.Nome as 'Funcionário' , pro.Nome as 'Marca' , SUM(ped.Quantidade) as 'Quantidade' from Pedidos ped 
inner join Funcionario fun on ped.FuncionarioId = fun.Id 
inner join Produtos pro on ped.ProdutoId = pro.Id group by fun.Nome, pro.Nome, ped.Quantidade
order by ped.Quantidade ASC

--	2.8  - Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando sua respectiva quantidade de itens
select fun.Nome as 'Funcionário' , pro.Nome as 'Marca', (pro.Valor * ped.Quantidade) as 'Valor Total', ped.Quantidade from Pedidos ped 
inner join Funcionario fun on ped.FuncionarioId = fun.Id 
inner join Produtos pro on ped.ProdutoId = pro.Id group by fun.Nome, pro.Nome, (pro.Valor * ped.Quantidade), ped.Quantidade
order by pro.Nome ASC -- verificar


--2.9  - Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando seu valor total lembrando que o valor total e a a "quantidade * valor"
select ped.Quantidade , pro.Nome from Pedidos ped 
inner join Produtos pro on ped.ProdutoId = pro.Id
order by ped.Quantidade DESC

--2.9  - Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando seu valor total lembrando que o valor total e a a "quantidade * valor"
select ped.Quantidade, pro.Nome , SUM(pro.Valor * ped.Quantidade) as 'Valor Total' , fun.Nome  from Pedidos ped
inner join Produtos pro on ped.ProdutoId = pro.Id 
inner join Funcionario fun on ped.FuncionarioId = fun.Id
group by ped.Quantidade, pro.Nome , pro.Valor * ped.Quantidade, fun.Nome
order by ped.Quantidade DESC

--	2.10 - Vamos retornar em uma seleção nosso produto mais pedido dentro de nossa base de dados
select pro.Nome , ped.Quantidade from Pedidos ped 
inner join Produtos pro on ped.ProdutoId = pro.Id
group by pro.Nome, ped.Quantidade
order by ped.Quantidade DESC


--	2.11 - Vamos retornar em uma seleção o produto que gerou a maior receita dentro de nossa base de dados 
select pro.Nome, ped.Quantidade from Pedidos ped inner join Produtos pro on ped.ProdutoId = pro.Id group by pro.Nome, ped.Quantidade


--	2.12 - Vamos retornar em uma seleção para o primeiro funcionario os produtos que ele não comprou de nosso mercado

select fun.Nome as 'Funcionário' , pro.Nome as 'Marca', (pro.Valor * ped.Quantidade) as 'Valor Total', ped.Quantidade from Pedidos ped 
inner join Funcionario fun on ped.FuncionarioId = fun.Id 
inner join Produtos pro on ped.ProdutoId = pro.Id group by fun.Nome, pro.Nome, (pro.Valor * ped.Quantidade), ped.Quantidade
order by pro.Nome ASC --fazer


--	2.13 - Vamos retornar em uma seleção os produtos ordenados pela ordem do mais comprado para o menos comprado
select fun.Nome as 'Funcionário' , pro.Nome as 'Marca', (pro.Valor * ped.Quantidade) as 'Valor Total', ped.Quantidade from Pedidos ped 
inner join Funcionario fun on ped.FuncionarioId = fun.Id 
inner join Produtos pro on ped.ProdutoId = pro.Id group by fun.Nome, pro.Nome, (pro.Valor * ped.Quantidade), ped.Quantidade
order by ped.Quantidade DESC


