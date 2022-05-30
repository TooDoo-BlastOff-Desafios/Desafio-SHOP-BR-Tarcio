CREATE DATABASE [SHOP-BR]

USE [SHOP-BR]
CREATE TABLE [Loja](
    [id] UNIQUEIDENTIFIER NOT NULL,
    [nome] NVARCHAR(120) NOT NULL,
    [telefone] NVARCHAR(20) NULL,
    [email] NVARCHAR(180) NOT NULL UNIQUE,
    [endereco] NVARCHAR(255) NOT NULL

    CONSTRAINT [PK_Loja] PRIMARY KEY ([id])
);
GO --INT NOT NULL IDENTITY(1,1)


CREATE TABLE [Produto](
    [id] UNIQUEIDENTIFIER NOT NULL,
    [nome] NVARCHAR(120) NOT NULL,
    [marca] NVARCHAR(20) NOT NULL,
    [tipo] INT NOT NULL,
    [preco] DECIMAL NOT NULL,

    CONSTRAINT [PK_Produto] PRIMARY KEY ([id])
);
GO

CREATE TABLE [Loja-Produto](
    [loja_id] UNIQUEIDENTIFIER NOT NULL,
    [produto_id] UNIQUEIDENTIFIER NOT NULL,
    [quantidade_estoque] INT NOT NULL, 
    

     CONSTRAINT [PK_Loja-Produto] PRIMARY KEY ([loja_id], [produto_id]),
     CONSTRAINT [FK_Loja-Produto_Loja_loja_id] FOREIGN KEY ([loja_id]) REFERENCES [Loja] ([id]),
     CONSTRAINT [FK_Loja-Produto_Produto_produto_id] FOREIGN KEY ([produto_id]) REFERENCES [Produto] ([id])
)

CREATE TABLE [Correio](
    [id] UNIQUEIDENTIFIER NOT NULL,
    [prazo_entrega] INT,
    [valor_frete] DECIMAL,

    CONSTRAINT [PK_Correio] PRIMARY KEY ([id])
);
GO

CREATE TABLE [Compra](
    [produto_id] UNIQUEIDENTIFIER NOT NULL, 
    [cliente_id] UNIQUEIDENTIFIER NOT NULL,
    [valor_total] DECIMAL NOT NULL,
    [tipo_pagamento] NVARCHAR(20) NOT NULL,
    [quantidade_comprada] INT NOT NULL,
    [cod_rastreamento] UNIQUEIDENTIFIER NOT NULL,
    

    CONSTRAINT [PK_Compra] PRIMARY KEY ([produto_id], [cliente_id]),
    CONSTRAINT [FK_Compra_Correio_cod_rastreamento] FOREIGN KEY ([cod_rastreamento]) REFERENCES [Correio] ([id]),
);
GO

ALTER TABLE [Compra]
    ADD FOREIGN KEY ([produto_id]) REFERENCES [Produto] ([id])

ALTER TABLE [Compra]
    ADD FOREIGN KEY ([cliente_id]) REFERENCES [Cliente] ([cpf])

CREATE TABLE [Avaliacao](
    [produto_id] UNIQUEIDENTIFIER NOT NULL,
    [cliente_id] UNIQUEIDENTIFIER NOT NULL,
    [nota] TINYINT NOT NULL, -- 0 a 255
    [descricao] TEXT NOT NULL,

     CONSTRAINT [PK_Avaliacao] PRIMARY KEY ([produto_id], [cliente_id]),
)

ALTER TABLE [Avaliacao]
    ADD FOREIGN KEY ([produto_id]) REFERENCES [Produto] ([id])

ALTER TABLE [Avaliacao]
    ADD FOREIGN KEY ([cliente_id]) REFERENCES [Cliente] ([cpf])

CREATE TABLE [Cliente](
    [cpf] UNIQUEIDENTIFIER NOT NULL,
    [nome] NVARCHAR(120) NOT NULL,
    [email] NVARCHAR(180) NOT NULL,
    [senha] NVARCHAR(180) NOT NULL,
    [nivel] TINYINT NOT NULL, -- 0 a 255
    [telefone] NVARCHAR(20) NULL,

    CONSTRAINT [PK_Cliente] PRIMARY KEY ([cpf])
);
GO









