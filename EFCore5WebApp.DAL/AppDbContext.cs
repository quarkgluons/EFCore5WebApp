using Microsoft.EntityFrameworkCore;
using EFCore5WebApp.Core.Entities;
using System.Collections.Generic;


namespace EFCore5WebApp.DAL
{
    // TO run these programs: run the command from the EFCore5WebApp MVC project folder
    // dotnet ef migrations add <Migration Name> --project ../EFCore5WebApp.DAL/EFCore5WebApp.DAL.csproj
    public class AppDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<LookUp> LookUps { get; set; }


        public AppDbContext() : base()
        {

        }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            const string V = "";
            modelBuilder.Entity<LookUp>().HasData(new List<LookUp>()
            {
                new LookUp() { Code = "AL", Description = "Alabama", LookUpType =
                        LookUpType.State},
                new LookUp() { Code = "AK", Description = "Alaska",
                        LookUpType = LookUpType.State},
                    new LookUp() { Code = "AZ", Description = "Arizona",
                        LookUpType = LookUpType.State},
                    new LookUp() { Code = "AR", Description = "Arkansas",
                        LookUpType = LookUpType.State},
                    new LookUp() { Code = "CA", Description = "California",
                        LookUpType = LookUpType.State},
                    new LookUp() { Code = "CO", Description = "Colorado",
                        LookUpType = LookUpType.State},
                    new LookUp() { Code = "CT", Description = "Connecticut",
                        LookUpType = LookUpType.State},
                    new LookUp() { Code = "DE", Description = "Delaware",
                        LookUpType = LookUpType.State},
                    new LookUp() { Code = "DC", Description = "District of Columbia",
                        LookUpType = LookUpType.State},
                    new LookUp() { Code = "FL", Description = "Florida",
                        LookUpType = LookUpType.State},
                    new LookUp() { Code = "GA", Description = "Georgia",
                        LookUpType = LookUpType.State},
                    new LookUp() { Code = "ID", Description = "Idaho",
                        LookUpType = LookUpType.State},
                    new LookUp() {Code="USA", Description = "United States of America",
                        LookUpType = LookUpType.Country}
            });
            modelBuilder.Entity<Person>().HasData(new List<Person>()
            {
                new Person(){ Id = 1, FirstName = "John", LastName = "Smith",
                        EmailAddress = "john@smith.com"},
                new Person(){ Id = 2, FirstName = "Susan", LastName = "Jones",
                        EmailAddress = "john@smith.com" }
            });
            modelBuilder.Entity<Address>().HasData(new List<Address>()
            {
                new Address() { Id = 1, AddressLine1 = "123 Test St", AddressLine2 = "",
                        City = "Beverly Hills", State = "CA", ZipCode = "90210", PersonId = 1,
                        Country = "USA"},
                    new Address() { Id = 2, AddressLine1 = "123 Michigan Ave",
                        AddressLine2 = "", City = "Chicago", State = "IL", ZipCode = "60612",
                        PersonId = 2, Country = "USA"},
                    new Address() { Id = 3, AddressLine1 = "100 1St St", AddressLine2 = "",
                        City = "Chicago", State = "IL", ZipCode = "60612", PersonId = 2,
                        Country = "USA"}
            });
        }
    }
}
