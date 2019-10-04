update Marcas set UsuInc = 1 where UsuInc = 0 -- exercicio 1

select * from Marcas where UsuInc = 1; -- exercicio 2

select * from Marcas where UsuInc = 2; -- exercicio 3

select usuario.Usuario,
COUNT(mar.UsuInc) as 'Total'
from Usuarios usuario
inner join Marcas mar on usuario.Id = mar.UsuInc where mar.UsuInc = 1
group by usuario.Usuario  -- exercicio 4


--select usuario.Usuario,
--COUNT(mar.UsuInc) as 'Total'
--from Usuarios usuario
--inner join Marcas mar on usuario.Id = mar.UsuInc where mar.UsuInc = 2
--group by usuario.Usuario  order by COUNT (mar.UsuInc) DESC
---- exercicio 5


select usuario.Usuario,
COUNT(mar.UsuInc) as 'Total'
from Usuarios usuario
inner join Marcas mar on usuario.Id = mar.UsuInc where usuario.Id between 1 and 2
group by usuario.Usuario  order by COUNT (mar.UsuInc) DESC
-- exercicio 5

--select car.UsuInc,
--COUNT(car.UsuInc) as 'Total' from Carros car inner join Usuarios usu on car.UsuInc =  usu.Usuario  where usu.Usuario = 1 group by usu.Usuario 


select car.Modelo, car.Marca, usu.Usuario from Carros car inner join Usuarios usu on car.UsuInc = usu.Id where Usuario like 'Felipe%' 
-- exercicio 6

select car.Modelo, car.Marca, usu.Usuario from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
--inner join Marcas mar on car.Marca = mar.Nome
where Usuario like 'Giomar%' 
-- exercicio 7


select COUNT(car.UsuInc) as 'Total'
from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
where Usuario like 'Felipe%' 
group by usu.Usuario order by COUNT(car.UsuInc) ASC
--exercicio 8


select COUNT(car.UsuInc) as 'Total'
from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
where Usuario like 'Giomar%' 
group by usu.Usuario order by COUNT(car.UsuInc) DESC
-- exercicio 9


select COUNT(car.UsuInc) as 'Total'
from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id where usu.Id between 1 and 2
 order by COUNT(car.UsuInc) DESC
--exercicio 10 

select car.Modelo, car.Marca, usu.Usuario from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
inner join Marcas mar on mar.Nome = car.Marca
where Usuario like 'Felipe%' 
-- exercicio 11


--Trazer o valor total de vendas 2019 isolado
select SUM(vend.Valor) from Vendas vend where vend.DatInc between '01/01/2019' and '12/31/2019'

--Trazer a quantidade total de vendas 2019 isolado

select COUNT(vend.Quantidade) from Vendas vend where vend.DatInc between '01/01/2019' and '12/31/2019'

--Trazer a quantidade de vendas em cada ano e ordenar do maior para o menor
select year(DatInc) as 'ano', sum(Valor) as 'total'
from Vendas group by YEAR (DatInc)
order by SUM(Valor) DESC


select MONTH(DatInc) as 'Mês', sum(Valor) as 'total'
from Vendas group by MONTH (DatInc)
order by SUM(Valor) DESC


--teste
--Trazer o mês de cada ano que retornou a maior quantidade de vendas

select top 3 year(DatInc) as 'ano', sum(Quantidade) as 'total',  MONTH(DatInc) as 'mes'
from Vendas group by YEAR (DatInc), MONTH(DatInc)
order by SUM(Quantidade) DESC

--valor
--Trazer o mês de cada ano que retornou o maior valor de vendas

select  year(DatInc) as 'ano', sum(Valor*Quantidade) as 'total',  MONTH(DatInc) as 'mes'
from Vendas group by YEAR (DatInc), MONTH(DatInc)
order by SUM(Valor*Quantidade) DESC


--teste mes 
select  year(DatInc) as 'ano', sum(Valor*Quantidade) as 'total',  MIN(MONTH(DatInc)) as 'mes' 
from Vendas  group by YEAR (DatInc), MONTH(DatInc) 
order by MONTH(DatInc)DESC 

