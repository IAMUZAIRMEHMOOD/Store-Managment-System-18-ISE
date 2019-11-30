CREATE TABLE [dbo].[Table]
(
	[Employee Id] INT NOT NULL PRIMARY KEY, 
    [First name] NCHAR(10) NOT NULL, 
    [Last name] NCHAR(10) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Phone Number] INT NOT NULL, 
    [Permanent Address] TEXT NOT NULL, 
    [Salary Catagory] NCHAR(1) NOT NULL, 
    [Joined Date] DATETIME NOT NULL, 
    [Male] BIT NOT NULL, 
    [Married] BIT NOT NULL
)
