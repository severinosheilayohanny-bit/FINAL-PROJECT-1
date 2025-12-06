using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpaLibrary.Models;

using System;

public class Employee : Person
{
    public string Role { get; set; } = "";
    public DateTime HireDate { get; set; }
    public decimal CommissionRate { get; set; } 
    public Employee() { }

    public Employee(int id, string firstName, string lastName, string role, decimal commissionRate)
        : base(id, firstName, lastName)
    {
        Role = role;
        HireDate = DateTime.Now;
        CommissionRate = commissionRate;
    }

    public override string GetFullName() => $"{FirstName} {LastName}";

    public decimal CalculateCommission(decimal amount) => Math.Round(amount * CommissionRate, 2);
    public decimal CalculateCommission(decimal amount, decimal overrideRate) => Math.Round(amount * overrideRate, 2);

    public override string ToString() => $"{Id,-4} {GetFullName(),-25} {Role,-12} {CommissionRate,6:P}";
}

