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

    public DbSet<Company> Companies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Logic: Set unique index for Email
        modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
        modelBuilder.Entity<Client>().HasIndex(c => c.Email).IsUnique();
        modelBuilder.Entity<Company>().HasIndex(com => com.TaxId).IsUnique();
        modelBuilder.Entity<Company>().HasIndex(com => com.ContactEmail).IsUnique();

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

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Alpha Tech Group", TaxId = "76.123.456-1", Address = "Silicon Valley 101", ContactEmail = "info@alphatech.com", Phone = "+15550101" },
                new Company { Id = 2, Name = "Beta Logistics SA", TaxId = "76.123.456-2", Address = "Industrial Park 45", ContactEmail = "ops@betalog.com", Phone = "+15550102" },
                new Company { Id = 3, Name = "Gamma Creative Lab", TaxId = "76.123.456-3", Address = "Downtown Ave 789", ContactEmail = "hello@gammalab.net", Phone = "+15550103" },
                new Company { Id = 4, Name = "Delta Food & Bev", TaxId = "76.123.456-4", Address = "Market Street 12", ContactEmail = "orders@deltafood.com", Phone = "+15550104" },
                new Company { Id = 5, Name = "Epsilon Energy", TaxId = "76.123.456-5", Address = "Green Tower 5", ContactEmail = "admin@epsilon.org", Phone = "+15550105" },
                new Company { Id = 6, Name = "Zeta Healthcare", TaxId = "76.123.456-6", Address = "Medical Center Plaza", ContactEmail = "care@zetahealth.com", Phone = "+15550106" },
                new Company { Id = 7, Name = "Eta Construction", TaxId = "76.123.456-7", Address = "Build Site 99", ContactEmail = "projects@etacon.com", Phone = "+15550107" },
                new Company { Id = 8, Name = "Theta Software", TaxId = "76.123.456-8", Address = "Code Road 404", ContactEmail = "support@theta.io", Phone = "+15550108" },
                new Company { Id = 9, Name = "Iota Retail", TaxId = "76.123.456-9", Address = "Shopping Mall Wing B", ContactEmail = "sales@iota.com", Phone = "+15550109" },
                new Company { Id = 10, Name = "Kappa Finance", TaxId = "76.123.456-10", Address = "Wall Street 200", ContactEmail = "finance@kappa.net", Phone = "+15550110" },
                new Company { Id = 11, Name = "Lambda Transport", TaxId = "76.123.456-11", Address = "Port Terminal 3", ContactEmail = "fleet@lambda.com", Phone = "+15550111" },
                new Company { Id = 12, Name = "Mu Marketing", TaxId = "76.123.456-12", Address = "Creative Hub 10", ContactEmail = "ads@mu.agency", Phone = "+15550112" },
                new Company { Id = 13, Name = "Nu Networking", TaxId = "76.123.456-13", Address = "Signal Way 55", ContactEmail = "noc@nu.com", Phone = "+15550113" },
                new Company { Id = 14, Name = "Xi Exports", TaxId = "76.123.456-14", Address = "Global Trade Center", ContactEmail = "export@xi.com", Phone = "+15550114" },
                new Company { Id = 15, Name = "Omicron Security", TaxId = "76.123.456-15", Address = "Safe House Blvd", ContactEmail = "protect@omicron.org", Phone = "+15550115" },
                new Company { Id = 16, Name = "Pi Consulting", TaxId = "76.123.456-16", Address = "Expertise Lane 314", ContactEmail = "advice@piconsult.com", Phone = "+15550116" },
                new Company { Id = 17, Name = "Rho Real Estate", TaxId = "76.123.456-17", Address = "Property Heights 22", ContactEmail = "rent@rho.com", Phone = "+15550117" },
                new Company { Id = 18, Name = "Sigma Telecom", TaxId = "76.123.456-18", Address = "Antenna Hill 1", ContactEmail = "telco@sigma.io", Phone = "+15550118" },
                new Company { Id = 19, Name = "Tau Tourism", TaxId = "76.123.456-19", Address = "Airport View 77", ContactEmail = "travel@tau.com", Phone = "+15550119" },
                new Company { Id = 20, Name = "Upsilon Mining", TaxId = "76.123.456-20", Address = "Mountain Road 50", ContactEmail = "earth@upsilon.com", Phone = "+15550120" }
            );
        }
        catch (Exception ex)
        {
            // Error handling for data seeding
            throw new Exception("Error while seeding data: " + ex.Message);
        }
    }
}