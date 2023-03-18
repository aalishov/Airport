using Airport.Data;
using Airport.Models;
using Airport.Services;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airport.Tests
{
    public class AirportsServiceTests
    {

        private List<Models.Airport> airports = new List<Models.Airport>()
        {
            new Models.Airport(){Id=1,Name="SofiaAirport",Country="Bulgaria" }
        };

        private IQueryable<Models.Airport> dbTable = null;

        private AirportsService service = null;
        private Mock<AppDbContext> mockContext = null;


        [SetUp]
        public void Setup()
        {


            dbTable = airports.ToList().AsQueryable();

            var mockSet = new Mock<DbSet<Models.Airport>>();
            mockSet.As<IQueryable<Models.Airport>>().Setup(m => m.Provider).Returns(dbTable.Provider);
            mockSet.As<IQueryable<Models.Airport>>().Setup(m => m.Expression).Returns(dbTable.Expression);
            mockSet.As<IQueryable<Models.Airport>>().Setup(m => m.ElementType).Returns(dbTable.ElementType);
            mockSet.As<IQueryable<Models.Airport>>().Setup(m => m.GetEnumerator()).Returns(dbTable.GetEnumerator());

            mockContext = new Mock<AppDbContext>();
            mockContext.Setup(p => p.Airports).Returns(mockSet.Object);


            service = new AirportsService(mockContext.Object);
        }

        [Test]
        public void TestCreateAirportWithInvalidName()
        {

            var expected = "Airport invalid name!";
            var actual = service.CreateAirport("", "Bulgaria");

            Assert.That(actual, Is.EqualTo(expected));

            expected = "Airport invalid name!";
            actual = service.CreateAirport("       ", "Bulgaria");
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestCreateAirportWithInvalidCountryName()
        {

            var expected = "Airport invalid country name!";
            var actual = service.CreateAirport("Sofia", "");

            Assert.That(actual, Is.EqualTo(expected));

            expected = "Airport invalid country name!";
            actual = service.CreateAirport("Sofia", "    ");
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}
