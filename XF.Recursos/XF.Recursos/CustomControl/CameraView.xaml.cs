using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Recursos.API;

namespace XF.Recursos.CustomControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CameraView : ContentPage
    {
        public CameraView()
        {
            InitializeComponent();
        }

        private void btnCamera_Clicked(object sender, EventArgs e)
        {
            ICamera capturar = DependencyService.Get<ICamera>();
            capturar.CapturarFoto();

            MessagingCenter.Subscribe<ICamera, string>(this, "cameraFoto",
                (objeto, image) =>
                {
                    this.imgFoto.Source = ImageSource.FromFile(image);
                });
        }

        private void btnSelecionar_Clicked(object sender, EventArgs e)
        {
            ICamera capturar = DependencyService.Get<ICamera>();
            capturar.SelecionarFoto();

            MessagingCenter.Subscribe<ICamera, string>(this, "cameraFoto",
                (objeto, image) =>
                {
                    this.imgFoto.Source = ImageSource.FromFile(image);
                });
        }

    }
}