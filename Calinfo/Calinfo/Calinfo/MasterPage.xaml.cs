using Calinfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calinfo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {

        public MasterPage()
        {
            InitializeComponent();
        }
    
        private async void ResturantsButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void LabourButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void TransportButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void HealthButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void SupermarketButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void WorkshopButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void ServicesButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void GovernmentButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void EducationButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }




    }
}