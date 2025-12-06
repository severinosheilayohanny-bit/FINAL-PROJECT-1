using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpaLibrary.Models;

using System;

public class Commission
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public int AppointmentId { get; set; }
    public decimal Amount { get; set; }
    public bool Paid { get; set; }

    public Commission() { }

    public Commission(int id, int employeeId, int appointmentId, decimal amount)
    {
        Id = id;
        EmployeeId = employeeId;
        AppointmentId = appointmentId;
        Amount = amount;
        Paid = false;
    }

    public void MarkPaid() => Paid = true;

    public override string ToString() => $"{Id,-4} Emp:{EmployeeId,-3} Appt:{AppointmentId,-3} {Amount,8:C} Paid:{Paid}";
}

