using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUTODEALERN.Model;

namespace AUTODEALERN.DAL
{
    class ADInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ADContext>
    {
        protected override void Seed(ADContext context)
        {
            Console.WriteLine("Начало заполнения базы данных");
            List<Salesman> salesmen = new List<Salesman>
            {
                new Salesman { Name = "John Doe", Position = "Senior Sales Consultant", ContactInfo = "john@example.com" },
                new Salesman { Name = "Alice Smith", Position = "Sales Manager", ContactInfo = "alice@example.com" },
                new Salesman { Name = "Bob Johnson", Position = "Junior Sales Consultant", ContactInfo = "bob@example.com" },
                new Salesman { Name = "Emily Brown", Position = "Trainee Sales Consultant", ContactInfo = "emily@example.com" },
                new Salesman { Name = "Michael Wilson", Position = "Assistant Sales Consultant", ContactInfo = "michael@example.com" }
            };//?
            salesmen.ForEach(s => context.SalesmanDb.Add(s));

            List<Client> clients = new List<Client>
            {//seats - колво купленных машин, статус - новый/старый клиент
                new Client { ClientNumber = 89011234567, Seats = 0, Status = "Новый" },
                new Client { ClientNumber = 89159876543, Seats = 2, Status = "Старый" },
                new Client { ClientNumber = 89035551234, Seats = 6, Status = "Старый" },
                new Client { ClientNumber = 89258765432, Seats = 3, Status = "Старый" },
                new Client { ClientNumber = 89103219876, Seats = 0, Status = "Новый" }

            };
            clients.ForEach(s => context.ClientDb.Add(s));

            List<MenuItem> menuItems = new List<MenuItem> 
            {
                new MenuItem { Name = "Ford", Description = "Focus. 4602. ", Price = 9.99m, Category = "Sedan" },
                new MenuItem { Name = "Opel", Description = "Vivaro.", Price = 12.50m, Category = "Sedan" },
                new MenuItem { Name = "Porsche", Description = "911", Price = 7.99m, Category = "Sportscar" },
                new MenuItem { Name = "kia", Description = "Rio.", Price = 11.75m, Category = "Sedan" },
                new MenuItem { Name = "Aston Martin", Description = "DBS", Price = 6.50m, Category = "Sportscar" }

            };
            menuItems.ForEach(s => context.MenuItemDb.Add(s));
            base.Seed(context);
            Console.WriteLine("Завершение заполнения базы данных");
        }
       
    }
}
