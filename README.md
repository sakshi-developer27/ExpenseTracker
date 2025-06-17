# ExpenseTracker
Expense Management System – API Based Application

📄 Description:
The Expense Management System is a backend API application developed using ASP.NET Core and SQL Server, designed to help users efficiently manage their personal or business finances. The system allows users to record income and expenses, categorize them, and generate meaningful financial insights through summaries and reports.

This project demonstrates core principles of RESTful API design, data modeling, and server-side development, making it ideal for learning or showcasing real-world backend development skills.

🎯 Core Objectives:
- Track and manage financial transactions (both income and expenses)
- Categorize transactions (e.g., Food, Rent, Salary, Utilities)
- View financial summaries such as total income, total expenses, and balance
- Perform CRUD operations on transaction data
- Enable filtering by date, type, or category for reporting

⚙️ Technology Stack:
- Backend Framework: ASP.NET Core Web API
- Database: SQL Server (Entity Framework Core for ORM)
- Language: C#
- Architecture: RESTful services
- Optional Tools: Swagger for API testing,JWT for authentication

📦 Key Features:
 User Management
- Register/Login (with JWT Authentication)
- Each user's data is isolated

Transaction Management
- Add, view, update, and delete income or expense entries
- Add description, category, date, and amount for each transaction

Category Management
- Define custom categories (e.g., Groceries, Bills, Transport)
- Assign transactions to categories

Financial Summary
-Total income, total expense, and remaining balance
-Monthly breakdown and top spending categories

Filtering & Reporting
- Filter transactions by date range, category, or type
- Generate summaries for specific months
