using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Recursos.GPS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoordenadaView : ContentPage
    {
        public CoordenadaView()
        {
            InitializeComponent();
        }

        private void btnCoordenada_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<ILocalizacao>().GetCoordenada();

            MessagingCenter.Subscribe<ILocalizacao, Coordenada>(this, "coordenada",
                (objeto, geo) =>
                {
                    Coordenada coord = geo as Coordenada;
                    lblLatitude.Text = geo.Latitude;
                    lblLongitude.Text = geo.Longitude;
                });
        }
    }
}