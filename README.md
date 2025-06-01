# individual-assignment2
# MyLibrary: A C# WinForms Library Management System

---

## Project Summary

MyLibrary is a robust desktop application built with C# and WinForms, designed to streamline the management of a library's book inventory and member borrowing activities. This project emphasizes practical application of **event-driven programming**, intuitive **UI design**, and seamless **database integration** using ADO.NET. It provides a user-friendly interface for managing books, borrowers, and tracking book issuance and returns.

* **Secure User Authentication:**
    * A simple login form validates user credentials against a dedicated `Users` table in the database.
    * Ensures only authorized personnel can access the main application features.
* **Comprehensive Book Management:**
    * **Dashboard View:** Displays all books in a clear `DataGridView`, showing `BookID`, `Title`, `Author`, `PublicationYear`, and `AvailableCopies`.
    * **CRUD Operations:** Easily **Add**, **Edit**, or **Delete** book records via dedicated forms.
    * **Data Validation:** Implements strict validation to ensure all book details are accurate and within logical ranges.
* **Efficient Borrower Management:**
    * **Borrower List:** Presents all registered borrowers in a `DataGridView`, including `BorrowerID`, `Name`, `Email`, and `Phone`.
    * **CRUD Operations:** Full capability to **Add**, **Edit**, and **Delete** borrower profiles.
    * **Input Validation:** Validates borrower information, including email format and phone numbers.
* **Streamlined Book Issuance & Return:**
    * **Issue Book:** Select a borrower and a book to record a new issue. Automatically decrements `AvailableCopies` and logs the `IssueDate` and `DueDate` in the `IssuedBooks` table.
    * **Return Book:** Mark an issued book as returned, incrementing `AvailableCopies` and updating the `IssuedBooks` record.
* **Reporting & Filtering (Bonus):**
    * **Book Filtering:** Quickly find books by `Author` or within a specific `PublicationYear` range.
    * **Overdue Report:** Generate a report of all currently overdue books, helping manage library resources efficiently.

---

## Technical Stack

* **Programming Language:** C#
* **Application Framework:** .NET (Windows Forms)
* **Database System:** SQL Server LocalDB
* **Data Access Layer:** ADO.NET, utilizing **parameterized queries** for enhanced security against SQL injection.
* **Event Handling:** Extensive use of standard WinForms event handlers (e.g., `Click`, `SelectionChanged`, `TextChanged`).
* **Error Management:** Robust `try-catch` blocks for all database interactions, providing user-friendly error messages.
* **Input Validation:** Comprehensive validation rules implemented for all user inputs.

---

## Getting Started

Follow these steps to set up and run the MyLibrary application on your system:

1.  **Clone the Repository:**
    ```bash
    git clone [https://github.com/YourUsername/MyLibrary.git](https://github.com/YourUsername/MyLibrary.git)
    cd MyLibrary
    ```

2.  **Database Configuration:**
    * Ensure **SQL Server Express or LocalDB** is installed on your machine.
    * Open SQL Server Management Studio (SSMS) or use the SQL Server Object Explorer in Visual Studio.
    * Execute the `database/MyLibrary_Schema.sql` script to create the necessary database, tables, and populate initial data, including the default admin user.

3.  **Open in Visual Studio:**
    * Launch Visual Studio (2019 or newer is recommended) and open the `MyLibrary.sln` solution file.

4.  **Restore NuGet Packages:**
    * If prompted, right-click on the "MyLibrary" solution in the Solution Explorer and select "Restore NuGet Packages" to download any required dependencies.

