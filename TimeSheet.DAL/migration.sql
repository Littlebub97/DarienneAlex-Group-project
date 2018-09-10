IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF SCHEMA_ID(N'TimeSheet') IS NULL EXEC(N'CREATE SCHEMA [TimeSheet];');

GO

CREATE TABLE [TimeSheet].[Employees] (
    [Id] int NOT NULL IDENTITY,
    [EmployeeName] nvarchar(50),
    [TimeStamp] rowversion,
    CONSTRAINT [PK_Employees] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180909204100_Initial', N'1.1.0-rtm-22752');

GO

