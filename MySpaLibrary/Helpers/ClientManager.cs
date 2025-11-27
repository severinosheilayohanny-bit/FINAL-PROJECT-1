using MySpaLibrary.Models;
using MySpaLibrary.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MySpaLibrary.Helpers;

public class ClientManager
{
    private readonly SpaDbContext _db;

    public ClientManager(SpaDbContext db)
    {
        _db = db;
    }

    public void AddClient(Client client)
    {
        _db.Clients.Add(client);
        _db.SaveChanges();
    }

    public List<Client> ListClients()
    {
        return _db.Clients.AsNoTracking().ToList();
    }

    public Client? FindById(int id)
    {
        return _db.Clients.Find(id);
    }

    public List<Client> Search(string term)
    {
        term = term?.ToLower() ?? "";
        return _db.Clients
            .Where(c =>
                c.FirstName.ToLower().Contains(term) ||
                c.LastName.ToLower().Contains(term) ||
                c.Phone.Contains(term) ||
                c.Email.ToLower().Contains(term)
            )
            .ToList();
    }
}
