Overview
This is a technical assessment task demonstrating a complete User Management System built with ASP.NET Core MVC. The project focuses on clean architecture, the Service Layer pattern , and robust authentication.


🛠 Tech Stack

Framework: .NET 8 (ASP.NET Core MVC).


Database: Entity Framework Core with SQLite (for portability).


Architecture: Service Layer Pattern (Abstraction).


Authentication: Cookie-based Authentication.

✨ Key Features

Authentication Module: 

Secure Login using LoginViewModel.

Validation for active users only (IsActive check).

Session management via Cookies.

User Management (CRUD): 

Create: Add new users with full validation.

Read: List all users in a responsive table.

Update: Edit existing user details.


Delete: Remove users from the system.

Validation & Error Handling: 

Server-side validation using Data Annotations.

Unified error handling in the Service Layer.

🏗 Architecture Highlights
To meet the requirement of "Architecture and code clarity", I implemented:

Model-View-Controller (MVC): For clear separation of UI and Logic.

Service Layer (Abstraction): Decoupled the Business Logic from Controllers using IUserService and UserService.

ViewModels: Used specific models for Login to ensure better data handling and security.
