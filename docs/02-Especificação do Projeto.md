# Especificações do Projeto

<table>
    <tbody>
        <tr align=center>
            <th colspan="2">Perfil 1: Administrador dos Espaços / Dono das Salas</th>
        </tr>
        <tr>
            <td width="150px"><b>Descrição</b></td>
            <td width="600px">Responsável pela gestão dos espaços de coworking e salas de reunião. Este perfil pode pertencer ao proprietário dos espaços ou a um gestor designado para administrar o uso, manutenção e a rentabilidade das salas. O administrador tem a responsabilidade de gerenciar a disponibilidade das salas, processar reservas, lidar com pagamentos e manter a qualidade do ambiente para os usuários.</td>
        </tr>
        <tr>
            <td><b>Necessidades</b></td>
            <td>
                <ol>
                    <li>Autenticar no sistema.</li>
                    <li>Gerenciar a disponibilidade das salas (reservas, horários, manutenção).</li>
                    <li>Informar pagamento da sala no sistema.</li>
                    <li>Gerenciar o sistema de pagamento diferido, garantindo que os valores sejam descontados no dia da reserva.</li>
                    <li>Gerenciar a comunicação com os usuários (avisos sobre regras, manutenção, etc).</li>
                    <li>Personalizar o ambiente e as regras de uso das salas.</li>
                    <li>Acompanhar o feedback dos usuários para melhorias.</li>
                </ol> 
            </td>
        </tr>
    </tbody>
</table>

<table>
    <tbody>
        <tr align=center>
            <th colspan="2">Perfil 2: Usuário Final</th>
        </tr>
        <tr>
            <td width="150px"><b>Descrição</b></td>
            <td width="600px">Profissionais, empresas ou freelancers que necessitam alugar salas de coworking ou reuniões por períodos específicos. Este perfil representa o cliente que busca um espaço para trabalhar ou realizar reuniões, com a expectativa de facilidade na reserva, conforto e qualidade do ambiente.</td>
        </tr>
        <tr>
            <td><b>Necessidades</b></td>
            <td>
                <ol>
                    <li>Autenticar no sistema.</li>
                    <li>Visualizar a disponibilidade das salas e escolher a mais adequada. </li>
                    <li>Reservar salas para períodos específicos.</li>
                    <li>Realizar cadastro de cartão de crédito como forma de pagamento.</li>
                    <li>Receber confirmações de reservas (voucher).</li>
                    <li>Visualizar e gerenciar suas reservas (alterações, cancelamentos).</li>
                    <li>Avaliar as salas e serviços após o uso.</li>
                    <li>Receber suporte em caso de problemas ou dúvidas.</li>
                </ol> 
            </td>
        </tr>
    </tbody>
</table>

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas nas tabelas que se seguem:

<table>
    <thead>
        <tr>
            <th>Persona</th>        
            <th>1</th>              
        </tr>
    </thead>
    <tbody>
     <tr>
            <td>João</td>
            <td></td>
        </tr>
     <tr>
            <td>Idade: 35 anos</td>
            <td>Ocupação: Gerente de Projetos em uma empresa de tecnologião</td>
        </tr>
        <tr>
            <td>Objetivos: João precisa frequentemente reservar salas para reuniões de equipe, apresentações para clientes e sessões de planejamento de projetos. Ele valoriza a facilidade e rapidez na reserva e precisa de ferramentas para agendar reuniões recorrentes.</td>
            <td>Frustrações: Encontrar salas disponíveis em horários de pico e a dificuldade de gerenciar alterações de última hora nas reservas.</td>
        </tr>
        <tr>
            <td>Tecnologia: Usuário avançado de ferramentas de produtividade, usa principalmente o computador para gerenciar seu trabalho.</td>
            <td>Necessidades: Notificações de alterações nas reservas, integração com calendário, e opção de reserva antecipada.</td> 
        </tr>
    </tbody>
</table>



