using CamLerQrCode.View;

namespace CamLerQrCode
{
    public partial class App : Application
    {
        public App()
        {   
            InitializeComponent();

            MainPage = new NavigationPage(new MainPageQrCode());
        }
    }
}
