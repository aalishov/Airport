using NUnit.Framework;
using Moq;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using Airport.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Airport.Data;
using Airport.Services;

namespace Airport.Tests
{
    public class PilotsServiceTests
    {
        private List<string> firstNames = new List<string>() { "Alexander", "Cullan", "Germana", "Janka", "Krystal", "Susy", "Saxon", "Lenore", "Enrichetta", "Delaney", "Carlotta" };
        private List<string> lastNames = new List<string>() { "Emburey", "Loblie", "Romera", "Oneal", "Ravenshear", "Gribben", "Briddock", "Salasar", "Albrooke", "Wainscot", "McDarmid" };

        private List<Pilot> pilots = new List<Pilot>();

        private IQueryable<Pilot> dbTablePilots = null;

        private PilotsService service = null;
        private Mock<AppDbContext> mockContext = null;

        [SetUp]
        public void Setup()
        {
            Random random = new Random();
            pilots.Clear();
            for (int i = 1; i <= 50; i++)
            {
                Pilot pilot = new Pilot()
                {
                    Id = i,
                    FirstName = firstNames[random.Next(firstNames.Count)],
                    LastName = lastNames[random.Next(lastNames.Count)],
                    Rating = random.Next(10) * random.NextDouble(),
                    Age = random.Next(18, 60)
                };
                pilots.Add(pilot);
            }
            dbTablePilots = pilots.ToList().AsQueryable();

            var mockSet = new Mock<DbSet<Pilot>>();
            mockSet.As<IQueryable<Pilot>>().Setup(m => m.Provider).Returns(dbTablePilots.Provider);
            mockSet.As<IQueryable<Pilot>>().Setup(m => m.Expression).Returns(dbTablePilots.Expression);
            mockSet.As<IQueryable<Pilot>>().Setup(m => m.ElementType).Returns(dbTablePilots.ElementType);
            mockSet.As<IQueryable<Pilot>>().Setup(m => m.GetEnumerator()).Returns(dbTablePilots.GetEnumerator());

            mockContext = new Mock<AppDbContext>();
            mockContext.Setup(p => p.Pilots).Returns(mockSet.Object);


            service = new PilotsService(mockContext.Object);
        }


        [Test]
        public void TestGetPilotsPagesCount()
        {

            var expected = 5;
            var actual = service.GetPilotsPagesCount();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestGetAndDeletePilotByIdCount()
        {
            Pilot pilot = service.GetPilotById(1);

            var expected = $"{nameof(Pilot)} {pilot.FirstName} {pilot.LastName} was deleted!"; ;
            var actual = service.DeletePilotById(pilot.Id);

            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}