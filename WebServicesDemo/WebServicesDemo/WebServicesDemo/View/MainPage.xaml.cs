using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServicesDemo.ViewModels;
using Xamarin.Forms;

namespace WebServicesDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new MainViewModels();
		}
	}
}
