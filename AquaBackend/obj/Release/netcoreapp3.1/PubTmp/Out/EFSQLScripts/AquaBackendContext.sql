IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200327184434_initial')
BEGIN
    CREATE TABLE [Transaction] (
        [Id] int NOT NULL IDENTITY,
        [PortfolioCode] nvarchar(max) NULL,
        [TransactionCode] nvarchar(max) NULL,
        [TranCodeLabel] nvarchar(max) NULL,
        [SecTypeCode1] nvarchar(max) NULL,
        [Symbol1] nvarchar(max) NULL,
        [FullName1] nvarchar(max) NULL,
        [PrincipalCurrencyCode1] nvarchar(max) NULL,
        [SecTypeCode2] nvarchar(max) NULL,
        [Symbol2] nvarchar(max) NULL,
        [FullName2] nvarchar(max) NULL,
        [PrincipalCurrencyCode2] nvarchar(max) NULL,
        [TradeDate] datetime2 NULL,
        [SettleDate] datetime2 NULL,
        [Quantity] real NULL,
        [TradeAmount] real NULL,
        [UnitPrice] real NULL,
        [Comment] nvarchar(max) NULL,
        CONSTRAINT [PK_Transaction] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200327184434_initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200327184434_initial', N'3.1.1');
END;

GO

