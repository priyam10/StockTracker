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
        private string url = "https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol=MSFT&interval=1min&apikey=I6L2EI9FXS12JRHU";        

        public StockAPI()
        {

        }

        public void GetCurrentPrice()
        {
            // Create a web client.
            using (WebClient client = new WebClient())
            {
                // Get the response string from the URL.
                string xml = client.DownloadString(url);

                // Load the response into an XML document.
                XmlDocument xml_document = new XmlDocument();
                xml_document.LoadXml(xml);

                // Format the XML.
                using (StringWriter string_writer = new StringWriter())
                {
                    XmlTextWriter xml_text_writer = new XmlTextWriter(string_writer);
                    xml_text_writer.Formatting = Formatting.Indented;
                    xml_document.WriteTo(xml_text_writer);

                    // Return the result.
                    string xml_string = string_writer.ToString();
                }
            }
        }
    }
}
