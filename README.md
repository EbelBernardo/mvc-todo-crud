# Projeto ToDo List - ASP.NET MVC

## Descrição

Este é um projeto desenvolvido com ASP.NET MVC, utilizando Entity Framework e SQL Server LocalDB para persistência de dados. A aplicação implementa um CRUD de tarefas, com uma interface simples baseada em Bootstrap.
O objetivo é praticar os fundamentos da arquitetura MVC, manipulação de dados com Entity Framework, e contrução de views com Razor e Data Annotations.

---

## Funcionalidades

- Cadastro de tarefas com título obrigatório
- Marcar e desmarcar tarefas como concluídas
- Exclusão de tarefas com confirmação
- Filtro visual por status (concluída ou pendente)
- Exibição simples e organizada com Bootstrap

---

## Tecnologias Utilizadas
- .NET 8
- ASP.NET MVC
- Entity Framework Core
- SQL Server LocalDB
- C#
- Bootstrap 5
- Razor Views

---

## Como rodar o Projeto

1. Clone este repositório:
   ```bash
   git clone https://github.com/EbelBernardo/mvc-todo-crud.git

2. Navegue até a pasta do projeto
   ```bash
   cd ToDoList-MVC

3. Restaure os pacotes NuGet
   ```bash
   dotnet restore

4. Execute as migrações do Entity Framework Core para criar o banco de dados:
   ```bash
   dotnet ef database update

5. Rode o projeto
   ```bash
   dotnet run

## Estrutura do Projeto
  ```
    /Controllers        - Lógica dos endpoints (TasksController)
    /Models             - Classe de domínio (TaskItem)
    /Data               - AppDbContext com Entity Framework
    /Views/Tasks        - Páginas Razor da aplicação
    /wwwroot            - Arquivos estáticos (CSS, JS, etc)
    /Program.cs         - Inicialização da aplicação
  ```

## Contribuições 
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou pull requests.

## Autor
Bernardo Ebel <br>
[GitHub](https://github.com/EbelBernardo) | [LinkedIn](https://www.linkedin.com/in/bernardo-ebel-743831303/)
