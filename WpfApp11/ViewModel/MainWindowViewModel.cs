using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
    
     class MainWindowViewModel : ViewModelBase
    {
        private double euros;
        public double Euros
        {
            get { return euros; }
            set { euros = value;
                OnPropertyChanged("Euros");
                OnEurosChanged();
            }
        }

        private double dollars;
        public double Dollars
        {
            get { return dollars; }
            set
            {
                dollars = value;
                OnPropertyChanged("Dollars");
            }
        }

        private void OnEurosChanged()
        {
            Dollars = Math.Round(Euros * 1.1, 2);
        }


       
    }
}
