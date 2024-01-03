using CamLerQrCode.ViewModel;

namespace CamLerQrCode.View;

public partial class MainPageQrCode : ContentPage
{
	public MainPageQrCode()
	{
		InitializeComponent();
		BindingContext = new MainPageQrCodeViewModel();
    }
}