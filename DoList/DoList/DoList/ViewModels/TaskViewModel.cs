using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;



namespace DoList.ViewModels
{
    public class TaskViewModel : INotifyPropertyChanged
    {
        private TaskModel _task;
        
        public TaskModel task
        {
            get { return _task; }
            set
            {
                _task = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<TaskModel> _list;
        public ObservableCollection<TaskModel> list
        {
            get { return _list; }
            set
            {

                _list = value;
            }
        }

        private string _message;
        public string message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }
       
        public Command AddCommand
        {
            get
            {
                return new Command(() =>
                {
                    
                    list.Add(task);
                    message = "your task  is saved";

                });
            }
        }


        public ICommand SaveCommand { get; set; }

        public INavigation Navigation { get; set; }


        public TaskViewModel(INavigation navigation)
        {
            task = new TaskModel
            {
                task = "",
                date = "",
                time = ""

            };
            list = new ObservableCollection<TaskModel>();
            this.Navigation = navigation;
            this.SaveCommand = new Command(async () => await GotoPage2());
        }

        public async Task GotoPage2()
        {

            await Navigation.PushAsync(new Page2());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
