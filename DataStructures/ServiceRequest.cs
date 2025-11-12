using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableValleyMunicipalApp.DataStructures
{
    public class ServiceRequest
    {
        public int requestID {  get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }

        public ServiceRequest(int id, string desc, string dept, string status, int priority)
        {
            requestID = id;
            Description = desc;
            Department = dept;
            Status = status;
            Priority = priority;
        }
    }
}
