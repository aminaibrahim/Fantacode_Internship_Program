using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace Geolocator
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {

        private string loc {get; set;}
        public string Loc
        {
            get
            {
                return loc;
            }
            set
            {
                loc = value;
            }
        }
        
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        public async void ButtonClicked(object sender, EventArgs e)
        {
            var locator = CrossGeolocator.Current;
            var position = await locator.GetPositionAsync();
            if (position != null)
            {
                Loc = position.Longitude.ToString();
                OnPropertyChanged("Loc");
            }
        }
    }
}
