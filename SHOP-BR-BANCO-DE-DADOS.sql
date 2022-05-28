CREATE DATABASE [SHOP-BR]

USE [master];

DECLARE @kill varchar(8000) = '';  
SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), session_id) + ';'  
FROM sys.dm_exec_sessions
WHERE database_id  = db_id('SHOP-BR')

EXEC(@kill);

DROP DATABASE [SHOP-BR]

USE [SHOP-BR]
CREATE TABLE [Loja](
    [id] INT NOT NULL IDENTITY(1,1),
    [nome] NVARCHAR(120) NOT NULL,
    [telefone] NVARCHAR(20) NULL,
    [email] NVARCHAR(180) NOT NULL UNIQUE,
    [endereco] NVARCHAR(255) NOT NULL

    CONSTRAINT [PK_Loja] PRIMARY KEY ([id])
);
GO 


CREATE TABLE [Produto](
    [id] INT NOT NULL IDENTITY(1,1),
    [nome] NVARCHAR(120) NOT NULL,
    [marca] NVARCHAR(20) NOT NULL,
    [tipo] NVARCHAR(20) NOT NULL,
    [preco] DECIMAL NOT NULL,
    [quantidade_estoque] INT NOT NULL

    CONSTRAINT [PK_Produto] PRIMARY KEY ([id])
);
GO


CREATE TABLE [Loja-Produto](
    [loja_id] INT NOT NULL,
    [produto_id] INT NOT NULL, 
    

     CONSTRAINT [PK_Loja-Produto] PRIMARY KEY ([loja_id], [produto_id]),
     CONSTRAINT [FK_Loja-Produto_Loja_loja_id] FOREIGN KEY ([loja_id]) REFERENCES [Loja] ([id]),
     CONSTRAINT [FK_Loja-Produto_Produto_produto_id] FOREIGN KEY ([produto_id]) REFERENCES [Produto] ([id])
)
GO

CREATE TABLE [Correio](
    [id] INT NOT NULL IDENTITY(1,1),
    [prazo_entrega] INT,
    [valor_frete] DECIMAL,

    CONSTRAINT [PK_Correio] PRIMARY KEY ([id])
);
GO

CREATE TABLE [Cliente](
    [cpf] NVARCHAR(20) NOT NULL,
    [nome] NVARCHAR(120) NOT NULL,
    [email] NVARCHAR(180) NOT NULL,
    [senha] NVARCHAR(180) NOT NULL,
    [nivel] INT NOT NULL,
    [telefone] NVARCHAR(20) NULL,

    CONSTRAINT [PK_Cliente] PRIMARY KEY ([cpf])
);
GO

CREATE TABLE [Compra](
    [produto_id] INT NOT NULL, 
    [cliente_id] NVARCHAR(20) NOT NULL,
    [valor_total] DECIMAL NOT NULL,
    [tipo_pagamento] NVARCHAR(20) NOT NULL,
    [quantidade_comprada] INT NOT NULL,
    [cod_rastreamento] INT NOT NULL,
    

    CONSTRAINT [PK_Compra] PRIMARY KEY ([produto_id], [cliente_id]),
    CONSTRAINT [FK_Compra_Correio_cod_rastreamento] FOREIGN KEY ([cod_rastreamento]) REFERENCES [Correio] ([id]),
    CONSTRAINT [FK_Compra_Produto_cod_produto] FOREIGN KEY ([produto_id]) REFERENCES [Produto] ([id]),
    CONSTRAINT [FK_Compra_Cliente_cod_cliente] FOREIGN KEY ([cliente_id]) REFERENCES [Cliente] ([cpf])
);
GO

CREATE TABLE [Avaliacao](
    [produto_id] INT NOT NULL ,
    [cliente_id] NVARCHAR(20) NOT NULL,
    [nota] TINYINT NOT NULL, -- 0 a 255
    [descricao] TEXT NOT NULL,

     CONSTRAINT [PK_Avaliacao] PRIMARY KEY ([produto_id], [cliente_id]),
     CONSTRAINT [FK_Compra_Produto_produto_id] FOREIGN KEY ([produto_id]) REFERENCES [Produto] ([id]),
     CONSTRAINT [FK_Compra_Cliente_cliente_id] FOREIGN KEY ([cliente_id]) REFERENCES [Cliente] ([cpf])
)
GO



--===============Loja==========================================
CREATE OR ALTER PROCEDURE [NovaLoja]
    @nome       NVARCHAR(120),
    @telefone   NVARCHAR(20),
    @email      NVARCHAR(180),
    @endereco   NVARCHAR(255)
