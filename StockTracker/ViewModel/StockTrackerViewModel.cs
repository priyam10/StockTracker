using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.ViewModel
{
    class StockTrackerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string stockQueryText;


        public string StockQueryText
        {
            get {
                return stockQueryText;
            }
            set
            {
                PropertyChanged("");
            }
        }
    }
}
