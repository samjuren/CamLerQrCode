namespace CamLerQrCode.View;

public partial class CameraQrCode : ContentPage
{
	public CameraQrCode()
	{
		InitializeComponent();

        CamQrCode.Options = new ZXing.Net.Maui.BarcodeReaderOptions
        {
            Formats = ZXing.Net.Maui.BarcodeFormat.QrCode,
            AutoRotate = true,
            Multiple = true
        };
    }
    private void CamQrCode_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        var result = e.Results?.FirstOrDefault();

        if (result is null)
            return;

        Dispatcher.DispatchAsync(async () =>
        {
            await DisplayAlert("Resultado: ", result.Value, "Ok");
        });
    }
}