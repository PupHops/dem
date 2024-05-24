using Microsoft.EntityFrameworkCore;

using dem.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace dem
{
    public class Context : DbContext
    {
        //Scaffold-DbContext "Server=(localdb)\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer
        //public readonly string connectionString = "Initial Catalog=bibaNew;Server=192.168.221.12;user=user04;password=04;TrustServerCertificate=true";
        //private readonly string connectionString = "Data Source=DESKTOP-HIITB3O; initial Catalog=biba; " +
        //"Integrated Security=True;TrustServerCertificate=True";
        private readonly string connectionString = "Data Source=Dany; initial Catalog=Remont; Integrated Security=True;TrustServerCertificate=True";

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<StatusTicket> StatusTickets { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }


        public Context()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();

            Clients.AddRange(
    new Client()
    {
        Name = "asd",
        PhoneNumber = "79999999"
    }
   );

            Employees.AddRange(
                new Employee()
                {
                    Name = "asd",
                    Password = "asd",
                    Dificult = "Стажёр"
                }
               );
            StatusTickets.AddRange(
    new StatusTicket()
    {
        Title = "Open"
    },
    new StatusTicket()
    {
        Title = "In Progress"
    },
    new StatusTicket()
    {
        Title = "Closed"
    }
);

            Tickets.AddRange(
           new Ticket()
           {
               DateAdd = DateTime.Now,
               Device = "Laptop",
               FaultType = "Hardware",
               ProblemDescription = "Screen not working",
               EmployeeId = 1, // Assuming an employee with Id 1 exists
               ClientId = 1, // Assuming a client with Id 1 exists
               StatusTicketId = 1 // Assuming a status with Id 1 exists
           });

            //Tickets.AddRange(
            //    new Ticket()
            //    {

            //    });

            SaveChanges();

        }
    }
}
