using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestSettings
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        
        }
        Label heading = new Label
        {
            Text = "Display Language is " + TestSettings.Helpers.Settings.DisplayLanguage,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            FontAttributes = FontAttributes.Bold
        };


    }
}
