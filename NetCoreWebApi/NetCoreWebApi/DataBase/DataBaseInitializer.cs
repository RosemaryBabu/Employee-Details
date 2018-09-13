using NetCoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApi.DataBase
{
    public class DataBaseInitializer
    {
        public static void Initialize(EmployeeEntity context)
        {
            context.Database.EnsureCreated();

            if(context.Employees.Any())
            {
                return;
            }
            var employees = new Employee[]
            {
                new Employee{FirstName="David",MiddleName="Sam",JoiningDate=DateTime.Now.Date,Salary=15000.00},
                new Employee{FirstName="Midhun",MiddleName="Raj",JoiningDate=DateTime.Now.Date,Salary=15000.00},
                new Employee{FirstName="G",MiddleName="Gopal",JoiningDate=DateTime.Now.Date,Salary=20000.00},
                new Employee{FirstName="Shan",MiddleName="K",JoiningDate=DateTime.Now.Date,Salary=15000.00},
                new Employee{FirstName="Megna",MiddleName="Jacob",JoiningDate=DateTime.Now.Date,Salary=15000.00},
                new Employee{FirstName="Ann",MiddleName="Thomas",JoiningDate=DateTime.Now.Date,Salary=5000.00},
                new Employee{FirstName="Lucy",MiddleName="Maggie",JoiningDate=DateTime.Now.Date,Salary=1000.00},
                new Employee{FirstName="Henny",MiddleName="Teresa",JoiningDate=DateTime.Now.Date,Salary=16000.00},
                new Employee{FirstName="Athira",MiddleName="Jose",JoiningDate=DateTime.Now.Date,Salary=15000.00},
                new Employee{FirstName="Amarnath",MiddleName="K",JoiningDate=DateTime.Now.Date,Salary=10000.00},
                new Employee{FirstName="Eana",MiddleName="Akhil",JoiningDate=DateTime.Now.Date,Salary=17000.00},
                new Employee{FirstName="Eva",MiddleName="Mariya",JoiningDate=DateTime.Now.Date,Salary=20000.00},
                new Employee{FirstName="Unni",MiddleName="Sidharth",JoiningDate=DateTime.Now.Date,Salary=12000.00},
                new Employee{FirstName="Lakshmi",MiddleName="Nair",JoiningDate=DateTime.Now.Date,Salary=16000.00}

            };

            foreach(Employee  e in employees)
            {
                context.Employees.Add(e);
            }

            context.SaveChanges();
        }
    }
}
