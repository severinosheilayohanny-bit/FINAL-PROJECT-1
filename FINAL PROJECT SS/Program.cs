using MySpaLibrary.Helpers;
using MySpaLibrary.Models;
using MySpaLibrary.Database;
using System;
using System.Linq;

namespace FINAL_PROJECT_SS;

class Program
{
    static void Main()
    {
        DbTest.TestConnection();

        var db = new SpaDbContext();

        var clientMgr = new ClientManager(db);
        var serviceMgr = new ServiceManager(db);
        var employeeMgr = new EmployeeManager(db);
        var apptMgr = new AppointmentManager(db);

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- SPA MANAGEMENT SYSTEM ---\n");
            Console.WriteLine("1. Add Client");
            Console.WriteLine("2. List Clients");
            Console.WriteLine("3. Update Client");
            Console.WriteLine("4. Delete Client");
            Console.WriteLine("------------------------------");
            Console.WriteLine("5. Add Service");
            Console.WriteLine("6. List Services");
            Console.WriteLine("7. Update Service");
            Console.WriteLine("8. Delete Service");
            Console.WriteLine("------------------------------");
            Console.WriteLine("9. Add Employee");
            Console.WriteLine("10. List Employees");
            Console.WriteLine("11. Update Employee");
            Console.WriteLine("12. Delete Employee");
            Console.WriteLine("------------------------------");
            Console.WriteLine("13. Schedule Appointment");
            Console.WriteLine("14. List Appointments");
            Console.WriteLine("15. Cancel Appointment");
            Console.WriteLine("16. Complete Appointment");
            Console.WriteLine("------------------------------");
            Console.WriteLine("17. Exit");
            Console.Write("\nChoose an option: ");

            var opt = Console.ReadLine();

            try 
            {
                switch (opt)
                {

                    case "1":
                        Console.Write("First name: "); var fn = Console.ReadLine() ?? "";
                        Console.Write("Last name: "); var ln = Console.ReadLine() ?? "";
                        Console.Write("Document: "); var doc = Console.ReadLine() ?? "";
                        Console.Write("Phone: "); var phone = Console.ReadLine() ?? "";
                        Console.Write("Email: "); var email = Console.ReadLine() ?? "";
                        Console.Write("Address: "); var addr = Console.ReadLine() ?? "";

                        var client = new Client(0, fn, ln, doc, phone, email, addr);
                        clientMgr.AddClient(client);
                        db.SaveChanges(); 
                        Console.WriteLine("\nClient added.");
                        break;

                    case "2":
                        var clients = clientMgr.ListClients();
                        if (clients.Count == 0) Console.WriteLine("\nNo clients.");
                        else clients.ForEach(c => Console.WriteLine(c));
                        break;

                    case "3":
                        Console.Write("Client ID: "); int.TryParse(Console.ReadLine(), out int ucid);
                        var cUpdate = clientMgr.FindById(ucid);

                        if (cUpdate == null) { Console.WriteLine("Client not found."); break; }

                        Console.Write("New phone: "); cUpdate.Phone = Console.ReadLine() ?? "";
                        Console.Write("New email: "); cUpdate.Email = Console.ReadLine() ?? "";
                        Console.Write("New address: "); cUpdate.Address = Console.ReadLine() ?? "";

                        db.SaveChanges();
                        Console.WriteLine("\nClient updated.");
                        break;

                    case "4":
                        Console.Write("Client ID to delete: "); int.TryParse(Console.ReadLine(), out int dcid);
                        clientMgr.DeleteClient(dcid);
                        db.SaveChanges(); 

                        Console.WriteLine("\nClient deleted.");
                        break;

                    case "5":
                        Console.Write("Service name: "); var sname = Console.ReadLine() ?? "";
                        Console.Write("Description: "); var sdesc = Console.ReadLine() ?? "";
                        Console.Write("Duration (minutes): "); int.TryParse(Console.ReadLine(), out int dur);
                        Console.Write("Price: "); decimal.TryParse(Console.ReadLine(), out decimal price);

                        var svc = new Service(0, sname, sdesc, dur, price);
                        serviceMgr.AddService(svc);
                        db.SaveChanges(); 
                        Console.WriteLine("\nService added.");
                        break;

                    case "6":
                        var services = serviceMgr.ListServices();
                        if (services.Count == 0) Console.WriteLine("\nNo services.");
                        else services.ForEach(s => Console.WriteLine(s));
                        break;

                    case "7":
                        Console.Write("Service ID: "); int.TryParse(Console.ReadLine(), out int usid);
                        var sUpdate = serviceMgr.FindById(usid);

                        if (sUpdate == null) { Console.WriteLine("Service not found."); break; }

                        Console.Write("New name: "); sUpdate.Name = Console.ReadLine() ?? "";
                        Console.Write("New description: "); sUpdate.Description = Console.ReadLine() ?? "";
                        Console.Write("New price: "); decimal.TryParse(Console.ReadLine(), out decimal newP); sUpdate.Price = newP;

                        db.SaveChanges();
                        Console.WriteLine("\nService updated.");
                        break;

                    case "8":
                        Console.Write("Service ID: "); int.TryParse(Console.ReadLine(), out int dsid);
                        serviceMgr.DeleteService(dsid);
                        db.SaveChanges(); 

                        Console.WriteLine("\nService deleted.");
                        break;

                    case "9":
                        Console.Write("First name: "); var efn = Console.ReadLine() ?? "";
                        Console.Write("Last name: "); var eln = Console.ReadLine() ?? "";
                        Console.Write("Role: "); var role = Console.ReadLine() ?? "";
                        Console.Write("Commission rate (0.10 = 10%): ");
                        decimal.TryParse(Console.ReadLine(), out decimal rate);

                        var emp = new Employee(0, efn, eln, role, rate);
                        employeeMgr.AddEmployee(emp);
                        db.SaveChanges(); 
                        Console.WriteLine("\nEmployee added.");
                        break;

                    case "10":
                        var empList = employeeMgr.ListEmployees();
                        if (empList.Count == 0) Console.WriteLine("\nNo employees.");
                        else empList.ForEach(e => Console.WriteLine(e));
                        break;

                    case "11":
                        Console.Write("Employee ID: "); int.TryParse(Console.ReadLine(), out int ueId);
                        var eUpdate = employeeMgr.FindById(ueId);

                        if (eUpdate == null) { Console.WriteLine("Employee not found."); break; }

                        Console.Write("New role: "); eUpdate.Role = Console.ReadLine() ?? "";
                        Console.Write("New commission rate: "); decimal.TryParse(Console.ReadLine(), out decimal nRate);
                        eUpdate.CommissionRate = nRate;

                        db.SaveChanges();
                        Console.WriteLine("\nEmployee updated.");
                        break;

                    case "12":
                        Console.Write("Employee ID: "); int.TryParse(Console.ReadLine(), out int deId);
                        employeeMgr.DeleteEmployee(deId); 
                        db.SaveChanges();

                        Console.WriteLine("\nEmployee deleted.");
                        break;

                    case "13":
                        Console.Write("Client ID: "); int.TryParse(Console.ReadLine(), out int cid);
                        Console.Write("Service ID: "); int.TryParse(Console.ReadLine(), out int sid);
                        Console.Write("Employee ID: "); int.TryParse(Console.ReadLine(), out int eid);
                        Console.Write("Start (yyyy-MM-dd HH:mm): ");
                        DateTime.TryParse(Console.ReadLine(), out DateTime start);

                        var serv = serviceMgr.FindById(sid);
                        if (serv == null) { Console.WriteLine("\nService not found."); break; }

                        var ap = new Appointment(0, cid, sid, eid, start, serv.DurationMinutes);

                        if (!apptMgr.ScheduleAppointment(ap))
                            Console.WriteLine("\nConflict detected. Cannot schedule.");
                        else
                            Console.WriteLine("\nAppointment scheduled.");
                        break;

                    case "14":
                        var apps = apptMgr.ListAppointments();
                        if (apps.Count == 0) Console.WriteLine("\nNo appointments.");
                        else apps.ForEach(a => Console.WriteLine(a));
                        break;

                    case "15":
                        Console.Write("Appointment ID: "); int.TryParse(Console.ReadLine(), out int caid);
                        apptMgr.CancelAppointment(caid);

                        Console.WriteLine("\nAppointment cancelled.");
                        break;

                    case "16":
                        Console.Write("Appointment ID: "); int.TryParse(Console.ReadLine(), out int aid);
                        Console.Write("Amount paid: "); decimal.TryParse(Console.ReadLine(), out decimal paid);
                        Console.Write("Method: "); var method = Console.ReadLine() ?? "Cash";

                        var appointment = apptMgr.FindById(aid);
                        if (appointment == null) { Console.WriteLine("\nAppointment not found."); break; }

                        var employee = employeeMgr.FindById(appointment.EmployeeId);
                        var serv2 = serviceMgr.FindById(appointment.ServiceId);

                        if (employee == null || serv2 == null) { Console.WriteLine("\nEmployee or service missing."); break; }
                        var payment = apptMgr.CompleteAppointment(aid, paid, method, employee, serv2);

                        Console.WriteLine($"\nPayment recorded: {payment}");
                        break;

                    case "17":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("\nInvalid option.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nError: {ex.Message}");
                Console.ResetColor();
                Console.WriteLine("Press any key to return to menu...");
                Console.ReadKey();
            }
        }

        Console.WriteLine("\nByeBye...");
        Console.ReadKey();
    }
}