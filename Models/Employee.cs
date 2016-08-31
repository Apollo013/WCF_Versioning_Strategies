using System.Runtime.Serialization;

namespace Models
{
    [DataContract(Name = "Employee", Namespace = "http://schemas.MyWCFVersioningExample.com/sample/2016/08")]
    public class Employee
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }

        // NEW PROPERTY ADDED
        [DataMember(IsRequired = false)]
        public string Address { get; set; }
    }
}
