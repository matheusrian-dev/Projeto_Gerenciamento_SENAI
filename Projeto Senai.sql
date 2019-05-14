CREATE DATABASE Senai
GO

USE Senai
GO

CREATE TABLE Funcionario(
 cpf			      INT PRIMARY KEY NOT NULL,
 nomeFunc             VARCHAR(90)  NULL,
 cargo				  VARCHAR(100) NULL,
 senha				  VARCHAR(100) NULL,
 telefoneFunc		  VARCHAR(20)  NULL,
 emailFunc	          VARCHAR(70)  NULL,
 );

CREATE TABLE Empresa(
 cnpj			      INT PRIMARY KEY NOT NULL,
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
 Empresa_cnpj		  INT 		  NULL,
 FOREIGN KEY (Empresa_cnpj)
	REFERENCES Empresa(cnpj)
);

SELECT * FROM Aluno;
SELECT * FROM Empresa;

--DROP DATABASE Senai;

