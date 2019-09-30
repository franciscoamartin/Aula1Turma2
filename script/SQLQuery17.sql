UPDATE 
Livros
SET --alteracao no sql
Ativo = 0 --expressao qua vai ser alterada
WHERE Id = 
(select ID from Livros WHERE Ativo = 1 order by id desc -- ordena em decrescente
OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY) -- mostra a 1 linha