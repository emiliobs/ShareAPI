using Microsoft.EntityFrameworkCore;
using Shared.Common.Entities;

namespace Shared.API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    // Logic: Define DbSet for Users and Clients
    public DbSet<User> Users { get; set; }

    public DbSet<Client> Clients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Logic: Set unique index for Email
        modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
        modelBuilder.Entity<Client>().HasIndex(c => c.Email).IsUnique();

        // Logic: Seed 25 users into the database
        try
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Emilio", LastName = "Barrera", Phone = "56912345678123456789", Email = "emilio@example.com", Password = "Pass123" },
                new User { Id = 2, FirstName = "Juan", LastName = "Perez", Phone = "56900000000123456780", Email = "juan.perez@example.com", Password = "User456" },
                new User { Id = 3, FirstName = "Maria", LastName = "Lopez", Phone = "56900000000123456781", Email = "m.lopez@example.com", Password = "Secret789" },
                new User { Id = 4, FirstName = "Carlos", LastName = "Soto", Phone = "56900000000123456782", Email = "c.soto@example.com", Password = "Admin321" },
                new User { Id = 5, FirstName = "Ana", LastName = "Silva", Phone = "56900000000123456783", Email = "a.silva@example.com", Password = "Power999" },
                new User { Id = 6, FirstName = "Luis", LastName = "Martinez", Phone = "56900000000123456784", Email = "l.martinez@example.com", Password = "Login111" },
                new User { Id = 7, FirstName = "Elena", LastName = "Gomez", Phone = "56900000000123456785", Email = "e.gomez@example.com", Password = "Pass555" },
                new User { Id = 8, FirstName = "Pedro", LastName = "Castro", Phone = "56900000000123456786", Email = "p.castro@example.com", Password = "Word000" },
                new User { Id = 9, FirstName = "Sofia", LastName = "Rojas", Phone = "56900000000123456787", Email = "s.rojas@example.com", Password = "Key1234" },
                new User { Id = 10, FirstName = "Diego", LastName = "Torres", Phone = "56900000000123456788", Email = "d.torres@example.com", Password = "Dev8888" },
                new User { Id = 11, FirstName = "Laura", LastName = "Vargas", Phone = "56900000000123456789", Email = "l.vargas@example.com", Password = "Test222" },
                new User { Id = 12, FirstName = "Jorge", LastName = "Herrera", Phone = "56900000000123456710", Email = "j.herrera@example.com", Password = "Secure9" },
                new User { Id = 13, FirstName = "Rosa", LastName = "Mendez", Phone = "56900000000123456711", Email = "r.mendez@example.com", Password = "Mendez1" },
                new User { Id = 14, FirstName = "Pablo", LastName = "Araya", Phone = "56900000000123456712", Email = "p.araya@example.com", Password = "Araya22" },
                new User { Id = 15, FirstName = "Carmen", LastName = "Nuñez", Phone = "56900000000123456713", Email = "c.nunez@example.com", Password = "Nunez33" },
                new User { Id = 16, FirstName = "Mario", LastName = "Pinto", Phone = "56900000000123456714", Email = "m.pinto@example.com", Password = "Pinto44" },
                new User { Id = 17, FirstName = "Isabel", LastName = "Duran", Phone = "56900000000123456715", Email = "i.duran@example.com", Password = "Duran55" },
                new User { Id = 18, FirstName = "Andres", LastName = "Jara", Phone = "56900000000123456716", Email = "a.jara@example.com", Password = "Jara666" },
                new User { Id = 19, FirstName = "Paola", LastName = "Salas", Phone = "56900000000123456717", Email = "p.salas@example.com", Password = "Salas77" },
                new User { Id = 20, FirstName = "Raul", LastName = "Vega", Phone = "56900000000123456718", Email = "r.vega@example.com", Password = "Vega888" },
                new User { Id = 21, FirstName = "Gloria", LastName = "Ruz", Phone = "56900000000123456719", Email = "g.ruz@example.com", Password = "Ruz9999" },
                new User { Id = 22, FirstName = "Felipe", LastName = "Leiva", Phone = "56900000000123456720", Email = "f.leiva@example.com", Password = "Leiva10" },
                new User { Id = 23, FirstName = "Monica", LastName = "Pena", Phone = "56900000000123456721", Email = "m.pena@example.com", Password = "Pena202" },
                new User { Id = 24, FirstName = "Hugo", LastName = "Cano", Phone = "56900000000123456722", Email = "h.cano@example.com", Password = "Cano303" },
                new User { Id = 25, FirstName = "Silvia", LastName = "Bustos", Phone = "56900000000123456723", Email = "s.bustos@example.com", Password = "Bustos4" }
            );

            modelBuilder.Entity<Client>().HasData(
                 new Client { Id = 1, Name = "Tech Solutions", Email = "contact@techsolutions.com", PhoneNumber = "+1234567890" },
                 new Client { Id = 2, Name = "Global Logistics", Email = "info@globallogistics.com", PhoneNumber = "+1987654321" },
                 new Client { Id = 3, Name = "Creative Agency", Email = "hello@creativeagency.net", PhoneNumber = "+1122334455" },
                 new Client { Id = 4, Name = "Summit Retail", Email = "support@summitretail.com", PhoneNumber = "+1555666777" },
                 new Client { Id = 5, Name = "Oceanic Corp", Email = "admin@oceanic.org", PhoneNumber = "+1444333222" },
                 new Client { Id = 6, Name = "Prime Health", Email = "billing@primehealth.com", PhoneNumber = "+1888999000" },
                 new Client { Id = 7, Name = "Eco Energy", Email = "sales@ecoenergy.io", PhoneNumber = "+1777111222" },
                 new Client { Id = 8, Name = "Stellar Soft", Email = "dev@stellarsoft.com", PhoneNumber = "+1666555444" },
                 new Client { Id = 9, Name = "Urban Eats", Email = "manager@urbaneats.com", PhoneNumber = "+1222999888" },
                 new Client { Id = 10, Name = "Blue Horizon", Email = "info@bluehorizon.com", PhoneNumber = "+1333444555" },
                 new Client { Id = 11, Name = "Fast Track", Email = "ops@fasttrack.com", PhoneNumber = "+1999888777" },
                 new Client { Id = 12, Name = "Green Leaf", Email = "contact@greenleaf.net", PhoneNumber = "+1000111222" },
                 new Client { Id = 13, Name = "Nexus IT", Email = "support@nexusit.com", PhoneNumber = "+1111222333" },
                 new Client { Id = 14, Name = "Skyline Const", Email = "office@skyline.com", PhoneNumber = "+1444555666" },
                 new Client { Id = 15, Name = "Peak Finance", Email = "wealth@peakfinance.com", PhoneNumber = "+1777888999" },
                 new Client { Id = 16, Name = "Nova Media", Email = "ads@novamedia.com", PhoneNumber = "+1222333444" },
                 new Client { Id = 17, Name = "Terra Firma", Email = "land@terrafirma.org", PhoneNumber = "+1555444333" },
                 new Client { Id = 18, Name = "Vivid Arts", Email = "gallery@vividarts.com", PhoneNumber = "+1666777888" },
                 new Client { Id = 19, Name = "Zenith Group", Email = "ceo@zenith.com", PhoneNumber = "+1888777666" },
                 new Client { Id = 20, Name = "Delta Apps", Email = "build@deltaapps.io", PhoneNumber = "+1000999888" }
             );
        }
        catch (Exception ex)
        {
            // Error handling for data seeding
            throw new Exception("Error while seeding data: " + ex.Message);
        }
    }
}