select 
car.Modelo,
mar.Nome as 'Marca',
usu.Nome as 'UsuarioCriacao',
usu1.Nome as 'usuarioalteracao'
from Carros car inner join Marcas mar on car.MarcaCodigo = mar.Codigo
				inner join Usuario usu on car.UsuarioCriacao = usu.Id
				inner join Usuario usu1 on car.UsuarioAlteracao = usu1.Id