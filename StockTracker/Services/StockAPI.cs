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
        private string url = "https://www.alphavantage.co/query?function={0}&symbol={1}{2}&apikey=I6L2EI9FXS12JRHU";        

        public StockAPI()
        {
            //Stock stockData = GetTodayPrices();
            //if(stockData != null)
            //{
                
            //}
        }

        public Stock GetTodayPrices(string function, string symbol, string timeInterval)
        {
            // Create a web client.
            Stock stock = null;
            WebClient webClient = new WebClient();
            string temp_url = url.Replace("{0}", function);
            temp_url = temp_url.Replace("{1}", symbol);
            if (function.Equals("TIME_SERIES_DAILY"))
            {
                // Month query will not have intervals for days since its one value per day.
                temp_url = temp_url.Replace("{2}", timeInterval);
            }
            else
            {
                temp_url = temp_url.Replace("{2}", "&interval=" + timeInterval);
            }

            var data = webClient.DownloadString(temp_url);            

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
                                DateTime dt;
                                if (function.Equals("TIME_SERIES_DAILY"))
                                {
                                    try
                                    {
                                        dt = DateTime.ParseExact(property.Name, "yyyy-MM-dd", null);
                                    }
                                    catch (Exception e)
                                    {
                                        dt = DateTime.ParseExact(property.Name, "yyyy-MM-dd HH:mm:ss", null);
                                    }                                    
                                }
                                else
                                {
                                    dt = DateTime.ParseExact(property.Name, "yyyy-MM-dd HH:mm:ss", null);
                                }
                                
                                stock.StockPrices.Add(new StockPrice(dt, Double.Parse(property.Value["1. open"].ToString())));
                            }
                    }
                }
            }

            return stock;
        }
    }
}
