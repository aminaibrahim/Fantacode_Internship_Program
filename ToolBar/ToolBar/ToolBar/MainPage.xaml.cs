using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToolBar
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        public async void first(object sender, EventArgs e)
        {
            MainLabel.Text = "firsticon";    
        }
        public async void ButtonClicked(object sender, EventArgs e)
        {
            Label.Text = "secondicon";
        }
        

    }
}
