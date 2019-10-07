update Marcas set UsuInc = 1 where UsuInc = 0 -- exercicio 1

select * from Marcas where UsuInc = 1 ; -- exercicio 2

select * from Marcas where UsuInc = 2; -- exercicio 3

--Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor
select usuario.Usuario,
COUNT(mar.UsuInc) as 'Total'
from Usuarios usuario
inner join Marcas mar on usuario.Id = mar.UsuInc where Usuario like 'Felipe%'
group by usuario.Usuario  order by COUNT(mar.UsuInc) ASC-- exercicio 4



--Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
select usuario.Usuario,
COUNT(mar.UsuInc) as 'Total'
from Usuarios usuario
inner join Marcas mar on usuario.Id = mar.UsuInc where Usuario like 'Giomar%'
group by usuario.Usuario  order by COUNT(mar.UsuInc) ASC-- exercicio 5

--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 
select usuario.Usuario,
COUNT(mar.UsuInc) as 'Total'
from Usuarios usuario
inner join Marcas mar on usuario.Id = mar.UsuInc where Usuario = 'Felipe' or Usuario = 'Giomar'
group by usuario.Usuario  
-- exercicio 6

--select car.UsuInc,
--COUNT(car.UsuInc) as 'Total' from Carros car inner join Usuarios usu on car.UsuInc =  usu.Usuario  where usu.Usuario = 1 group by usu.Usuario 

--Trazer somente os carros que Felipe cadastrou
select car.Modelo, car.Marca, usu.Usuario from Carros car inner join Usuarios usu on car.UsuInc = usu.Id where Usuario like 'Felipe%' 
-- exercicio 7

--Trazer somente os carros que Giomar cadastrou
select car.Modelo, car.Marca, usu.Usuario from Carros car inner join Usuarios usu on car.UsuInc = usu.Id where Usuario like 'Giomar%' 
-- exercicio 8

--Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
select COUNT(car.UsuInc) as 'Total'
from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
where Usuario like 'Felipe%' 
group by usu.Usuario order by COUNT(car.UsuInc) DESC
--exercicio 9

--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
select COUNT(car.UsuInc) as 'Total'
from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
where Usuario like 'Giomar%' 
group by usu.Usuario order by COUNT(car.UsuInc) ASC
-- exercicio 10

--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 
select COUNT(car.UsuInc) as 'Total'
from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id where Usuario = 'Felipe' or Usuario = 'Giomar'
--exercicio 11

--Trazer somente os carros das marcas que Felipe cadastrou
select car.Modelo, car.Marca, usu.Usuario from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
inner join Marcas mar on car.Marca = mar.Id
where Usuario like 'Felipe%' 
-- exercicio 12 -v

--Trazer somente os carros das marcas que Giomar cadastrou
select car.Modelo, car.Marca, usu.Usuario from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
inner join Marcas mar on car.Marca = mar.Id
where Usuario like 'Giomar%' 
--exercicio 13 -v

--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
select SUM(vend.Quantidade) as 'Quantidade', car.Modelo, car.Marca, usu.Usuario from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
inner join Marcas mar on car.Marca = mar.Id
inner join Vendas vend on vend.Id = vend.Id
where Usuario like 'Felipe%' group by vend.Quantidade, car.Modelo, car.Marca, usu.Usuario
--exercicio 14  -v

--Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
select SUM(vend.Quantidade) as 'Quantidade', car.Marca from Vendas vend 
inner join Usuarios usu on vend.UsuInc = usu.Id 
inner join Carros car on car.Id = vend.Carro
where Usuario = 'Giomar' group by vend.Quantidade, car.Marca
--exercicio 15


--Trazer o valor total de vendas 2019 isolado
select SUM(vend.Valor) as 'Valor Total em 2019' from Vendas vend where vend.DatInc between '01/01/2019' and '12/31/2019'
--exercicio 16


