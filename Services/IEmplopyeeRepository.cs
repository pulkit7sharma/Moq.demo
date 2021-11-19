using Moq.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moq.Demo.Services
{
    public interface IEmplopyeeRepository
    {
        public Task<Employee> GetById(int id);
        public Task<string> GetEmployeeInfo(int id);
    }
}
