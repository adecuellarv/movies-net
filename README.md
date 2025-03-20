# C# Application with SQL Server and REST API

## Prerequisites

Before setting up the project, ensure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download) (8.0) or higher
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

## Setup Instructions

### 1. Clone the repository
```sh
git https://github.com/adecuellarv/movies-net.git
cd Solution
```

### 2. Install NuGet Packages (if not installed)
The project requires the following NuGet packages:
```sh
- cd .\WebApplication1
- dotnet add package Microsoft.EntityFrameworkCore.SqlServer
- dotnet add package Microsoft.EntityFrameworkCore.Tools
```

Alternatively, restore all dependencies:
```sh
dotnet restore
```

### 3. Configure the Database
1. Create a new SQL Server database.
2. Update the connection string in `appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DATABASE;User Id=YOUR_USER;Password=YOUR_PASSWORD;"
}
```

### 4. Apply Migrations
Run the following command to apply the migrations:
```sh
dotnet ef database update
```
This will create the necessary tables in your database.

### 5. Seed Initial Data
If the repository contains a SQL script with sample data, execute it in your SQL Server:
1. Open SSMS or any SQL tool.
2. Execute the scripts `actors_data.sql` `category_data.sql` `movies_data.sql` to populate initial data.

### 6. Run the Application
Start the application using:
```sh
dotnet run
```
The API will be available at `https://localhost:5054` or `http://localhost:7037`.

### 7. API Endpoints
The application exposes REST API endpoints.
- `https://localhost:7037/api/categories`
- `https://localhost:7037/api/actors`
- `https://localhost:7037/api/movies`
- `https://localhost:7037/api/movies?actor=category=`


## Additional Notes
- If you modify the database models, run:
```sh
dotnet ef migrations add MigrationName
```
and then update the database with:
```sh
dotnet ef database update
```
- Ensure your firewall allows connections to SQL Server if accessing remotely.

---
This should provide a clear guide for setting up and running your C# application. Let me know if you need adjustments! 🚀