--Trazer a quantidade total de vendas 2019 isolado
select COUNT(vend.Quantidade) as 'Quantidade Total 2019' from Vendas vend where vend.DatInc between '01/01/2019' and '12/31/2019'
--exercicio 17

--Trazer a quantidade de vendas em cada ano e ordenar do maior para o menor
select year(DatInc) as 'Ano', sum(Valor) as 'Total'
from Vendas group by YEAR (DatInc)
order by SUM(Valor) DESC
--exercicio 18

--Trazer o mês de cada ano que retornou o maior valor de vendas
select top 3 year(DatInc) as 'ano', MONTH(DatInc) as 'Mês', sum(Valor) as 'Total'
from Vendas group by MONTH (DatInc), year(DatInc)
order by SUM(Valor) DESC
--exercicio 19 -v

--Trazer o mês de cada ano que retornou a maior quantidade de vendas - forma correta
select YEAR(ven1.DatInc), 
(select top 1 MONTH(ven.DatInc)
From Vendas ven
where YEAR(ven.DatInc) = YEAR(ven1.DatInc)
group by MONTH(ven.DatInc)
order by SUM(ven.Quantidade) DESC)
from Vendas ven1
group by YEAR (ven1.DatInc)

--Trazer o mês de cada ano que retornou a maior quantidade de vendas - gambiarra
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

--Trazer o valor total de vendas que Felipe realizou
select SUM(vend.Valor*Quantidade) as 'Valor Total' from Vendas vend  where UsuInc = 1
--valor total de Felipe
select SUM(vend.Valor*Quantidade) as 'Valor Total' from Vendas vend  inner join Usuarios usu on vend.UsuInc = usu.Id where Usuario like 'Felipe%'
--exercicio 20

--Trazer o valor total de vendas que Giomar realizou
select SUM(vend.Valor*Quantidade) as 'Valor Total' from Vendas vend  where UsuInc = 2
--exercicio 20

--quantidade total felipe
select COUNT(vend.Quantidade) as 'Quantidade Total' from Vendas vend  where UsuInc = 1
--quantidade total giomar
select COUNT(vend.Quantidade) as 'Quantidade Total' from Vendas vend  where UsuInc = 2


--valor total de giomar e Felipe
select SUM(vend.Valor*vend.Quantidade) as 'Valor Total' from Vendas vend  inner join Usuarios usu on vend.UsuInc = usu.Id where Usuario like 'Giomar%'

select SUM(vend.Valor* vend.Quantidade) as 'Valor Total' from Vendas vend  inner join Usuarios usu on vend.UsuInc = usu.Id where Usuario like 'Felipe%'



--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select COUNT(vend.UsuInc) as 'Quantidade Total', usu.Usuario from Vendas vend 
inner join Usuarios usu on vend.UsuInc = usu.Id where usu.Usuario = 'Felipe' or usu.Usuario = 'Giomar' group by vend.UsuInc, usu.Usuario order by COUNT(vend.UsuInc) ASC



--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select SUM(vend.Valor * vend.Quantidade) as 'Valor Total' , usu.Usuario as 'Usuario' from Vendas vend  
inner join Usuarios usu on vend.UsuInc = usu.Id where usu.Usuario = 'Felipe' or usu.Usuario = 'Giomar' group by usu.Usuario order by SUM(vend.Valor * vend.Quantidade) ASC



select COUNT(vend.Valor) as 'Valor Total' , usu.Usuario as 'Usuario' from Vendas vend  
inner join Usuarios usu on vend.UsuInc = usu.Id where usu.Usuario = 'Felipe' or usu.Usuario = 'Giomar' group by usu.Usuario order by SUM(vend.Valor * vend.Quantidade) ASC


--Trazer  a marca mais vendida de todos os anos -v
select COUNT(vend.Quant) from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
inner join Marcas mar on car.Marca = mar.Id 
group by mar.Nome order by Vendas.Quantidade ASC




----Trazer  a marca mais vendida de todos os anos -correta

