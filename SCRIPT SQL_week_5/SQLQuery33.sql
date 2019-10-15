select 
car.Modelo, 
mar.Nome,
car.Placa,
car.Ano 
from 
Carros 
car -- abreviamos e criamos um alias para chamar e ficar mais facil
inner --indicador que ambas as tavleas devem estar relacionadas com os dados
join --junta tabelas a outra
Marcas 
mar 
on -- indicador que vamos mostrar como vamos relacionar as informacoes
car.MarcaCodigo = mar.Codigo --aqui informamos que carros tem um codigo igual em marcas e portanto a referencia de marcas seria
-- a coluna código com isso ele nos tras a linha que temos essa referencia e podemos utilizar todas as colunas da linha com informacoes