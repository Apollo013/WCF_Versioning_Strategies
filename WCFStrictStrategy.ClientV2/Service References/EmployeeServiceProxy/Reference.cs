﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFStrictStrategy.ClientV2.EmployeeServiceProxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.MyWCFVersioningExample.com/sample/2016/09", ConfigurationName="EmployeeServiceProxy.EmployeeService")]
    public interface EmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.MyWCFVersioningExample.com/sample/2016/09/EmployeeService/UpdateEmploy" +
            "ee", ReplyAction="http://www.MyWCFVersioningExample.com/sample/2016/09/EmployeeService/UpdateEmploy" +
            "eeResponse")]
        Models.Employee UpdateEmployee(Models.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.MyWCFVersioningExample.com/sample/2016/09/EmployeeService/UpdateEmploy" +
            "ee", ReplyAction="http://www.MyWCFVersioningExample.com/sample/2016/09/EmployeeService/UpdateEmploy" +
            "eeResponse")]
        System.Threading.Tasks.Task<Models.Employee> UpdateEmployeeAsync(Models.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.MyWCFVersioningExample.com/sample/2016/09/EmployeeService/GetEmployee", ReplyAction="http://www.MyWCFVersioningExample.com/sample/2016/09/EmployeeService/GetEmployeeR" +
            "esponse")]
        Models.Employee GetEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.MyWCFVersioningExample.com/sample/2016/09/EmployeeService/GetEmployee", ReplyAction="http://www.MyWCFVersioningExample.com/sample/2016/09/EmployeeService/GetEmployeeR" +
            "esponse")]
        System.Threading.Tasks.Task<Models.Employee> GetEmployeeAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EmployeeServiceChannel : WCFStrictStrategy.ClientV2.EmployeeServiceProxy.EmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<WCFStrictStrategy.ClientV2.EmployeeServiceProxy.EmployeeService>, WCFStrictStrategy.ClientV2.EmployeeServiceProxy.EmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Models.Employee UpdateEmployee(Models.Employee emp) {
            return base.Channel.UpdateEmployee(emp);
        }
        
        public System.Threading.Tasks.Task<Models.Employee> UpdateEmployeeAsync(Models.Employee emp) {
            return base.Channel.UpdateEmployeeAsync(emp);
        }
        
        public Models.Employee GetEmployee(int id) {
            return base.Channel.GetEmployee(id);
        }
        
        public System.Threading.Tasks.Task<Models.Employee> GetEmployeeAsync(int id) {
            return base.Channel.GetEmployeeAsync(id);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Name="EmployeeService", Namespace="http://www.MyWCFVersioningExample.com/sample/2016/08", ConfigurationName="EmployeeServiceProxy.EmployeeService1")]
    public interface EmployeeService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.MyWCFVersioningExample.com/sample/2016/08/EmployeeService/UpdateEmploy" +
            "ee", ReplyAction="http://www.MyWCFVersioningExample.com/sample/2016/08/EmployeeService/UpdateEmploy" +
            "eeResponse")]
        Models.Employee UpdateEmployee(Models.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.MyWCFVersioningExample.com/sample/2016/08/EmployeeService/UpdateEmploy" +
            "ee", ReplyAction="http://www.MyWCFVersioningExample.com/sample/2016/08/EmployeeService/UpdateEmploy" +
            "eeResponse")]
        System.Threading.Tasks.Task<Models.Employee> UpdateEmployeeAsync(Models.Employee emp);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EmployeeService1Channel : WCFStrictStrategy.ClientV2.EmployeeServiceProxy.EmployeeService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeService1Client : System.ServiceModel.ClientBase<WCFStrictStrategy.ClientV2.EmployeeServiceProxy.EmployeeService1>, WCFStrictStrategy.ClientV2.EmployeeServiceProxy.EmployeeService1 {
        
        public EmployeeService1Client() {
        }
        
        public EmployeeService1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeService1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeService1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeService1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Models.Employee UpdateEmployee(Models.Employee emp) {
            return base.Channel.UpdateEmployee(emp);
        }
        
        public System.Threading.Tasks.Task<Models.Employee> UpdateEmployeeAsync(Models.Employee emp) {
            return base.Channel.UpdateEmployeeAsync(emp);
        }
    }
}
