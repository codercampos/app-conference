using FormsToolkit;
using Plugin.ExternalMaps;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Conference.Clients.Portable
{
    public class VenueViewModel : ViewModelBase
    {
        public bool CanMakePhoneCall => true;
        public string EventTitle => "CaribbeanDevConf";
        public string LocationTitle => "Hard Rock Hotel & Casino Punta Cana";
        public string Address1 => "Km 28, #74, Bv. Turístico del Este";
        public string Address2 => "Punta Cana, República Dominicana 23000";
        public double Latitude => 18.7333722;
        public double Longitude => -68.4849367;
        public string HotelPhoneNumber => "+18097310000";

        ICommand  navigateCommand;
        public ICommand NavigateCommand =>
            navigateCommand ?? (navigateCommand = new Command(async () => await ExecuteNavigateCommandAsync())); 

        async Task ExecuteNavigateCommandAsync()
        {
            Logger.Track(ConferenceLoggerKeys.NavigateToConference);
            if(!await CrossExternalMaps.Current.NavigateTo(LocationTitle, Latitude, Longitude))
            {
                MessagingService.Current.SendMessage(MessageKeys.Message, new MessagingServiceAlert
                    {
                        Title = "Unable to Navigate",
                        Message = "Please ensure that you have a map application installed.",
                        Cancel = "OK"
                    });
            }
        }

        ICommand  callCommand;
        public ICommand CallCommand =>
            callCommand ?? (callCommand = new Command(ExecuteCallCommand)); 

        void ExecuteCallCommand()
        {
            Logger.Track(ConferenceLoggerKeys.CallHotel);
            try
            {
                PhoneDialer.Open(HotelPhoneNumber);
            }
            catch (FeatureNotSupportedException)
            {
                Application.Current?.MainPage?.DisplayAlert("Sorry!", "Your device doesn't appear to support phone calls!", "OK");
            }
        }
    }
}


