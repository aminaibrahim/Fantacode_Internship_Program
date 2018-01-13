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
        private void Button(object sender,EventArgs e)
        {
            string welcome = Name.Text;
            asd.Text = "Welcome\t " + welcome;
        }
        private async void Tap(object sender, EventArgs e)
        {
           await asd.TranslateTo(200, 300, 1000, Easing.CubicIn);
            await asd.RotateTo(90,800,Easing.SinOut);

        }
        private async void Button1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
	}

}
