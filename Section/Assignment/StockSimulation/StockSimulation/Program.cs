using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace StockSimulation
{
    internal class Program
    {
        static void Main()
        {
            var stocks = new List<Stock>
            {
                new Stock("Tata", 200),
                new Stock("Bajaj", 175),
                new Stock("Reliance",300),
                new Stock("Airtel", 125)
            };

            var cancellationTokenSource = new CancellationTokenSource();
        }
    }
}
