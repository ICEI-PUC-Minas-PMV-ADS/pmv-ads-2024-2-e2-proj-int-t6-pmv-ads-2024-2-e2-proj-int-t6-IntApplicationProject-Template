# Registro de Testes de Software

| Caso de Teste | CT-07 – Cadastrar perfil de usuário |
|---------------|---------------------------------|
| Requisitos Associado | RF-07 - Desenvolver tela de Usuários, permitindo cadastro, edição, visualização e exclusão de perfis. |
| Objetivo do Teste | Verificar se o usuário consegue cadastrar e gerenciar seu perfil. |
| Passos 	| - Acessar a funcionalidade de "Administradores" ou "clientes" <br> - Clicar no botão "Novo Administrador" ou "Novo cliente" <br> - Prencher os campos obrigatórios <br> - Confirmar o cadastro <br> - Acessar a funcionalidade de "Administradores" ou "clientes" <br> - Clicar no botão "Editar" (ícone de caneta) <br> - Alterar dados <br> - Confirmar o edição <br> - Acessar a funcionalidade de "Administradores" ou "clientes" <br> - Clicar no botão "Deletar" (ícone de lixeira) <br> - Acessar a funcionalidade de "Administradores" ou "clientes" <br> - Clicar no botão "Visualizar" (ícone de olho) |
|Critérios de Êxito| Foi possível realizar o cadastro dos usuários, edição, visualização e exclusão dos mesmos. |

Registro de evidência:

https://github.com/user-attachments/assets/3dbf51b0-06db-4bed-ab5e-89603bf38274


| **Caso de Teste** 	| **CT-05 – Cadastrar cartão de crédito** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-05 - Desenvolver tela para cadastro de cartão de crédito para pagamento diferido no dia da reserva pelos usuários finais. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar um cartão de crédito. |
| Passos 	| - Acessar a funcionalidade de "Cadastro de Cartão" <br> - Informar os dados do cartão <br> - Confirmar o cadastro |
| Critério de Êxito | - O cadastro é realizado com sucesso e o cartão fica associado ao perfil do usuário. |

Registro de evidência: 

https://github.com/user-attachments/assets/7e1793fe-e96e-4c8c-8470-f126638976a7

| **Caso de Teste** 	| **CT-01 – Autenticar no Sistema** 	                            |
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - Desenvolver tela de Login com módulo de autenticação. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar a autenticação no sistema. |
| Passos 	| - Acessar o navegador <br> - Clicar no botão "Area restrita" <br> - Preencher os campos de e-mail e senha <br> - Clicar em "Acessar" |
| Critério de Êxito | - O login é realizado com sucesso, e o usuário é direcionado à página inicial. |

Registro de evidência:

https://github.com/user-attachments/assets/fa90c915-27ad-41e3-be51-96f41f33bccb


| **Caso de Teste** 	| **CT-08 – Cancelamento de reservas pelo administrador** 	                            |
|:---:	|:---:	|
|	Requisito Associado 	| RF-08 - Desenvolver tela para que administradores possam cancelar reservas e notificar usuários sobre o cancelamento. |
| Objetivo do Teste 	| Verificar se o administrador consegue cancelar uma reserva e notificar o usuário. |
| Passos 	| - Acessar o painel administrativo - Selecionar uma reserva existente - Cancelar a reserva - Verificar se o usuário foi notificado sobre o cancelamento |
| Critério de Êxito | - A reserva é cancelada com sucesso e o usuário é notificado. |

Registro de evidência:

https://github.com/user-attachments/assets/2e40b2c4-2f4a-424f-b2c4-132c720e9605


| **Caso de Teste** 	| **CT-02 – Gerenciamento de Salas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-02 - Desenvolver tela de gerenciamento de Salas, permitindo cadastro, edição, visualização e exclusão de informações. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar, editar, visualizar e excluir informações sobre salas. |
| Passos 	| - Acessar a funcionalidade "Gerenciamento de Salas" <br> - Cadastrar uma nova sala <br> - Editar as informações da sala cadastrada <br> - Visualizar os dados da sala <br> - Excluir a sala cadastrada |
| Critério de Êxito | - Todas as operações (cadastrar, editar, visualizar, excluir) são realizadas com sucesso. |

Registro de evidência:

| **Caso de Teste** 	| **CT-03 – Visualizar disponibilidade das salas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-03 - Desenvolver tela para visualização da disponibilidade das salas em tempo real pelos usuários finais. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar a disponibilidade das salas em tempo real. |
| Passos 	| - Realizar o login no sistema <br> - Acessar o menu "Salas Disponíveis" <br> - Visualizar as salas disponíveis com seus horários e datas |
| Critério de Êxito | - A lista de salas disponíveis é apresentada corretamente em tempo real. |

Registro de evidência:

https://github.com/user-attachments/assets/53a3e991-94c4-497a-8011-89c2fcc2f8bf







<!-- <span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
|Registro de evidência | www.teste.com.br/drive/ct-01 |

| **Caso de Teste** 	| **CT-02 – Realizar login** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00Y - A aplicação deve permitir que um usuário previamente cadastrado faça login |
|Registro de evidência | www.teste.com.br/drive/ct-02 |

## Avaliação

Discorra sobre os resultados do teste. Ressaltando pontos fortes e fracos identificados na solução. Comente como o grupo pretende atacar esses pontos nas próximas iterações. Apresente as falhas detectadas e as melhorias geradas a partir dos resultados obtidos nos testes.

> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/) -->

