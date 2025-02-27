CREATE TABLE [dbo].[Student] (
    [BId]         INT           NOT NULL,
    [BookName]    VARCHAR (MAX) NULL,
    [AurthorName] VARCHAR (150) NULL,
    [Id]          INT           NOT NULL,
    [StudentName] NVARCHAR (MAX) NULL,
    [StudentPhno] NCHAR(10)    NULL,
    [Year]        NVARCHAR(50)           NULL,
    [RentDate]    DATE          NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Id] ASC)
);

