using Models;
using System.ServiceModel;

namespace WCFAgileStrategy.Service.Services
{
    [ServiceContract(Name = "EmployeeService", Namespace = "http://www.MyWCFVersioningExample.com/sample/2016/08")]
    public interface IEmployeeService
    {
        [OperationContract]
        Employee UpdateEmployee(Employee emp);


        // NEW METHOD ADDED
        [OperationContract]
        Employee GetEmployee(int id);
    }
}
