using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpaLibrary.Models;

using System;

public class Payment
{
    public int Id { get; set; }
    public int AppointmentId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaidAt { get; set; }
    public string Method { get; set; } = ""; 
    public Payment() { }

    public Payment(int id, int appointmentId, decimal amount, string method)
    {
        Id = id;
        AppointmentId = appointmentId;
        Amount = amount;
        Method = method;
        PaidAt = DateTime.Now;
    }

    public override string ToString() => $"{Id,-4} Appt:{AppointmentId,-3} {Amount,8:C} {PaidAt}";
}