<table>
    <thead>
        <tr>
            <th>Persona</th>        
            <th>2</th>              
        </tr>
    </thead>
    <tbody>
     <tr>
            <td>Mariana</td>
            <td></td>
        </tr>
     <tr>
            <td>Idade: 22 anos</td>
            <td>Ocupação: Estudante de engenharia</td>
        </tr>
        <tr>
            <td>Objetivos: Mariana precisa reservar salas de estudo para trabalhos em grupo, sessões de revisão antes de provas, e apresentações de projetos. Ela valoriza a disponibilidade de salas silenciosas e bem equipadas.</td>
            <td>Frustrações: Dificuldade em encontrar salas disponíveis durante a época de provas e em locais próximos ao campus.</td>
        </tr>
        <tr>
            <td>Tecnologia: Usuária de smartphone, utiliza o sistema principalmente por aplicativos móveis.</td>
            <td>Necessidades: Interface intuitiva, fácil navegação, opção de busca por proximidade e disponibilidade em tempo real.</td>
        </tr>
    </tbody>
</table>



<table>
    <thead>
        <tr>
            <th>Persona</th>        
            <th>3</th>              
        </tr>
    </thead>
    <tbody>
     <tr>
            <td>Carlos</td>
            <td></td>
        </tr>
     <tr>
            <td>Idade: 28 anos</td>
            <td>Ocupação: Designer Gráfico Freelancer</td>
        </tr>
        <tr>
            <td>Objetivos: Carlos precisa de um espaço para trabalhar em projetos de design, realizar videochamadas com clientes, e conduzir workshops. Ele valoriza salas com boa iluminação e equipamento audiovisual de qualidade.</td>
            <td>Frustrações: Dificuldade em encontrar salas equipadas e problemas com a qualidade da conexão de internet nas salas.</td>
        </tr>
        <tr>
            <td>Tecnologia: Usuário de laptop e smartphone, utiliza o sistema em ambas as plataformas.</td>
            <td>Necessidades: Filtragem de salas por equipamentos disponíveis, acesso fácil ao histórico de reservas e suporte a reservas de última hora.</td>
        </tr>
    </tbody>
</table>


<table>
    <thead>
        <tr>
            <th>Persona</th>        
            <th>4</th>              
        </tr>
    </thead>
    <tbody>
     <tr>
            <td>Ana</td>
            <td></td>
        </tr>
     <tr>
            <td>Idade: 42 anos</td>
            <td>Ocupação: Secretária Executiva em uma empresa de consultoria</td>
        </tr>
        <tr>
            <td>Objetivos: Ana é responsável por agendar reuniões para os executivos da empresa, coordenar videoconferências, e garantir que as salas estejam preparadas para eventos. Ela precisa de um sistema confiável que permita gerenciar várias reservas ao mesmo tempo.</td>
            <td>Frustrações: Inconsistências na disponibilidade das salas e falta de informações detalhadas sobre os recursos das salas.</td>
        </tr>
        <tr>
            <td>Tecnologia: Usuária de desktop, usa o sistema principalmente em um computador no escritório.</td>
            <td>Necessidades: Acesso rápido a todas as reservas, opção de gerenciamento de múltiplas reservas e notificações para atualizações de última hora.</td>
        </tr>
    </tbody>
</table>



<table>
    <thead>
        <tr>
            <th>Persona</th>        
            <th>5</th>              
        </tr>
    </thead>
    <tbody>
     <tr>
            <td>Lucas</td>
            <td></td>
        </tr>
     <tr>
            <td>Idade: 45 anos</td>
            <td>Ocupação: Pesquisador em uma universidade</td>
        </tr>
        <tr>
            <td>Objetivos: Lucas precisa de salas para conduzir seminários, grupos de discussão e reuniões com colaboradores de pesquisa. Ele valoriza a privacidade e a disponibilidade de recursos para apresentações acadêmicas.</td>
            <td>Frustrações: Concorrência pelas salas de seminários e dificuldade em agendar salas para períodos prolongados.</td>
        </tr>
        <tr>
            <td>Tecnologia: Usuário de laptop e tablet, prefere usar o sistema em dispositivos que possa levar para suas reuniões.</td>
            <td>Necessidades: Reserva de longos períodos, opção de bloqueio de horário para atividades contínuas, e filtragem de salas por recursos específicos.</td>
        </tr>
    </tbody>
