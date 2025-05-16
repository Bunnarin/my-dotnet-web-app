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

2.  **Clone the Repository:**
    ```bash
    git clone [YOUR_REPOSITORY_URL]
    cd MyWebApp
    ```
    (Replace `[YOUR_REPOSITORY_URL]` with the actual URL of your GitHub repository.)

3.  **Configure Database Connection:**
    * The application uses a SQL Server database. You need to provide your own connection string.
    * **Recommended (for development):** Use User Secrets to store your connection string securely outside of the project file.
        ```bash
        dotnet user-secrets init
        dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Your_SQL_Server_Connection_String_Here"
        ```
        (Replace `"Your_SQL_Server_Connection_String_Here"` with your actual SQL Server connection string.)
    * **Alternatively (less secure for committing):** You can modify the `appsettings.json` file, but **ensure you do not commit sensitive information to your repository.**

4.  **Apply Migrations:**
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

5.  **Build and Run the Application:**
    * In Visual Studio, press `Ctrl+F5` to build and run the application without debugging, or use the .NET CLI:
    ```bash
    dotnet build
    dotnet run
    ```

6.  **Access the Application:**
    * Open your web browser and navigate to the URL displayed in the console (usually `https://localhost:xxxx`).

## Authentication

The application includes basic user authentication using ASP.NET Core Identity:

* **Registration:** New users can create an account by navigating to `/Identity/Account/Register`.
* **Login:** Existing users can log in by navigating to `/Identity/Account/Login`.

## Important Notes

* **Security:** This is a basic application and might not include robust security measures suitable for production environments. Be mindful of security best practices if you intend to deploy this application.
* **Connection String:** As mentioned in the Setup Instructions, **do not hardcode your database connection string directly in your source code or commit it to your repository.** Use secure configuration methods like User Secrets or environment variables.

## Contributing

If you'd like to contribute to this project, please feel free to fork the repository and submit pull requests with your changes.

## License

[Specify your license here, e.g., MIT License]
