using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication
{
    public class MyModel : INotifyPropertyChanged
    {
        private string title;
        public string Title 
        { 
            get => title;
            set
            {
                title = value;
                RaisePropertyChanged("Title");
            }
        }

        private int numberId;
        public int NumberId
        {
            get => numberId;
            set
            {
                numberId = value;
                RaisePropertyChanged("NumberId");
            }
        }



        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
