CREATE TABLE Usuario (
  id INT PRIMARY KEY AUTO_INCREMENT,
  nome VARCHAR(255) NOT NULL,
  email VARCHAR(255) NOT NULL,
  senha VARCHAR(255) NOT NULL,
  tipo ENUM('adotante', 'abrigo') NOT NULL,
  dataNascimento DATE NOT NULL,
  dataCadastro DATE NOT NULL
);

CREATE TABLE Pet (
  id INT PRIMARY KEY AUTO_INCREMENT,
  nome VARCHAR(255) NOT NULL,
  idade INT NOT NULL,
  tipoIdade ENUM('dias', 'meses', 'anos') NOT NULL,
  tipoPet VARCHAR(255) NOT NULL,
  raca VARCHAR(255),
  sexo ENUM('macho', 'fêmea') NOT NULL,
  porte ENUM('pequeno', 'médio', 'grande') NOT NULL,
  idAbrigo INT NOT NULL,
  FOREIGN KEY (idAbrigo) REFERENCES Usuario(id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Adocao (
  id INT PRIMARY KEY AUTO_INCREMENT,
  usuario_id INT NOT NULL,
  idPet INT NOT NULL,
  statusAdocao ENUM('iniciado', 'em andamento', 'finalizado', 'cancelado') NOT NULL,
  dataInicio DATE NOT NULL,
  dataFinalizacao DATE,
  FOREIGN KEY (usuario_id) REFERENCES Usuario(id)
    ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (idPet) REFERENCES Pet(id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Notificacao (
  id INT PRIMARY KEY AUTO_INCREMENT,
  usuario_id INT NOT NULL,
  mensagem TEXT NOT NULL,
  dataEnvio DATE NOT NULL,
  FOREIGN KEY (usuario_id) REFERENCES Usuario(id)
    ON DELETE CASCADE ON UPDATE CASCADE
);

/*
Explicação dos Relacionamentos:
Tabela Usuario: Representa os usuários da plataforma. A chave primária é o id, que é único para cada usuário.
Tabela Pet: Relaciona-se com a tabela Usuario através da chave estrangeira idAbrigo, que referencia o abrigo responsável pelo pet. Quando um abrigo é deletado, os pets relacionados também são deletados devido à regra ON DELETE CASCADE.
Tabela Adocao: Representa o processo de adoção. Contém as chaves estrangeiras usuario_id (para o usuário que está adotando) e idPet (para o pet sendo adotado). As regras de integridade referencial garantem que se um pet ou usuário for deletado, o processo de adoção relacionado também será.
Tabela Notificacao: Relaciona-se com Usuario pela chave estrangeira usuario_id, que referencia o usuário que recebe a notificação.

*/