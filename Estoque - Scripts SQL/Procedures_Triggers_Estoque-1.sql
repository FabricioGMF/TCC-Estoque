use ESTOQUE

/*PROCEDURES CLIENTE*/
--Procedure Insere_cliente
create procedure insere_cliente
	@codigo int output,
	@nome varchar(100),
	@cpfcnpj varchar(20),
	@rg varchar(9),
	@logradouro varchar(80),
	@bairro varchar(50),
	@cidade varchar(50),
	@uf varchar(2),
	@cep varchar(8),
	@email varchar(100),
	@telefone varchar(11),
	@telefone2 varchar(11),
	@datacadastro datetime
as
	insert into CLIENTE(NOME, CPFCNPJ, RG, LOGRADOURO, BAIRRO, CIDADE, UF, CEP, EMAIL, TELEFONE,
						TELEFONE2, DATACADASTRO)
	values(@nome, @cpfcnpj, @rg, @logradouro, @bairro, @cidade, @uf, @cep, @email, @telefone,
			@telefone2, @datacadastro)
	set @codigo = (select @@IDENTITY)

--Procedure altera_cliente
create procedure altera_cliente
	@codigo int output,
	@nome varchar(100),
	@cpfcnpj varchar(20),
	@rg varchar(9),
	@logradouro varchar(80),
	@bairro varchar(50),
	@cidade varchar(50),
	@uf varchar(2),
	@cep varchar(8),
	@email varchar(100),
	@telefone varchar(11),
	@telefone2 varchar(11),
	@datacadastro datetime
as
	update cliente set NOME = @nome, CPFCNPJ = @cpfcnpj, RG = @rg, LOGRADOURO = @logradouro,
						BAIRRO = @bairro, CIDADE = @cidade, UF = @uf, CEP = @cep, EMAIL = @email,
						TELEFONE = @telefone, TELEFONE2 = @telefone2, DATACADASTRO = @datacadastro
	where CODIGO = @codigo

--Procedure exclui_cliente
create procedure exclui_cliente
	@codigo int
as
	delete from CLIENTE where CODIGO = @codigo

--Procedure seleciona_cliente
create procedure seleciona_cliente
	@filtro varchar(100) = null
as
begin
	if @filtro is null
		select CODIGO as 'ID', NOME as 'Nome/Razão Social', CPFCNPJ as 'CPF/CNPJ', RG, 
				LOGRADOURO as 'Logradouro', BAIRRO as 'Bairro', CIDADE as 'Cidade', UF, CEP, 
				EMAIL as 'E-mail', TELEFONE as 'Telefone 1', TELEFONE2 as 'Telefone 2',
				DATACADASTRO as 'Data Cadastro'
		from CLIENTE
	else
		select CODIGO as 'ID', NOME as 'Nome/Razão Social', CPFCNPJ as 'CPF/CNPJ', RG,
				LOGRADOURO as 'Logradouro', BAIRRO as 'Bairro', CIDADE as 'Cidade', UF, CEP,
				EMAIL as 'E-mail', TELEFONE as 'Telefone 1', TELEFONE2 as 'Telefone 2',
				DATACADASTRO as 'Data Cadastro'
		from CLIENTE
			where NOME like '%' + @filtro + '%'
			   or CPFCNPJ like '%' + @filtro + '%'
			   or RG like '%' + @filtro + '%'
			   or LOGRADOURO like '%' + @filtro + '%'
			   or BAIRRO like '%' + @filtro + '%'
			   or CIDADE like '%' + @filtro + '%'
			   or UF like '%' + @filtro + '%'
			   or CEP like '%' + @filtro + '%'
			   or EMAIL like '%' + @filtro + '%'
			   or TELEFONE like '%' + @filtro + '%'
			   or TELEFONE2 like '%' + @filtro + '%'
end

/*PROCEDURES PRODUTO*/
--Procedure insere_produto
create procedure insere_produto
	@codigo int output,
	@descricao nvarchar(100),
	@valorcompra decimal(10,2),
	@valorvenda decimal(10,2),
	@estoque int,
	@estoque_minimo int,
	@estoque_maximo int,
	@estoque_seguranca int
as
	insert into PRODUTOS(DESCRICAO, VALORCOMPRA, VALORVENDA, ESTOQUE, ESTOQUE_MINIMO,
							ESTOQUE_MAXIMO, ESTOQUE_SEGURANCA)
	values(@descricao, @valorcompra, @valorvenda, @estoque, @estoque_minimo,
			@estoque_maximo, @estoque_seguranca)
	set @codigo = (select @@IDENTITY)

--Procedure altera_produto
----Obs.: realizado diretamente no método Alterar da classe ProdutosDAL.

--Procedure exclui_produto
create procedure exclui_produto
	@codigo int
as
	delete from PRODUTOS where CODIGO = @codigo

--Procedure seleciona_produto
create procedure seleciona_produto
	@filtro varchar(100) = null
as
begin
	if @filtro is null
		select CODIGO as 'ID Produto', DESCRICAO as 'Descrição', VALORCOMPRA as 'Valor de compra',
				VALORVENDA as 'Valor de Venda', ESTOQUE as 'Estoque', ESTOQUE_MINIMO as 'Estoque Mínimo', 
				ESTOQUE_MAXIMO as 'Estoque Máximo', ESTOQUE_SEGURANCA as 'Estoque de Segurança' 
		from PRODUTOS
	else
		select CODIGO as 'ID Produto', DESCRICAO as 'Descrição', VALORCOMPRA as 'Valor de compra',
				VALORVENDA as 'Valor de Venda', ESTOQUE as 'Estoque', ESTOQUE_MINIMO as 'Estoque Mínimo', 
				ESTOQUE_MAXIMO as 'Estoque Máximo', ESTOQUE_SEGURANCA as 'Estoque de Segurança'
		from PRODUTOS
			where DESCRICAO like '%' + @filtro + '%'
end

/*PROCEDURES ITEM_VENDA*/
--Procedure insere_itemVenda
----Obs.: realizado diretamente no método Inserir da classe ItemVendaDAL.

--create procedure insere_itemVenda
--	@codigoVenda int output,
--	@codigoProduto int,
--	@qtditem int,
--	@valoritem decimal(10,2),
--	@totalitem decimal(10,2)
--as
--	SELECT TOP 1 * FROM ITEM_VENDAS ORDER BY CODIGOVENDA DESC

--	insert into ITEM_VENDAS(CODIGOPRODUTO, QTD_ITEM, VALOR_ITEM, TOTAL_ITEM)
--	values(@codigoProduto, @qtditem, @valoritem, @totalitem)
--	set @codigoVenda = (select @@IDENTITY)

	--update PRODUTOS set ESTOQUE = ESTOQUE - @qtditem where CODIGO = @codigoProduto 

--Procedure altera_itemVenda
----Obs.: realizado diretamente no método Alterar da classe ItemVendaDAL.

--Procedure exclui_itemVenda
create procedure exclui_itemVenda
	@codigoVenda int
as
	delete from ITEM_VENDAS where CODIGOVENDA = @codigoVenda