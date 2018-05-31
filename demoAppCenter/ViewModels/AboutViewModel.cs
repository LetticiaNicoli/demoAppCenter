using System;
using System.Windows.Input;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace demoAppCenter
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Sugestão do dia";

            OpenBeerCommand = new Command(() => throw new NotImplementedException());

            OpenWebCommand = new Command(() =>
            {
                var ex = new TimeoutException("API demorou para responder");
                Crashes.TrackError(ex);

            });
        }

        public ICommand OpenBeerCommand { get; }
        public ICommand OpenWebCommand { get; }
    }
}
