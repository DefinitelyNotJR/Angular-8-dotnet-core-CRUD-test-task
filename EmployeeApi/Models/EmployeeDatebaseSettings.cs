namespace EmployeeApi.Models
{
    public class EmployeeDatabaseSettings : IEmployeeDatabaseSettings
    {
        public string EmployeeCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

        public string PositionCollectionName { get; set; }
    }

    public interface IEmployeeDatabaseSettings
    {
        string EmployeeCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string PositionCollectionName { get; set; }
    }
}