using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBillCalculator
{
    public abstract class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual bool Set<T>(ref T item, T value, string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(item, value)) {
                return false;
            } else
            {
                item = value;
                OnPropertyChanged(propertyName);
                return true;                
            }            
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}