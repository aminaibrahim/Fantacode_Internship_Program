using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace My_Diary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page : ContentPage
    {
        public Page()
        {
            InitializeComponent();
        }
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
           string Comment= await DisplayActionSheet("Do you want to save it?", "Yes", "No");
            if (Comment == "Yes")
                await Navigation.PushAsync(new ListPage(DATE.Text,CONTENT.Text));
            

        }

    }
}