using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeApi.Models.Entities;
using EmployeeApi.Services.DbService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;
        
        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult<List<Employee>> Get() =>
            _employeeService.Get();

        [Route("add")]
        [HttpPost]
        public ActionResult<Employee> Create ( Employee employee) =>
        
            _employeeService.Create(employee);
            
        [Route("delete/{id}")]
        [HttpDelete]
        public void Delete(string id) =>
            _employeeService.Remove(id);


        
    }
}