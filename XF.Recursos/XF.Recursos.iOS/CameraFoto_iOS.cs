using System;
using XF.Recursos.API;
using Xamarin.Media;
using XF.Recursos.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(CameraFoto_iOS))]
namespace XF.Recursos.iOS
{
    public class CameraFoto_iOS : ICamera
    {
        public async void CapturarFoto()
        {
            var capturar = new MediaPicker();

            MediaFile mediaPath;
            if (capturar.IsCameraAvailable)
            {
                mediaPath = await capturar.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    DefaultCamera = CameraDevice.Rear,
                    Name = string.Format("foto_{0}.jpg", DateTime.Now.ToString()),
                    Directory = "Fiap"
                });
            }
        }

        public async void SelecionarFoto()
        {
            var capturar = new MediaPicker();

            MediaFile mediaPath;
            if (capturar.IsCameraAvailable)
                mediaPath = await capturar.PickPhotoAsync();
        }
    }
}