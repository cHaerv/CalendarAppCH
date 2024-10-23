# CalendarAppCH

This project is to demo a calendar app that uses Blazor with SQLite database connected through Entity Framework Core!

## Features
View a monthly calendar
Add new appointments with title, start, and end time
Store appointments in an SQLite database
## Prerequisites
.NET SDK (version 6.0 or higher)
Entity Framework Core (EF Core)
SQLite database

## Getting Started
1. Clone the Repository
```
git clone https://github.com/cHaerv/CalendarAppCH.git
```
2. Install Dependencies
Ensure you have the required packages installed:
```
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
```
3. Migrate the Database
Run the following commands in the Package Manager Console (or use dotnet ef CLI):
```
Add-Migration InitialCreate
Update-Database
```
4. Run the App
```
dotnet run
```
Navigate to https://localhost:5001 to view the app in your browser.
