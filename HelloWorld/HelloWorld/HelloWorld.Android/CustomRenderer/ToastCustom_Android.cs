using Android.Widget;
using HelloWorld.CustomRenderer;
using Xamarin.Forms;

[assembly: Dependency(typeof(HelloWorld.Droid.CustomRenderer.ToastCustom_Android))]
namespace HelloWorld.Droid.CustomRenderer
{
    public class ToastCustom_Android : ITostCustom
    {
        public void ShowToast(string message)
        {
            Toast.MakeText(Forms.Context, message, ToastLength.Long).Show();
        }
    }
}