AS
BEGIN
     INSERT INTO [Loja] (nome, telefone, email, endereco)
                VALUES(@nome, @telefone, @email, @endereco)
END
GO


CREATE OR ALTER PROCEDURE [DeletarLoja]
    @id   NVARCHAR(120)
AS
BEGIN
    DECLARE @existeLoja     INT
    SELECT @existeLoja  =  [Loja].[id] FROM [Loja] WHERE @id = [Loja].[id];

    IF @existeLoja > 0
        BEGIN
            DELETE FROM [Loja]
            WHERE @id = [Loja].[id]
            
        END
END
GO

CREATE OR ALTER PROCEDURE [AtualizarLoja]
    @idPesquisado         INT,
    @nome                 NVARCHAR(120),
    @telefone             NVARCHAR(20),
    @email                NVARCHAR(180),
    @endereco             NVARCHAR(255)
AS
BEGIN

    UPDATE [Loja]
    SET [Loja].[nome] = @nome,
    [Loja].[telefone] = @telefone,
    [Loja].[email] = @email,
    [Loja].[endereco] = @endereco
    WHERE @idPesquisado = [Loja].[id];
        
END
GO

--=========================Produto===================================

CREATE OR ALTER PROCEDURE [NovoProduto]
    @nome       NVARCHAR(120),
    @marca   NVARCHAR(20),
    @tipo      NVARCHAR(180),
    @preco   DECIMAL,
    @quantidade INT
AS
BEGIN
     INSERT INTO [Produto] (nome, marca, tipo, preco, quantidade_estoque)
                VALUES(@nome, @marca, @tipo, @preco, @quantidade)
END
GO


CREATE OR ALTER PROCEDURE [DeletarProduto]
    @id   NVARCHAR(120)
AS
BEGIN
    DECLARE @existeLoja     INT
    SELECT @existeLoja  =  [Produto].[id] FROM [Produto] WHERE @id = [Produto].[id];

    IF @existeLoja > 0
        BEGIN
            DELETE FROM [Loja-Produto]
            WHERE @id = [Loja-Produto].[produto_id]
        END
        BEGIN
            DELETE FROM [Produto]
            WHERE @id = [Produto].[id]
            
        END
END
GO

CREATE OR ALTER PROCEDURE [AtualizarProduto]
    @idPesquisado         INT,
    @nome       NVARCHAR(120),
    @marca   NVARCHAR(20),
    @tipo      NVARCHAR(180),
    @preco   DECIMAL,
    @quantidade INT
AS
BEGIN

    UPDATE [Produto]
    SET [Produto].[nome] = @nome,
    [Produto].[marca] = @marca,
    [Produto].[tipo] = @tipo,
    [Produto].[preco] = @preco,
    [Produto].[quantidade_estoque] = @quantidade
    WHERE @idPesquisado = [Produto].[id];
        
END
GO

--=====================Loja-Produto===================================



SELECT [Loja].[nome] AS [nome_loja], [Produto].[nome] AS [nome_produto], [Produto].[quantidade_estoque]
    FROM [Loja] INNER JOIN [Loja-Produto]
    ON [Loja].[id] = [Loja-Produto].[loja_id]
    INNER JOIN [Produto]
    ON [Loja-Produto].[produto_id] = [Produto].[id]

SELECT [Produto].[id] AS [id_produto], [Produto].[nome] AS [nome_produto], [Produto].[Preco], [Produto].[quantidade_estoque]
        FROM [Produto]
GO

--=====================Cliente===================================
CREATE OR ALTER PROCEDURE [NovoCliente]
    @cpf        NVARCHAR(20),
    @nome       NVARCHAR(120),
    @email      NVARCHAR(180),
    @senha      NVARCHAR(180),
    @telefone   NVARCHAR(20)
AS
BEGIN
     DECLARE @nivel     INT
     SELECT @nivel = 1;
     INSERT INTO [Cliente] (cpf, nome, email, senha, nivel, telefone)
                VALUES(@cpf, @nome, @email, @senha, @nivel, @telefone)
END
GO

CREATE OR ALTER PROCEDURE [DeletarCliente]
    @cpf   NVARCHAR(20)
AS
BEGIN
    DECLARE @existeLoja     INT
    SELECT @existeLoja  =  [Cliente].[cpf] FROM [Cliente] WHERE @cpf = [Cliente].[cpf];

    IF @existeLoja > 0
        BEGIN
            DELETE FROM [Avaliacao]
            WHERE @cpf = [Avaliacao].[cliente_id]
        END
        BEGIN
            DELETE FROM [Compra]
            WHERE @cpf = [Compra].[cliente_id]
        END
        BEGIN
            DELETE FROM [Cliente]
            WHERE @cpf = [Cliente].[cpf]
            
        END
