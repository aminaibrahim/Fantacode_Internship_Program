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
        
        public ICommand AddCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public INavigation Navigation { get; set; }
       
        private TaskModel _task;
        public TaskModel Taskm
        {
            get { return _task; }
            set
            {
                _task = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<TaskModel> _list;
        public ObservableCollection<TaskModel> List
        { get; set; }
            /*get { return _list; }
            set
            {

                _list = value;
                
            }
        }*/

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

        public TaskViewModel(INavigation navigation)
        {
            Taskm = new TaskModel
            {
                task = "",
                date = "",
                time = ""

            };
            List = new ObservableCollection<TaskModel>();
            {
            };
            this.Navigation = navigation;
            this.SaveCommand = new Command(async () => await GotoPage2());
            this.AddCommand = new Command(() =>
            {

                List.Add(Taskm);
                message = "your task  is saved";

            });
        }


        public async Task GotoPage2()
        {

            await Navigation.PushAsync(new Page2(List));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
