USE SENAI_HROADS_MANHA;
GO

INSERT INTO Classe(nomeClasse)
VALUES ('Bárbaro'), ('Cruzado'), ('Caçadora de Demônios'), ('Monge'), ('Necromante'), ('Feiticeiro'), ('Arcanista');
GO

INSERT INTO Habilidade(nomeHabilidade)
VALUES ('Lança Mortal'), ('Escudo Supremo'), ('Recuperar Vida');
GO

INSERT INTO Tipos_Habilidade(idHabilidade, nomeTipo)
VALUES (1, 'Ataque'), (2, 'Defesa'), (3, 'Cura');
GO

INSERT INTO Tipos_Habilidade(nomeTipo)
VALUES ('Magia');
GO

INSERT INTO Classe_Habilidade (idHabilidade, idClasse, nomeClasse, nomeHabilidade)
VALUES (1, 1, 'Bárbaro', 'Lança Mortal'), (1, 1, 'Bárbaro', 'Escudo Supremo'), (2, 2, 'Cruzado', 'Escudo Supremo'), (1, 3, 'Caçadora de Demônios', 'Lança Mortal'), (3, 4, 'Monge', 'Recuperar Vida'), (2, 4, 'Monge', 'Escudo Supremo'), (3, 6, 'Feiticeiro', 'Recuperar Vida');
GO

-- add Necromante sabendo q ele possui valores nulos e será modificado futuramente?


INSERT INTO Personagem (idClasse, nomePersonagem, capacidadeMaxVida, capacidadeMaxMana, DataCriacao, DataAtualizacao)
VALUES (1, 'DeuBug', 100, 80, '2019-01-18', '2021-08-10'),(4, 'BitBug', 70, 100, '2016-03-17', '2021-08-10'), (7, 'Fer8', 75, 60, '2018-03-18', '2021-08-10');
GO