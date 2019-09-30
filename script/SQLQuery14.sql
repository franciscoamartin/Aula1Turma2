insert into Usuarios
(Nome, Login, Senha)
values
('Adagoberto', 'urenedison', 'joao')
GO
select * from Usuarios

update Usuarios set Ativo = 0 where Id = 10