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
3. Run the solution


If you want to experiment with the Products REST endpoint, create database and table using the sql script below
CREATE DATABASE KissApiDB
GO
USE KissApiDB
GO
-- 2. Create table Products 
CREATE TABLE [dbo].[Products](
	[Id] [uniqueidentifier] ROWGUIDCOL NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Barcode] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Rate] [decimal](18, 2) NOT NULL,
	[AddedOn] [datetime] NOT NULL,
	[ModifiedOn] [datetime] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]