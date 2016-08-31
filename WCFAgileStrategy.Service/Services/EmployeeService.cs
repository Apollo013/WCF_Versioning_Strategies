using Models;

namespace WCFAgileStrategy.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        // ADDED METHOD FOR V2
        public Employee GetEmployee(int id)
        {
            if (id == 1)
                return new Employee { Id = 1, Name = "Paul", Address = "Dublin" };
            else
                return null;
        }

        public Employee UpdateEmployee(Employee emp)
        {
            return new Employee() { Id = emp.Id, Name = emp.Name };
        }
    }
}