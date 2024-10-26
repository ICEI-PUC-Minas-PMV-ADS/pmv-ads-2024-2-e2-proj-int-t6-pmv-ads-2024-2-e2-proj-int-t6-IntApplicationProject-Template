CREATE DATABASE officeroomie COLLATE Latin1_General_100_CI_AS_SC_UTF8;

-- Tabela clientes
CREATE TABLE clientes (
    id INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    cpf VARCHAR(11) NOT NULL UNIQUE,
    endereco_logradouro VARCHAR(255) NOT NULL,
    endereco_numero VARCHAR(10),
    endereco_complemento VARCHAR(100),
    endereco_cep VARCHAR(20),
    endereco_bairro VARCHAR(100),
    endereco_cidade VARCHAR(100),
    endereco_estado VARCHAR(50),
    endereco_pais VARCHAR(50)
);

-- Tabela administradores
CREATE TABLE administradores (
    id INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    cpf VARCHAR(11) NOT NULL UNIQUE,
    senha VARCHAR(255) NOT NULL,
    permissoes VARCHAR(100) NOT NULL
);

-- Tabela salas
CREATE TABLE salas (
    id INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(255) NOT NULL,
    descricao VARCHAR(100),
    capacidade INT NOT NULL,
    categoria VARCHAR(255) NOT NULL,
    status VARCHAR(50) NOT NULL,
);

-- Tabela reservas
CREATE TABLE reservas (
    id INT PRIMARY KEY IDENTITY(1,1),
    data_reserva DATE NOT NULL,
    hora_inicio TIME NOT NULL,
    hora_fim TIME NOT NULL,
    protocolo VARCHAR(50) NOT NULL UNIQUE,
    status VARCHAR(50) NOT NULL,
    cliente_id INT NOT NULL,
    sala_id INT NOT NULL,
    CONSTRAINT fk_reservas_clientes FOREIGN KEY (cliente_id) REFERENCES clientes(id),
    CONSTRAINT fk_reservas_salas FOREIGN KEY (sala_id) REFERENCES salas(id)
);

-- Tabela pagamentos
CREATE TABLE pagamentos (
    id INT PRIMARY KEY IDENTITY(1,1),
    valor DECIMAL(10,2) NOT NULL,
    data_pagamento DATE NOT NULL,
    status VARCHAR(50) NOT NULL,
    reserva_id INT NOT NULL,
    cliente_id INT NOT NULL,
    CONSTRAINT fk_pagamentos_reservas FOREIGN KEY (reserva_id) REFERENCES reservas(id),
    CONSTRAINT fk_pagamentos_clientes FOREIGN KEY (cliente_id) REFERENCES clientes(id)
);