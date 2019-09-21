CREATE TABLE [dbo].[InputLog] (
    [id]      INT            NOT NULL IDENTITY,
    [message] NVARCHAR (MAX) NOT NULL,
    [time]    DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