-- Valor total de felipe
select SUM(vend.Valor*Quantidade) as 'Valor Total' from Vendas vend  where UsuInc = 1
--valor total giomar
select SUM(vend.Valor*Quantidade) as 'Valor Total' from Vendas vend  where UsuInc = 2
--quantidade total felipe
select SUM(vend.Quantidade) as 'Quantidade Total' from Vendas vend  where UsuInc = 1
--quantidade total giomar
select SUM(vend.Quantidade) as 'Quantidade Total' from Vendas vend  where UsuInc = 2

--valor total de Felipe
select SUM(vend.Valor*Quantidade) as 'Valor Total' from Vendas vend  inner join Usuarios usu on vend.UsuInc = usu.Id where Usuario like 'Felipe%'

--valor total de giomar
select SUM(vend.Valor*Quantidade) as 'Valor Total' from Vendas vend  inner join Usuarios usu on vend.UsuInc = usu.Id where Usuario like 'Giomar%'


--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select SUM(vend.Quantidade) as 'Quantidade Total' from Vendas vend  
inner join Usuarios usu on vend.UsuInc = usu.Id where usu.Usuario = 'Felipe' or usu.Usuario = 'Giomar' order by vend.Quantidade DESC

--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select SUM(vend.Quantidade * vend.Valor) as 'Valor Total' from Vendas vend  
inner join Usuarios usu on vend.UsuInc = usu.Id where usu.Usuario = 'Felipe' or usu.Usuario = 'Giomar' order by vend.Valor ASC

--Trazer  a marca mais vendida de todos os anos
select car.Modelo, mar.Nome, usu.Usuario from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
inner join Marcas mar on car.Marca = mar.Id 
where Usuario like 'Felipe%' 


----Trazer  a marca mais vendida de todos os anos

select SUM(vend.Quantidade) as 'Quantidade' , car.Modelo, mar.Nome as 'Marca', usu.Usuario from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
inner join Marcas mar on car.Marca = mar.Id 
inner join Vendas vend on vend.Id = vend.Id
where Usuario like 'Felipe%' group by vend.Quantidade, car.Modelo, mar.Nome, usu.Usuario order by vend.Quantidade DESC

-- marca mais vendida de todos os anos
select SUM(vend.Quantidade) as 'Quantidade' , mar.Nome as 'Marca', usu.Usuario from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
inner join Marcas mar on car.Id = mar.Id 
inner join Vendas vend on vend.Id = vend.Id
where usu.Usuario = 'Felipe' or usu.Usuario = 'Giomar' group by vend.Quantidade, mar.Nome, usu.Usuario order by Quantidade DESC

-- valor total marca mais vendida de todos os anos
select SUM(vend.Quantidade* vend.Valor) as 'Valor' , mar.Nome as 'Marca', usu.Usuario from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
inner join Marcas mar on car.Id = mar.Id 
inner join Vendas vend on vend.Id = vend.Id
where usu.Usuario = 'Felipe' or usu.Usuario = 'Giomar' group by vend.Quantidade, mar.Nome, usu.Usuario order by Valor DESC

--Trazer a quantidade do carro mais vendido de todos os anos
select SUM(vend.Quantidade) as 'Quantidade' , mar.Nome as 'Marca', usu.Usuario from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
inner join Marcas mar on car.Id = mar.Id 
inner join Vendas vend on vend.Id = vend.Id
where usu.Usuario = 'Felipe' or usu.Usuario = 'Giomar' group by vend.Quantidade, mar.Nome, usu.Usuario order by Quantidade DESC

--Trazer o valor do carro mais vendido de todos os anos
select SUM(vend.Valor ) as 'Valor' , mar.Nome as 'Marca', usu.Usuario from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
inner join Marcas mar on car.Id = mar.Id 
inner join Vendas vend on vend.Id = vend.Id
where usu.Usuario = 'Felipe' or usu.Usuario = 'Giomar' group by vend.Quantidade, mar.Nome, usu.Usuario order by Quantidade DESC

--test
select SUM(vend.Valor ) as 'Valor' , mar.Nome as 'Marca', usu.Usuario from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
inner join Marcas mar on car.Id = mar.Id 
inner join Vendas vend on vend.Id = vend.Id
where usu.Usuario = 'Felipe' group by vend.Quantidade, mar.Nome, usu.Usuario order by Quantidade DESC













