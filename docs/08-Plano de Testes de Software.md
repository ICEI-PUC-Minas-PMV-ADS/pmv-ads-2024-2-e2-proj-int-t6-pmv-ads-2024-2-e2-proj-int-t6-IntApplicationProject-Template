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
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site. <br> - Efetuar o Login <br> - Visualizar a Home Page <br> - Selecionar a opção de cadastro de animais <br> - Preencher os dados requisitados <br> - Verificar se o animal foi cadastrado com sucesso. <br> Caso desejar mudar alguma informação do Pet cadastrado, selecionar a ferramenta "Editar". <br> - Editar os dados que deseja <br> - Verificar se o cadastro do animal foi editado com sucesso. |
|Critério de Êxito | O usuário deverá fazer o cadastro do animal que deseja, visualizando os dados corretamente do cadastro feito. Caso seja utilizado a edição de informações, o usuário deverá visualizar as informações corrigidas após alteração. |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
