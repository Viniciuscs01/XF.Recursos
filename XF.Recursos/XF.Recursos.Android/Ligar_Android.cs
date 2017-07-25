using System.Linq;
using Android.Content;
using XF.Recursos.API;
using Xamarin.Forms;
using Android.Telephony;
using Android.Net;
using XF.Recursos.Droid;

[assembly: Dependency(typeof(Ligar_Android))]
namespace XF.Recursos.Droid
{
     public class Ligar_Android : ILigar
    {
        public bool Discar(string telefone)
        {
            var context = Forms.Context;
            if (context == null) return false;

            var intent = new Intent(Intent.ActionCall);
            intent.SetData(Uri.Parse("tel:" + telefone));

            if (IsIntentAvailable(context, intent))
            {
                context.StartActivity(intent);
                return true;
            }

            return false;
        }

        public static bool IsIntentAvailable(Context context, Intent intent)
        {
            var packageManager = context.PackageManager;

            var list = packageManager.QueryIntentServices(intent, 0)
                .Union(packageManager.QueryIntentActivities(intent, 0));

            if (list.Any()) return true;

            var manager = TelephonyManager.FromContext(context);
            return manager.PhoneType != PhoneType.None;
        }
    }
}