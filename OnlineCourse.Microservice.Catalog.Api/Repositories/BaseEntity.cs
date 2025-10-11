using MongoDB.Bson.Serialization.Attributes;

namespace OnlineCourse.Microservice.Catalog.Api.Repositories
{
    public class BaseEntity
    {
        //snow flakes
        [BsonElement("_id")] public Guid Id { get; set; }
    }
}
