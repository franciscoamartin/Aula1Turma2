INSERT INTO Generos VALUES ('FUNK'),('BANDINHA'),('GAUCHAO')
SELECT * FROM Generos
INSERT INTO Artistas (GeneroId,Nome) values (1,'BIRULEIBY')
INSERT INTO Artistas (GeneroId,Nome) values (1,'MC DELANO')
INSERT INTO Artistas (GeneroId,Nome) values (2,'BANDA PASSARELA')
INSERT INTO Artistas (GeneroId,Nome) values (3,'SAN MARINO')
INSERT INTO Artistas (GeneroId,Nome) values (3,'BAITACA')
SELECT * FROM Artistas
INSERT INTO Cancoes (ArtistaId,Nome) values (1,'CRIA ASA PERIQUITA')
INSERT INTO Cancoes (ArtistaId,Nome) values (2,'TCHUTCHUCA TREME TREME')
INSERT INTO Cancoes (ArtistaId,Nome) values (3, 'ALO SEGURANÇA')
INSERT INTO Cancoes (ArtistaId,Nome) values (4,'ELE TE TRAI')
INSERT INTO Cancoes (ArtistaId,Nome) values (4,'FOTO 3X4')
INSERT INTO Cancoes (ArtistaId,Nome) values (5,'FUNDO DA GROTA')
select * from Cancoes

SELECT  gen.Nome as 'Genero', art.Nome as 'Artista' , can.Nome as 'Nome música' FROM Generos gen 
		inner join Artistas art on gen.Id = art.GeneroId 
		inner join Cancoes can on art.Id = can.ArtistaId


select gen.Nome as 'Genero', COUNT(art.Nome) as 'Quantidade Artistas' FROM Generos gen 
inner join Artistas art on gen.Id = art.GeneroId
group by gen.Nome

SELECT  gen.Nome as 'Genero', COUNT(can.Nome) as 'Quantidade de Artista' FROM Generos gen 
		inner join Artistas art on gen.Id = art.GeneroId 
		inner join Cancoes can on art.Id = can.ArtistaId
		group by gen.Nome
