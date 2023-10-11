
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/11/2023 12:40:35
-- Generated from EDMX file: D:\Programy\csharp\chorzow2023csharp\ConsoleApp1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [biblioteka];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ksiazkaSet'
CREATE TABLE [dbo].[ksiazkaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [tytul] nvarchar(max)  NOT NULL,
    [autor] nvarchar(max)  NOT NULL,
    [isbn] nvarchar(max)  NOT NULL,
    [rok_wydania] int  NOT NULL
);
GO

-- Creating table 'stronaSet'
CREATE TABLE [dbo].[stronaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [numer] nvarchar(max)  NOT NULL,
    [il_obrazow] nvarchar(max)  NOT NULL,
    [ksiazka_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ksiazkaSet'
ALTER TABLE [dbo].[ksiazkaSet]
ADD CONSTRAINT [PK_ksiazkaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'stronaSet'
ALTER TABLE [dbo].[stronaSet]
ADD CONSTRAINT [PK_stronaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ksiazka_Id] in table 'stronaSet'
ALTER TABLE [dbo].[stronaSet]
ADD CONSTRAINT [FK_ksiazkastrona]
    FOREIGN KEY ([ksiazka_Id])
    REFERENCES [dbo].[ksiazkaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ksiazkastrona'
CREATE INDEX [IX_FK_ksiazkastrona]
ON [dbo].[stronaSet]
    ([ksiazka_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------