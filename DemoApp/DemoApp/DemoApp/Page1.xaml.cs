using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage, INotifyPropertyChanged
    {

        public Page1()
        {
            InitializeComponent();

            CameraButton.Clicked += CameraButton_Clicked;
        }
        private string photoImage { get; set; }
        public string PhotoImage
        {


            get { return photoImage; }
            set
            {
                photoImage = value;
                OnPropertyChanged();

            }
        }

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
                //PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });

                PhotoImage = photo.Path;

            OnPropertyChanged("PhotoImage");
        }
        
        
    }
}