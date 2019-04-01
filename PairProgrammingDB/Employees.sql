CREATE TABLE [dbo].[Employees]
(
	[EmployeeID] INT NOT NULL,
	[Employee Name] NVARCHAR(50) NOT NULL,
	[Pay Rate] MONEY NOT NULL,
	[Hours Worked] FLOAT NOT NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
)
