using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using WMI_Backend.Models;
using System.Linq;
using Microsoft.AspNetCore.OData.Query;
using MongoDB.Bson;

namespace WMI_Backend.Repository
{
    public class CarsRepository
    {
        private readonly IMongoCollection<Car> _carsCollection;

        public CarsRepository()
        {

        }

        public CarsRepository(IOptions<WmiDatabaseConfig> wmiDatabaseConfig)
        {
            var mongoClient = new MongoClient(
            wmiDatabaseConfig.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                wmiDatabaseConfig.Value.DatabaseName);

            _carsCollection = mongoDatabase.GetCollection<Car>(
                wmiDatabaseConfig.Value.BooksCollectionName);
        }

        public virtual List<Car> GetAll(ODataQueryOptions<Car> options)
        {
            var query = _carsCollection.AsQueryable();
            var result = (IQueryable<Car>)options.ApplyTo(query, new ODataQuerySettings()
            {
                HandleNullPropagation = HandleNullPropagationOption.False

            });
            return result.ToList();
        }

        public virtual long GetTotalCount(FilterQueryOption filter)
        {
            if (filter != null)
            {
                var query = _carsCollection.AsQueryable();
                var result = (IQueryable<Car>)filter.ApplyTo(query, new ODataQuerySettings() {
                    HandleNullPropagation = HandleNullPropagationOption.False

                });
                return result.Count();
            }
            return GetTotalCount();
        }

        public virtual long GetTotalCount()
        {
            return _carsCollection.CountDocuments(new BsonDocument());
        }

        public virtual async Task<List<string>> GetCountries()
        {
            var filter = new BsonDocument();
            return await _carsCollection.Distinct<string>(nameof(Country), filter).ToListAsync();
        }

        public void InsertMany(List<Car> cars)
        {
            _carsCollection.InsertMany(cars);
        }
    }
}

