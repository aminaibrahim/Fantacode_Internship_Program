using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private async void Button(object sender,EventArgs e)
        {
            string welcome = Name.Text;
            asd.Text = "Welcome\t " + welcome;
        }
        private async void Tap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
	}
}
