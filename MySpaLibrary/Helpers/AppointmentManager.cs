using MySpaLibrary.Models;
using MySpaLibrary.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MySpaLibrary.Helpers;

public class AppointmentManager
{
    private readonly SpaDbContext _db;

    public AppointmentManager(SpaDbContext db)
    {
        _db = db;
    }

    public bool ScheduleAppointment(Appointment ap)
    {
            var conflict = _db.Appointments
            .Where(a =>
                a.Status == AppointmentStatus.Scheduled &&
                (a.EmployeeId == ap.EmployeeId || a.ClientId == ap.ClientId)
            )
            .AsEnumerable()
            .Any(a => !(ap.EndAt <= a.StartAt || ap.StartAt >= a.EndAt));

        if (conflict) return false;

        _db.Appointments.Add(ap);
        _db.SaveChanges();
        return true;
    }

    public List<Appointment> ListAppointments()
    {
        return _db.Appointments
            .Include(a => a.Service)
            .Include(a => a.Employee)
            .Include(a => a.Client)
            .ToList();
    }

    public Appointment? FindById(int id)
    {
        return _db.Appointments.Find(id);
    }

  public Payment CompleteAppointment(int appointmentId, decimal amountPaid, string method, Employee emp, Service svc)
    {
        var ap = FindById(appointmentId) 
            ?? throw new Exception("Appointment not found");

        if (ap.Status == AppointmentStatus.Completed)
        {
            throw new InvalidOperationException("This appointment is already completed and paid.");
        }
        
        ap.Complete();
        _db.Appointments.Update(ap);

        var payment = new Payment(0, appointmentId, amountPaid, method);
        _db.Payments.Add(payment);

        var commissionAmount = emp.CalculateCommission(amountPaid);
        var commission = new Commission(0, emp.Id, appointmentId, commissionAmount);
        _db.Commissions.Add(commission);

        _db.SaveChanges();
        return payment;
    }

    public List<Payment> ListPayments() => _db.Payments.ToList();
    public List<Commission> ListCommissions() => _db.Commissions.ToList();
}



