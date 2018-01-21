
using MyWeather.Models;
using Plugin.TextToSpeech;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace MyWeather.ViewModels
{
   public  class ViewPageVM: INotifyPropertyChanged
    {
        WeatherService WeatherService { get; } = new WeatherService();
        private string city { get; set; }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
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
        ICommand searchbutton;
        public ICommand SearchButton=>
                 searchbutton ?? 
                 (searchbutton= new Command(async () => await ExecuteGetWeatherCommand())); 
 
 
         private async Task ExecuteGetWeatherCommand()
         { 
             
             try 

             { 
                 WeatherRoot weatherRoot = null;         
            
                     weatherRoot = await WeatherService.GetWeather(City.Trim());
                Temp = $"Temp: {weatherRoot?.MainWeather?.Temperature ?? 0}";
                OnPropertyChanged("Temp");
                    await CrossTextToSpeech.Current.Speak(Temp); 
             }
            catch (Exception ex) 
             { 
                 Temp = "Unable to get Weather"; 
             } 
          
         }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string name = "") =>
             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


    } 

}
