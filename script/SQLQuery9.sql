insert into Usuarios      --informamos a tabela que vamos registrar o valor nome as coluna que vamos carregar as 
								--informacoes values informamos que os valores estarao logo a seguir nossas informacoes na ordem das colunas 

(Nome) values ('nuki')
GO
select * from Usuarios
GO
insert into Usuarios
(Nome, Login, Senha) values ('Robserval', 'pulsao', '123456')
GO
select * from Usuarios

insert into Livros
(Nome ) values ('livro1', 'livro2', 'livro3', 'livro4', 'livro5')
Go 
Select *from Livros


