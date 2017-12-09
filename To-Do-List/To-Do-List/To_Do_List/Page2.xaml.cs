using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace To_Do_List
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
            MainListView.ItemsSource = new List<Schedule>
            {
                new Schedule
                {
                    Date= "12/12/2017",
                    Time =12,
                    Note= "complete task1"
                },
                new Schedule
                {
                    Date= "13/12/2017",
                    Time = 1,
                    Note = "complete task2"
                }
            };
		}
	}
}