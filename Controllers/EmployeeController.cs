using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq.Demo.Models;
using Moq.Demo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moq.Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmplopyeeRepository _emplopyeeRepository;
        public EmployeeController(IEmplopyeeRepository emplopyeeRepository)
        {
            _emplopyeeRepository = emplopyeeRepository;
        }
        [HttpGet(nameof(GetById))]
        public async Task<Employee> GetById(int id)
        {
           Employee employee = await _emplopyeeRepository.GetById(id);
           return employee;
        }
        [HttpGet(nameof(GetEmployeeInfo))]
        public async Task<string> GetEmployeeInfo(int id)
        {
            string name=await _emplopyeeRepository.GetEmployeeInfo(id);
            return name;
        }
    }
}
