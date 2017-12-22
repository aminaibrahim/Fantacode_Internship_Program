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
	public partial class ListPage : ContentPage
	{
		public ListPage (string parameter1, string parameter2)
		{
			InitializeComponent ();
            Date.Text = parameter1;
            Notes.Text = parameter2;
            new Menu();
		}
	}
}