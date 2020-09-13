using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;
using EmployeeApi.Models;
using EmployeeApi.Models.Entities;
using MongoDB.Driver;
using System.Linq;
using System;

namespace EmployeeApi.Services.DbService

{
    public class EmployeeService 
    {
        private readonly IMongoCollection<Employee> _employees;

        public EmployeeService(IEmployeeDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _employees = database.GetCollection<Employee>(settings.EmployeeCollectionName);
        }

        public List<Employee> Get() =>
            _employees.Find(Employee => true).ToList();
        public Employee Get(string id) =>
            _employees.Find<Employee>(c => c.Id == id).FirstOrDefault();

        public Employee Create(Employee employee)
        {
            var dupes = _employees.Find<Employee>(c => c.Name == employee.Name && String.IsNullOrEmpty(c.DateStoppedWorking)).ToList();
            foreach(var dupe in dupes)
            {
                var emp = dupe;
                emp.DateStoppedWorking = DateTime.Now.Date.ToString("yyyy-MM-dd");
                Update(dupe.Id, emp);
            }
            _employees.InsertOne(employee);
            return employee;
        }
        public void Update(string id, Employee employeeIn) =>
            _employees.ReplaceOne(employee => employee.Id == id, employeeIn);
        public void Remove(Employee employeeIn) =>
            _employees.DeleteOne(employee => employee.Id == employeeIn.Id);
        public void Remove(string id) =>
            _employees.DeleteOne(employee => employee.Id == id);
        
    }
}

