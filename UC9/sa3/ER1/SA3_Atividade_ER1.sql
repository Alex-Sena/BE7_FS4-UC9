--cria��o do banco de dados
CREATE DATABASE TesteSegurancaBE7FS4;

--colocar o banco de dados em uso
USE TesteSegurancaBE7FS4;

--cria��o de uma tabela para armazenar usu�rios
CREATE TABLE Usuarios
(
	Id INT PRIMARY KEY IDENTITY,  --identity torna o campo auto incremental
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR(50) NOT NULL
);

--consulta a todos os dados da tabela criada
SELECT * FROM Usuarios;

--cadastrar um usu�rio no banco de dados
INSERT INTO Usuarios VALUES ('email@email.com',1234);
INSERT INTO Usuarios VALUES ('luiz.lozano@sp.senai.br','vip12345');

--hasheando dados em uma consulta
SELECT Id, Email, HASHBYTES('MD2',Senha) FROM Usuarios; --HASHBYTES(DOIS ARGUMENTOS - PRIMEIRO CAMPO O ALGORITIMO E O SEGUNDO O CAMPO A HASHEAR)

--hasheando dados e filtrando apenas um usu�rio
SELECT Id, Email, HASHBYTES('MD2',Senha) FROM Usuarios WHERE Id = 1; 

--hasheando dados e filtrando apenas um usu�rio e dado apelido para a coluna hasheada
SELECT Id, Email, HASHBYTES('MD2',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 1;  

--hasheando algoritimo MD4 (Seguindo os ultimos exemplos de linhaXcolunas)
SELECT Id, Email, HASHBYTES('MD4',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 1;  

--hasheando algoritimo MD5 (Seguindo os ultimos exemplos de linhaXcolunas)
SELECT Id, Email, HASHBYTES('MD5',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 1; 

--hasheando algoritimo SHA (Seguindo os ultimos exemplos de linhaXcolunas)
SELECT Id, Email, HASHBYTES('SHA',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 1; 

--hasheando algoritimo SHA1 (Seguindo os ultimos exemplos de linhaXcolunas)
SELECT Id, Email, HASHBYTES('SHA1',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 1; 

--hasheando algoritimo SHA2_256 (Seguindo os ultimos exemplos de linhaXcolunas)
SELECT Id, Email, HASHBYTES('SHA2_256',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 1;

--hasheando algoritimo SHA2_512 (Seguindo os ultimos exemplos de linhaXcolunas)
SELECT Id, Email, HASHBYTES('SHA2_512',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 1;