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

Identifique, em torno de, 5 personas. Para cada persona, lembre-se de descrever suas angústicas, frustrações e expectativas de vida relacionadas ao problema. Além disso, defina uma "aparência" para a persona. Para isso, você poderá utilizar sites como [https://this-person-does-not-exist.com/pt#google_vignette](https://this-person-does-not-exist.com/pt) ou https://thispersondoesnotexist.com/ 

Utilize também como referência o exemplo abaixo:

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/IntApplicationProject-Template/blob/main/docs/img/AnaClara1.png" alt="Persona1"/>

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> 
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

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
            <td>Deve ter uma tela de Login com distinção de perfil do usuário (Administrador dos Espaços e Usuário Final).</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RF- 02</td>
            <td>CRUD de Salas (Deve ser possível cadastrar, editar, visualizar e excluir informações sobre as salas).</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RF- 03</td>
            <td>Usuários finais devem conseguir visualizar a disponibilidade das salas em tempo real.</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RF- 04</td>
            <td>Deve ser possível realizar reservas de salas para períodos específicos, com confirmação imediata.	</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RF- 05</td>
            <td>Usuários finais devem poder cadastrar um cartão de crédito para pagamento diferido no dia da reserva.</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RF- 06</td>
            <td>O sistema deve processar automaticamente os pagamentos no dia da reserva, debitando o valor do cartão cadastrado.</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RF- 07</td>
            <td>CRUD de Usuários (Deve ser possível cadastrar, editar, visualizar e excluir perfis de usuários).</td>
            <td>Média</td>
        </tr>
        <tr>
            <td>RF- 08</td>
            <td>Administradores devem poder cancelar reservas e notificar usuários sobre o cancelamento.</td>
            <td>Média</td>
        </tr>
        <tr>
            <td>RF- 09</td>
            <td>O sistema deve enviar notificações de confirmação e lembretes de reservas para os usuários finais.</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RF- 10</td>
            <td>O sistema deve permitir que os usuários alterem ou cancelem suas reservas com um prazo determinado antes da data da reserva.</td>
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
            <td>O sistema deve garantir a segurança dos dados dos alunos e usuários</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RNF-02</td>
            <td>A interface do usuário deve ser intuitiva e de fácil utilização</td>
            <td>Média</td>
        </tr>
        <tr>
            <td>RNF-03</td>
            <td>O sistema deve ser compatível com diferentes dispositivos e navegadores web</td>
            <td>Alta</td>
        </tr>
        <tr>
            <td>RNF-04</td>
            <td>O código deve ser bem estruturado e documentado para fácil manutenção.</td>
            <td>Alta</td>
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
