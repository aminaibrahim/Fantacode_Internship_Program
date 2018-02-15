using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace UnitTesting.ViewModels
{
   public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private int _valueA { get; set; }
        public int valueA
        {
            get
            {
                return _valueA;
            }
            set
            {
                _valueA = value;
                OnPropertyChanged();
            }
        }
        private int _valueB { get; set; }
        public int valueB
        {
            get
            {
                return _valueB;
            }
            set
            {
                _valueB = value;
                OnPropertyChanged();
            }
        }
        private int _result { get; set; }
        public int result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }
        public ICommand AddCommand
        {
            get
            {
                return new Command(() =>
              {
                  result = _valueA + _valueB;
              });
            }
        }
    }
}
