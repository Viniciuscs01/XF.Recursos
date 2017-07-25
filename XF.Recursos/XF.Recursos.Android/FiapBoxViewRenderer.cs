using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using XF.Recursos.CustomControl;
using System.ComponentModel;
using Xamarin.Forms;
using XF.Recursos.Droid;

[assembly: ExportRenderer(typeof(FiapBoxView), typeof(FiapBoxViewRenderer))]
namespace XF.Recursos.Droid
{
    class FiapBoxViewRenderer : BoxRenderer
    {
        public FiapBoxViewRenderer()
        {
            SetWillNotDraw(false);
        }

        public override void Draw(Canvas canvas)
        {
            base.Draw(canvas);

            FiapBoxView boxView = (FiapBoxView)Element;

            Rect ret = new Rect();
            GetDrawingRect(ret);

            Rect inside = ret;
            inside.Inset((int)boxView.EspessuraDaBorda, (int)boxView.EspessuraDaBorda);

            Paint paint = new Paint();
            paint.Color = boxView.Color.ToAndroid();

            canvas.DrawRect(inside, paint);
            paint.Color = boxView.CorDaBorda.ToAndroid();
            paint.StrokeWidth = (float)boxView.EspessuraDaBorda;
            paint.SetStyle(Paint.Style.Stroke);

            canvas.DrawRect(ret, paint);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            Invalidate();
        }
    }
}