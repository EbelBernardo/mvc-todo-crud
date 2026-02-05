# Task Management System - ASP.NET MVC

Task management web application developed in ASP.NET MVC, using Entity Framework Core and SQL Server LocalDB for data persistence.

The project implements a CRUD workflow for managing tasks, with server-side validation, UI state management and persistence.
It focuses on applying MVC architecture, domain modeling and backend-driven UI rendering.

---

## 🎯 Purpose

This project was developed for educational purposes to practice and consolidate key backend and web development concepts, including:

- Building MVC-based web applications in ASP.NET
- Implementing CRUD operations with persistence
- Applying server-side validation with Data Annotations
- Managing application state (completed vs pending tasks)
- Structuring a project using separation of concerns
- Integrating controllers, database and Razor views

---

## 🛠 Technologies Used

- C#
- .NET 8
- ASP.NET MVC
- Entity Framework Core
- SQL Server LocalDB
- Bootstrap 5
- Razor Views

---

## 📁 Project Structure

   ```
      /Controllers
        TasksController   → Handles HTTP requests and application flow
      /Models
        TaskItem          → Domain entity representing a task
      /Data
        AppDbContext      → Entity Framework Core database context
      /Views/Tasks
        Razor pages for task management
      /wwwroot
        Static assets (CSS, JS, etc.)
      /Program.cs
        Application bootstrap and configuration
   ```

## 🚀 Running the Project 

Clone the repository
   ```
      git clone https://github.com/EbelBernardo/mvc-todo-crud.git
   ```

Navigate to the project folder
   ```
      cd ToDoList-MVC
   ```

Restore NuGet packages
   ```
      dotnet restore
   ```

Apply Entity Framework migrations
   ```
      dotnet ef database update
   ```

Run the application
   ```
      dotnet run
   ```

---

## 🧩 Core Features

- Create tasks with required title validation
- Mark and unmark tasks as completed
- Delete tasks with confirmation
- Visual filtering by task status
- Clean and responsive UI with Bootstrap

---

## 🧠 Architecture

- The application follows the ASP.NET MVC pattern:
- Models represent the domain and database entities
- Controllers handle HTTP requests and orchestrate business logic
- Views render the UI using Razor
- Entity Framework Core is used to persist task data, allowing the application state to survive restarts and enabling a real database-backed workflow.

---

## 📌 Project Status

✔️ Completed for study and learning purposes.

---

## 📄 License

This project is free to use for educational purposes.

---

## 👤 Autor
Bernardo Ebel <br>
[GitHub](https://github.com/EbelBernardo) | [LinkedIn](https://www.linkedin.com/in/bernardo-ebel-743831303/)

--- 

## 🧠 Final Note

This project represents a practical study of backend-driven web applications using ASP.NET MVC, focusing on persistence, validation, and architectural organization rather than just UI.
