using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalespersonDemo
{
    class ISellable
    {
        public interface Sellable
        {
            void SalesSpeech();
            void MakeSale(int val);

        }
    }
}
