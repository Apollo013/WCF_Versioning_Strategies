using Models;
using System;
using WCFStrictStrategy.ClientV2.EmployeeServiceProxy;

namespace WCFStrictStrategy.ClientV2
{
    class Program
    {
        static void Main(string[] args)
        {
            // V1 & V2
            using (EmployeeServiceClient client = new EmployeeServiceClient())
            {
                var e = client.UpdateEmployee(new Employee { Id = 1, Name = "Paul" });
                Console.WriteLine($"Employee ID: {e.Id} ; Name: {e.Name} ");

                Console.WriteLine(new String('-', 120));

                // New method call for V2
                e = client.GetEmployee(1);
                Console.WriteLine($"Employee ID: {e.Id} ; Name: {e.Name}");
            }
        }
    }
}
