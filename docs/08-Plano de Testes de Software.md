<body>

<h1>Plano de Testes de Software</h1>

<p><span style="color:red">Pré-requisitos:</span> <a href="2-Especificação do Projeto.md">Especificação do Projeto</a>, <a href="3-Projeto de Interface.md">Projeto de Interface</a></p>

<p>Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.</p>

<p>Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto".</p>

<!-- Caso de Teste CT-01 -->
<table>
    <tr>
        <th>**Caso de Teste**</th>
        <th>**CT-01 – Cadastrar perfil**</th>
    </tr>
    <tr>
        <td>Requisito Associado</td>
        <td>RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil.</td>
    </tr>
    <tr>
        <td>Objetivo do Teste</td>
        <td>Verificar se o usuário consegue se cadastrar na aplicação.</td>
    </tr>
    <tr>
        <td>Passos</td>
        <td>- Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar"</td>
    </tr>
    <tr>
        <td>Critério de Êxito</td>
        <td>- O cadastro foi realizado com sucesso.</td>
    </tr>
</table>

<!-- Caso de Teste CT-02 -->
<table>
    <tr>
        <th>**Caso de Teste**</th>
        <th>**CT-02 – Efetuar login**</th>
    </tr>
    <tr>
        <td>Requisito Associado</td>
        <td>RF-00Y - A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail.</td>
    </tr>
    <tr>
        <td>Objetivo do Teste</td>
        <td>Verificar se o usuário consegue realizar login.</td>
    </tr>
    <tr>
        <td>Passos</td>
        <td>- Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login"</td>
    </tr>
    <tr>
        <td>Critério de Êxito</td>
        <td>- O login foi realizado com sucesso.</td>
    </tr>
</table>

<!-- Caso de Teste CT-03 -->
<table>
    <tr>
        <th>**Caso de Teste**</th>
        <th>**CT-03 – Gerenciar salas**</th>
    </tr>
    <tr>
        <td>Requisito Associado</td>
        <td>RF-02 - A aplicação deve permitir que o usuário gerencie as salas disponíveis.</td>
    </tr>
    <tr>
        <td>Objetivo do Teste</td>
        <td>Verificar se o usuário consegue adicionar, editar e remover salas.</td>
    </tr>
    <tr>
        <td>Passos</td>
        <td>- Acessar a funcionalidade "Gerenciar Salas" <br> - Adicionar uma nova sala <br> - Editar as informações da sala <br> - Remover a sala</td>
    </tr>
    <tr>
        <td>Critério de Êxito</td>
        <td>- As operações de adicionar, editar e remover salas são realizadas com sucesso.</td>
    </tr>
</table>

<!-- Caso de Teste CT-04 -->
<table>
    <tr>
        <th>**Caso de Teste**</th>
        <th>**CT-04 – Reservar sala**</th>
    </tr>
    <tr>
        <td>Requisito Associado</td>
        <td>RF-03 - A aplicação deve permitir que o usuário reserve salas para eventos.</td>
    </tr>
    <tr>
        <td>Objetivo do Teste</td>
        <td>Verificar se o usuário consegue reservar uma sala.</td>
    </tr>
    <tr>
        <td>Passos</td>
        <td>- Acessar a funcionalidade "Reservar Sala" <br> - Selecionar uma sala <br> - Escolher o horário e a data <br> - Confirmar a reserva</td>
    </tr>
    <tr>
        <td>Critério de Êxito</td>
        <td>- A sala é reservada com sucesso.</td>
    </tr>
</table>

<!-- Caso de Teste CT-05 -->
<table>
    <tr>
        <th>**Caso de Teste**</th>
        <th>**CT-05 – Cancelar reserva**</th>
    </tr>
    <tr>
        <td>Requisito Associado</td>
        <td>RF-04 - A aplicação deve permitir que o usuário cancele reservas previamente feitas.</td>
    </tr>
    <tr>
        <td>Objetivo do Teste</td>
        <td>Verificar se o usuário consegue cancelar uma reserva.</td>
    </tr>
    <tr>
        <td>Passos</td>
        <td>- Acessar a funcionalidade "Minhas Reservas" <br> - Selecionar a reserva desejada <br> - Confirmar o cancelamento</td>
    </tr>
    <tr>
        <td>Critério de Êxito</td>
        <td>- A reserva é cancelada com sucesso.</td>
    </tr>
