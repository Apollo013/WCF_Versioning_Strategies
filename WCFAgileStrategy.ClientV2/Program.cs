using System;
using WCFAgileStrategy.ClientV2.AgileEmployeeServiceProxy;

namespace WCFAgileStrategy.ClientV2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EmployeeServiceClient client = new EmployeeServiceClient())
            {
                var e = client.UpdateEmployee(new Employee { Id = 1, Name = "Paul" });
                Console.WriteLine($"Employee ID: {e.Id} ; Name: {e.Name} ; Address {e.Address}"); // Same as V1, but with Address property

                Console.WriteLine(new String('-', 120));

                // New method call for V2
                e = client.GetEmployee(1);
                Console.WriteLine($"Employee ID: {e.Id} ; Name: {e.Name} ; Address {e.Address}"); // Same as V1, but with Address property
            }
        }
    }
}
