using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using StockTracker.Services;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using System.ComponentModel;
using StockTracker.Model;

namespace StockTracker.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        
        public LoginView()
        {
            InitializeComponent();

            // Set X-axis labels & Y-axis labels
            //YFormatter = value => value.ToString("C");

            StockAPI api = new StockAPI();
            Stock stockData = api.GetTodayPrices();
            if (stockData != null)
            {
                stockData.StockPrices.Reverse();
                Values = new ChartValues<double>(stockData.StockPrices.Select(x => x.Open));
                //Labels = stockData.StockPrices.Select(x => x.Time.TimeOfDay.ToString()).ToList();
                //Labels = new List<string>();
                //for(int i = 0; i < stockData.StockPrices.Count; i += 20)
                //{
                //    Labels.Add(stockData.StockPrices[i].Time.TimeOfDay.ToString());
                //}
                    //new[] { "9:30 AM", "10:00 AM", "10:30 AM" , "11:00 AM", "11:30 AM", "12:00 PM", "12:30 PM", "1:00 PM", "1:30 PM", "2:00 PM", "2:30 PM", "3:00 PM", "3:30 PM", "4:00 PM"};//stockData.StockPrices.Select(x => x.Time).ToList();
            }

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public ChartValues<double> Values { get; set; }
        public List<string> Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
    }
}
