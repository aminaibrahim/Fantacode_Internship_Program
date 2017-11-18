using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMI_Calc
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked (object sender, EventArgs e)
        {
            
            double text1 = Convert.ToInt32(height.Text);
            double text2 = Convert.ToInt32(weight.Text);
            double text3 = text2 / ((text1/100) * (text1/100));
            MainLabel.Text = "Your BMI is : "  + text3;
        }
    }
}