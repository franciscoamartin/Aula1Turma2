INSERT INTO Pedidos (Numero, ClienteId, Valor)values('N0004001', 1, 379.44)
INSERT INTO Pedidos (Numero, ClienteId, Valor)values('N0000501', 1, 179.44)
INSERT INTO Pedidos (Numero, ClienteId, Valor)values('N0000101', 1, 979.44)
INSERT INTO Pedidos (Numero, ClienteId, Valor)values('N000151', 2, 479.44)
INSERT INTO Pedidos (Numero, ClienteId, Valor)values('M0550501', 2, 139.44)
INSERT INTO Pedidos (Numero, ClienteId, Valor)values('P000051', 3, 79.44)
INSERT INTO Pedidos (Numero, ClienteId, Valor)values('H0550001', 3, 29.44)

SELECT * FROM Pedidos order by ClienteId asc 


select ped.ClienteId, cli.Nome,ped.Numero, ped.Valor, ped.DataCriacao, ped.DataAlteracao from Pedidos ped 
inner join Clientes cli on ped.ClienteId = cli.Id order by ClienteId asc  -- select com ordenacao e setar por dados.


select ped.* from Pedidos ped inner join Clientes cli on ped.ClienteId = cli.Id where cli.Nome = 'Giomar' -- select no nome Giomar.

select SUM(ped.valor) from Pedidos ped inner join Clientes cli on ped.ClienteId = cli.Id where cli.Nome = 'Giomar'  -- somar valor de giomar

select IIF(SUM( ped.valor) > 2000, 'Brinde', 'Nao ganhou') from Pedidos ped inner join Clientes cli on ped.ClienteId = cli.Id where cli.Nome = 'Giomar' 
-- filtrar por valor/ primeiro parametro de string é true e o segundo é false.



