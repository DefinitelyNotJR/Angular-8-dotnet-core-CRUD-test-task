using System;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace EmployeeApi.Models.Entities
{
    public class Position : BaseEntity
    {
        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string Name { get; set; }
        
    }
} 
