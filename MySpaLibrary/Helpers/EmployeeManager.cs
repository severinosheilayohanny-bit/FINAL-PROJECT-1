using MySpaLibrary.Models;
using MySpaLibrary.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MySpaLibrary.Helpers;

public class EmployeeManager
{
    private readonly SpaDbContext _db;

    public EmployeeManager(SpaDbContext db)
    {
        _db = db;
    }

    public void AddEmployee(Employee e)
    {
        _db.Employees.Add(e);
        _db.SaveChanges();
    }

    public List<Employee> ListEmployees()
    {
        return _db.Employees.AsNoTracking().ToList();
    }

    public Employee? FindById(int id)
    {
        return _db.Employees.Find(id);
    }

    public void DeleteEmployee(int employeeId)
    {
        var employeeToDelete = _db.Employees.Find(employeeId);

        if (employeeToDelete != null)
        {
            _db.Employees.Remove(employeeToDelete);
        }
        else
        {
            throw new InvalidOperationException($"Employee with ID {employeeId} not found for deletion.");
        }
    }
}
