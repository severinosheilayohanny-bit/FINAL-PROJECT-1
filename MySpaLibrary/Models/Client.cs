using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpaLibrary.Models;

using System;

public class Client : Person
{
    public string Document { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Email { get; set; } = "";
    public string Address { get; set; } = "";
    public DateTime RegisteredAt { get; set; }

    public Client() { }

        public Client(int id, string firstName, string lastName, string document,
                  string phone, string email, string address)
        : base(id, firstName, lastName)
    {
        Document = document;
        Phone = phone;
        Email = email;
        Address = address;
        RegisteredAt = DateTime.Now;
    }

    public override string GetFullName() => $"{FirstName} {LastName}";

    public override string ToString()
    {
        return $"{Id,-4} {GetFullName(),-25} {Phone,-14} {Email,-30}";
    }
}
