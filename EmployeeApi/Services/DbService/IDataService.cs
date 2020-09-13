using System.Threading.Tasks;
using EmployeeApi.Models.Entities;

namespace EmployeeApi.Services.DbService
{
    public interface IDataService
    {
        Task AddNewAsync();
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(Employee employee);
    }
}