using CamLerQrCode.View;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ZXing.OneD;

namespace CamLerQrCode.ViewModel
{
    public class MainPageQrCodeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ICommand AbrirCamera { get; set; }

        public MainPageQrCodeViewModel() 
        {
            AbrirCamera = new Command(() =>
            {
                var page = Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();
                page.Navigation.PushAsync(new CameraQrCode());
            });
        }
    }
}