</table>

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|João       | Como gerente de projetos, preciso reservar salas de reunião de forma rápida e eficiente.Ele deseja receber notificações sobre alterações nas reservas e integrar essas reservas com seu calendário para melhor organização.                  | Garantir que sua equipe tenha um espaço adequado para reuniões de planejamento e apresentações para clientes. |
|Mariana       | Precisa reservar salas de estudo silenciosas e bem equipadas.                 | Para trabalhos em grupo e sessões de revisão antes das provas. |
|Carlos       | Precisa de um espaço de trabalho com boa iluminação e equipamento audiovisual de qualidade.                  | Para realizar videochamadas com clientes e conduzir workshops. |
|Ana       | Precisa agendar reuniões para os executivos da empresa e coordenar videoconferências.                  | Garantir que as salas estejam preparadas para eventos. Ela quer um sistema confiável que permita gerenciar múltiplas reservas ao mesmo tempo e receber notificações para atualizações de última hora |
|Lucas       | Precisa reservar salas para seminários, grupos de discussão e reuniões com colaboradores de pesquisa.                  | Ele valoriza a privacidade e a disponibilidade de recursos para apresentações acadêmicas e deseja reservar salas por longos períodos. |



Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

<table>
    <thead>
        <tr>
            <th>ID</th>        
            <th>Descrição</th>        
            <th>Prioridade</th>        
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>RF- 01</td>
            <td>Desenvolver tela de Login com módulo de autênticação.</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RF- 02</td>
            <td>Desenvolver tela de gerenciamento de Salas, permitindo cadastro, edição, visualização e exclusão de informações.</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RF- 03</td>
            <td>Desenvolver tela para visualização da disponibilidade das salas em tempo real pelos usuários finais.</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RF- 04</td>
            <td>Desenvolver tela para realização de reservas de salas para períodos específicos, com confirmação imediata.</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RF- 05</td>
            <td>Desenvolver tela para cadastro de cartão de crédito para pagamento diferido no dia da reserva pelos usuários finais.</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RF- 06</td>
             <td>Desenvolver funcionalidade para processamento automático de pagamentos no dia da reserva, debitando o valor do cartão cadastrado.</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RF- 07</td>
            <td>Desenvolver tela de Usuários, permitindo cadastro, edição, visualização e exclusão de perfis.</td>
            <td>Média</td>
        </tr>
        <tr>
            <td>RF- 08</td>
            <td>Desenvolver tela para que administradores possam cancelar reservas e notificar usuários sobre o cancelamento.</td>
            <td>Média</td>
        </tr>
        <tr>
            <td>RF- 09</td>
            <td>Desenvolver funcionalidade para envio de notificações de confirmação de reservas para os usuários finais.</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RF- 10</td>
            <td>Desenvolver tela que permita aos usuários alterarem ou cancelarem suas reservas com um prazo determinado antes da data da reserva.</td>
            <td>Alta</td>
        </tr>
    </tbody>
</table>


### Requisitos não Funcionais

<table>
    <thead>
        <tr>
            <th>ID</th>        
            <th>Descrição</th>        
            <th>Prioridade</th>        
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>RNF-01</td>
            <td>Desenvolver mecanismos para garantir a segurança dos dados dos usuários.</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RNF-02</td>
            <td>Desenvolver interface do usuário intuitiva e de fácil utilização.</td>
            <td>Média</td>
        </tr>
        <tr>
            <td>RNF-03</td>
            <td>Desenvolver sistema compatível com diferentes dispositivos e navegadores web.</td>
            <td>Média</td>
        </tr>
        <tr>
            <td>RNF-04</td>
            <td>Desenvolver código bem estruturado e documentado para fácil manutenção.</td>
            <td>Média</td>
        </tr>
    </tbody>
</table>

**Prioridade: Alta / Média / Baixa. 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

<table>
    <thead>
        <tr>
            <th>ID</th>        
            <th>Descrição</th>              
        </tr>
    </thead>
    <tbody>
     <tr>
            <td> RE-01</td>
            <td>A aplicação deve ser entregue de forma plenamente funcional até 08/12/2024.</td>
     </tr>
     <tr>
            <td> RE-02</td>
            <td>Cada integrante da equipe ficará responsável pelo desenvolvimento completo (Back-End e Front-End) das funcionalidades pelas quais ficou responsável.</td>
     </tr>
    </tbody>
</table>

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
