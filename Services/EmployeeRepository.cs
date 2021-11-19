using Microsoft.EntityFrameworkCore;
using Moq.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moq.Demo.Services
{
    public class EmployeeRepository : IEmplopyeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Employee> GetById(int id)
        {
            Employee employee = await _context.Employees.FirstOrDefaultAsync(em => em.id == id);
            return employee;
        }

        public async Task<string> GetEmployeeInfo(int id)
        {
            string name = await _context.Employees.Where(c => c.id == id).Select(d => d.name).FirstOrDefaultAsync();
            return name;
        }
    }
}
