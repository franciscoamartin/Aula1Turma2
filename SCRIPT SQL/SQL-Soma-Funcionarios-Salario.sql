select Nome, (select sum(valor) from Salarios where Funcionario = Funcionarios.Id) 
from Funcionarios -- soma de salarios sem o inner join

select func.Nome,
SUM(sal.Valor) as 'Total no 3 meses'
from Funcionarios func
inner join Salarios sal on func.Id = sal.Funcionario
group by func.Nome -- soma de salarios por funcionarios

select func.Nome,
AVG(sal.Valor) as 'Total no 3 meses'
from Funcionarios func
inner join Salarios sal on func.Id = sal.Funcionario
group by func.Nome -- média de salarios por funcionarios


select func.Nome,
AVG(sal.Valor) as 'Total no 3 meses',
COUNT(sal.Valor) as 'Quantidade de Pagamentos'
from Funcionarios func
inner join Salarios sal on func.Id = sal.Funcionario
group by func.Nome -- Quantidade de salarios por funcionarios


select func.Nome,
AVG(sal.Valor) as 'Total no 3 meses',
COUNT(sal.Valor) as 'Quantidade de Pagamentos',
SUM(sal.Valor) / COUNT(sal.Valor) as 'Nova Média'
from Funcionarios func
inner join Salarios sal on func.Id = sal.Funcionario
group by func.Nome -- media de salarios dividido por meses trabalhados dos funcionarios

select * from Salarios where Id between 3 and 8 -- select por intervalo id

select * from Salarios where DataCriacao between '07/06/2019' and '08/07/2019' --select por data de criacao

select top 5 * from Salarios order by Valor desc -- top5 maiores salarios

select * from Salarios where Id >= 3 and Id <= 8 -- select por intervalo usando operadores


select func.Nome,
AVG(sal.Valor) as 'Total no 3 meses',
COUNT(sal.Valor) as 'Qty de Pagamentos',
SUM(sal.Valor) / COUNT(sal.Valor) as 'Nova Média',
SUM(sal.valor) as 'Total'
from Funcionarios func
inner join Salarios sal on func.Id = sal.Funcionario
group by func.Nome 
order by SUM(sal.Valor) desc
-- media de salarios dividido por meses trabalhados dos funcionarios mais ordenacao por valor


update Funcionarios set DataSaida = '10/03/2019', DataAlteracao = GETDATE(), Ativo = 0
where Nome like 'Maria%'

select * from Funcionarios where Nome like '%ri%' -- % indicador de busca que contem a palavra entre %

select * from Funcionarios where Nome like '%ria' -- termina com a palavra

select * from Funcionarios where Nome like 'Mar%' -- começa com a palavra

select * from Funcionarios 

select Nome, CONVERT(VARCHAR(10),  DataInicio, 103) as 'Inicio',
			CONVERT(VARCHAR(10),  DataSaida, 103) as 'Saida'
			from Funcionarios





