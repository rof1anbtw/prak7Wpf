using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pr7Wpf.ViewModels;

namespace pr7Wpf.ViewModels
{
    public class ViewModelLocator
    {
        public MainViewModel MainViewModel
        {
            get { return new MainViewModel(); }
        }

        public HistoryViewModel HistoryViewModel
        {
            get { return new HistoryViewModel(); }
        }
    }
}
