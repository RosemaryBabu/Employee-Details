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
    public class DetailsModel : PageModel
    {
        private readonly NetCoreWebApi.DataBase.EmployeeEntity _context;

        public DetailsModel(NetCoreWebApi.DataBase.EmployeeEntity context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employees.FirstOrDefaultAsync(m => m.ID == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
