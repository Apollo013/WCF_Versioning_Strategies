using System;
using WCFAgileStrategy.Client.AgileEmployeeServiceProxy;

namespace WCFAgileStrategy.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EmployeeServiceClient client = new EmployeeServiceClient())
            {
                var e = client.UpdateEmployee(new Employee { Id = 1, Name = "Paul" });
                Console.WriteLine($"Employee ID: {e.Id} ; Name: {e.Name}");
            }
        }
    }
}
