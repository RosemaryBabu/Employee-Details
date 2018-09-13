using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebApi.DataBase;
using NetCoreWebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly EmployeeEntity _context;

        public ValuesController(EmployeeEntity context)
        {
            _context = context;

            if(_context.Employees.Count()==0)
            {
                _context.Employees.Add(new Employee
                {
                    FirstName = "Dummy Employee",
                    MiddleName = "Dummy Employee",
                    Salary = 0.0,
                    JoiningDate = DateTime.Now.Date
                });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Employee>> GetAll()
        {
            return _context.Employees.ToList();
        }

        [HttpGet("{Id}")]
        public ActionResult<Employee> GetById(int id)
        {
            var employee = _context.Employees.Find(id);
            if(employee==null)
            {
                return new NotFoundObjectResult("Employee not found");
            }
            return employee;
        }

        [HttpPost]

        public ActionResult Post(Employee employee)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Employees.Add(new Employee
            {
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                Salary = employee.Salary,
                JoiningDate = employee.JoiningDate
            });
            _context.SaveChanges();

            return new OkObjectResult("Employee created");
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int id)
        {
            if (_context.Employees.Find(id) == null)
            {
                return new NotFoundObjectResult("No Employee found at " + id + " position");
            }
            _context.Employees.Remove(_context.Employees.Find(id));
            return new OkObjectResult("Employee deleted");
        }
        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
