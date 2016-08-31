using Models;
using System.ServiceModel;

namespace WCFSemiStrictStrategy.Service.Services
{
    [ServiceContract(Name = "EmployeeService", Namespace = "http://www.MyWCFVersioningExample.com/sample/2016/09")] // changed to '09' from '08'
    public interface IEmployeeService_V2 : IEmployeeService
    {
        // NEW METHOD ADDED
        [OperationContract]
        Employee GetEmployee(int id);
    }
}
