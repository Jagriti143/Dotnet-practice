

  select e.Dept,e.Name,e.Salary from [dbo].[EmployeeMaster] e
  join (
  select Dept,max(Salary) as MaxSalary from [dbo].[EmployeeMaster] group by Dept
  ) d on e.Dept=d.Dept where e.Salary=d.MaxSalary
