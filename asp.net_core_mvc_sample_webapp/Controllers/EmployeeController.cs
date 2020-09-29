using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.net_core_mvc_webapp_sample.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_mvc_webapp_sample.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IMapper _mapper;
        public EmployeeController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult ViewEmployees()
        {
            var emp = new List<Employee>();
            emp.Add(new Employee()
            {
                Id = 1,
                Name = "Anu",
                Age = "26",
                Gender = "Female",
                Designation = "TA",
                Email = "anu@abc.com",
                Detail = "lorem ipsum lorem ipsum lorem ipsum."
            });

            emp.Add(new Employee()
            {
                Id = 2,
                Name = "Raghav",
                Age = "22",
                Gender = "Male",
                Designation = "SE",
                Email = "raghav@abc.com",
                Detail = "lorem ipsum lorem ipsum lorem ipsum."
            });

            var empList = new List<Models.Employee>();
            foreach (var e in emp)
            {
                empList.Add(_mapper.Map<Models.Employee>(e));
            }

            return View(empList);
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveEmployee(Models.Employee emp)
        {
            if (ModelState.IsValid)
            {
                //var res = _mapper.Map<Employee>(emp);
                // call DAl to save

            }

            return View("AddEmp", emp);
        }

        public IActionResult UpdateEmployee(Models.Employee emp)
        {
            return View(emp);
        }

        [HttpPost]
        public IActionResult SaveEmployeeUpdate(Models.Employee emp)
        {
            if (ModelState.IsValid)
            {
                //var res = _mapper.Map<Employee>(emp);
                // status=call DAl to save

                return RedirectToAction("ViewEmployee");
            }

            return View("UpdateEmployee", emp);
        }

        public IActionResult DeleteEmployee(Models.Employee emp)
        {
            return View(emp);
        }

        [HttpPost]
        public IActionResult SaveDeletion(int id)
        {
            try
            {
                //var res = _mapper.Map<Employee>(emp);
                // status=call DAl to delete

                return RedirectToAction("ViewEmployees");
            }
            catch
            {
                return View("Error");
            }
        }
    }
}
