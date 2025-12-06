using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpaLibrary.Models;

using System;

public class Service
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public int DurationMinutes { get; set; }
    public decimal Price { get; set; }

    public Service() { }

    public Service(int id, string name, string description, int durationMinutes, decimal price)
    {
        Id = id;
        Name = name;
        Description = description;
        DurationMinutes = durationMinutes;
        Price = price;
    }

        public decimal CalculatePrice() => Price;

        public decimal CalculatePrice(decimal discountPercent)
    {
        var discount = Price * (discountPercent / 100m);
        return Math.Round(Price - discount, 2);
    }

    public override string ToString() => $"{Id,-4} {Name,-20} {DurationMinutes,3}min {Price,8:C}";
}

