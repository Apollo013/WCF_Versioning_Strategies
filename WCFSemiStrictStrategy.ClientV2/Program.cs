using Models;
using System;
using WCFSemiStrictStrategy.ClientV2.EmployeeServiceProxy;

namespace WCFSemiStrictStrategy.ClientV2
{
    class Program
    {
        static void Main(string[] args)
        {
            // V1
            using (EmployeeServiceClient client = new EmployeeServiceClient())
            {
                var e = client.UpdateEmployee(new Employee { Id = 1, Name = "Paul" });
                Console.WriteLine($"Employee ID: {e.Id} ; Name: {e.Name} ");
            }

            // V2
            using (EmployeeService1Client client = new EmployeeService1Client())
            {
                Console.WriteLine(new String('-', 120));

                // New method call for V2
                var e = client.GetEmployee(1);
                Console.WriteLine($"Employee ID: {e.Id} ; Name: {e.Name}");
            }
        }
    }
}
