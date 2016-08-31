using Models;
using System.ServiceModel;

namespace WCFSemiStrictStrategy.Service.Services
{
    [ServiceContract(Name = "EmployeeService", Namespace = "http://www.MyWCFVersioningExample.com/sample/2016/08")]
    public interface IEmployeeService
    {
        [OperationContract]
        Employee UpdateEmployee(Employee emp);
    }
}
