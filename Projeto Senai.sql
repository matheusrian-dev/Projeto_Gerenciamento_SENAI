CREATE DATABASE Senai
GO

USE Senai
GO

CREATE TABLE Funcionario(
 cpf			      VARCHAR(15) PRIMARY KEY NOT NULL,
 nomeFunc             VARCHAR(90)  NULL,
 cargo				  VARCHAR(100) NULL,
 senha				  VARCHAR(100) NULL,
 telefoneFunc		  VARCHAR(20)  NULL,
 emailFunc	          VARCHAR(70)  NULL,
 );

CREATE TABLE Empresa(
 cnpj			      VARCHAR(22) PRIMARY KEY NOT NULL,
 nomeEmpresa          VARCHAR(90) NULL,
 razaoSocial          VARCHAR(100) NULL,
 endereco             VARCHAR(100) NULL,
 telefoneEmpresa      VARCHAR(20) NULL,
 emailEmpresa	      VARCHAR(70) NULL,
 responsavel          VARCHAR(100) NULL,
 );

CREATE TABLE Aluno(
 raAluno			  INT PRIMARY KEY NOT NULL,
 alunoNome            VARCHAR(90) NULL,
 nascimento           DATE        NULL,
 idadeAluno	          INT         NULL,
 sexo                 VARCHAR(50) NULL,
 grauInstrucao        VARCHAR(50) NULL,
 rua                  VARCHAR(50) NULL,
 numero               VARCHAR(6)  NULL,
 complemento          VARCHAR(30) NULL,
 bairro               VARCHAR(30) NULL,
 estado               VARCHAR(5)  NULL,
 cidade               VARCHAR(30) NULL,
 cep                  VARCHAR(30) NULL,
 telefone1            VARCHAR(20) NULL,
 telefone2            VARCHAR(20) NULL,
 identidade           VARCHAR(20) NULL,
 cpf                  VARCHAR(20) NULL,
 email                VARCHAR(90) NULL,
 carteiraTrabalho     VARCHAR(30) NULL,
 nomePai              VARCHAR(90) NULL,
 telefonePai          VARCHAR(20) NULL,
 nomeMae              VARCHAR(90) NULL,
 telefoneMae          VARCHAR(20) NULL,
 nomeCurso            VARCHAR(90) NULL,
 codigoTurma          VARCHAR(30) NULL,
 statusAluno          VARCHAR(10) NULL,
 dataMatricula		  DATE		  NULL,	
 Empresa_cnpj		  VARCHAR(22) NULL,
 FOREIGN KEY (Empresa_cnpj)
	REFERENCES Empresa(cnpj)
);

CREATE TABLE Enturmar(
	codEnturmar			INT PRIMARY KEY IDENTITY(1,1),
	nomeAluno			VARCHAR(90) NULL,
	cpfEnturmar			VARCHAR(20) NULL,	
	emailEnturmar		VARCHAR(90) NULL,
	telefoneEnturmar	VARCHAR(20) NULL,
	codigoEnturmar		VARCHAR(30) NULL,	
	sexoEnturmar		VARCHAR(50) NULL,
	periodo				VARCHAR(200)NULL,
	tipoContrato		VARCHAR(50) NULL,
	inicioContrato		DATE  NULL,
	fimContrato			DATE  NULL,	
	nomeFantasia		VARCHAR(100) NULL,
	telefoneEmpresa2	VARCHAR(15)NULL,
	emailEmpresa2		VARCHAR(70) NULL,
	enderecoEmpresa		VARCHAR(100) NULL,
	razaoSocial2		VARCHAR(100) NULL,	
	responsavel2		VARCHAR(100) NULL,
	Empresa_cnpj		VARCHAR(22) NULL,
	FOREIGN KEY (Empresa_cnpj)
		REFERENCES Empresa(cnpj)	
);

--SELECT * FROM Aluno;
--SELECT * FROM Empresa;
--SELECT * FROM Enturmar;

INSERT INTO Funcionario VALUES('999.999.999-99', 'Admin', 'Coordenador', '123', '(31) 98988-3242', 'admin@gmail.com');
--DROP DATABASE Senai;
--SELECT * FROM Funcionario;

