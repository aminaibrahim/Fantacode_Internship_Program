using Plugin.SpeechRecognition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Speech
{
	public partial class MainPage : ContentPage , INotifyPropertyChanged
	{
        private string speech { get; set; }
        public string Speech
        {
            get
            {
                return speech;
            }
            set
            {
                speech = value;
                OnPropertyChanged();
            }
        }



		public MainPage()
		{
			InitializeComponent();
            BindingContext = this;
		}
        public async void ButtonClicked(object sender, EventArgs e)
        {
            var listener = CrossSpeechRecognition
    .Current
    .ContinuousDictation()
    .Subscribe(phrase => {
        // will keep returning phrases as pause is observed
        });

            // make sure to dispose to stop listening
            listener.Dispose();
            Speech = listener.ToString();

        }

    }
}
