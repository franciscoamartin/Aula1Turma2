SELECT * FROM Salarios ORDER BY DataCriacao ASC

SELECT func.Nome as 'Nome',
sal.Funcionario as 'Id Funcionario ', 
func.DataInicio as 'Data Início',
sal.Valor as 'Valor Salário',
sal.DataCriacao as 'Data do Salario'
FROM Salarios sal 
inner join Funcionarios func on sal.Funcionario = func.Id order by func.Nome --select e troca id por nome

UPDATE Funcionarios set Ativo = 1 -- setar o ativo para 1

INSERT INTO Salarios 
(Funcionario, Valor, DataCriacao)
values 
(1004, 1800, '07/05/2019'),
(1004, 1700, '08/07/2019'),
(1004, 1800, '09/06/2019')

