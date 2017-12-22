using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Diary
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 (string par1, string par2, string par3)
		{
			InitializeComponent ();
            Da.Text = par1;
            Head.Text = par2;
            Content.Text = par3;
		}
	}
}