📘 ADO.NET Employee Management System
📌 Project Overview

This is a Console Application built using C# and ADO.NET that connects to SQL Server (SQLEXPRESS) to perform database operations.

The project demonstrates:

Database connectivity using SqlConnection
CRUD Operations (Create, Read, Update, Delete)
Use of SqlCommand
Working with SqlDataReader
Connection string configuration
Basic repository pattern (EmpRepo)



🛠 Technologies Used

C#
.NET Framework / .NET
ADO.NET
SQL Server Express
SQL Server Management Studio (SSMS)



🗄 Database Setup
1️⃣ Install SQL Server Express (if not installed)

Ensure SQL Server (SQLEXPRESS) is running.

2️⃣ Create Database

Run this in SSMS:

CREATE DATABASE sharanya;
GO

USE sharanya;

CREATE TABLE Employee (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Salary DECIMAL(10,2),
    Department NVARCHAR(100)
);




🔌 Connection String

Make sure your connection string is:

"Data Source=DESKTOP-B87N1ET\\SQLEXPRESS;
 Initial Catalog=sharanya;
 Integrated Security=True;"


⚠ Make sure:

SQL Server service is running
Database name matches exactly
Integrated Security has a space

📂 Project Structure
ADO.NET/
│
├── Program.cs        → Entry point
├── EmpRepo.cs        → Database logic (CRUD)
├── App.config        → Connection string
└── README.md



🚀 How to Run the Project

Open solution in Visual Studio
Ensure SQL Server (SQLEXPRESS) is running
Verify connection string
Build the solution
Run the project


📈 Next Steps (How to Move Forward)
Here’s how you should continue improving this project:



✅ Phase 1 – Complete CRUD

Insert Employee
View All Employees
Update Employee
Delete Employee





✅ Phase 2 – Improve Code Structure

Move connection string to App.config
Use using statements for connections
Add exception handling (try-catch)
Separate model class (Employee.cs)


✅ Phase 3 – Advanced ADO.NET Concepts

Use SqlDataAdapter
Work with DataSet
Implement transactions
Implement Stored Procedures

Example stored procedure:

CREATE PROCEDURE GetAllEmployees
AS
BEGIN
    SELECT * FROM Employee;
END



✅ Phase 4 – Convert to Layered Architecture

Structure like this:

Presentation Layer
Business Layer
Data Access Layer



✅ Phase 5 – Upgrade to ASP.NET Core (Optional)

Once comfortable:
Convert to Web API
Connect frontend
Implement Dependency Injection
Use Entity Framework Core



🧠 Learning Goals

After completing this project, you should understand:
How ADO.NET works internally
Connection lifecycle
Command execution types
Reader vs Adapter
SQL Server connectivity issues



🐞 Common Errors & Fixes


| Error                 | Reason                  | Fix                       |
| --------------------- | ----------------------- | ------------------------- |
| Keyword not supported | Wrong connection string | Use correct keywords      |
| Login failed          | Authentication issue    | Check Integrated Security |
| Cannot open database  | DB doesn't exist        | Create DB in SSMS         |
| Network-related error | SQL service stopped     | Start SQLEXPRESS service  |




📌 Author

Sharanya
Learning ADO.NET and SQL Server 🚀
