CREATE TABLE [dbo].[RBook] (
    [BId]         INT           NOT NULL,
    [BookName]    NVARCHAR (50) NULL,
    [AurthorName] NVARCHAR (50) NULL,
    [Id]          INT           NOT NULL,
    [StudentName] NVARCHAR (50) NULL,
    [StudentPhno] NCHAR (10)    NULL,
    [Year]        NVARCHAR(50)           NULL,
    [RentDate]    DATE          NULL,
    [ReturnDate]  DATE          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

