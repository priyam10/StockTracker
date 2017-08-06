using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StockTracker.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StockTracker.Services
{
    // API Key: I6L2EI9FXS12JRHU
    class StockAPI
    {
        private string url = "https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol=TSLA&interval=5min&apikey=I6L2EI9FXS12JRHU";        

        public StockAPI()
        {
            //Stock stockData = GetTodayPrices();
            //if(stockData != null)
            //{
                
            //}
        }

        public Stock GetTodayPrices()
        {
            // Create a web client.
            Stock stock = null;
            WebClient webClient = new WebClient();
            var data = webClient.DownloadString(url);            

            JObject objects = JObject.Parse(data);
            foreach(KeyValuePair<string, JToken> kvp in objects)
            {
                //Console.WriteLine("Key: " + kvp.Key + " Value: "+ kvp.Value.ToString());
                JToken token = kvp.Value;
                stock = new Stock();
                if (kvp.Key.Equals("Meta Data"))
                {
                    stock.Symbol = token["2. Symbol"].ToString();
                   // Console.WriteLine("Symbol: "+ token["2. Symbol"]);

                }
                else
                {
                    var stockTimes = token.Children();
                    stock.StockPrices = new List<StockPrice>();
                    foreach (JToken time in stockTimes)
                    {
                        
                            var property = time as JProperty;

                            if (property != null)
                            {
                                //Console.WriteLine("DateTime: " + property.Name + " Open: " + property.Value["1. open"]);
                                DateTime dt = DateTime.ParseExact(property.Name, "yyyy-MM-dd HH:mm:ss", null);
                                stock.StockPrices.Add(new StockPrice(dt, Double.Parse(property.Value["1. open"].ToString())));
                            }
                    }
                }
            }

            return stock;
        }
    }
}
