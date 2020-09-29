using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_mvc_webapp_sample.Repository
{
    public class EmployeeMapper : Profile
    {
        public EmployeeMapper()
        {
            //CreateMap<Employee, Models.Employee>();
            //CreateMap<Models.Employee, Employee>(); // used while save
        }
    }
}