</table>

<!-- Caso de Teste CT-06 -->
<table>
    <tr>
        <th>**Caso de Teste**</th>
        <th>**CT-06 – Receber confirmação de reserva**</th>
    </tr>
    <tr>
        <td>Requisito Associado</td>
        <td>RF-05 - A aplicação deve enviar uma notificação ao usuário após a reserva ser confirmada.</td>
    </tr>
    <tr>
        <td>Objetivo do Teste</td>
        <td>Verificar se o usuário recebe uma notificação de confirmação após a reserva.</td>
    </tr>
    <tr>
        <td>Passos</td>
        <td>- Realizar uma reserva <br> - Verificar se a notificação de confirmação é recebida</td>
    </tr>
    <tr>
        <td>Critério de Êxito</td>
        <td>- A notificação de confirmação é recebida com sucesso.</td>
    </tr>
</table>

<!-- Caso de Teste CT-07 -->
<table>
    <tr>
        <th>**Caso de Teste**</th>
        <th>**CT-07 – Editar perfil**</th>
    </tr>
    <tr>
        <td>Requisito Associado</td>
        <td>RF-06 - A aplicação deve permitir que o usuário edite seu perfil.</td>
    </tr>
    <tr>
        <td>Objetivo do Teste</td>
        <td>Verificar se o usuário consegue editar seu perfil.</td>
    </tr>
    <tr>
        <td>Passos</td>
        <td>- Acessar a funcionalidade "Meu Perfil" <br> - Editar as informações desejadas <br> - Confirmar as alterações</td>
    </tr>
    <tr>
        <td>Critério de Êxito</td>
        <td>- As alterações no perfil são salvas com sucesso.</td>
    </tr>
</table>

<!-- Caso de Teste CT-08 -->
<table>
    <tr>
        <th>**Caso de Teste**</th>
        <th>**CT-08 – Visualizar disponibilidade**</th>
    </tr>
    <tr>
        <td>Requisito Associado</td>
        <td>RF-07 - A aplicação deve mostrar a disponibilidade das salas para reserva.</td>
    </tr>
    <tr>
        <td>Objetivo do Teste</td>
        <td>Verificar se o usuário consegue visualizar a disponibilidade das salas.</td>
    </tr>
    <tr>
        <td>Passos</td>
        <td>- Acessar a funcionalidade "Disponibilidade" <br> - Selecionar a data desejada <br> - Verificar as salas disponíveis</td>
    </tr>
    <tr>
        <td>Critério de Êxito</td>
        <td>- A disponibilidade das salas é exibida corretamente.</td>
    </tr>
</table>

<!-- Caso de Teste CT-09 -->
<table>
    <tr>
        <th>**Caso de Teste**</th>
        <th>**CT-09 – Receber notificação de cancelamento**</th>
    </tr>
    <tr>
        <td>Requisito Associado</td>
        <td>RF-08 - A aplicação deve enviar uma notificação ao usuário após o cancelamento da reserva.</td>
    </tr>
    <tr>
        <td>Objetivo do Teste</td>
        <td>Verificar se o usuário recebe uma notificação de cancelamento após cancelar uma reserva.</td>
    </tr>
    <tr>
        <td>Passos</td>
        <td>- Cancelar uma reserva <br> - Verificar se a notificação de cancelamento é recebida</td>
    </tr>
    <tr>
        <td>Critério de Êxito</td>
        <td>- A notificação de cancelamento é recebida com sucesso.</td>
    </tr>
</table>

<!-- Caso de Teste CT-10 -->
<table>
    <tr>
        <th>**Caso de Teste**</th>
        <th>**CT-10 – Visualizar histórico de reservas**</th>
    </tr>
    <tr>
        <td>Requisito Associado</td>
        <td>RF-09 - A aplicação deve permitir que o usuário visualize seu histórico de reservas.</td>
    </tr>
    <tr>
        <td>Objetivo do Teste</td>
        <td>Verificar se o usuário consegue visualizar seu histórico de reservas.</td>
    </tr>
    <tr>
        <td>Passos</td>
        <td>- Acessar a funcionalidade "Meu Histórico" <br> - Verificar as reservas realizadas anteriormente</td>
    </tr>
    <tr>
        <td>Critério de Êxito</td>
        <td>- O histórico de reservas é exibido corretamente.</td>
    </tr>
</table>

</body>

> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> - [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
