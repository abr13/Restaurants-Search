
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/09/2018 23:06:23
-- Generated from EDMX file: D:\ABR\Projects\QuickRestaurants\QuickRestaurants\AppCode\DAL\QuickRestaurantsModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [QuickResttaurantsDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Restaurants]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Restaurants];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Restaurants'
CREATE TABLE [dbo].[Restaurants] (
    [RestaurantID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Address] nvarchar(250)  NOT NULL,
    [Mobile] nvarchar(10)  NOT NULL,
    [Website] nvarchar(100)  NOT NULL,
    [Time] nvarchar(20)  NOT NULL,
    [Days] nvarchar(20)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [RestaurantID] in table 'Restaurants'
ALTER TABLE [dbo].[Restaurants]
ADD CONSTRAINT [PK_Restaurants]
    PRIMARY KEY CLUSTERED ([RestaurantID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------