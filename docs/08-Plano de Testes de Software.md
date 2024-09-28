# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

| **Caso de Teste**   | **CT-01 – Autenticar no Sistema**                                   |
|:-------------------:|:------------------------------------------------------------------:|
| Requisito Associado | RF-01 - Desenvolver tela de Login com módulo de autenticação.      |
| Objetivo do Teste   | Verificar se o usuário consegue realizar a autenticação no sistema. |
| Passos              | - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher os campos de e-mail e senha <br> - Clicar em "Login" |
| Critério de Êxito   | - O login é realizado com sucesso, e o usuário é direcionado à página inicial. |

<br>

| **Caso de Teste**   | **CT-02 – Gerenciamento de Salas**                                  |
|:-------------------:|:------------------------------------------------------------------:|
| Requisito Associado | RF-02 - Desenvolver tela de gerenciamento de Salas, permitindo cadastro, edição, visualização e exclusão de informações. |
| Objetivo do Teste   | Verificar se o usuário consegue cadastrar, editar, visualizar e excluir informações sobre salas. |
| Passos              | - Acessar a funcionalidade "Gerenciamento de Salas" <br> - Cadastrar uma nova sala <br> - Editar as informações da sala cadastrada <br> - Visualizar os dados da sala <br> - Excluir a sala cadastrada |
| Critério de Êxito   | - Todas as operações (cadastrar, editar, visualizar, excluir) são realizadas com sucesso. |

<br>

| **Caso de Teste**   | **CT-03 – Visualizar disponibilidade das salas**                   |
|:-------------------:|:------------------------------------------------------------------:|
| Requisito Associado | RF-03 - Desenvolver tela para visualização da disponibilidade das salas em tempo real pelos usuários finais. |
| Objetivo do Teste   | Verificar se o usuário consegue visualizar a disponibilidade das salas em tempo real. |
| Passos              | - Realizar o login no sistema <br> - Acessar o menu "Salas Disponíveis" <br> - Visualizar as salas disponíveis com seus horários e datas |
| Critério de Êxito   | - A lista de salas disponíveis é apresentada corretamente em tempo real. |

<br>

| **Caso de Teste**   | **CT-04 – Reservar sala para um período específico**                |
|:-------------------:|:------------------------------------------------------------------:|
| Requisito Associado | RF-04 - Desenvolver tela para realização de reservas de salas para períodos específicos, com confirmação imediata. |
| Objetivo do Teste   | Verificar se o usuário consegue reservar uma sala para um período específico. |
| Passos              | - Acessar a funcionalidade de "Reservar Sala" <br> - Selecionar a sala desejada <br> - Escolher o horário e data da reserva <br> - Confirmar a reserva |
| Critério de Êxito   | - A reserva é realizada com sucesso e uma confirmação imediata é exibida. |

<br>

| **Caso de Teste**   | **CT-05 – Cadastrar cartão de crédito**                            |
|:-------------------:|:------------------------------------------------------------------:|
| Requisito Associado | RF-05 - Desenvolver tela para cadastro de cartão de crédito para pagamento diferido no dia da reserva pelos usuários finais. |
| Objetivo do Teste   | Verificar se o usuário consegue cadastrar um cartão de crédito.    |
| Passos              | - Acessar a funcionalidade de "Cadastro de Cartão" <br> - Informar os dados do cartão <br> - Confirmar o cadastro |
| Critério de Êxito   | - O cadastro é realizado com sucesso e o cartão fica associado ao perfil do usuário. |

<br>

| **Caso de Teste**   | **CT-06 – Processar pagamento no dia da reserva**                  |
|:-------------------:|:------------------------------------------------------------------:|
| Requisito Associado | RF-06 - Desenvolver funcionalidade para processamento automático de pagamentos no dia da reserva, debitando o valor do cartão cadastrado. |
| Objetivo do Teste   | Verificar se o pagamento é processado automaticamente no dia da reserva. |
| Passos              | - Confirmar uma reserva de sala para um período futuro <br> - Verificar o processamento do pagamento no dia da reserva |
| Critério de Êxito   | - O pagamento é processado automaticamente, e o valor é debitado corretamente. |

<br>

| **Caso de Teste**   | **CT-07 – Cadastrar perfil de usuário**                             |
|:-------------------:|:------------------------------------------------------------------:|
| Requisito Associado | RF-07 - Desenvolver tela de Usuários, permitindo cadastro, edição, visualização e exclusão de perfis. |
| Objetivo do Teste   | Verificar se o usuário consegue cadastrar e gerenciar seu perfil.   |
| Passos              | - Acessar a funcionalidade de "Cadastro de Usuário" <br> - Preencher os dados obrigatórios (nome, e-mail, etc.) <br> - Confirmar o cadastro |
| Critério de Êxito   | - O cadastro é realizado com sucesso, e o usuário consegue visualizar e editar suas informações posteriormente. |

<br>

| **Caso de Teste**   | **CT-08 – Cancelamento de reservas pelo administrador**             |
|:-------------------:|:------------------------------------------------------------------:|
| Requisito Associado | RF-08 - Desenvolver tela para que administradores possam cancelar reservas e notificar usuários sobre o cancelamento. |
| Objetivo do Teste   | Verificar se o administrador consegue cancelar uma reserva e notificar o usuário. |
| Passos              | - Acessar o painel administrativo <br> - Selecionar uma reserva existente <br> - Cancelar a reserva <br> - Verificar se o usuário foi notificado sobre o cancelamento |
| Critério de Êxito   | - A reserva é cancelada com sucesso e o usuário é notificado.      |

<br>

| **Caso de Teste**   | **CT-09 – Receber notificação de confirmação de reserva**          |
|:-------------------:|:------------------------------------------------------------------:|
| Requisito Associado | RF-09 - Desenvolver funcionalidade para envio de notificações de confirmação de reservas para os usuários finais. |
| Objetivo do Teste   | Verificar se o usuário recebe uma notificação de confirmação após a reserva. |
| Passos              | - Realizar uma reserva <br> - Verificar se a notificação de confirmação é enviada ao usuário |
| Critério de Êxito   | - A notificação é recebida corretamente após a confirmação da reserva. |

<br>

| **Caso de Teste**   | **CT-10 – Alterar ou cancelar reservas**                           |
|:-------------------:|:------------------------------------------------------------------:|
| Requisito Associado | RF-10 - Desenvolver tela que permita aos usuários alterarem ou cancelarem suas reservas com um prazo determinado antes da data da reserva. |
| Objetivo do Teste   | Verificar se o usuário consegue alterar ou cancelar uma reserva dentro do prazo permitido. |
| Passos              | - Acessar a lista de reservas <br> - Selecionar uma reserva <br> - Realizar a alteração ou cancelamento dentro do prazo permitido |
| Critério de Êxito   | - A reserva é alterada ou cancelada com sucesso dentro do prazo determinado. |

<br>

> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> - [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
