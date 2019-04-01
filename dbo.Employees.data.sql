MERGE INTO Employees AS Target
USING (VALUES
	  (223476, 'Angela Rush', 15.00, 32.25),
	  (223487, 'Bill Marsh', 16.50, 45.50),
	  (223504, 'Peggy Simon', 16.75, 50),
	  (223512, 'Carl Yost', 15.75, 40),
	  (223519, 'Joe Miles', 15.00, 40),
	  (223525, 'Joan Jeffries', 14.25, 25.75),
	  (223536, 'George Mills', 13.65, 38),
	  (223542, 'Gary Cooper', 15.25, 37.25),
	  (223558, 'Mary Millicent', 15.75, 40)
)
AS Source ([EmployeeID], [Employee Name], [Pay Rate], [Hours Worked])
ON Target.[EmployeeID] = Source.[EmployeeID]
WHEN NOT MATCHED BY TARGET THEN
INSERT ([EmployeeID], [Employee Name], [Pay Rate], [Hours Worked])
VALUES ([EmployeeID], [Employee Name], [Pay Rate], [Hours Worked]);