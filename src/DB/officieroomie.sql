CREATE DATABASE officeroomie COLLATE Latin1_General_100_CI_AS_SC_UTF8;

-- Tabela enderecos
CREATE TABLE enderecos (
    id INT PRIMARY KEY IDENTITY(1,1),
    logradouro VARCHAR(255) NOT NULL,
    numero VARCHAR(10),
    complemento VARCHAR(100),
    cep VARCHAR(20),
    bairro VARCHAR(100),
    cidade VARCHAR(100),
    estado VARCHAR(50),
    pais VARCHAR(50)
);

-- Tabela clientes
CREATE TABLE clientes (
    id INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    cpf VARCHAR(11) NOT NULL UNIQUE,
    endereco_id INT NOT NULL,
    CONSTRAINT fk_clientes_enderecos FOREIGN KEY (endereco_id) REFERENCES enderecos(id)
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

-- Tabela categorias_sala
CREATE TABLE categorias_sala (
    id INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(255) NOT NULL
);

-- Tabela salas
CREATE TABLE salas (
    id INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(255) NOT NULL,
    descricao VARCHAR(100),
    capacidade INT,
    categoria_id INT NOT NULL,
    status VARCHAR(50) NOT NULL,
    CONSTRAINT fk_salas_categorias FOREIGN KEY (categoria_id) REFERENCES categorias_sala(id)
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