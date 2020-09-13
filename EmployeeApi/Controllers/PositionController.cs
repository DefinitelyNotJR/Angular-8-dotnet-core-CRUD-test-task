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
    public class PositionController : ControllerBase
    {
        private readonly PositionService _positionService;
        
        public PositionController(PositionService positionService)
        {
            _positionService = positionService;
        }

        [HttpGet]
        public ActionResult<List<Position>> Get() =>
            _positionService.Get();

        [Route("add")]
        [HttpPost]
        public ActionResult<Position> Create ( Position position) =>
            _positionService.Create(position);
        
        [Route("delete/{id}")]
        [HttpDelete]
        public void Delete(string id) =>
            _positionService.Remove(id);

        
    }
}