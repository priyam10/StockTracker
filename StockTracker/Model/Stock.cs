using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Model
{
    class Stock
    {
        public string Symbol { get; set; }

        public List<StockPrice> StockPrices { get; set; }     


    }
}
