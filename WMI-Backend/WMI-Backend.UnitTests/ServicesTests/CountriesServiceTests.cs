using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using WMI_Backend.Models;
using WMI_Backend.Repository;
using WMI_Backend.Services;
using Xunit;

namespace WMI_Backend.UnitTests.ServicesTests
{
    public class CountriesServiceTests
    {
        private readonly Mock<CarsRepository> _carsRepositoryMock;

        public CountriesServiceTests()
        {
            _carsRepositoryMock = new Mock<CarsRepository>();
        }

        [Fact]
        public async Task GetAll_ShouldReturnList()
        {
            // Arrange
            var data = new List<string> { "US", "MEXICO"};
            _carsRepositoryMock.Setup(p => p.GetCountries()).ReturnsAsync(data);
            var service = new CountriesService(_carsRepositoryMock.Object);

            // Act
            var result = await service.GetAll();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(data.Count, result.Count);
        }

        [Fact]
        public async Task GetAll_WhenNoData_ShouldReturnEmptyList()
        {
            // Arrange
            var data = new List<string>();
            _carsRepositoryMock.Setup(p => p.GetCountries()).ReturnsAsync(data);
            var service = new CountriesService(_carsRepositoryMock.Object);

            // Act
            var result = await service.GetAll();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public async Task GetAll_WhenNullItemPresent_ShouldMapToBlank()
        {
            // Arrange
            var data = new List<string> { null};
            _carsRepositoryMock.Setup(p => p.GetCountries()).ReturnsAsync(data);
            var service = new CountriesService(_carsRepositoryMock.Object);

            // Act
            var result = await service.GetAll();

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Blank", result.First().Value);
        }
    }
}

