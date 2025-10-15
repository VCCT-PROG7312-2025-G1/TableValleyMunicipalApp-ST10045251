using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableValleyMunicipalApp.Models
{
    internal class Events
    {
        public string Id{ get; set; } 
        public string EventName{ get; set; }
        public  DateTime Date{ get; set; }
        public string Category{ get; set; }
        public string Location{ get; set; }
        public string Description{ get; set; }
    }
}
  