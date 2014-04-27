using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    class RealEstateSalesPerson : SalesPerson
    {
       
        public double totalValueSold { get; set; }
        public double totalCommission { get; set; }
        public double commissionRate { get; set; }

        
        public RealEstateSalesPerson(string _first, string _last, double rate) : base(_first, _last)
             
        {
            totalCommission = 0;
            totalValueSold = 0;
            commissionRate = rate;
        }

        
        public void SalesSpeech()
        {
            Console.WriteLine(" Real Estate Sales Person Speech ");
            
            Console.WriteLine("I am a RealEstate Sales Person and My name is " +getFullName() + 
                                      "\nI have a 20 years experience in real estate sales.");
            
            Console.WriteLine("");
        }

        
        public void MakeSale(int val)
        {
            totalValueSold += val;
            totalCommission = commissionRate * totalValueSold;
         }

    }
}
