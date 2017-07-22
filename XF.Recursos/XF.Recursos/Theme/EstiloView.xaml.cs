using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Recursos.Theme
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EstiloView : ContentPage
	{
        public static readonly BindableProperty HeaderFIAPProperty = BindableProperty.Create("HeaderFIAP", typeof(string), typeof(ThemeView), null);
        public static readonly BindableProperty FooterFIAPProperty = BindableProperty.Create("FooterFIAP", typeof(string), typeof(ThemeView), null);

        public string HeaderFIAP
        {
            get { return (string)GetValue(HeaderFIAPProperty); }
        }

        public string FooterFIAP
        {
            get { return (string)GetValue(FooterFIAPProperty); }
        }

        public EstiloView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            base.OnAppearing();
        }

    }
}