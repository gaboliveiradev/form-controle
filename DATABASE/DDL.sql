CREATE DATABASE business_manager;
USE business_manager;

CREATE TABLE Funcionario (
	id int auto_increment,
	nome varchar(150) NOT NULL,
	email varchar(150) NOT NULL,
	cpf char(11) NOT NULL,
	senha varchar(100) NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE Produto (
	id int auto_increment,
	ean char(13) NOT NULL,
	nome varchar(150) NOT NULL,
	valor_compra double NOT NULL,
	valor_venda double NOT NULL,
	estoque int NOT NULL,
	id_funcionario int NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (id_funcionario) REFERENCES Funcionario(id)
);