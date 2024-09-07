# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

| João Silva    |                                    |                |
|--------------------|------------------------------------|----------------------------------------|
|![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/joaomarques.png)|**Idade:** 60 anos - **Ocupação:**  Designer Gráfico |Aplicativos: Facebook, Whatsapp, Instagram.|
|**Descrição:** João mora em um apartamento e está à procura de um animal de estimação para adoção. Ele prefere cães de porte médio e está preocupado com questões como o comportamento do animal e a compatibilidade com seu estilo de vida. Tem pouca experiência com adoção e busca informações sobre cuidados com animais. |**Necessidades:** Por trabalhar durante quase todo dia, Juliana não consegue acompanhar horários regulares de coleta reciclável em seu bairro, tornando-se assim inviável faltar em seu trabalho para depositar o lixo em um local ideal.|**Objetivos:** Adotar um animal compatível com seu estilo de vida e acessar uma área informativa com dicas sobre cuidados e adoção.| 

| Maria Fernandes   |                                    |                |
|--------------------|------------------------------------|----------------------------------------|
|![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/claralima.png)|**Idade:** 45 anos - **Ocupação:**  Responsável por um abrigo de animais |Aplicativos: Facebook, Whatsapp, Instagram.|
|**Descrição:** Maria administra um abrigo para animais abandonados. Ela é responsável por gerenciar os perfis dos animais no sistema, cadastrar novos animais e responder aos interessados em adoção. Tem pouco tempo disponível e busca um sistema que facilite o gerenciamento das informações e a comunicação com os adotantes. |**Necessidades:** Cadastrar e editar informações sobre os animais disponíveis, receber notificações quando alguém demonstrar interesse em um animal e facilitar a comunicação com adotantes.|**Objetivos:** Promover a adoção dos animais de maneira rápida e eficiente e gerenciar o abrigo e as informações dos animais de forma simples.| 

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
| Jõao Silva| cadastrar-me no site | conseguir acesso a plataforma para adotar.      |
| Jõao Silva| realizar login no site    | conseguir adotar.      |
| Maria Fernandes| cadastrar-me no site | conseguir acesso a plataforma e  mostrar os animais disponiveis.    |
| Maria Fernandes| realizar login no site | conseguir disponibilizar os animais para adoção.   |
| Usuário | visualizar minhas informações cadastradas   |   possibilitar o acesso as minhas informações.    |
| Jõao Silva / Maria Fernandes | de um filtro de busca personalisado       | encontrar rapidamente um animal que atenda às minhas preferências.            |
| Maria Fernandes  | cadastrar animais para adoção    |  possibilitar a adoção dos animais disponíveis e cadastrados       |
| Maria Fernandes  | editar as informações dos meus animais cadastrados |  possibilitar a edição de informações e cadastro.     |
| Jõao Silva| conseguir visualizar os animais disponíveis para adoção e suas caracteristicas   |  conseguir escolher a melhor opção para adoção.      |
| Maria Fernandes| receber notificações quando alguém demonstrar interesse no meu animal cadastrado  |  conseguir contato com o interessado e sanar possiveis dúvidas sobre o animal e a adoção.     |
|  Jõao Silva | demonstrar interesse no animal atráves de um formulário   |  possibilitar o dono de abrigo de animais saber do interesse na adoção.     |
| Usuário | de uma área informativa com conteúdos sobre cuidados com animais e dicas de adoção. |  aumentar o conhecimento sobre o assunto.  |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que o usuário avalie uma agência de intercâmbio com base na sua experiência| ALTA | 
|RF-002| A aplicação deve permitir que o usuário inclua comentários ao fazer uma avaliação de uma agência de intercâmbio    | ALTA |
|RF-003| A aplicação deve permitir que o usuário consulte todas as agências de intercâmbio cadastradas ordenando-as com base em suas notas | ALTA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | MÉDIA | 
|RNF-002| A aplicação deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
