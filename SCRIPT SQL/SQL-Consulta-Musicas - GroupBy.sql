insert into Playlist values ('Foto 3x4','San marino','Bandinha')

select Genero, COUNT(Artista) as 'Número' from Playlist
group by Genero -- filtrar por genero e mostrar a quantidade

select * from Playlist

select Artista, COUNT(Nome) from Playlist
group by Artista -- filtrar e agrupar todos os artistas e mostrar o quantidade

select DISTINCT Genero from Playlist -- filtrar por genero com o distinct

