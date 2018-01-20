using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Task_10
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            MainList.ItemsSource = _list;
		}
        private readonly List<string> _list = new List<string>
        {
            "apple", "ball","baloon", "ant", "cow", "dice", "animal", "ink", "airport"
        };
        private void OnPressed(object sender, EventArgs e)
        {
            string keyword = MainSearch.Text;
            //IEnumerable<string> ResultList = _list.Where(name => name.ToLower().Contains(keyword.ToLower()));
            IEnumerable<string> ResultList = from list in _list where list.ToLower().Contains(keyword.ToLower()) select list;
            MainList.ItemsSource = ResultList;
        }
	}
}
