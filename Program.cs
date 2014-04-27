using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RealEstateSalesPerson realEstatePerson = new RealEstateSalesPerson("Bill", "Gates", 0.07); 
            GirlScout girlScountPerson = new GirlScout("Cindy", "Smith");

            realEstatePerson.SalesSpeech();
            girlScountPerson.SalesSpeech();

            Console.WriteLine("");

            realEstatePerson.MakeSale(1500);
            realEstatePerson.MakeSale(5000);
            realEstatePerson.MakeSale(55000);

            girlScountPerson.MakeSale(150);
            girlScountPerson.MakeSale(400);

         
            Console.WriteLine("Real Estate Sales Person: ");
            Console.WriteLine("Name:" + realEstatePerson.getFullName());
            Console.WriteLine("Total Values Sold: " + realEstatePerson.totalValueSold.ToString("C2"));
            Console.WriteLine("Commission Rate: " + realEstatePerson.commissionRate.ToString());
            Console.WriteLine("Total Commission Earned: " + realEstatePerson.totalCommission.ToString("C2"));
            Console.WriteLine("");


            Console.WriteLine("Girl Scout Sales Person: ");
            Console.WriteLine("Name:" + girlScountPerson.getFullName());
            Console.WriteLine("No of Boxes Sold: " + girlScountPerson.noOfBoxesSold.ToString());
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
