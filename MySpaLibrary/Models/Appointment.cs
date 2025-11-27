using System;

namespace MySpaLibrary.Models
{
    public enum AppointmentStatus { Scheduled = 0, Completed = 1, Cancelled = 2, NoShow = 3 }

    public class Appointment
    {
        public int Id { get; set; }

                public int ClientId { get; set; }
        public int ServiceId { get; set; }
        public int EmployeeId { get; set; }

        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public AppointmentStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }

                public Client Client { get; set; }
        public Service Service { get; set; }
        public Employee Employee { get; set; }

        public Appointment() { }

        public Appointment(int id, int clientId, int serviceId, int employeeId, DateTime startAt, int durationMinutes)
        {
            Id = id;
            ClientId = clientId;
            ServiceId = serviceId;
            EmployeeId = employeeId;
            StartAt = startAt;
            EndAt = startAt.AddMinutes(durationMinutes);
            Status = AppointmentStatus.Scheduled;
            CreatedAt = DateTime.Now;
        }

        public void Complete() => Status = AppointmentStatus.Completed;
        public void Cancel() => Status = AppointmentStatus.Cancelled;

        public static Appointment ScheduleNow(int id, int clientId, int serviceId, int employeeId, int durationMinutes)
        {
            return new Appointment(id, clientId, serviceId, employeeId, DateTime.Now, durationMinutes);
        }

        public override string ToString()
            => $"{Id,-4} Client:{ClientId,-3} Service:{ServiceId,-3} Emp:{EmployeeId,-3} {StartAt,-20} {Status}";
    }
}
