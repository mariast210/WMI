using System;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WMI_Backend.Repository;
using WMI_Backend.Services;
using Xunit;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.Http;
using Castle.Core.Resource;
using Microsoft.OData.ModelBuilder;
using WMI_Backend.Models;
using Microsoft.OData.UriParser;
using System.Linq;

namespace WMI_Backend.UnitTests.ServicesTests
{
    public class CarsServiceTests
    {
        private readonly Mock<CarsRepository> _carsRepositoryMock;

        public CarsServiceTests()
        {
            _carsRepositoryMock = new Mock<CarsRepository>();
        }

        [Fact]
        public void GetAll_ShouldReturnList()
        {
            // Arrange
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Car>("Cars");
            var httpContext = new DefaultHttpContext();
            var queryOptions = new ODataQueryOptions<Car>(new ODataQueryContext(builder.GetEdmModel(), typeof(Car), new ODataPath()), httpContext.Request);

            var data = new List<Car> { new Car {
                    Country = null,
                    CreatedOn = DateTimeOffset.Parse("2015-03-26"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    UpdatedOn = DateTimeOffset.Parse("2015-06-04"),
                    VehicleType = "Passenger Car",
                    WMI = "JHM"
                },
                new Car {
                    Country = "UNITED STATES (USA)",
                    CreatedOn = DateTimeOffset.Parse("2015-03-26"),
                    DateAvailableToPublic = DateTimeOffset.Parse("2015-01-01"),
                    Name = "HONDA OF AMERICA MFG., INC.",
                    UpdatedOn = null,
                    VehicleType = "Passenger Car",
                    WMI = "1HG"
                } };
            _carsRepositoryMock.Setup(p => p.GetAll(queryOptions)).Returns(data);
            _carsRepositoryMock.Setup(p => p.GetTotalCount(queryOptions.Filter)).Returns(2);
            var service = new CarsService(_carsRepositoryMock.Object);

            // Act
            var result = service.GetAll(queryOptions);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.TotalCount);
            Assert.Equal(2, result.Data.Count());
        }
    }
}

