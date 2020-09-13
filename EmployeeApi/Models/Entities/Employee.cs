using System;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace EmployeeApi.Models.Entities
{
    public class Employee : BaseEntity
    {
        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string Name { get; set; }
        [BsonElement("Position")]
        [JsonProperty("Position")]
        public string Position { get; set; }
        [BsonElement("Salary")]
        [JsonProperty("Salary")]
        public int Salary { get; set; }
        [BsonElement("DateStartedWorking")]
        [JsonProperty("DateStartedWorking")]
        public string DateStartedWorking { get; set; }
        [BsonElement("DateStoppedWorking")]
        [JsonProperty("DateStoppedWorking")]
        public string DateStoppedWorking { get; set; }
    }
} 
