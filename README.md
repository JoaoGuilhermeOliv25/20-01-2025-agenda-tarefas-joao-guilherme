# Agenda Tarefas 
### Aplicativo desktop desenvolvido para aplicação prática de conceitos de Arquitetura de Software, separação de responsabilidades e boas práticas de desenvolvimento.

### Tecnologias Utilizadas
 - **C#** - Linguagem principal
 - **.NET** - Plataforma de desenvolvimento
 - **Windows Forms** - Interface gráfica desktop
 - **SQLite** - Banco de dados relacional embarcado
 - **Visual Studio 2022** - Ambiente de desenvolvimento
 - **Arquitetura em Camadas** - Separação de responsabilidades (UI, Services e Repository)
 - **Registro do Windows** (inicialização automática)

### Visão Geral
O **Agenda Tarefas** é uma aplicação desktop para gerenciamento simples de tarefas, com persistência local em banco de dados SQLite.

O projeto foi desenvolvido com o objetivo de simular um cenário real de software, aplicando conceitos como:
Separação de responsabilidades
Organização em camadas
Persistência desacoplada da interface
Gerenciamento de configurações via arquivo JSON
Armazenamento seguro de dados em AppData
Inicialização automática com o Windows

### Interface

<img width="1577" height="1016" alt="AgendaTarefa_print" src="https://github.com/user-attachments/assets/8671d5fc-368b-445b-80ea-858a28aa948d" />

### Funcionalidades
 - Cadastro de tarefas
 - Listagem de tarefas
 - Exclusão de tarefas
 - Persistência em banco SQLite
 - Criação automática do banco de dados
 - Configuração salva em arquivo JSON
 - Opção de iniciar com o Windows

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
O sistema utiliza o **SQLite**, um banco de dados relacional embarcado, ideal para aplicações desktop leves. 
 - Banco criado localmente
 - Persistência automática das tarefas
 - Integração direta com C# através de biblioteca específica

### Requisistos para Execução
 - Windows
 - .NET Framework compatível com o projeto(v4.8)
 - Visual Studio (recomendado para execução e edição do código)

### Como Executar o Projeto
 1. Clone o repositório do projeto:
```git clone https://github.com/JoaoGuilhermeOliv25/20-01-2025-agenda-tarefas-joao-guilherme.git```
 2. Abra a solução (AgendaTarefas.sln) no Visual Studio
 3. Restaure as dependências se nescessário
 4. Compile e execute o projeto

### Autor
**João Guilherme de Oliveira**

Projeto desenvolvido para fins educacionais e construção de portfólio em desenvolvimento de software.



