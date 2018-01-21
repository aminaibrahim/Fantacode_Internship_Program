using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WeatherApp;
using Xamarin.Forms;

namespace Weather_APP
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {

        Weather w= new Weather();
        private string zonal;
        public string Zonal
        {
            get
            {
                return Zonal;
            }
            set
            {
                zonal = value;
            }
        }
        private string temp;
        public string Temp
        {
            get
            {
                return temp;
            }
            set
            {
                temp = value;
            }
        }

        public MainPage()
        {
            InitializeComponent();
           
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            w = await Core.GetWeather(Zonal);
            if (w != null)
            {
                Temp = w.Temperature;
                OnPropertyChanged("Temp");
            }
        }
    }
}
