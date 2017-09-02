
ALTER PROCEDURE 
	ViewCasesForEmployee @id int
AS
	SELECT
		c.Id,
		c.EmployeeId,
		c.CaseNumber,
		e.FirstName,
		e.LastName,
		c.StartDate,
		c.EndDate,
		c.Approved,
		c.Denied
	FROM
		dbo.EmployeeCase c
		INNER JOIN dbo.Employee e on c.EmployeeId = e.Id
	where
		e.Id = @id