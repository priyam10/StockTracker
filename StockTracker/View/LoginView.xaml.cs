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
using LiveCharts.Configurations;
using StockTracker.ViewModel;

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

            DataContext = new StockTrackerViewModel();
            //StockAPI api = new StockAPI();
            //Stock stockData = api.GetTodayPrices();
            //if (stockData != null)
            //{
            //    stockData.StockPrices.Reverse();
            //    // Set X-axis & Y-axis data/labels
            //    Values = new ChartValues<double>(stockData.StockPrices.Select(x => x.Open));
            //    Labels = stockData.StockPrices.Select(x => x.Time.ToString("hh:mm tt")).ToList();
            //}

            //DataContext = this;
        }

        //public ChartValues<double> Values { get; set; }
        //public List<string> Labels { get; set; }
    }
}
