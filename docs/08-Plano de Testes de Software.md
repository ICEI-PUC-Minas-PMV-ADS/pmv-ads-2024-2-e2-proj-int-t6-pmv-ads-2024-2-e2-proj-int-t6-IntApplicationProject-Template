# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - O sistema deve possibilitar ao usuário fazer login, se cadastrar ou alterar sua senha. | RF-003 - O sistema deve fornecer feedback claro para ações do usuário, como confirmações de formulários e mensagens de erro. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site. <br> - Visualizar a página inicial. <br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | O usuário deve fazer o cadastro, preenchendo informações solicitadas com base no cadastro de Pessoa Física ou Pessoa Jurídica. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-001 - O sistema deve possibilitar ao usuário fazer login, se cadastrar ou alterar sua senha. | RF-002 - O sistema deve permitir ao usuário verificar as informações registradas no cadastro, após fazer seu login. | RF-003 - O sistema deve fornecer feedback claro para ações do usuário, como confirmações de formulários e mensagens de erro. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site. <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | O usuário deverá fazer o login, recebendo um feedback mostrando se o login foi bem ou mal sucedido. Após a confirmação de login, os dados previamente cadastrados deverão aparecer para o usuário. |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
