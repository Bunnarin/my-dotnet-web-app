# MyWebApp - A Simple Book Management Application

This is a basic web application built with ASP.NET Core MVC for managing a collection of books. It allows users to view a list of books, create new books, and delete existing ones.

## Features

* **View Book List:** Displays a table of books with their titles and prices.
* **Create New Books:** Provides a form to add new books to the collection.
* **Delete Books:** Allows users to remove books from the collection.

## Technologies Used

* **ASP.NET Core MVC:** A framework for building web applications using the Model-View-Controller architectural pattern.
* **C#:** The primary programming language used.
* **Entity Framework Core (EF Core):** An Object-Relational Mapper (ORM) for interacting with the database.
* **SQL Server:** The relational database used to store book data.
* **HTML, CSS, Bootstrap:** Standard web technologies for structuring and styling the user interface.
* **ASP.NET Core Identity:** Framework for handling user authentication and authorization (basic setup included for login and registration).

## Setup Instructions

Follow these steps to get the application running on your local machine:

1.  **Prerequisites:**
    * [.NET SDK](https://dotnet.microsoft.com/download) (Make sure you have a compatible version installed).
    * [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads) (or SQL Server Express) installed and running.
    * [Visual Studio](https://visualstudio.microsoft.com/downloads/) (recommended) or another suitable code editor.

2.  **Configure Database Connection:**
    * The application uses a SQL Server database. You need to provide your own connection string.
    * **Recommended (for development):** Use User Secrets to store your connection string securely outside of the project file.
        ```bash
        dotnet user-secrets init
        dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Your_SQL_Server_Connection_String_Here"
        ```
        (Replace `"Your_SQL_Server_Connection_String_Here"` with your actual SQL Server connection string.)
    * **Alternatively (less secure for committing):** You can modify the `appsettings.json` file, but **ensure you do not commit sensitive information to your repository.**

3.  **Apply Migrations:**
    * Open the Package Manager Console in Visual Studio (Tools -> NuGet Package Manager -> Package Manager Console) or use the .NET CLI:
    ```powershell
    # Package Manager Console
    Add-Migration InitialCreate
    Update-Database
    ```
    ```bash
    # .NET CLI
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```
    This will create the necessary database tables based on your Entity Framework Core models.

4.  **Build and Run the Application:**
    * In Visual Studio, press `Ctrl+F5` to build and run the application without debugging, or use the .NET CLI:
    ```bash
    dotnet run
    ```
