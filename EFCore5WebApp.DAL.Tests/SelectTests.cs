using NUnit.Framework;
using EFCore5WebApp.DAL;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using EFCore5WebApp.Core.Entities;

namespace EFCore5WebApp.DAL.Tests
{
    public class SelectTests
    {
        private AppDbContext _context;

        [SetUp]
        public void Setup()
        {
            _context = new AppDbContext(new DbContextOptionsBuilder<AppDbContext>()
                                        .UseSqlServer("Server=192.168.122.1;Database=EFCore5WebApp;User=sa;Password=mssql@121212;Trusted_Connection=True;MultipleActiveResultSets=true;integrated security=false").Options);
        }

        [Test]
        public void GetAllPersons()
        {
            IEnumerable<Person> persons = _context.Persons.ToList();
            Assert.AreEqual(2, persons.Count());
        }

        [Test]
        public void HaveLookUpRecords()
        {
            var lookUps = _context.LookUps.ToList();
            // Method queries example
            var countries = lookUps.Where(x => x.LookUpType == LookUpType.Country)
                .ToList();
            var states = lookUps.Where(x => x.LookUpType == LookUpType.State)
                .ToList();
            Assert.AreEqual(1, countries.Count());
            Assert.AreEqual(12, states.Count());

            // Link Queries type
            var newLookUps = from lookup in _context.LookUps where lookup.LookUpType == LookUpType.Country select lookup;
            Assert.AreEqual(newLookUps.ToList().Count(), 1);



        }
    }
}
