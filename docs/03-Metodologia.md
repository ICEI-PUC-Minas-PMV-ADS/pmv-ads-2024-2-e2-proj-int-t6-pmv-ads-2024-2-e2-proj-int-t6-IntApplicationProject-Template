
# Metodologia

A seguir, descrevemos a metodologia escolhida pela equipe para a criação de um sistema de agendamento de salas para coworking e reuniões. Além disso, detalhamos as ferramentas e os ambientes de trabalho empregados durante o desenvolvimento do projeto. Incluímos uma explicação sobre os diversos ambientes utilizados e a estrutura para a gestão do código-fonte. Também discutimos o processo e os recursos usados para organizar e coordenar o time de desenvolvimento.

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `instável`: versão já testada do software, porém instável
- `teste`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

A branch main é reservado para versões prontas para produção, enquanto a branch dev contém versões em desenvolvimento que ainda estão sujeitas a testes. A branch teste é usado para realizar testes nos códigos antes da produção. Se problemas forem detectados, as correções são aplicadas isoladamente na branch instável para estabilizar a versão antes de entrar em produção.


## Gerenciamento de Projeto

### Divisão de Papéis

A divisão de papéis do grupo baseada na divisão SCRUM (Scrum Master, Product Owner, Equipe de Desenvolvimento e Equipe de Design) da seguinte forma:
<ul>
<li>Scrum Master: Marcelly Thais Freitas Neves;</li>
<li>Product Owner: Fernando Vinicius Sousa Moura;</li>
<li>Equipe de Desenvolvimento: Kevin Lucas Andrade Dos Santos, Brena Aparecida Ferreira e Farley Rodrigues De Souza;</li>
<li>Equipe de Design: Caio de Souza Araujo.</li>
</ul>


### Processo

Para organização e distribuição das tarefas do projeto, a equipe está utilizando o Trello, estruturado com as seguintes listas:
<ul>
<li>Product Backlog: recebe as tarefas a serem trabalhadas e representa o Backlog do produto. Todas as atividades identificadas no decorrer do projeto são incorporadas a esta lista. </li>
<li>To do: esta lista representa o Sprint Backlog que está sendo trabalhado.</li>
<li>In progress: lista das tarefas iniciadas.</li>
<li>Done: nesta lista são colocadas as tarefas finalizadas.</li>
</ul>
O quadro kanban do grupo no Trello está presente no link: https://trello.com/b/qLCwklTt/projeto-office-roomie e está apresentado no estado atual da seguinte forma:

![Imagem Kanban](img/Kanban.PNG)



### Ferramentas

<div align="justify">
As ferramentas empregadas no projeto são:
<br/><br/>
  
+  Editor de código;
+  Ferramentas de comunicação;
+  Ferramentas de desenho de tela (figma);

O editor de código foi escolhido porque ele possui uma integração com o sistema de versão. As ferramentas de comunicação utilizadas possuem integração semelhante e por isso foram selecionadas. Por fim, para criar diagramas utilizamos essa ferramenta por melhor captar as necessidades da nossa solução.
<br/><br/>
Os artefatos do projeto são desenvolvidos a partir das plataformas GitHub, Trello e Figma, apresentadas com seu propósito na tabela que se segue.
<br/><br/>

| Ambiente | Plataforma | Link de acesso | 
|:--------------------|:---------------------|:--------------------|
| Repositório de código fonte | GitHub |https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t6-officeroomie.git |
| Documentos do projeto | GitHub | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-2-e2-proj-int-t6-officeroomie/tree/main/docs |
| Projeto de interface e wireframes | Figma | https://www.figma.com/design/RFnGBlg7dOkRw1XzQqsUdR/Projeto---Sala-de-Reuni%C3%A3o |
| Gerenciamento do projeto | Trello | https://trello.com/b/qLCwklTt/projeto-office-roomie |
<br/>
</div>