5.  **Verify Connection String:**
    * Open the `App.config` file in the main project.
    * Confirm that the `<connectionStrings>` section points to your SQL Server LocalDB instance:
        ```xml
        <connectionStrings>
            <add name="MyLibraryDB" connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MyLibrary.mdf;Integrated Security=True;Connect Timeout=30" providerName="System.Data.SqlClient" />
        </connectionStrings>
        ```
        *(Note: `|DataDirectory|` resolves to the application's executable folder. Make sure `MyLibrary.mdf` is copied to your `bin/Debug` or `bin/Release` directory if using a file-based LocalDB.)*

6.  **Build and Run:**
    * From the Visual Studio menu, select `Build` > `Build Solution`.
    * Press `F5` or click the green "Start" button to launch the application.

---

## Default Login Credentials

Use the following credentials to access the application after setup:

* **Username:** `admin`
* **Password:** `password123`

---

## Visual Walkthrough

Explore the MyLibrary application's interface through these key screenshots:

* **User Login Screen:** The entry point to the system.
    ![Login Form](docs/screenshots/login_form.png)

* **Main Application Window - Books Management:** Overview of all library books.
    ![Books Management](docs/screenshots/books_management.png)

* **Add/Edit Book Form:** For managing individual book details.
    ![Add/Edit Book](docs/screenshots/add_edit_book.png)

* **Main Application Window - Borrowers Management:** List of all registered library members.
    ![Borrowers Management](docs/screenshots/borrowers_management.png)

* **Add/Edit Borrower Form:** To manage borrower information.
    ![Add/Edit Borrower](docs/screenshots/add_edit_borrower.png)

* **Book Issuance Process:** Demonstrating how books are lent out.
    ![Issue Book](docs/screenshots/issue_book_flow.png)

* **Book Return Process:** How borrowed books are checked back in.
    ![Return Book](docs/screenshots/return_book_flow.png)

* **(Bonus) Overdue Books Report:** A quick glance at pending returns.
    ![Overdue Books Report](docs/screenshots/overdue_report.png)

---

## Database Schema (`database/MyLibrary_Schema.sql`)

This SQL script defines the database structure and populates it with initial data for the MyLibrary application.

```sql
-- SQL Server LocalDB Database Schema for MyLibrary

-- Users Table: Stores application user credentials
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(256) NOT NULL -- IMPORTANT: In a production app, use robust hashing (e.g., BCrypt)!
);

-- Books Table: Manages the library's book inventory
CREATE TABLE Books (
    BookID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(255) NOT NULL,
    Author NVARCHAR(100) NOT NULL,
    PublicationYear INT NOT NULL,
    AvailableCopies INT NOT NULL DEFAULT 1 CHECK (AvailableCopies >= 0)
);

-- Borrowers Table: Contains information about library members
CREATE TABLE Borrowers (
    BorrowerID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE,
    Phone NVARCHAR(20)
);

-- IssuedBooks Table: Records borrowing transactions
CREATE TABLE IssuedBooks (
    IssueID INT PRIMARY KEY IDENTITY(1,1),
    BookID INT NOT NULL,
    BorrowerID INT NOT NULL,
    IssueDate DATE NOT NULL DEFAULT GETDATE(),
    DueDate DATE NOT NULL,
    ReturnDate DATE NULL, -- Marks when the book was returned (NULL if not yet returned)
    FOREIGN KEY (BookID) REFERENCES Books(BookID),
    FOREIGN KEY (BorrowerID) REFERENCES Borrowers(BorrowerID)
);

-- Initial Data Seeding
INSERT INTO Users (Username, PasswordHash) VALUES
('admin', 'password123'); -- For demonstration; replace with hashed password in real deployment.

INSERT INTO Books (Title, Author, PublicationYear, AvailableCopies) VALUES
('The Great Gatsby', 'F. Scott Fitzgerald', 1925, 5),
('To Kill a Mockingbird', 'Harper Lee', 1960, 3),
('1984', 'George Orwell', 1949, 7),
('Pride and Prejudice', 'Jane Austen', 1813, 4),
('The Catcher in the Rye', 'J.D. Salinger', 1951, 2);

INSERT INTO Borrowers (Name, Email, Phone) VALUES
('Alice Smith', 'alice.s@example.com', '123-456-7890'),
('Bob Johnson', 'bob.j@example.com', '987-654-3210'),
('Charlie Brown', 'charlie.b@example.com', '555-123-4567'),
('Diana Prince', 'diana.p@example.com', '777-888-9999');

-- Example of an initial issued book (optional for testing)
-- INSERT INTO IssuedBooks (BookID, BorrowerID, IssueDate, DueDate) VALUES
-- (1, 1, GETDATE(), DATEADD(day, 14, GETDATE()));
