using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NetCoreWebApi.DataBase;
using NetCoreWebApi.Models;

namespace NetCoreWebApi
{
    public class IndexModel : PageModel
    {
        private readonly NetCoreWebApi.DataBase.EmployeeEntity _context;

        public IndexModel(NetCoreWebApi.DataBase.EmployeeEntity context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees.ToListAsync();
        }
    }
}
