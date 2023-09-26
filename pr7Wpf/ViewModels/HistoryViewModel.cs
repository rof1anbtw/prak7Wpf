using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pr7Wpf.ViewModels
{
    public class HistoryViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<string> historyItems = new ObservableCollection<string>();

        public ObservableCollection<string> HistoryItems
        {
            get { return historyItems; }
            set
            {
                historyItems = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AddToHistory(string expression, double result)
        {
            string historyItem = $"{expression} = {result}";
            HistoryItems.Add(historyItem);
        }
    }
}
