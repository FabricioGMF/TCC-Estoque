create database ESTOQUE --Criação do banco de dados
use ESTOQUE				--Uso do banco de dados

/*Tabela cliente*/
create table CLIENTE(
	CODIGO int identity not null primary key,
	NOME varchar(100),
	CPFCNPJ varchar(20),
	RG varchar(9),
	LOGRADOURO varchar(80),
	BAIRRO varchar(50),
	CIDADE varchar(50),
	UF varchar(2),
	CEP varchar(8),
	EMAIL varchar(100),
	TELEFONE varchar(11),
	TELEFONE2 varchar(11),
	DATACADASTRO datetime
)
select * from CLIENTE

/*Tabela produtos*/
create table PRODUTOS(
	CODIGO int identity not null primary key,
	DESCRICAO nvarchar(100),
	VALORCOMPRA decimal(10,2),
	VALORVENDA decimal(10,2),
	ESTOQUE int,
	ESTOQUE_MINIMO int,
	ESTOQUE_MAXIMO int,
	ESTOQUE_SEGURANCA int
)
select * from PRODUTOS

/*Tabela vendas*/
create table VENDAS(
	CODIGOVENDA int identity not null,
	DATA_VENDA datetime null,
	--QUANTIDADE int null,
	FATURADO decimal(10,2) null,
	--PRECO_UNITARIO decimal(10,2) null,
	CODIGOCLIENTE int null,
	--CODIGOPRODUTO int null,
	foreign key (CODIGOCLIENTE) references CLIENTE(CODIGO),
	--foreign key (CODIGOPRODUTO) references PRODUTOS(CODIGO)
	CONSTRAINT [PK_VENDAS] PRIMARY KEY CLUSTERED 
    (
        CODIGOVENDA ASC
    )
)
select * from VENDAS

/*Tabela Item vendas*/
CREATE TABLE ITEM_VENDAS(
	CODIGOVENDA int not null,
	CODIGOPRODUTO int NULL,
	QTD_ITEM int NULL,
	VALOR_ITEM decimal(10,2) NULL,
	TOTAL_ITEM decimal(10,2) NULL,
	foreign key (CODIGOPRODUTO) references PRODUTOS(CODIGO),
	CONSTRAINT [PK_ITEM_VENDAS] PRIMARY KEY NONCLUSTERED 
    (
        CODIGOVENDA ASC
    )
)

--ALTER TABLE [ITEM_VENDAS] 
--    ADD CONSTRAINT fk_CODIGOVENDA
--    FOREIGN KEY(CODIGOVENDA)
--REFERENCES [VENDAS] (CODIGOVENDA)

SELECT TOP 1 * FROM VENDAS ORDER BY CODIGOVENDA DESC