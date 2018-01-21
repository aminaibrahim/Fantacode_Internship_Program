
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoApp.Models;
using ToDoApp.Sevices;
using Xamarin.Forms;

namespace ToDoApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        ToDoServices toDoService { get; } = new ToDoServices();
        public MainViewModel()
        {
            list = new ObservableCollection<TodoItem>();
        }
        private int _todoId;
        public int todoId
        {
            get { return _todoId; }
            set { _todoId = value;
                OnPropertyChanged();
            }
        }

        private string _task { get; set; }
        public string task
        {
            get
            {
                return _task;
            }
            set
            {
                _task = value;
                OnPropertyChanged();
            }
        }
        private string _description { get; set; }
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }
        private bool _done { get; set; }
        public bool done
        {
            get
            {
                return _done;
            }
            set
            {
                _done = value ;
                OnPropertyChanged();
            }
        }
       /* private string _switchcontent { get; set; }
        public string switchcontent
        {
            get
            {
                return _switchcontent;
            }
            set
            {
                _switchcontent = value;
                OnPropertyChanged();
            }
        }*/
        private ObservableCollection<TodoItem> list { get; set; }
        public ObservableCollection<TodoItem> List
        {
            get
            {
                return list;
            }
            set
            {
                list = value;
                OnPropertyChanged();
            }
        }


        public TodoItem item { get; set; }



        public ICommand AddButton => (new Command(async () => await AddCommand()));

        //  public event PropertyChangedEventHandler PropertyChanged;

        private async Task AddCommand()
        {
            item = new TodoItem();

            item.task = task;
            item.description = description;
            item.done = done;
            

            bool res;
            try
            {
                res = await toDoService.PostTodo(item);
            }
            catch (Exception ex)
            {
                res = false;
            }


        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));




        public ICommand ViewButton => (new Command(async () => await ViewCommand()));

        //  public event PropertyChangedEventHandler PropertyChanged;

        private async Task ViewCommand()


        {

          
            try
            {
                List = new ObservableCollection<TodoItem>();
                var  result = await toDoService.GetTodoList();
                if(result!=null)
                {
                    foreach (var x in result)
                    {
                        List.Add(x);
                    }
                }
            }
            catch (Exception ex)
            {
                task = "wrong";
            }
        }
       
        public ICommand DeleteButton => (new Command(async () => await deleteCommand()));

        //  public event PropertyChangedEventHandler PropertyChanged;

        private async Task deleteCommand()
        {
          
            bool res;
            try
            {
                task = Selected.task;
                description = Selected.description;
                done = Selected.done;
                todoId = Selected.todoId;
                res = await toDoService.Delete(todoId);
            }
            catch (Exception ex)
            {
                res = false;
            }


        }

        public ICommand UpdateButton => (new Command(async () => await UpdateCommand()));


        private async Task UpdateCommand()
        {
            item = new TodoItem();

             item.task = task;
             item.description = description;
             item.done = done;
             item.todoId = todoId;
             
          
            bool res;
            try
            {
                res = await toDoService.Update(item);
            }
            catch (Exception ex)
            {
                res = false;
            }
        }




        private TodoItem _Selected { get; set; }
      public TodoItem Selected
       {
    get
    {
        return _Selected;
    }

    set
    {
                if (_Selected != value)
                {
                    _Selected= value;
                    OnPropertyChanged();
                    task = _Selected.task;
                    description = _Selected.description;
                    done = _Selected.done;
                    todoId = _Selected.todoId;
                }
    }
}

     



          public ICommand DoneButton => (new Command(async () => await DoneCommand()));

       

        private async Task DoneCommand()
        {
            item = new TodoItem();

           item.task = task;
            item.description = description;
            item.done = done;
            item.todoId = todoId;
            bool res;
            try
            {
                res = await toDoService.Done(item);
            }
            catch (Exception ex)
            {
                res = false;
            }
        }

        
    }


}
      