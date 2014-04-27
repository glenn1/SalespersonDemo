using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    abstract class SalesPerson
    {
        public SalesPerson(string _first, string _last)
        {
            firstName = _first;
            lastName = _last;
        }
        
        public string firstName { get; set; }
        public string lastName { get; set; }

        
        public string getFullName()
        {
            return firstName + " " + lastName;
        }
        
    }
}
