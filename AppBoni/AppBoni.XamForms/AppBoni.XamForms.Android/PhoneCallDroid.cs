using System;
using Android.App;
using Android.Content;
using AppBoni.XamForms.Droid;
using AppBoni.XamForms.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneCallDroid))]
namespace AppBoni.XamForms.Droid
{
    public class PhoneCallDroid : IPhoneCall
    {

        public void MakeQuickCall(string phoneNumber)
        {
            try
            {
                var uri = Android.Net.Uri.Parse($"tel:{phoneNumber}");
                var intent = new Intent(Intent.ActionDial, uri);
                Xamarin.Forms.Forms.Context.StartActivity(intent);
            }
            catch (Exception ex)
            {
                new AlertDialog.Builder(Android.App.Application.Context).SetPositiveButton("OK", (sender, args) =>
                {
                    //user pressed OK
                }).SetMessage(ex.ToString()).SetTitle("Android Exception").Show();
            }
        }
    }
}