﻿using Models;

namespace WCFStrictStrategy.Service.Services
{
    public class EmployeeService : IEmployeeService, IEmployeeService_V2
    {
        public Employee GetEmployee(int id)
        {
            if (id == 1)
            {
                return new Employee { Id = 1, Name = "Paul", Address = "Dublin" };
            }
            return null;
        }

        public Employee UpdateEmployee(Employee emp)
        {
            return emp;
        }
    }
}