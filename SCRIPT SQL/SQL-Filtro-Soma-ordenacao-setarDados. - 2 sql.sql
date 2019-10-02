select * from Clientes;
select * from Pedidos;

select cli.* from Clientes cli
				inner join Pedidos ped on cli.Id = ped.ClienteId
				where ped.Numero in ('P000051', 'H0550001', 'M0550001'); --select nos codigos das notas

select * from Pedidos ped
where ped.ClienteId in (select cli.Id from Clientes cli
				inner join Pedidos ped on cli.Id = ped.ClienteId
				where ped.Numero in ('P000051', 'H0550001', 'M0550001')) order by ped.Valor DESC; -- select e ordenacao