using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    class GirlScout : SalesPerson
    {
        public int noOfBoxesSold { get; set; }

        public GirlScout(string _first, string _last)
            : base(_first, _last)
       
        {
            noOfBoxesSold = 0;
        }
        public void SalesSpeech()
        {
            Console.WriteLine(" Girl Scout Sales Person Speech ");
            Console.WriteLine("I am a girl scout and My name is " + getFullName() +
                                    "\nand I have a 3 years in sales.");
            
            Console.WriteLine("");


        }

        
        public void MakeSale(int val)
        {
            noOfBoxesSold += val;

        }
    }
}
