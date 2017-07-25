using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XF.Recursos.CustomControl;
using XF.Recursos.Droid;

[assembly:ExportRenderer(typeof(FiapButton), typeof(FiapButtonRenderer))]
namespace XF.Recursos.Droid
{
    class FiapButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Gray);
            }
        }
    }
}