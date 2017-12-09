using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Diary
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void NavigateButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(today.Text,title.Text,note.Text));
        }
    }
}
