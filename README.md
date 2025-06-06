# Employee WebApp

This is an ASP.NET Core MVC web application for managing employee data.

## Features

- List, add, edit, and delete employees
- Uses Entity Framework Core for data access
- Bootstrap for responsive UI
- Seed data for initial employees

## Project Structure

- `Controllers/` - MVC controllers (e.g., EmployeeController)
- `Models/` - Entity and DbContext classes
- `Views/` - Razor views for UI
- `Migrations/` - Entity Framework Core migrations
- `wwwroot/` - Static files (CSS, JS, libraries)

## Getting Started

1. **Restore dependencies**
   ```
   dotnet restore
   ```

2. **Apply migrations and update the database**
   ```
   dotnet ef database update
   ```

3. **Run the application**
   ```
   dotnet run
   ```

4. Open your browser and navigate to `https://localhost:5001` (or the URL shown in the console).

## Requirements

- [.NET Core SDK 3.1 or later](https://dotnet.microsoft.com/download)
- SQL Server (or change connection string in `appsettings.json`)

## License

This project uses open source libraries such as Bootstrap and jQuery. See the `wwwroot/lib` directory for their licenses.
