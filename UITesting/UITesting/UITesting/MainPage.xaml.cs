using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UITesting
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
        }
            private async void AddButton_Clicked(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(First.Text);
            int num2 = Convert.ToInt32(Second.Text);
            int res = num1 + num2;
            Result.Text = Convert.ToString(res);
        }
        private async void MulButton_Clicked(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(First.Text);
            int num2 = Convert.ToInt32(Second.Text);
            int res = num1 * num2;
            Result.Text = Convert.ToString(res);
        }
    }
}
