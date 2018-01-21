using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calinfo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        public async void LoginIcon(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        
        public  async void Search_Button (object sender,EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}
