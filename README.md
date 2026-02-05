# Agenda Tarefas 
### Aplicativo desktop desenvolvido para aplicação prática de conceitos de Arquitetura de Software

### Tecnologias Utilizadas
 - **C#** - Linguagem principal
 - **.NET** - Plataforma de desenvolvimento
 - **Windows Forms** - Interface gráfica desktop
 - **SQLite** - Banco de dados relacional embarcado
 - **Visual Studio 2022** - Ambiente de desenvolvimento
 - **Arquitetura em Camadas** - Separação de responsabilidades (UI, Services e Repository) 

### Imagem do Aplicativo
O Agenda Tarefas é um aplicativo desktop desenvolvido com o objetivo de aplicar, na prática, conceitos teóricos de Arquitetura de Software, organização em camadas e boas práticas de programação.

<img width="1582" height="1020" alt="print1" src="https://github.com/user-attachments/assets/fc30166a-2668-4f90-9689-32c09b108cae" />

### Objetivo do Projeto
O projeto Agenda Tarefas foi desenvolvido com foco educacional e prático, com o objetivo de consolidar conhecimentos em desenvolvimento desktop utilizando C#, persistência de dados com SQLite e aplicação de uma arquitetura em camadas.
A aplicação busca simular um cenário real de software, priorizando organização, separação de responsabilidades e manutenção do código.

### Funcionalidades
 - Criação de tarefas com persistência em banco de dados SQLite
 - Exclusão de tarefas cadastradas
 - Listagem de tarefas armazenadas
 - Interface gráfica simples e objetiva
 - Organização do código seguindo arquitetura em camadas

**Observação:** o projeto está em constante evolução e novas funcionalidades podem ser adicionadas futuramente.


### Arquitetura do Projeto
 - **UI (Interface do Usuário)** - Responsável pela interação com o usuário através dos formulários Windows Forms.
 - **Services** - Camada intermediária que concentra regras de negócio e validações.
 - **Repository (DAL)** - Responsável pelo acesso aos dados e comunicação direta com o banco SQLite.

Essa separação evita acoplamento excessivo e facilita futuras manutenções ou evoluções do sistema.


### Banco de Dados
