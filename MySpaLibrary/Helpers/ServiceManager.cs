using MySpaLibrary.Models;
using MySpaLibrary.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MySpaLibrary.Helpers;

public class ServiceManager
{
    private readonly SpaDbContext _db;

    public ServiceManager(SpaDbContext db)
    {
        _db = db;
    }

    public void AddService(Service s)
    {
        _db.Services.Add(s);
        _db.SaveChanges();
    }

    public List<Service> ListServices()
    {
        return _db.Services.AsNoTracking().ToList();
    }

    public Service? FindById(int id)
    {
        return _db.Services.Find(id);
    }

    public void DeleteService(int serviceId)
    {
        var serviceToDelete = _db.Services.Find(serviceId);

        if (serviceToDelete != null)
        {
            _db.Services.Remove(serviceToDelete);
        }
        else
        {
            throw new InvalidOperationException($"Service with ID {serviceId} not found for deletion.");
        }
    }
}