END
GO

CREATE OR ALTER PROCEDURE [AtualizarCliente]
    @cpfPesquisado        NVARCHAR(20),
    @nome                 NVARCHAR(120),
    @email                NVARCHAR(180),
    @senha                NVARCHAR(180),
    @telefone             NVARCHAR(20)
AS
BEGIN

    UPDATE [Cliente]
    SET [Cliente].[nome] = @nome,
    [Cliente].[email] = @email,
    [Cliente].[senha] = @senha,
    [Cliente].[telefone] = @telefone
    WHERE @cpfPesquisado = [Cliente].[cpf];
        
END
GO

--====================Correio==============================

CREATE OR ALTER PROCEDURE [NovoCorreio]
    @prazo_entrega INT,
    @valor_frete DECIMAL
AS
BEGIN
     INSERT INTO [Correio] (prazo_entrega, valor_frete)
                VALUES(@prazo_entrega, @valor_frete)
END
GO


CREATE OR ALTER PROCEDURE [DeletarCorreio]
    @id   INT
AS
BEGIN
    DECLARE @existeLoja     INT
    SELECT @existeLoja  =  [Correio].[id] FROM [Correio] WHERE @id = [Correio].[id];

    IF @existeLoja > 0
        BEGIN
            DELETE FROM [Compra]
            WHERE @id = [Compra].[cod_rastreamento]
        END
        BEGIN
            DELETE FROM [Correio]
            WHERE @id = [Correio].[id]
            
        END
END
GO

CREATE OR ALTER PROCEDURE [AtualizarCorreio]
    @idPesquisado         INT,
    @prazo_entrega        INT,
    @valor_frete          DECIMAL
AS
BEGIN

    UPDATE [Correio]
    SET [Correio].[prazo_entrega] = @prazo_entrega ,
    [Correio].[valor_frete] = @valor_frete 
    WHERE @idPesquisado = [Correio].[id];
        
END
GO
--=========================Compra==========================================================

CREATE OR ALTER PROCEDURE [NovaCompra]
    @produto_id INT, 
    @cliente_id NVARCHAR(20),
    @tipo_pagamento NVARCHAR(20),
    @quantidade_comprada INT,
    @cod_rastreamento INT
AS
BEGIN
    DECLARE @existeProdutoId INT
    DECLARE @existeCpf NVARCHAR(20)
    DECLARE @existeCodReastreamento INT
    DECLARE @quantidadeEstoque  INT

    SELECT @existeProdutoId  =  [Produto].[id] FROM [Produto] WHERE @produto_id = [Produto].[id];
    SELECT @existeCpf  =  [Cliente].[cpf] FROM [Cliente] WHERE @cliente_id = [Cliente].[cpf];
    SELECT @existeCodReastreamento  =  [Correio].[id] FROM [Correio] WHERE @cod_rastreamento = [Correio].[id];
    SELECT @quantidadeEstoque = [Produto].[quantidade_estoque] FROM [Produto] WHERE @produto_id = [Produto].[id];

    IF(@existeProdutoId IS NOT NULL)
        BEGIN
            IF(@existeCpf IS NOT NULL)
                BEGIN
                    IF(@existeCodReastreamento IS NOT NULL)
                        BEGIN
                            IF(@quantidade_comprada <= @quantidadeEstoque)
                                BEGIN
                                    DECLARE @valor_total DECIMAL
                                    DECLARE @verificarCpf NVARCHAR(20)
                                    SELECT @valor_total = [Produto].[Preco] FROM [Produto] WHERE @produto_id = [Produto].[id];
                                    SELECT @valor_total = @valor_total * @quantidade_comprada;
                                    SELECT @valor_total = @valor_total + [Correio].[valor_frete] FROM [Correio] WHERE @cod_rastreamento = [Correio].[id]
                                    
                                    SELECT @verificarCpf = [Compra].[cliente_id] FROM [Compra] WHERE  [Compra].[cliente_id] = @existeCpf and [Compra].[produto_id] = @existeProdutoId
                                    IF(@verificarCpf is NOT NULL)
                                        BEGIN
                                            UPDATE [Compra]
                                            SET [Compra].[quantidade_comprada] = [Compra].[quantidade_comprada] + @quantidade_comprada
                                            WHERE  [Compra].[cliente_id] = @existeCpf and [Compra].[produto_id] = @existeProdutoId;

                                            UPDATE [Compra]
                                            SET [Compra].[valor_total] = [Compra].[valor_total] + @valor_total
                                            WHERE  [Compra].[cliente_id] = @existeCpf and [Compra].[produto_id] = @existeProdutoId;

                                            UPDATE [Compra]
                                            SET [Compra].[tipo_pagamento] = @tipo_pagamento
                                            WHERE  [Compra].[cliente_id] = @existeCpf and [Compra].[produto_id] = @existeProdutoId;


                                        END
                                    ELSE
                                        BEGIN
                                            INSERT INTO [Compra] (produto_id, cliente_id, valor_total, tipo_pagamento, quantidade_comprada, cod_rastreamento)
                                            VALUES(@produto_id, @cliente_id, @valor_total, @tipo_pagamento, @quantidade_comprada, @cod_rastreamento)
                                        END
                                     UPDATE [Produto]
                                            SET [Produto].[quantidade_estoque] = [Produto].[quantidade_estoque] - @quantidade_comprada
                                            WHERE @produto_id = [Produto].[id];

                                    
                                END
                            ELSE
                                BEGIN
                                    SELECT 'Compra não realizada, quantidade insuficiente'
                                END
                        END
                    ELSE
                        BEGIN
                            SELECT 'Compra não realizada, Frete não disponível'
                        END
                END
            ELSE
                BEGIN
                    SELECT 'Compra não realizada, Cpf inválido'
                END
        END
    ELSE
        BEGIN
            SELECT 'Compra não realizada, Produto inválido'
        END    
