using SettingsApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SettingsApp
{
    public partial class MainPage : ContentPage
    {
        public string display { get; set; }
        public MainPage()
        {
            InitializeComponent();
            display = Settings.DisplayLanguage;
            BindingContext = this;
        }
      /*  Label heading = new Label
        {
            Text = "Display Language is " + SettingsApp.Helpers.Settings.DisplayLanguage,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            FontAttributes = FontAttributes.Bold
        };*/
    }
}