select mar.Nome as 'Quantidade' from Marcas mar 
inner join Carros car on car.Marca = mar.Id 
inner join Vendas vend on vend.Carro = car.Id
 group by  mar.Nome order by SUM(vend.Quantidade) DESC


 -- Trazer o valor total da marca mais vendida de todos os anos	-- correta	

select  SUM(vend.Quantidade * vend.Valor) as 'Total' from Marcas mar 
inner join Carros car on car.Marca = mar.Id 
inner join Vendas vend on vend.Carro = car.Id
 group by  mar.Nome order by SUM(vend.Quantidade * vend.Valor) DESC


 --Trazer a quantidade do carro mais vendido de todos os anos -- correta
 select car.Modelo, SUM(vend.Quantidade) as 'Total' from Vendas vend
inner join Carros car on vend.Carro = car.Id 
 group by  car.Modelo order by SUM(vend.Quantidade ) DESC


  --Trazer o valor do carro mais vendido de todos os anos -
  select AVG( vend.Valor) as 'Total' from Carros car
inner join Vendas vend on vend.Carro = car.Id 
 group by  car.Modelo order by SUM(vend.Valor) DESC




 --Trazer o valor do carro mais vendido de todos os anos -- ver
 select  SUM(vend.Quantidade * vend.Valor) as 'Total', mar.Nome from Marcas mar 
inner join Carros car on car.Marca = mar.Id 
inner join Vendas vend on vend.Carro = car.Id
 group by  mar.Nome order by SUM(vend.Quantidade * vend.Valor) DESC



-- marca mais vendida de todos os anos
select SUM(vend.Quantidade) as 'Quantidade' , mar.Nome as 'Marca', usu.Usuario from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
inner join Marcas mar on car.Id = mar.Id 
inner join Vendas vend on vend.Id = vend.Id
where usu.Usuario = 'Felipe' or usu.Usuario = 'Giomar' group by vend.Quantidade, mar.Nome, usu.Usuario order by Quantidade DESC






-- valor total marca mais vendida de todos os anos
select SUM(vend.Quantidade * vend.Valor) as 'Valor' , mar.Nome as 'Marca', usu.Usuario from Carros car
inner join Usuarios usu on car.UsuInc = usu.Id
inner join Marcas mar on car.Id = mar.Id
inner join Vendas vend on vend.Id = vend.Id
where usu.Usuario = 'Felipe' or usu.Usuario = 'Giomar' group by vend.Quantidade, mar.Nome, usu.Usuario order by Valor DESC

select SUM(vend.Quantidade * vend.Valor) as 'Valor' from Vendas vend where UsuInc = 1




--Trazer a quantidade do carro mais vendido de todos os anos
select SUM(vend.Quantidade) as 'Quantidade' , mar.Nome as 'Marca' from Carros car
inner join Usuarios usu on car.UsuInc = usu.Id 
inner join Marcas mar on car.Id = mar.Id 
inner join Vendas vend on vend.Id = vend.Id
where usu.Usuario = 'Felipe' or usu.Usuario = 'Giomar' group by vend.Quantidade, mar.Nome order by Quantidade DESC





--Trazer o valor do carro mais vendido de todos os anos
select SUM(vend.Valor ) as 'Valor' , mar.Nome as 'Marca', usu.Usuario from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
inner join Marcas mar on car.Id = mar.Id 
inner join Vendas vend on vend.Id = vend.Id
where usu.Usuario = 'Felipe' or usu.Usuario = 'Giomar' group by vend.Quantidade, mar.Nome, usu.Usuario order by Quantidade DESC

--test
select SUM(vend.Valor) as 'Valor' , mar.Nome as 'Marca', usu.Usuario from Carros car 
inner join Usuarios usu on car.UsuInc = usu.Id 
inner join Marcas mar on car.Id = mar.Id 
inner join Vendas vend on vend.Id = vend.Id
where usu.Usuario = 'Felipe' group by vend.Quantidade, mar.Nome, usu.Usuario order by Quantidade DESC

