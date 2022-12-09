# salary

# Important

download the project from https://github.com/saminehadibi/salary

# Introduction

This project is create with **ASP.NET Core MVC** .

After downloading the project, follow the steps below to run application.

1.Open solution in Visual Studio 2019 (v16.4)+ and build the solution.

2.Check the connection string in the appsettings.json file of the Web.Mvc project, change it if you want.

3.Open Package Manager Console and run the Update-Database command to create your database (ensure that the Default project is selected as .EntityFrameworkCore in the Package Manager Console window).

4.Run the application. you can run the project with IISExpress and see the run in localhost.

If you have problems with running the application, please try closing and opening Visual Studio again. It sometimes fails on first package restore.


# Overview
After run we can use it to call  All application services. For example, we can use the Salary service to get a list of Salareis.

For example request GetAll.
'https://localhost:44311/api/services/app/Salary/GetAll'.

Almost all operations available on the UI are also available as a Web API, since the UI uses the same Web API, and can be easily consumed.

