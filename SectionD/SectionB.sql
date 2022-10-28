/*a.write a sql statement*/
SELECT d.Name
FROM Employee e, Department d
WHERE e.DepartmentId = d.DepartmentId
AND e.Name = "Jenny Lawrence";

/*b*/
SELECT e.EmployeeId, e.Name 
FROM Employee e
WHERE e.DepartmentId IS NULL
OR e.DepartmentId NOT IN (SELECT DISTINCT d.DepartmentId FROM Deparment d);

SELECT d.Name 
FROM Employee e, Department d 
WHERE e.DeparmentId = d.DepartmentId
GROUP BY d.DepartmentId
HAVING COUNT(e.EmployeeId) > 5
AND SUM(e.DepProjBudget) > 10000;