END
GO


CREATE OR ALTER PROCEDURE [DeletarCompra]
    @id   INT,
    @cpf NVARCHAR(20)
AS
BEGIN
    
    DELETE FROM [Compra]
    WHERE @id = [Compra].[produto_id] and @cpf = [Compra].[cliente_id]
    
END
GO

CREATE OR ALTER PROCEDURE [AtualizarCompra]
    @idPesquisadoProduto         INT,
    @idPesquisadoCliente    NVARCHAR(20),
    @tipo_pagamento NVARCHAR(20),
    @quantidade_comprada INT,
    @cod_rastreamento INT
AS
BEGIN
     BEGIN
        DECLARE @quantidade_estoque_anterior    INT
        DECLARE @quantida_comprada_anterior     INT
        DECLARE @quantidade_total_estoque_anterior  INT
        DECLARE @novaQuantidadeEstoque  INT
        SELECT @quantidade_estoque_anterior = [Produto].[quantidade_estoque] FROM [Produto] WHERE @idPesquisadoProduto = [Produto].[id];
        SELECT @quantida_comprada_anterior = [Compra].[quantidade_comprada] FROM [Compra] WHERE @idPesquisadoProduto = [Compra].[produto_id] and @idPesquisadoCliente = [Compra].[cliente_id]

        DECLARE @valor_total DECIMAL
        SELECT @valor_total = [Produto].[Preco] FROM [Produto] WHERE @idPesquisadoProduto = [Produto].[id];
        SELECT @valor_total = @valor_total * @quantidade_comprada;
        SELECT @valor_total = @valor_total + [Correio].[valor_frete] FROM [Correio] WHERE @cod_rastreamento = [Correio].[id]

        SELECT @novaQuantidadeEstoque = @quantidade_total_estoque_anterior - @quantidade_comprada
        UPDATE [Produto]
            SET [Produto].[quantidade_estoque] = @novaQuantidadeEstoque
            WHERE @idPesquisadoProduto = [Produto].[id];
    END

    UPDATE [Compra]
    SET [Compra].[valor_total] = @valor_total ,
    [Compra].[tipo_pagamento] = @tipo_pagamento,
    [Compra].[quantidade_comprada] = @quantidade_comprada,
    [Compra].[cod_rastreamento] = @cod_rastreamento
    WHERE @idPesquisadoProduto = [Compra].[produto_id] and @idPesquisadoCliente = [Compra].[produto_id];
        
END
GO





CREATE OR ALTER PROCEDURE [ListarHistoricoCompra]
AS
BEGIN
    SELECT [Cliente].[nome] AS [nome_cliente], [Produto].[nome] AS [nome_produto], [Compra].[valor_total], [Compra].[tipo_pagamento]
        FROM [Cliente] INNER JOIN [Compra]
        ON [Cliente].[cpf] = [Compra].[cliente_id]
        INNER JOIN [Produto]
        ON [Compra].[produto_id] = [Produto].[id]
END
GO

