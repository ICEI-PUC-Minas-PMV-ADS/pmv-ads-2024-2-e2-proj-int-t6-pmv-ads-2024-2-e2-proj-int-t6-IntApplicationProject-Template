# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - O sistema deve possibilitar ao usuário fazer login, se cadastrar ou alterar sua senha. <br> RF-003 - O sistema deve fornecer feedback claro para ações do usuário, como confirmações de formulários e mensagens de erro.| 
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site. <br> - Visualizar a página inicial. <br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | O usuário deve fazer o cadastro, preenchendo informações solicitadas com base no cadastro de Pessoa Física ou Pessoa Jurídica. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Efetuar login**	|
|Requisito Associado | RF-001 - O sistema deve possibilitar ao usuário fazer login, se cadastrar ou alterar sua senha. <br> RF-002 - O sistema deve permitir ao usuário verificar as informações registradas no cadastro, após fazer seu login. <br> RF-003 - O sistema deve fornecer feedback claro para ações do usuário, como confirmações de formulários e mensagens de erro. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site. <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | O usuário deverá fazer o login, recebendo um feedback mostrando se o login foi bem ou mal sucedido. Após a confirmação de login, os dados previamente cadastrados deverão aparecer para o usuário. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Verificar o funcionamento de busca e pesquisa de animais na Home Page.**	|
|Requisito Associado | RF-007 - O sistema deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar os animais. |
| Objetivo do Teste 	| Verificar se o usuário consegue utilizar o sistema de busca por animais. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site. <br> - Visualizar o campo de filtro/busca na Home Page <br> - Preencher os dados requisitados <br> - Clicar em "Filtrar" |
|Critério de Êxito | O usuário deverá fazer busca, visualizando os animais com base nos filtros que foram selecionados. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 – Verificar o funcionamento do cadastro e edição de informações de animais.**	|
|Requisito Associado | RF-004 - O sistema deve permitir cadastrar animais disponíveis para adoção. <br> RF-005 - O Sistema deve permitir editar as informações dos animais cadastrados.|
| Objetivo do Teste 	| Verificar se a parte de cadastro de animais e edição de informações está correta. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site. <br> - Efetuar o Login <br> - Visualizar a Home Page <br> - Selecionar a opção de cadastro de animais <br> - Preencher os dados requisitados <br> - Verificar se o animal foi cadastrado com sucesso. <br> - Caso desejar mudar alguma informação do Pet cadastrado, selecionar a ferramenta "Editar". <br> - Editar os dados que deseja <br> - Verificar se o cadastro do animal foi editado com sucesso. |
|Critério de Êxito | O usuário deverá fazer o cadastro do animal que deseja, visualizando os dados corretamente do cadastro feito. Caso seja utilizado a edição de informações, o usuário deverá visualizar as informações corrigidas após alteração. |
|  	|  	|
| **Caso de Teste** 	| **CT-05 – Verificar o funcionamento da parte de animais disponíveis para adoção.**	|
|Requisito Associado | RF-006 - O sistema deve ter uma página de perfil detalhada para cada animal como: histórico de saúde, comportamento, características específicas e fotos.|
| Objetivo do Teste 	| Verificar se a parte de visualização dos dados específicos dos animais estão corretas. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site. <br> - Efetuar o Login <br> - Visualizar a Home Page <br> - Selecionar a opção "Animais" <br> - Visualizar a aba com os animais disponíveis para adoção <br> - Verificar se aparece informações específicas do animal ao clicar nele. |
|Critério de Êxito | O usuário deverá visualizar os animais disponíveis para adoção com sucesso, visualizando os dados especificamente do animal ao clicar sobre ele. |
|  	|  	|
| **Caso de Teste** 	| **CT-06 – Verificar se o usuário consegue demonstrar interesse no animal disponível para adoção que deseja.**	|
|Requisito Associado | RF-008 - O sistema deve permitir o adotante/usuário demonstrar interesse em um animal.|
| Objetivo do Teste 	| Verificar se o usuário consegue demosntrar interesse no animal que deseja adotar. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site. <br> - Efetuar o Login <br> - Visualizar a Home Page <br> - Selecionar a opção "Animais" <br> - Visualizar a aba com os animais disponíveis para adoção <br> - Clicar na opção "Tenho Interesse" sobre o animal que deseja adotar. <br> - Preencher as informações necessárias para prosseguir com o interesse |
|Critério de Êxito | O usuário deverá demonstrar interesse no animal selecionado, preenchendo informações requisitadas para prosseguir com a adoção. |
|  	|  	|
| **Caso de Teste** 	| **CT-07 – Verificar se o sistema notifica o abrigo quando um usuário demonstra interesse em um animal do estabelecimento, permitindo que ele acompanhe o status da adoção**	|
|Requisito Associado | RF-009 - O sistema deve notificar ao abrigo quando um usuário demonstrar interesse em um animal cadastrado. <br> RF-010 - O sistema deverá permitir fazer o acompanhamento do status de adoções: pendentes, em processo ou concluídas.|
| Objetivo do Teste 	| Verificar se o abrigo é notificado quando um usuário demonstra interesse em algum animal disponível para adoção. Após a notificação, o sistema deverá informar o status da adoção solicitada, sendo os status: pendente, em processo ou concluído. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site. <br> - Efetuar o Login (como abrigo) <br> - Visualizar a Home Page <br> - Verificar a área de notificações <br> - Visualizar a notificação de que um animal do abrigo está sendo solicitado por um usuário. <br> - Clicar na notificação para visualizar as informações do usuário e qual animal foi escolhido <br> - Após o início do processo de adoção, ambos receberão notificações caso o status da adoção se altere. |
|Critério de Êxito | O abrigo deverá receber notificação sempre que um usuário demonstrar interesse em um animal disponível para adoção no sistema. Após o início do processo, tanto o abrigo quanto o usuário deverão receber notificações informando o status da adoção solicitada. |


 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
