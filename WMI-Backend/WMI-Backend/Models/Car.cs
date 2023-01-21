using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WMI_Backend.Models
{
	public class Car
	{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Country { get; set; }
        [BsonRepresentation(BsonType.String)]
        public DateTimeOffset? CreatedOn { get; set; }
        [BsonRepresentation(BsonType.String)]
        public DateTimeOffset? DateAvailableToPublic { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? UpdatedOn { get; set; }
        public string VehicleType { get; set; }
        public string WMI { get; set; }
    }
}

