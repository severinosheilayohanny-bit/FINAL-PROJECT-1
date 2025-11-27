using MySpaLibrary.Database;
using MySpaLibrary.Models;

public class DbTest
{
    public static void TestConnection()
    {
        Console.WriteLine("Probando conexión con la base de datos...");

        using var db = new SpaDbContext();

        try
        {
                        var canConnect = db.Database.CanConnect();
            Console.WriteLine($"¿Conexión exitosa?: {canConnect}");

                        var employee = db.Employees.ToList();

            Console.WriteLine($"Employee encontrados: {employee.Count}");

            foreach (var c in employee)
            {
                Console.WriteLine($"{c.Id} - {c.FirstName} {c.LastName}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al conectar:");
            Console.WriteLine(ex.Message);
        }
    }
}

