using LiveCharts;
using StockTracker.Command;
using StockTracker.Model;
using StockTracker.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StockTracker.ViewModel
{
    class StockTrackerViewModel : INotifyPropertyChanged
    {
        private string stockQueryText;
        private ICommand searchStockCommand;
        private bool canExecute = true;
        private ChartValues<double> values;
        private List<string> labels;
        private StockAPI api;

        public StockTrackerViewModel()
        {
            api = new StockAPI();
        }

        public string StockQueryText
        {
            get
            {
                return stockQueryText;
            }
            set
            {
                stockQueryText = value;
                OnPropertyChanged("StockQueryText");
            }
        }

        public ICommand SearchStockCommand
        {
            get
            {
                if(searchStockCommand == null)
                {
                    searchStockCommand = new RelayCommand(param => this.LookupStock(param));
                }
                return searchStockCommand;
            }
            set
            {
                searchStockCommand = value;
            }
        }

        public void LookupStock(object obj)
        {           
            string timePeriod = obj as string;
            Console.WriteLine("Param: " + timePeriod);
            Stock stockData = api.GetTodayPrices(stockQueryText);
            if (stockData != null)
            {
                stockData.StockPrices.Reverse();
                // Set X-axis & Y-axis data/labels
                Values = new ChartValues<double>(stockData.StockPrices.Select(x => x.Open));
                Labels = stockData.StockPrices.Select(x => x.Time.ToString("hh:mm tt")).ToList();
            }
        }

        public ChartValues<double> Values
        {
            get
            {
                return values;
            }
            set
            {
                values = value;
                OnPropertyChanged("Values");
            }
        }

        public List<string> Labels
        {
            get
            {
                return labels;
            }
            set
            {
                labels = value;
                OnPropertyChanged("Labels");
            }
        }

        public bool CanExecute
        {
            get
            {
                return canExecute;
            }

            set
            {
                canExecute = value;
            }
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
