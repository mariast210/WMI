using System;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using WMI_Backend.Models;
using System.Linq;
using Microsoft.AspNetCore.OData.Query;

namespace WMI_Backend.Repository
{
	public class CarsRepository
	{
        private readonly IMongoCollection<Car> _carsCollection;

        public CarsRepository(IOptions<WmiDatabaseConfig> wmiDatabaseConfig)
        {
            var mongoClient = new MongoClient(
            wmiDatabaseConfig.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                wmiDatabaseConfig.Value.DatabaseName);

            _carsCollection = mongoDatabase.GetCollection<Car>(
                wmiDatabaseConfig.Value.BooksCollectionName);
        }

        public List<Car> GetAll(ODataQueryOptions<Car> options)
        {
            var query = _carsCollection.AsQueryable();
            var result = (IQueryable<Car>)options.ApplyTo(query);
            return result.ToList();
        }

        public int GetTotalCount(FilterQueryOption filter)
        {
            if (filter != null)
            {
                var query = _carsCollection.AsQueryable();
                var result = (IQueryable<Car>)filter.ApplyTo(query, new ODataQuerySettings());
                return result.Count();
            }
            return default;
        }
    }
}

