CREATE TABLE [dbo].[InputLog]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [message] NVARCHAR(MAX) NULL, 
    [time] DATETIME NULL
)
