using System;
using AppBoni.XamForms.Droid;
using AppBoni.XamForms.Services;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

[assembly: Dependency(typeof(PhoneCall_iOS))]
namespace AppBoni.XamForms.Droid
{
    public class PhoneCall_iOS : IPhoneCall
    {

        public void MakeQuickCall(string phoneNumber)
        {
            try
            {

                var url = new NSUrl($@"telprompt://{phoneNumber}");
                UIApplication.SharedApplication.OpenUrl(url);
            }
            catch (Exception ex)
            {
                var alert = new UIAlertView("iOS Exception", ex.Message, null, "OK", null);
                alert.Show();
            }
        }
    }
}