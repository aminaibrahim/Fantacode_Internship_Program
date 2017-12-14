using DoList.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DoList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page : ContentPage
    {
        public Page()
        {
            InitializeComponent();
            BindingContext = new TaskViewModel(Navigation);

        }
    }
}



      /* public List<Task> tasks = new List<Task>();

        public void Button_Clicked(object sender, EventArgs e)
        {
            //tasks = new List<Task>();
            Task newtask = new Task();
            newtask.task = Task.Text;
            newtask.date = Date.Text;
            newtask.time = Time.Text;
           
            tasks.Add(newtask);
        }
            

        private async void NavigateButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2(tasks));
        }
    }
}*/