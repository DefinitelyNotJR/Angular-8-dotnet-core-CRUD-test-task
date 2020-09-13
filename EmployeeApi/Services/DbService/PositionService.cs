using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;
using EmployeeApi.Models;
using EmployeeApi.Models.Entities;
using MongoDB.Driver;
using System.Linq;

namespace EmployeeApi.Services.DbService
{

    public class PositionService
    {
        private readonly IMongoCollection<Position> _positions;

        public PositionService(IEmployeeDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _positions = database.GetCollection<Position>(settings.PositionCollectionName);

        }

        public Position Create(Position position)
        {
            _positions.InsertOne(position);
            return position;
        }

        public List<Position> Get() =>
           _positions.Find(Position => true).ToList();

        public void Remove(string id) =>
           _positions.DeleteOne(position => position.Id == id);

    }

}