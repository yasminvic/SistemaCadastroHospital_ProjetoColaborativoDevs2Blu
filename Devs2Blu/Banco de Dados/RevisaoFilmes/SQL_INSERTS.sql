/*INSERT Tabela GENERO*/

INSERT INTO genero (nome)
VALUES ('Ação'), 
       ('Drama'), 
       ('Fantasia'), 
       ('Ficção');
select * from genero;
/*INSERT Tabela CLASSIFICACAO*/
INSERT INTO classificacao (label, 
						   numlabel,
                           observacao)
VALUES ('Livre', 0, 'Exibição em qualquer horário.'),
	   ('10 anos', 10, 'Exibição em qualquer horário.'),
       ('12 anos', 12,'A partir das 20 horas.'),
       ('14 anos', 14, 'A partir das 21 Horas.'),
       ('16 anos', 16, 'A partir das 22 horas.'),
       ('18 anos', 18, 'A partir das 23 horas.');