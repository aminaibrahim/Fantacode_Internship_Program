
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DoList.ViewModels
{
    class ListViewModel:INotifyPropertyChanged
    {
        private ObservableCollection<TaskModel> _list;


        public ObservableCollection<TaskModel> List
        {
            get
            {
                return _list;
            }
            set
            {
                _list = value;
              
            }
        }
        public ListViewModel(ObservableCollection<TaskModel> List)
        {
            this.List = List;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}