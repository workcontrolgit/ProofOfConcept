This repo contains source code described in the medum.com article https://fuji-nguyen.medium.com/quick-proof-of-concept-asp-net-core-web-api-using-swashbuckle-aspnetcore-and-bogus-19977c84d4a2

## This project is based on Clean Architecture, Repository and Unit of Work patterns. The source code is organized in four projects

1. Core
2. Application
3. Infrastructure
4. WebApi


## The tech stack includes the following

1. ASP.NET CORE 3.1 for WebAPI
2. Dapper for ORM
3. SQLKata for query builder and paging
4. Swagger for WebAPI documentation and testing
5. Bogus and GenFu for mock data and rapid webapi prototype

## Instructions to run the project

1. Clone the repo
2. Open the KissApi.sln with Visual Studio 2019
3. Create database and table using the db_script.sql (find in the solution root foler)
4. Run the solution